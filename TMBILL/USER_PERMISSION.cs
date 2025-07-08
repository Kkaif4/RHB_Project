#define DEBUG
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL;

internal class USER_PERMISSION
{
	private string LOG_BY = "";

	public USER_PERMISSION()
	{
		LOG_BY = Settings.Default.Setting.ToString();
	}

	public bool Permission(string id, string operation)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select " + LOG_BY + " from DB_Permission where id='" + id + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string text = ((DbDataReader)(object)val3)[0].ToString();
						Debug.WriteLine("Allowed Permission " + text);
						string[] array = text.Split(new char[1] { '*' });
						Debug.WriteLine("After spilt Permission size " + array.Length);
						switch (operation)
						{
						case "Insert":
							if (array[0] != "")
							{
								return true;
							}
							break;
						case "Update":
							if (array[1] != "")
							{
								return true;
							}
							break;
						case "Delete":
							if (array[2] != "")
							{
								return true;
							}
							break;
						default:
							if (array[0] != "")
							{
								return true;
							}
							break;
						}
					}
				}
				((DbConnection)(object)val).Close();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}
}
