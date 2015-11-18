using System;
using System.Collections.Generic;
using IronPython.Hosting;
using IronRuby;
using Microsoft.Scripting.Hosting;

namespace NetScript.Impl.Iron
{
	public static class IronHelper
	{
		public static readonly IronRuby.Builtins.Numeric _dummyRubyLibRef;
		
		public static ScriptEngine CreateEngine(string lang)
		{
			switch (lang) {
				case "Python":
				case "IronPython":
					return Python.CreateEngine();
				case "Ruby":
				case "IronRuby":
					return Ruby.CreateEngine();
				default:
					throw new Exception(string.Format("Unknown engine '{0}'!", lang));
			}
		}
	}
}