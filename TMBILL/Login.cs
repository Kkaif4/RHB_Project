using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class Login : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private Button button1;

	private Button button2;

	private Panel panel1;

	private Label label1;

	private PictureBox pictureBox1;

	public Login()
	{
		InitializeComponent();
		((Control)label1).Text = new CalPeriod().getdate();
	}

	public void Loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	public void Loading1()
	{
		Application.Run((Form)(object)new FlashScreen());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Thread thread = new Thread(Loading);
		thread.Start();
		((Control)new Licence()).Show();
		thread.Abort();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between I4 and Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Invalid comparison between I4 and Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Invalid comparison between I4 and Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between I4 and Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between I4 and Unknown
		string text = new CalPeriod().isDateChanged();
		if (text == "True")
		{
			string text2 = "";
			string text3 = "ljl";
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from r_users where username='" + ((Control)metroTextBox1).Text + "'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							text2 = ((DbDataReader)(object)val3)["username"].ToString();
							text3 = ((DbDataReader)(object)val3)["password"].ToString();
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
			if (((Control)metroTextBox1).Text == text2 && ((Control)metroTextBox2).Text == text3)
			{
				string text4 = new CalPeriod().cheack();
				if (text4 == "True")
				{
					Settings.Default.Setting = text2;
					((SettingsBase)Settings.Default).Save();
					((Control)this).Hide();
					MainFrom mainFrom = new MainFrom();
					((Control)mainFrom).Show();
				}
				else if (text4 == "False")
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Licence Is Expired", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Hide();
						Renew_Licence renew_Licence = new Renew_Licence();
						((Control)renew_Licence).Show();
					}
				}
				else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, text4, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Incorrect UserName or Password", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (text == "FIRST")
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "NO USER REGISTRED YET", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You have changed System Date Do you want to update it?", "Error", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			CheckDate();
		}
		else
		{
			Application.Exit();
		}
	}

	public void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	public DateTime GetDateTime()
	{
		Thread thread = new Thread(loading);
		thread.Start();
		try
		{
			DateTime result = DateTime.MinValue;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.rhinfinity.com");
			httpWebRequest.Method = "GET";
			httpWebRequest.Accept = "text/html, application/xhtml+xml, */*";
			httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				string s = httpWebResponse.Headers["date"];
				result = DateTime.ParseExact(s, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
			}
			thread.Abort();
			return result;
		}
		catch (Exception)
		{
			thread.Abort();
			return new DateTime(1996, 2, 10);
		}
	}

	public string IsServiceRunning()
	{
		string result = "";
		string text = new ServiceManage().ServiceStatus();
		if (text == "Stopped")
		{
			new ServiceManage().StartService();
		}
		if (text == "NOTFOUND")
		{
			result = "";
		}
		if (text == "Running")
		{
			result = "True";
		}
		return result;
	}

	private void CheckDate()
	{
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Invalid comparison between I4 and Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Invalid comparison between Unknown and I4
		string text = IsServiceRunning();
		if (text == "True")
		{
			DateTime dateTime = GetDateTime();
			if (DateTime.Now.ToShortDateString() == dateTime.ToShortDateString())
			{
				string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
				using (StreamWriter streamWriter = File.CreateText(path))
				{
					CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);
					cultureInfo.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";
					cultureInfo.DateTimeFormat.LongTimePattern = "hh':'mm tt";
					Thread.CurrentThread.CurrentCulture = cultureInfo;
					Thread.CurrentThread.CurrentUICulture = cultureInfo;
					streamWriter.WriteLine(new Encryption().EncryptString(DateTime.Now.ToShortDateString()));
					streamWriter.Close();
				}
				string path2 = AppDomain.CurrentDomain.BaseDirectory + "LogD.txt";
				using StreamWriter streamWriter = File.CreateText(path2);
				streamWriter.WriteLine(new Encryption().EncryptString("True"));
				streamWriter.Close();
				return;
			}
			if (!(dateTime.ToShortDateString() == "10/02/1996"))
			{
				UpdateDate(dateTime);
				string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
				using (StreamWriter streamWriter = File.CreateText(path))
				{
					CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);
					cultureInfo.DateTimeFormat.ShortDatePattern = "dd'/'MM'/'yyyy";
					cultureInfo.DateTimeFormat.LongTimePattern = "hh':'mm tt";
					Thread.CurrentThread.CurrentCulture = cultureInfo;
					Thread.CurrentThread.CurrentUICulture = cultureInfo;
					streamWriter.WriteLine(new Encryption().EncryptString(DateTime.Now.ToShortDateString()));
					streamWriter.Close();
				}
				string path2 = AppDomain.CurrentDomain.BaseDirectory + "LogD.txt";
				using StreamWriter streamWriter = File.CreateText(path2);
				streamWriter.WriteLine(new Encryption().EncryptString("True"));
				streamWriter.Close();
				return;
			}
			if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "Check Your Internet Connection and Try Again", "Error", (MessageBoxButtons)5, (MessageBoxIcon)64) == 4)
			{
				CheckDate();
			}
			else
			{
				Application.Exit();
			}
		}
		else if (4 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "SERVICE ERROR ", "ERROR", (MessageBoxButtons)5, (MessageBoxIcon)48))
		{
			CheckDate();
		}
		else
		{
			Application.Exit();
		}
	}

	private void UpdateDate(DateTime date)
	{
		int year = date.Year;
		int month = date.Month;
		int day = date.Day;
		int hour = date.Hour;
		int minute = date.Minute;
		Process.Start("CMD", "/C TIME " + hour + ":" + minute);
		Process.Start("CMD", "/C DATE " + day + "/" + month + "/" + year);
	}

	private void Login_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void metroTextBox2_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		((Control)new SQL_SETUP()).Show();
	}

	private void Login_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
		metroTextBox1 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		button1 = new Button();
		button2 = new Button();
		panel1 = new Panel();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = (Image)(object)Resources.avtar;
		((Control)metroTextBox1.CustomButton).Location = new Point(295, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(33, 33);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		metroTextBox1.FontSize = (MetroTextBoxSize)2;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(26, 67);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "User Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		metroTextBox1.ShowButton = true;
		((Control)metroTextBox1).Size = new Size(329, 35);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "User Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 14.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox2.CustomButton.Image = (Image)(object)Resources.pass;
		((Control)metroTextBox2.CustomButton).Location = new Point(295, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(33, 33);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		metroTextBox2.FontSize = (MetroTextBoxSize)2;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(26, 108);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '●';
		metroTextBox2.PromptText = "Password";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		metroTextBox2.ShowButton = true;
		((Control)metroTextBox2).Size = new Size(329, 35);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.UseSystemPasswordChar = true;
		metroTextBox2.WaterMark = "Password";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 14.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Click += metroTextBox2_Click;
		((Control)button1).BackColor = Color.White;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.FromArgb(255, 128, 0);
		((Control)button1).Location = new Point(26, 154);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(113, 38);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "Login";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.Green;
		((Control)button2).Location = new Point(242, 154);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(113, 38);
		((Control)button2).TabIndex = 3;
		((Control)button2).Text = "Register";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((Control)panel1).BackColor = Color.FromArgb(0, 174, 219);
		((Control)panel1).Location = new Point(0, 229);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(381, 6);
		((Control)panel1).TabIndex = 4;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = Color.FromArgb(0, 174, 219);
		((Control)label1).Location = new Point(23, 198);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(268, 24);
		((Control)label1).TabIndex = 5;
		((Control)label1).Text = "Licence Exipre On: 12/10/1996";
		pictureBox1.Image = (Image)(object)Resources.icon;
		((Control)pictureBox1).Location = new Point(325, 27);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(30, 30);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 6;
		pictureBox1.TabStop = false;
		((Control)pictureBox1).Click += pictureBox1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(381, 235);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Login";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Login";
		((Form)this).FormClosed += new FormClosedEventHandler(Login_FormClosed);
		((Form)this).Load += Login_Load;
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
