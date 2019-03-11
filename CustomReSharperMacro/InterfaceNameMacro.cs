using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace CustomReSharperMacro
{
    [MacroDefinition("CustomReSharperMacro.InterfaceNameGet",
        ShortDescription = "Class name with LS replaced with I",
        LongDescription = "Takes the class name and removes leading LS and adds I to start")]
    public class InterfaceNameMacro : SimpleMacroDefinition
    {
        
    }
}