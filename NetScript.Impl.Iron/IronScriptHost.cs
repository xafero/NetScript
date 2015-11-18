using System;
using System.Collections.Generic;
using Microsoft.Scripting.Hosting;
using NetScript.API;

namespace NetScript.Impl.Iron
{
	public class IronScriptHost : IScriptHost
	{
		private ScriptEngine engine;
		
		public IronScriptHost(string lang)
		{
			engine = IronHelper.CreateEngine(lang);
		}
		
		public void Dispose()
		{
			if (engine == null)
				return;
			engine.Runtime.Shutdown();
			engine = null;
		}
	}
}