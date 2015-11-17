using System;
using Microsoft.Vsa;

namespace NetScript.Impl.Vsa
{
	#pragma warning disable 612, 618
	public class VisualSite : IVsaSite
	{
		public void GetCompiledState(out byte[] pe, out byte[] debugInfo)
		{
			throw new NotImplementedException();
		}
		
		public bool OnCompilerError(IVsaError error)
		{
			throw new NotImplementedException();
		}
		
		public object GetGlobalInstance(string name)
		{
			throw new NotImplementedException();
		}
		
		public object GetEventSourceInstance(string itemName, string eventSourceName)
		{
			throw new NotImplementedException();
		}
		
		public void Notify(string notify, object info)
		{
			throw new NotImplementedException();
		}
	}
	#pragma warning restore 612, 618
}