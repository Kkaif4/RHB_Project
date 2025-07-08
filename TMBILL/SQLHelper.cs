#define DEBUG
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.ServiceProcess;
using Microsoft.Win32;

namespace TMBILL;

internal class SQLHelper
{
	private SqlConnection cn;

	public bool IsConnection
	{
		get
		{
			if (((DbConnection)(object)cn).State == ConnectionState.Closed)
			{
				((DbConnection)(object)cn).Open();
			}
			return true;
		}
	}

	public SQLHelper()
	{
	}

	public SQLHelper(string constring)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		cn = new SqlConnection(constring);
	}

	public bool IsServerInstalled()
	{
		string text = "";
		RegistryView view = (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
		using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view))
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL", writable: false);
			if (registryKey2 != null)
			{
				string[] valueNames = registryKey2.GetValueNames();
				foreach (string text2 in valueNames)
				{
					text = text2;
				}
			}
		}
		if (text == "")
		{
			return false;
		}
		return true;
	}

	public string ServerRunning(string serviceName)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		string text = "SQL Server (" + serviceName + ")";
		ServiceController val = new ServiceController(text);
		try
		{
			string text2 = ((object)val.Status).ToString();
		}
		catch (Exception)
		{
			return "NOTFOUND";
		}
		Debug.WriteLine("The service is now " + ((object)val.Status).ToString());
		if (((object)val.Status).Equals((object)(ServiceControllerStatus)1) | ((object)val.Status).Equals((object)(ServiceControllerStatus)3) | ((object)val.Status).Equals((object)(ServiceControllerStatus)7) | ((object)val.Status).Equals((object)(ServiceControllerStatus)6))
		{
			try
			{
				val.Start();
				val.WaitForStatus((ServiceControllerStatus)4);
				Debug.WriteLine("The service is now " + ((object)val.Status).ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error in starting the service: " + ex.Message);
			}
		}
		return ((object)val.Status).ToString();
	}
}
