using Microsoft.CodeAnalysis;

namespace AutoHost
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        internal const string FunctionHost =
        @"
        ";

        void ISourceGenerator.Initialize(GeneratorInitializationContext context) { }
        void ISourceGenerator.Execute(GeneratorExecutionContext context) { }
    }

    public static class TemplateFunctionHost
    {
        [FunctionName(nameof(Result))]
        public static void Result()
        {

        }
    }
}