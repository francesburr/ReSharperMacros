using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Psi;

namespace CustomReSharperMacro
{
    [MacroImplementation(Definition = typeof(ControllerNameMacro))]
    public class ControllerNameMacroImpl : SimpleMacroImplementation
    {
        public override string EvaluateQuickResult(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);

            var controllerName = sourceFile == null ? "Replace This" : sourceFile.Name.Substring(0, sourceFile.Name.Length - 13);
            return controllerName;
        }
    }
}