using System;
using Microsoft.Vsa;

namespace NetScript.Impl.Vsa
{
	#pragma warning disable 612, 618
	public static class VsaHelper
	{
		public static IVsaEngine CreateEngine(string lang)
		{
			switch (lang) {
				case "VB":
				case "Visual Basic":
					return new Microsoft.VisualBasic.Vsa.VsaEngine();
				case "JScript":
				case "JScript.NET":
					return new Microsoft.JScript.Vsa.VsaEngine();
				default:
					throw new Exception(string.Format("Unknown Engine '{0}'!", lang));
			}
		}
	}
	#pragma warning restore 612, 618
}