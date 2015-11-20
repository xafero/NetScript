using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

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
		
		public object Eval(TextReader reader)
		{
			throw new NotImplementedException();
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