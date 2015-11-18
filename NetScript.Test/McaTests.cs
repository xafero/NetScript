using System;
using System.Collections.Generic;
using NetScript.Impl.Mca;
using NetScript.API;
using NUnit.Framework;

namespace NetScript.Test
{
	[TestFixture]
	public class McaTests
	{
		[Test]
		public void GetVisualBasic()
		{
			var engine = McaHelper.CreateScript("VB");
			var type = engine.GetType().GetGenericArguments()[1];
			Assert.AreEqual(type.FullName, "Microsoft.CodeAnalysis.Scripting.Script");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=4.0.0.0");
		}
		
		[Test]
		public void GetVbHost()
		{
			IScriptHost host = new McaScriptHost("VB");
			Assert.IsNotNull(host);
		}
		
		[Test]
		public void GetCSharp()
		{
			var engine = McaHelper.CreateScript("C#");
			var type = engine.GetType().GetGenericArguments()[1];
			Assert.AreEqual(type.FullName, "Microsoft.CodeAnalysis.Scripting.Script");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=4.0.0.0");
		}
		
		[Test]
		public void GetCsHost()
		{
			IScriptHost host = new McaScriptHost("C#");
			Assert.IsNotNull(host);
		}
	}
}