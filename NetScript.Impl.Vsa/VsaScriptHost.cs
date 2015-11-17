using System;
using Microsoft.Vsa;
using NetScript.API;

namespace NetScript.Impl.Vsa
{
	#pragma warning disable 612, 618
	public class VsaScriptHost : IScriptHost
	{
		private IVsaEngine engine;
		private VisualSite site;
		
		public VsaScriptHost(string lang, string moniker = null, string nameSpace = null)
		{
			// Patch default values
			var now = DateTime.Now.Millisecond;
			if (string.IsNullOrWhiteSpace(moniker))
				moniker = "guid://NetScript/"+lang+"/Instance#" + now;
			if (string.IsNullOrWhiteSpace(nameSpace))
				nameSpace = GetType().FullName+".inst" + now;
			// Initialize engine
			var engine = VsaHelper.CreateEngine(lang);
			engine.RootMoniker = moniker;
			engine.Site = (site = new VisualSite());
			engine.InitNew();
			engine.RootNamespace = nameSpace;
			engine.Name = lang.Replace(" ", "");
		}
		
		public void Dispose()
		{
			if (engine == null)
				return;
			engine.Close();
			engine = null;
		}
	}
	#pragma warning restore 612, 618
}