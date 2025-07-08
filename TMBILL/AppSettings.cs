using System.Configuration;

namespace TMBILL;

public class AppSettings
{
	private Configuration config;

	public AppSettings()
	{
		config = ConfigurationManager.OpenExeConfiguration((ConfigurationUserLevel)0);
	}

	public string getConnectionString()
	{
		return config.ConnectionStrings.ConnectionStrings["dbcon"].ConnectionString;
	}

	public void SetConnectionString(string connection)
	{
		config.ConnectionStrings.ConnectionStrings["dbcon"].ConnectionString = connection;
		config.ConnectionStrings.ConnectionStrings["dbcon"].ProviderName = "System.Data.SqlClient";
		config.Save((ConfigurationSaveMode)0);
	}
}
