using System;
using Newtonsoft.Json;

namespace NetScript.API
{
	public class ScriptException : Exception
	{
		public object Something { get; private set; }
		
		public ScriptException(object something) : base(ToJson(something))
		{
			Something = something;
		}
		
		private static string ToJson(object something)
		{
			return JsonConvert.SerializeObject(something, Formatting.Indented);
		}
	}
}