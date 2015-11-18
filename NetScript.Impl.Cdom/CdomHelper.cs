using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace NetScript.Impl.Cdom
{
	public static class CdomHelper
	{
		public static CodeDomProvider CreateProvider(string lang)
		{
			switch (lang) {
				case "VB":
				case "Visual Basic":
					return new Microsoft.VisualBasic.VBCodeProvider();
				case "C#":
				case "CSharp":
					return new Microsoft.CSharp.CSharpCodeProvider();
				case "J#":
				case "JSharp":
					return new Microsoft.VJSharp.VJSharpCodeProvider();
				case "JS":
				case "JScript":
					return new Microsoft.JScript.JScriptCodeProvider();
				case "F#":
				case "FSharp":
					return new FSharp.Compiler.CodeDom.FSharpCodeProvider();
				default:
					throw new Exception(string.Format("Unknown provider '{0}'!", lang));
			}
		}
	}
}