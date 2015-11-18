using System;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;
using Microsoft.CodeAnalysis.Scripting.VisualBasic;
using NetScript.API;

namespace NetScript.Impl.Mca
{
	public static class McaHelper
	{
		public static Func<string,Script> CreateScript(string lang)
		{
			switch (lang) {
				case "VB":
				case "Visual Basic":
					return c => VisualBasicScript.Create(c);
				case "C#":
				case "CSharp":
					return c => CSharpScript.Create(c);
				default:
					throw new Exception(string.Format("Unknown compiler '{0}'!", lang));
			}
		}
	}
}