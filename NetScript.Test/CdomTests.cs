﻿using System;
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
			using (IScriptHost host = new CdomScriptHost("VB"))
			{
				Assert.IsNotNull(host);
				var code =
					"Public Class Person "+'\n'+
					"   Private myName As String "+'\n'+
					"	Public Property Name() As String "+'\n'+
					"		Get "+'\n'+
					"			Return myName "+'\n'+
					"		End Get "+'\n'+
					"		Set "+'\n'+
					"			myName = Value "+'\n'+
					"		End Set "+'\n'+
					"	End Property "+'\n'+
					"End Class";
				var type = host.Eval(code);
				Assert.AreEqual(type+"", "Person");
			}
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
			using (IScriptHost host = new CdomScriptHost("C#"))
			{
				Assert.IsNotNull(host);
				var code = "public class Person { "+
					"public string Name { get; set; } "+
					"public int Age { get; set; } "+
					"public Person(string name, int age) { "+
					"   Name = name; "+
					"   Age = age; "+
					"} }";
				var type = host.Eval(code);
				Assert.AreEqual(type+"", "Person");
			}
		}
		
		[Test]
		public void GetJSharp()
		{
			var engine = CdomHelper.CreateProvider("J#");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.VJSharp.VJSharpCodeProvider");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=2.0.0.0");
		}
		
		[Test]
		public void GetJsHost()
		{
			IScriptHost host = new CdomScriptHost("J#");
			Assert.IsNotNull(host);
		}
		
		[Test]
		public void GetJScript()
		{
			var engine = CdomHelper.CreateProvider("JScript");
			Assert.AreEqual(engine.GetType().FullName, "Microsoft.JScript.JScriptCodeProvider");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=8.0.0.0");
		}
		
		[Test]
		public void GetJScriptHost()
		{
			IScriptHost host = new CdomScriptHost("JScript");
			Assert.IsNotNull(host);
		}
		
		[Test]
		public void GetFSharp()
		{
			var engine = CdomHelper.CreateProvider("F#");
			Assert.AreEqual(engine.GetType().FullName, "FSharp.Compiler.CodeDom.FSharpCodeProvider");
			Assert.AreEqual(engine.GetType().AssemblyQualifiedName.Split(',')[2], " Version=0.9.3.0");
		}
		
		[Test]
		public void GetFsHost()
		{
			IScriptHost host = new CdomScriptHost("F#");
			Assert.IsNotNull(host);
		}
	}
}