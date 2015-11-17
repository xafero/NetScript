using System;
using System.Collections.Generic;
using NetScript.Impl.Cdom;
using NetScript.Impl.Vsa;
using NetScript.API;
using NUnit.Framework;

namespace NetScript.Test
{
	[TestFixture]
	public class CdomTests
	{
		[Test]
		public void GetVisualBasic()
		{
			var engine = CdomHelper.CreateProvider("VB");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.VisualBasic.VBCodeProvider");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=4.0.0.0");
		}
		
		[Test]
		public void GetVbHost()
		{
			IScriptHost host = new CdomScriptHost("VB");
			Assert.IsNotNull(host);
		}
		
		[Test]
		public void GetCSharp()
		{
			var engine = CdomHelper.CreateProvider("C#");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.CSharp.CSharpCodeProvider");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=4.0.0.0");
		}
		
		[Test]
		public void GetCsHost()
		{
			IScriptHost host = new CdomScriptHost("C#");
			Assert.IsNotNull(host);
		}
	}
}