using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

using NetScript.API;

namespace NetScript.Impl.Cdom
{
	public class CdomScriptHost : IScriptHost
	{
		private CodeDomProvider provider;
		
		public CdomScriptHost(string lang)
		{
			provider = CdomHelper.CreateProvider(lang);
		}
		
		public void Dispose()
		{
			if (provider == null)
				return;
			provider.Dispose();
			provider = null;
		}
	}
}