using System;
using System.Collections.Generic;
using NetScript.Impl.Vsa;
using NetScript.API;
using NUnit.Framework;

namespace NetScript.Test
{
	[TestFixture]
	public class VsaTests
	{
		[Test]
		public void GetVbScript()
		{
			var engine = VsaHelper.CreateEngine("VBScript");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.VisualBasic.Vsa.VsaEngine");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=8.0.0.0");
		}
		
		[Test]
		public void GetVbsHost()
		{
			IScriptHost host = new VsaScriptHost("VBScript");
			Assert.IsNotNull(host);
		}
		
		[Test]
		public void GetJavaScript()
		{
			var engine = VsaHelper.CreateEngine("JScript");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.JScript.Vsa.VsaEngine");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=8.0.0.0");
		}
		
		[Test]
		public void GetJsHost()
		{
			IScriptHost host = new VsaScriptHost("JScript");
			Assert.IsNotNull(host);
		}
	}
}