using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using System.Linq;
using System.Runtime.InteropServices;

namespace CustomReSharperMacro
{
    [MacroImplementation(Definition = typeof(ServiceNameFromInterface))]
    public class ServiceNameFromInterfaceImpl : SimpleMacroImplementation
    {
        private readonly IMacroParameterValueNew _interfaceName;

        public ServiceNameFromInterfaceImpl([Optional] MacroParameterValueCollection args)
        {
            _interfaceName = args?.ElementAt(0);

        }

        public override HotspotItems GetLookupItems(IHotspotContext context)
        {
            return MacroUtil.SimpleEvaluateResult(GetServiceName(_interfaceName));
        }

        private string GetServiceName(IMacroParameterValueNew interfaceName)
        {
            string iName = interfaceName.GetValue();
            string baseName = iName.Substring(1, iName.Length - 1);
            return "LS" + baseName + "();";
        }
    }
}