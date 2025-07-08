#define DEBUG
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;

namespace TMBILL;

internal class CalPeriod
{
	private string maincom;

	private string div;

	public string getdate()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		try
		{
			int num = 0;
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from shop";
					SqlDataReader val3 = val2.ExecuteReader();
					num = (((DbDataReader)(object)val3).HasRows ? 1 : 0);
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
			if (num == 0)
			{
				return "No User Register Yet";
			}
			IsolatedStorageFile userStoreForAssembly = IsolatedStorageFile.GetUserStoreForAssembly();
			IsolatedStorageFileStream stream = new IsolatedStorageFileStream("Details.txt", FileMode.Open, userStoreForAssembly);
			using StreamReader streamReader = new StreamReader(stream);
			string cipherText = streamReader.ReadLine();
			string text = new Encryption().DecryptString(cipherText);
			Debug.WriteLine(text);
			string[] array = text.Split(new char[1] { '-' });
			return "Licence Expired On:" + DateTime.Parse(array[1]).AddDays(int.Parse(array[2])).ToShortDateString();
		}
		catch (Exception)
		{
			return "No User Register Yet";
		}
	}

	public string cheack()
	{
		try
		{
			IsolatedStorageFile userStoreForAssembly = IsolatedStorageFile.GetUserStoreForAssembly();
			IsolatedStorageFileStream stream = new IsolatedStorageFileStream("Details.txt", FileMode.Open, userStoreForAssembly);
			using StreamReader streamReader = new StreamReader(stream);
			string cipherText = streamReader.ReadLine();
			string text = new Encryption().DecryptString(cipherText);
			string[] array = text.Split(new char[1] { '-' });
			new Permission().setDateFormat();
			string s = DateTime.Today.ToShortDateString();
			DateTime dateTime = DateTime.Parse(s);
			string s2 = array[1].ToString();
			DateTime dateTime2 = DateTime.Parse(s2);
			DateTime dateTime3 = DateTime.Parse(s2).AddDays(int.Parse(array[2]));
			if (new Mac_Address().isValidMac(array[0]) > -1 && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				return "True";
			}
			return "False";
		}
		catch (Exception)
		{
			return "Software is not activated yet";
		}
	}

	public string isDateChanged()
	{
		try
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "LogD.txt";
			StreamReader streamReader = new StreamReader(File.OpenRead(path));
			string result = new Encryption().DecryptString(streamReader.ReadLine());
			streamReader.Close();
			return result;
		}
		catch (Exception)
		{
			return "FIRST";
		}
	}
}
