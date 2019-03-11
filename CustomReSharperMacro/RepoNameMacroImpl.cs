using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Psi;

namespace CustomReSharperMacro
{
    [MacroImplementation(Definition = typeof(RepoNameMacro))]
    public class RepoNameMacroImpl : SimpleMacroImplementation
    {
        public override string EvaluateQuickResult(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);

            var repoName = sourceFile == null ? "Replace This" : sourceFile.Name.Substring(2, sourceFile.Name.Length - 5);
            return repoName;
        }
    }
}