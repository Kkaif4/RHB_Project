using System;
using System.ServiceProcess;

namespace TMBILL;

internal class ServiceManage
{
	public string ServiceStatus()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		ServiceController val = new ServiceController("RHInfinity");
		try
		{
			text = ((object)val.Status).ToString();
		}
		catch (Exception)
		{
			return "NOTFOUND";
		}
		return text;
	}

	public void StartService()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ServiceController val = new ServiceController("RHInfinity");
		val.Start();
		val.WaitForStatus((ServiceControllerStatus)4);
	}
}
