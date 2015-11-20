using System;
using System.Collections.Generic;
using System.IO;

namespace NetScript.API
{
	public interface IScriptHost : IDisposable
	{
		/// <summary>
		/// Evaluates the specified script
		/// </summary>
		/// <param name="reader">The source of the script</param>
		/// <returns>The value returned by the script</returns>
		object Eval(TextReader reader);
	}
}