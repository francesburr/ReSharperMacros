using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Psi;

namespace CustomReSharperMacro
{
    [MacroImplementation(Definition = typeof(InterfaceNameMacro))]
    public class InterfaceNameMacroImpl : SimpleMacroImplementation
    {
        public override string EvaluateQuickResult(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);

            var baseName = sourceFile == null ? "Replace This" : sourceFile.Name.Substring(2, sourceFile.Name.Length - 5);
            var interfaceName = "I" + baseName;
            return interfaceName;
        }

    }
}