﻿using System;
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
				default:
					throw new Exception(string.Format("Unknown provider '{0}'!", lang));
			}
		}
	}
}