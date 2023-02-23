using CodeWriter;

namespace CodeGeneration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var settings = new CodeWriterSettings(CodeWriterSettings.CSharpDefault);
            var writer = new CodeWriter.CodeWriter(settings);

            for (int i = 2; i < 17; i++)
            {
                var typeParams = Enumerable.Range(1, i).Select(n => "T" + n.ToString()).ToArray();
                var outParams = string.Join(", ", typeParams.Select(tp => "out " + tp));
                var inParams = string.Join(", ", typeParams.Select(tp => "in " + tp));

                using (writer.B($"public interface IVisitable<{outParams}>"))
                {
                    writer._($"void Accept(IVisitor<{string.Join(", ", typeParams)}> visitor);");
                }

                using (writer.B($"public interface IVisitor<{inParams}>"))
                {
                    foreach (var typeParam in typeParams)
                    {
                        writer._($"void Visit ({typeParam} instance);");
                    }
                }

                using (writer.B($"public interface IVisitableExtended<{outParams}> : IVisitable<{string.Join(", ", typeParams)}>"))
                {
                    writer._($"TReturn Accept<TReturn>(IVisitorExtended<TReturn, {string.Join(", ", typeParams)}> visitor);");
                }

                using (writer.B($"public interface IVisitorExtended<out TReturn, {inParams}>"))
                {
                    foreach (var typeParam in typeParams)
                    {
                        writer._($"TReturn Visit ({typeParam} instance);");
                    }
                }
            }

            Console.WriteLine(writer.ToString());
        }
    }
}