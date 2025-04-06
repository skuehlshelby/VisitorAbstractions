using CodeWriter;
using System;
using System.IO;
using System.Reflection;

namespace CodeGeneration
{
    public static class Program
    {
        public const int MAX_PARAMS = 16;
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
            var visitableFactoriesFile = Path.Combine(codeFilesFolder, "VisitableFactories.cs");
            var visitorsFile = Path.Combine(codeFilesFolder, "Visitors.cs");
            var extensionsFile = Path.Combine(codeFilesFolder, "Extensions.cs");

            using (writer.B($"namespace {NOTHING_NAMESPACE}"))
            {
                using (writer.B("public sealed class Nothing"))
                {
                    writer._("private Nothing() { }");
                    writer._("public static readonly Nothing Instance = new Nothing();");
                }
            }

            #region Interfaces

            using (writer.B($"namespace {INTERFACES_NAMESPACE}"))
            {
                for (int i = 1; i <= MAX_PARAMS; i++)
                {
                    writer._($"#region T = {i}", string.Empty);

                    Templates.IVisitable(writer, i);

                    Templates.IVisitableFactory(writer, i);

                    Templates.IVisitor(writer, i);

                    Templates.IXxXVisitors(writer, i);

                    writer._("#endregion", string.Empty);
                }
            }

            #endregion

            writer.WriteAllText(interfacesFile);
            writer = new CodeWriter.CodeWriter(CodeWriterSettings.CSharpDefault);
            
            writer._("using System.Linq;",
                     "using System.Diagnostics;",
                     $"using {INTERFACES_NAMESPACE};",
                     $"using {VISITORS_NAMESPACE};",
                     string.Empty);

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
                     $"using {VARIANT_NAMESPACE};",
                     $"using {INTERFACES_NAMESPACE};",
                     string.Empty);

            using (writer.B($"namespace {VISITORS_NAMESPACE}"))
            {
                for (int i = 1; i <= MAX_PARAMS; i++)
                {
                    writer._($"#region T = {i}");
                    writer._();

                    Templates.VisitableFactory(writer, i);

                    writer._("#endregion");
                    writer._();
                }
            }

            writer.WriteAllText(visitableFactoriesFile);
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

                        Templates.VisitableActionExtension(writer, i);
                        Templates.VisitableFunctionExtension(writer, i);
                        Templates.DoubleVisitExtensions(writer, i);

                        writer._("#endregion", Environment.NewLine);
                    }
                }
            }

            writer.WriteAllText(extensionsFile);
        }
    }
}