using System.Collections.Generic;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.Util;
using Microsoft.Build.Logging;

namespace CustomReSharperMacro
{    
    [MacroDefinition("CustomReSharperMacro.ControllerNameGet",
        ShortDescription = "Class name with Controller removed",
        LongDescription = "Takes the class name and takes a substring to get controller name")]
    public class ControllerNameMacro : SimpleMacroDefinition
    {
        
    }
}