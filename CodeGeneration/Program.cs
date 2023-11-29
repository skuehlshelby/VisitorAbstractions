using CodeWriter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeGeneration
{
    public static class Program
    {
        public const int MAX_PARAMS = 16;
        private const string RETURN_PARAM = "TReturn";
        private const string NOTHING_NAMESPACE = "Abstractions.Functional";
        private const string VARIANT_NAMESPACE = "Abstractions.SumTypes.Variants";
        private const string INTERFACES_NAMESPACE = "Abstractions.Visitors.Interfaces";
        private const string VISITORS_NAMESPACE = "Abstractions.Visitors.FactoryMethods";
        private const string EXTENSIONS_NAMESPACE = "Abstractions.Visitors.Extensions";

        public static void Main(string[] _)
        {
            var writer = new CodeWriter.CodeWriter(CodeWriterSettings.CSharpDefault);
            var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var codeFilesFolder = Path.Combine(assemblyLocation[..assemblyLocation.IndexOf("CodeGeneration")], "VisitorAbstractions");
            var interfacesFile = Path.Combine(codeFilesFolder, "Interfaces.cs");
            var variantsFile = Path.Combine(codeFilesFolder, "Variants.cs");
            var visitorsFile = Path.Combine(codeFilesFolder, "Visitors.cs");
            var extensionsFile = Path.Combine(codeFilesFolder, "Extensions.cs");

            using (writer.B($"namespace {NOTHING_NAMESPACE}"))
            {
                using (writer.B("public sealed class Nothing"))
                {
                    writer._("private Nothing() { }");
                    writer._("public static readonly Nothing Instance = new();");
                }
            }

            #region Interfaces

            using (writer.B($"namespace {INTERFACES_NAMESPACE}"))
            {
                for (int i = 1; i <= MAX_PARAMS; i++)
                {
                    writer._($"#region T = {i}", string.Empty);

                    Templates.IVisitable(writer, i);

                    Templates.IVisitor(writer, i);

                    Templates.IXxXVisitors(writer, i);

                    writer._("#endregion", string.Empty);
                }
            }

            #endregion

            writer.WriteAllText(interfacesFile);
            writer = new CodeWriter.CodeWriter(CodeWriterSettings.CSharpDefault);

            writer._($"using {INTERFACES_NAMESPACE};", string.Empty);

            using (writer.B($"namespace {VARIANT_NAMESPACE}"))
            {
                for (int i = 1; i <= MAX_PARAMS; i++)
                {
                    writer._($"#region T = {i}", string.Empty);

                    Templates.Variant(writer, i);

                    writer._("#endregion", string.Empty);
                }
            }

            writer.WriteAllText(variantsFile);
            writer = new CodeWriter.CodeWriter(CodeWriterSettings.CSharpDefault);

            writer._("using System;",
                     $"using {INTERFACES_NAMESPACE};",
                     $"using {NOTHING_NAMESPACE};",
                     string.Empty);

            using (writer.B($"namespace {VISITORS_NAMESPACE}"))
            {
                for (int i = 1; i <= MAX_PARAMS; i++)
                {
                    writer._($"#region T = {i}");
                    writer._();

                    Templates.Visitor(writer, i);

                    writer._("#endregion");
                    writer._();
                }
            }

            writer.WriteAllText(visitorsFile);
            writer = new CodeWriter.CodeWriter(CodeWriterSettings.CSharpDefault);

            writer._("using System;",
                     $"using {INTERFACES_NAMESPACE};",
                     $"using {VISITORS_NAMESPACE};",
                     string.Empty);

            using (writer.B($"namespace {EXTENSIONS_NAMESPACE}"))
            {
                using (writer.B("public static class InterfaceExtensions"))
                {
                    for (int i = 1; i <= MAX_PARAMS; i++)
                    {
                        writer._($"#region T = {i}");

                        writer._($"public static void Accept<{TypeNameCsv(i)}>(this IVisitable<{TypeNameCsv(i)}> visitable, {ActionTypesAsCsv(i)}) => visitable.Accept(Visitor<{TypeNameCsv(i)}>.Create({ActionArgumentNamesAsCsv(i)}));");
                        writer._($"public static {RETURN_PARAM} Accept<{TypeNameCsv(i)}, {RETURN_PARAM}>(this IVisitable<{TypeNameCsv(i)}> visitable, {FuncTypesAsCsv(i)}) => visitable.Accept(Visitor<{TypeNameCsv(i)}>.Create({FuncArgumentNamesAsCsv(i)}));");

                        for (int j = i; j <= MAX_PARAMS; j++)
                        {
                            foreach (var combination in GetPairsOfNumbersWhichAddUpTo(j))
                            {
                                if (i == combination.First)
                                {
                                    writer._($"public static {RETURN_PARAM} Accept<{TypeNameCsv(j)}, {RETURN_PARAM}>(this IVisitable<{TypeNameCsv(i)}> visitable, I{combination.First}x{combination.Second}Visitor<{TypeNameCsv(j)}, {RETURN_PARAM}> visitor, IVisitable<{string.Join(", ", TypeNames(j).Skip(i))}> secondVisitable) => secondVisitable.Accept({string.Join(", ", Enumerable.Repeat("outer => visitable.Accept(" + string.Join(", ", Enumerable.Repeat("inner => visitor.Visit(inner, outer)", combination.First)) + ")", combination.Second))});");
                                }
                            }
                        }

                        writer._("#endregion", Environment.NewLine);
                    }
                }
            }

            writer.WriteAllText(extensionsFile);
        }

        public static IReadOnlyCollection<Pair<int, int>> GetPairsOfNumbersWhichAddUpTo(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"The number {number} is less than one.");
            }
            else if (number == 1)
            {
                return Array.Empty<Pair<int, int>>();
            }
            else
            {
                return Enumerable.Range(1, number - 1)
                                 .Select(i => new Pair<int, int>(i, number - i))
                                 .ToArray();
            }
        }

        public class Pair<T, U>
        {
            public Pair(T first, U second)
            {
                First = first;
                Second = second;
            }

            public T First { get; set; }
            public U Second { get; set; }

            public override string ToString() => $"{{{nameof(First)} : {First}, {nameof(Second)} : {Second}}}";
        }

        public enum Covariance
        {
            None,
            In,
            Out,
        }

        public static string[] TypeNames(int count) => Enumerable.Range(1, count).Select(i => $"T{i}").ToArray();
        public static string TypeNameCsv(int count, Covariance typeParamOption = Covariance.None)
        {
            var option = typeParamOption switch
            {
                Covariance.None => string.Empty,
                Covariance.In => "in ",
                Covariance.Out => "out ",
                _ => throw new NotImplementedException()
            };

            return string.Join(", ", TypeNames(count).Select(t => $"{option}{t}"));
        }

        public static string FuncTypesAsCsv(int count) => string.Join(", ", TypeNames(count).Select(t => $"Func<{t}, {RETURN_PARAM}> {t.ToLower()}Func"));
        public static string FuncArgumentNamesAsCsv(int count) => string.Join(", ", TypeNames(count).Select(t => $"{t.ToLower()}Func"));
        public static string ActionTypesAsCsv(int count) => string.Join(", ", TypeNames(count).Select(t => $"Action<{t}> {t.ToLower()}Action"));
        public static string ActionArgumentNamesAsCsv(int count) => string.Join(", ", TypeNames(count).Select(t => $"{t.ToLower()}Action"));
    }
}