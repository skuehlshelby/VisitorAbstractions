using CodeWriter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration
{
    internal static class Templates
    {
        private const int MAX_PARAMS = 16;
        private const string TYPE_PARAM = "T";
        private const string RETURN_PARAM = $"{TYPE_PARAM}Return";
        private static readonly IDictionary<int, string[]> TypeParameters = Enumerable.Range(1, MAX_PARAMS).ToDictionary(key => key, val => Enumerable.Repeat(TYPE_PARAM, val).Zip(Enumerable.Range(1, val), (l, r) => $"{l}{r}").ToArray());
        private static readonly IDictionary<int, string[]> OutTypeParameters = Enumerable.Range(1, MAX_PARAMS).ToDictionary(key => key, val => Enumerable.Repeat(TYPE_PARAM, val).Zip(Enumerable.Range(1, val), (l, r) => $"out {l}{r}").ToArray());
        private static readonly IDictionary<int, string[]> InTypeParameters = Enumerable.Range(1, MAX_PARAMS).ToDictionary(key => key, val => Enumerable.Repeat(TYPE_PARAM, val).Zip(Enumerable.Range(1, val), (l, r) => $"in {l}{r}").ToArray());

        private static string Csv(string[] strings) => string.Join(", ", strings);

        public static void IVisitable(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            using (codeWriter.B($"public interface IVisitable<{Csv(OutTypeParameters[typeParameterCount])}>"))
            {
                codeWriter._($"{RETURN_PARAM} Accept<{RETURN_PARAM}>(IVisitor<{Csv(TypeParameters[typeParameterCount])}, {RETURN_PARAM}> visitor);");
            }
        }

        public static void IVisitor(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            var typeParameterCsv = Csv(InTypeParameters[typeParameterCount]);

            using (codeWriter.B($"public interface IVisitor<{typeParameterCsv}, {RETURN_PARAM}>"))
            {
                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    codeWriter._($"{RETURN_PARAM} Visit({typeParameter} instance);");
                }                
            }
        }

        public static void IVisitableFactory(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            var typeParameterCsv = Csv(TypeParameters[typeParameterCount]);

            using (codeWriter.B($"public interface IVisitableFactory<{typeParameterCsv}>"))
            {
                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    codeWriter._($"IVisitable<{Csv(TypeParameters[typeParameterCount])}> Create({typeParameter} instance);");
                }
            }
        }

        public static void IXxXVisitors(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            foreach (var combination in GetPairsOfNumbersWhichAddUpTo(typeParameterCount))
            {
                var first = combination.Item1;
                var second = combination.Item2;

                using (codeWriter.B($"public interface I{first}x{second}Visitor<{Csv(InTypeParameters[typeParameterCount])}, {RETURN_PARAM}>"))
                {
                    foreach (var leftParam in TypeParameters[typeParameterCount][..first])
                    {
                        foreach (var rightParam in TypeParameters[typeParameterCount][first..])
                        {
                            codeWriter._($"{RETURN_PARAM} Visit ({leftParam} left, {rightParam} right);");
                        }
                    }
                }
            }
        }

        public static void Variant(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            codeWriter._(@"[DebuggerDisplay(""{{GetDebuggerDisplay(),nq}}"")]");

            using (codeWriter.B($"public sealed class Variant<{Csv(TypeParameters[typeParameterCount])}> : IVisitable<{Csv(TypeParameters[typeParameterCount])}>"))
            {
                codeWriter._($"private string GetDebuggerDisplay() => $\"{{nameof(Variant<{Csv(TypeParameters[typeParameterCount])}>)}}<{{string.Join(\", \", GetType().GetGenericArguments().Select(arg => arg.Name))}}> : {{Accept(Visitor<{Csv(TypeParameters[typeParameterCount])}>.Create({string.Join(", ", Enumerable.Repeat("t => t?.GetType().Name", typeParameterCount))}))}}\";");

                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    using (codeWriter.B($"private sealed class {typeParameter}Visitable : IVisitable<{Csv(TypeParameters[typeParameterCount])}>"))
                    {
                        codeWriter._($"private readonly {typeParameter} {typeParameter.ToLower()};",
                                     $"public {typeParameter}Visitable({typeParameter} {typeParameter.ToLower()}) => this.{typeParameter.ToLower()} = {typeParameter.ToLower()};",
                                     $"public {RETURN_PARAM} Accept<{RETURN_PARAM}>(IVisitor<{Csv(TypeParameters[typeParameterCount])}, {RETURN_PARAM}> visitor) => visitor.Visit({typeParameter.ToLower()});");
                    }
                }

                codeWriter._($"private readonly IVisitable<{Csv(TypeParameters[typeParameterCount])}> inner;");

                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    codeWriter._($"public Variant({typeParameter} instance) => inner = new {typeParameter}Visitable(instance);");
                }

                codeWriter._($"public {RETURN_PARAM} Accept<{RETURN_PARAM}>(IVisitor<{Csv(TypeParameters[typeParameterCount])}, {RETURN_PARAM}> visitor) => inner.Accept(visitor);");

                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    codeWriter._($"public static implicit operator Variant<{Csv(TypeParameters[typeParameterCount])}>({typeParameter} instance) => new Variant<{Csv(TypeParameters[typeParameterCount])}>(instance);");
                }
            }
        }

        public static void Visitor(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            using (codeWriter.B($"public static class Visitor<{Csv(TypeParameters[typeParameterCount])}>"))
            {
                using (codeWriter.B($"private sealed class NonReturningVisitor : IVisitor<{Csv(TypeParameters[typeParameterCount])}, Nothing>"))
                {
                    foreach (var typeParam in TypeParameters[typeParameterCount])
                    {
                        codeWriter._($"private readonly Action<{typeParam}> {typeParam.ToLower()}Action;");
                    }

                    codeWriter._();

                    using (codeWriter.B($"public NonReturningVisitor({Csv(TypeParameters[typeParameterCount].Select(t => $"Action<{t}> {t.ToLower()}Action").ToArray())})"))
                    {
                        foreach (var typeParam in TypeParameters[typeParameterCount].Select(t => t.ToLower()))
                        {
                            codeWriter._($"this.{typeParam}Action = {typeParam}Action ?? throw new ArgumentNullException(nameof({typeParam}Action));");
                        }
                    }

                    foreach (var typeParam in TypeParameters[typeParameterCount])
                    {
                        using (codeWriter.B($"public Nothing Visit({typeParam} instance)"))
                        {
                            codeWriter._($"{typeParam.ToLower()}Action.Invoke(instance);",
                                         "return Nothing.Instance;");
                        }
                    }
                }

                using (codeWriter.B($"private sealed class ReturningVisitor<{RETURN_PARAM}> : IVisitor<{Csv(TypeParameters[typeParameterCount])}, {RETURN_PARAM}>"))
                {
                    foreach (var typeParam in TypeParameters[typeParameterCount])
                    {
                        codeWriter._($"private readonly Func<{typeParam}, {RETURN_PARAM}> {typeParam.ToLower()}Func;");
                    }

                    codeWriter._();

                    using (codeWriter.B($"public ReturningVisitor({Csv(TypeParameters[typeParameterCount].Select(t => $"Func<{t}, {RETURN_PARAM}> {t.ToLower()}Func").ToArray())})"))
                    {
                        foreach (var typeParam in TypeParameters[typeParameterCount].Select(t => t.ToLower()))
                        {
                            codeWriter._($"this.{typeParam}Func = {typeParam}Func ?? throw new ArgumentNullException(nameof({typeParam}Func));");
                        }
                    }

                    foreach (var typeParam in TypeParameters[typeParameterCount])
                    {
                        codeWriter._($"public TReturn Visit({typeParam} instance) => {typeParam.ToLower()}Func.Invoke(instance);");
                    }
                }

                codeWriter._();
                codeWriter._($"public static IVisitor<{Csv(TypeParameters[typeParameterCount])}, Nothing> Create({Csv(TypeParameters[typeParameterCount].Select(t => $"Action<{t}> {t.ToLower()}Action").ToArray())}) => new NonReturningVisitor({Csv(TypeParameters[typeParameterCount].Select(t => $"{t.ToLower()}Action").ToArray())});");
                codeWriter._($"public static IVisitor<{Csv(TypeParameters[typeParameterCount])}, {RETURN_PARAM}> Create<{RETURN_PARAM}>({Csv(TypeParameters[typeParameterCount].Select(t => $"Func<{t}, {RETURN_PARAM}> {t.ToLower()}Func").ToArray())}) => new ReturningVisitor<{RETURN_PARAM}>({Csv(TypeParameters[typeParameterCount].Select(t => $"{t.ToLower()}Func").ToArray())});");
            }
        }

        public static void VisitableFactory(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            using (codeWriter.B($"public sealed class VisitableFactory<{Csv(TypeParameters[typeParameterCount])}> : IVisitableFactory<{Csv(TypeParameters[typeParameterCount])}>"))
            {
                foreach (var typeParameter in TypeParameters[typeParameterCount])
                {
                    codeWriter._($"public IVisitable<{Csv(TypeParameters[typeParameterCount])}> Create({typeParameter} instance) => new Variant<{Csv(TypeParameters[typeParameterCount])}>(instance);");
                }
            }
        }

        public static void VisitableActionExtension(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            var typenames = Csv(TypeParameters[typeParameterCount]);
            var actiontypenames = Csv(TypeParameters[typeParameterCount].Select(t => $"Action<{t}> {t.ToLower()}Action").ToArray());
            var actionargumentnames = Csv(TypeParameters[typeParameterCount].Select(t => $"{t.ToLower()}Action").ToArray());
            codeWriter._($"public static void Accept<{typenames}>(this IVisitable<{typenames}> visitable, {actiontypenames}) => visitable.Accept(Visitor<{typenames}>.Create({actionargumentnames}));");
        }

        public static void VisitableFunctionExtension(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            var typenames = Csv(TypeParameters[typeParameterCount]);
            var functypenames = Csv(TypeParameters[typeParameterCount].Select(t => $"Func<{t}, {RETURN_PARAM}> {t.ToLower()}Func").ToArray());
            var funcargumentnames = Csv(TypeParameters[typeParameterCount].Select(t => $"{t.ToLower()}Func").ToArray());
            codeWriter._($"public static {RETURN_PARAM} Accept<{typenames}, {RETURN_PARAM}>(this IVisitable<{typenames}> visitable, {functypenames}) => visitable.Accept(Visitor<{typenames}>.Create({funcargumentnames}));");
        }

        public static void DoubleVisitExtensions(CodeWriter.CodeWriter codeWriter, int typeParameterCount)
        {
            for (int i = 1; i <= MAX_PARAMS - typeParameterCount; i++)
            {
                codeWriter._($"public static {RETURN_PARAM} Accept<{Csv(TypeParameters[typeParameterCount + i])}, {RETURN_PARAM}>(this IVisitable<{Csv(TypeParameters[typeParameterCount])}> visitable, I{typeParameterCount}x{i}Visitor<{Csv(TypeParameters[typeParameterCount + i])}, {RETURN_PARAM}> visitor, IVisitable<{Csv(TypeParameters[typeParameterCount + i][typeParameterCount..])}> secondVisitable) => secondVisitable.Accept({string.Join(", ", Enumerable.Repeat("outer => visitable.Accept(" + string.Join(", ", Enumerable.Repeat("inner => visitor.Visit(inner, outer)", typeParameterCount)) + ")", i))});");
            }
        }

        private static IReadOnlyCollection<ValueTuple<int, int>> GetPairsOfNumbersWhichAddUpTo(int number)
        {
            return number switch
            {
                < 1 => throw new ArgumentOutOfRangeException(nameof(number), $"The number {number} is less than one."),
                1 => Array.Empty<ValueTuple<int, int>>(),
                _ => Enumerable.Range(1, number - 1)
                                 .Select(i => new ValueTuple<int, int>(i, number - i))
                                 .ToArray()
            };
        }
    }
}
