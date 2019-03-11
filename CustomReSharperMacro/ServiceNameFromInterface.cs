using System.Collections.Generic;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Refactorings.InlineParameter.Data;

namespace CustomReSharperMacro
{
    [MacroDefinition("CustomReSharperMacro.GetServiceFromInterface",
        ShortDescription = "Changes {#0:another variable} name to Service name",
        LongDescription = "Takes {#0:another variable} name removes the I and adds LS")]
    public class ServiceNameFromInterface : SimpleMacroDefinition
    {
        public override ParameterInfo[] Parameters { get { return new[] { new ParameterInfo(ParameterType.VariableReference) }; } }




    }
}