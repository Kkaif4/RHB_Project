#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;

namespace TMBILL;

public class SQL_SETUP : MetroForm
{
	private IContainer components = null;

	private MetroComboBox metroComboBox1;

	private Button button1;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((MetroForm)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SQL_SETUP));
		metroComboBox1 = new MetroComboBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(20, 57);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Your Server";
		((Control)metroComboBox1).Size = new Size(277, 29);
		((Control)metroComboBox1).TabIndex = 1;
		metroComboBox1.UseSelectable = true;
		((Control)button1).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(20, 92);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(277, 39);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "Connect";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(9f, 18f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(310, 146);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroComboBox1);
		((Control)this).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).Margin = new Padding(4);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "SQL_SETUP";
		((MetroForm)this).Padding = new Padding(30, 83, 30, 28);
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Setup Your Server";
		((Form)this).FormClosed += new FormClosedEventHandler(SQL_SETUP_FormClosed);
		((Form)this).Load += SQL_SETUP_Load;
		((Control)this).ResumeLayout(false);
	}

	public SQL_SETUP()
	{
		InitializeComponent();
	}

	private void SQL_SETUP_Load(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		((Control)this).Focus();
		((Form)this).Activate();
		if (new SQLHelper().IsServerInstalled())
		{
			ListInstances();
		}
		else if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "SQL SERVER IS NOT INSTALLED CONTACT TO DEVELOPER", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16) == 1)
		{
			Application.Exit();
		}
	}

	public void ListInstances()
	{
		RegistryView view = (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);
		RegistryKey registryKey2 = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL", writable: false);
		if (registryKey2 != null)
		{
			string[] valueNames = registryKey2.GetValueNames();
			foreach (string text in valueNames)
			{
				((ComboBox)metroComboBox1).Items.Add((object)text);
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Invalid comparison between I4 and Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between I4 and Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between I4 and Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between I4 and Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Invalid comparison between I4 and Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Invalid comparison between I4 and Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between I4 and Unknown
		if (((Control)metroComboBox1).Text != "")
		{
			string text = new SQLHelper().ServerRunning(((Control)metroComboBox1).Text);
			Debug.WriteLine("New Status : " + text);
			switch (text)
			{
			case "NOTFOUND":
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "SQL SERVER IS NOT INSTALLED CONTACT TO DEVELOPER", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				break;
			case "Running":
			{
				string text2 = "";
				string text3 = "Data Source=.\\" + ((Control)metroComboBox1).Text + ";AttachDbFilename=D:\\projects\\SHAHRUKH\\TMBILL\\TMBILL\\TMBILL\\DBASE.mdf;Integrated Security=True;User Instance=True";
				try
				{
					SQLHelper sQLHelper = new SQLHelper(text3);
					if (sQLHelper.IsConnection)
					{
						text2 = text3;
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Connection Successed", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							Application.Exit();
						}
					}
				}
				catch (Exception)
				{
					try
					{
						string text4 = "Data Source=.\\" + ((Control)metroComboBox1).Text + ";AttachDbFilename=D:\\projects\\SHAHRUKH\\TMBILL\\TMBILL\\TMBILL\\DBASE.mdf;Integrated Security=True;User Instance=False";
						SQLHelper sQLHelper2 = new SQLHelper(text4);
						if (sQLHelper2.IsConnection)
						{
							text2 = text4;
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Connection Successed", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								Application.Exit();
							}
						}
					}
					catch (Exception ex2)
					{
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Contact to developer " + ex2.Message, "Done", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							Application.Exit();
						}
					}
				}
				if (text2 != "")
				{
					new AppSettings().SetConnectionString(text2);
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Database Configured Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						Application.Exit();
					}
				}
				else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Error in Configuring Database", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					Application.Exit();
				}
				break;
			}
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Your Server", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void SQL_SETUP_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}
}
