using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TMBILL.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DBASE.mdf;Integrated Security=True;User Instance=True")]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string DBASEConnectionString => (string)((SettingsBase)this)["DBASEConnectionString"];

	[DebuggerNonUserCode]
	[DefaultSettingValue("NO")]
	[UserScopedSetting]
	public string Setting
	{
		get
		{
			return (string)((SettingsBase)this)["Setting"];
		}
		set
		{
			((SettingsBase)this)["Setting"] = value;
		}
	}
}
