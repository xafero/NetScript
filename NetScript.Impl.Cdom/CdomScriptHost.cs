using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
			return Eval(reader.ReadToEnd());
		}
		
		private object Eval(string code)
		{
			var cp = new CompilerParameters {
				GenerateInMemory = true
			};
			var res = provider.CompileAssemblyFromSource(cp, code);
			if (res.Errors.HasErrors)
				throw new ScriptException(res.Errors);
			var ass = res.CompiledAssembly;
			var types = ass.GetTypes().Where(t => t.Namespace != "My");
			if (types.Count() == 1)
				return types.First();
			return types.ToArray();
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