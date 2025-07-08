using System;
using System.Management;

namespace TMBILL;

internal class Mac_Address
{
	public string getmac()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection val2 = val.Get();
		string text = "";
		string text2 = "";
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.Current;
				object obj = ((ManagementBaseObject)val3)["MacAddress"];
				if (obj != null)
				{
					text = obj.ToString();
					text = text.Replace(":", "");
					text2 = text2 + text + "*";
					val3.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text2;
	}

	public int isValidMac(string mac)
	{
		string text = getmac();
		string[] array = text.Split(new char[1] { '*' });
		return Array.IndexOf(array, mac);
	}

	public string Singlemac()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * FROM Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection val2 = val.Get();
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.Current;
				object obj = ((ManagementBaseObject)val3)["MacAddress"];
				if (obj != null)
				{
					if (text == string.Empty)
					{
						text = obj.ToString();
					}
					val3.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Replace(":", "");
	}
}
