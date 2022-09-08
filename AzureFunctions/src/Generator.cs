using Microsoft.CodeAnalysis;

namespace AutoHost
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        internal const string FunctionHost =
        @"
        namespace AutoHost.Hosting
        {
            public class FunctionHost
            {
                [Microsoft.Azure.Functions.Worker.Function(nameof(Result))]
                public static void Result()
                {
                }
            }
        }
        ";

        void ISourceGenerator.Initialize(GeneratorInitializationContext context)
        {
        }
        void ISourceGenerator.Execute(GeneratorExecutionContext context)
        {
            context.AddSource("FunctionHost.cs", FunctionHost);
        }
    }
}