using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace CustomReSharperMacro
{
    [MacroDefinition("CustomReSharperMacro.ConverterNameGet",
        ShortDescription = "Class name with LS removed and Converter added to end",
        LongDescription = "Takes the class name and removes leading LS and adds Converter to the end")]
    public class ConverterNameMacro : SimpleMacroDefinition
    {
        
    }
}