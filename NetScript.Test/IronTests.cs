using System;
using NetScript.API;
using NetScript.Impl.Iron;
using NUnit.Framework;

namespace NetScript.Test
{
	[TestFixture]
	public class IronTests
	{
		[Test]
		public void GetPython()
		{
			var engine = IronHelper.CreateEngine("Python");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.Scripting.Hosting.ScriptEngine");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=1.1.0.20");
		}
		
		[Test]
		public void GetPythonHost()
		{
			using (IScriptHost host = new IronScriptHost("Python"))
			{
				Assert.IsNotNull(host);
				Assert.AreEqual(host.Eval("[x**2 for x in range(4)]"), new [] { 0,1,4,9 });
			}
		}
		
		[Test]
		public void GetRuby()
		{
			var engine = IronHelper.CreateEngine("Ruby");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.Scripting.Hosting.ScriptEngine");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=1.1.0.20");
		}
		
		[Test]
		public void GetRubyHost()
		{
			using (IScriptHost host = new IronScriptHost("Ruby"))
			{
				Assert.IsNotNull(host);
				Assert.AreEqual(host.Eval("(1..3).map { |i| 2 * i }"), new [] { 2,4,6 });
			}
		}
	}
}