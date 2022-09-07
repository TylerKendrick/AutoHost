using Microsoft.CodeAnalysis;

namespace AutoHost
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        internal const string FunctionHost =
        @"
        using Microsoft.Azure.WebJopbs;
        namespace AutoHost.Hosting
        {
            public class FunctionHost
            {
                [FunctionName(nameof(Result))]
                public static void Result()
                {
                }
            }
        }
        ";

        void ISourceGenerator.Initialize(GeneratorInitializationContext context) { }
        void ISourceGenerator.Execute(GeneratorExecutionContext context)
        {
            context.AddSource("FunctionHost.cs", FunctionHost);
        }
    }
}