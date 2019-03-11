using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace CustomReSharperMacro
{
    [MacroDefinition("CustomReSharperMacro.RepoNameGet",
        ShortDescription = "Class name with LS Removed",
        LongDescription = "Takes the class name and removes leading LS")]
    public class RepoNameMacro : SimpleMacroDefinition
    {
        
    }
}