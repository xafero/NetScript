using System;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;
using Microsoft.CodeAnalysis.Scripting.VisualBasic;
using NetScript.API;

namespace NetScript.Impl.Mca
{
	public class McaScriptHost : IScriptHost
	{
		public McaScriptHost(string lang)
		{
			
		}
		
		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}