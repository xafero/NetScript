using System;
using System.Collections.Generic;
using System.IO;

namespace NetScript.API
{
	public static class ScriptExtensions
	{
		public static object Eval(this IScriptHost engine, string script)
		{
			return engine.Eval(new StringReader(script));
		}
	}
}