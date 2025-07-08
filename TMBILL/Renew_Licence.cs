#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class Renew_Licence : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

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
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Renew_Licence));
		metroTextBox1 = new MetroTextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(312, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Icon = (Image)(object)Resources.at;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(23, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Registered Email Id";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(340, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Registered Email Id";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button1).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).Location = new Point(23, 98);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(340, 45);
		((Control)button1).TabIndex = 1;
		((Control)button1).Text = "Activate";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(386, 162);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Renew_Licence";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Renew Licence";
		((Form)this).FormClosed += new FormClosedEventHandler(Renew_Licence_FormClosed);
		((Form)this).Load += Renew_Licence_Load;
		((Form)this).Shown += Renew_Licence_Shown;
		((Control)this).ResumeLayout(false);
	}

	public Renew_Licence()
	{
		InitializeComponent();
	}

	public void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	private void Renew_Licence_Load(object sender, EventArgs e)
	{
	}

	public DateTime GetDateTime()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		Thread thread = new Thread(loading);
		thread.Start();
		try
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
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
				string text = httpWebResponse.Headers["date"];
				Debug.WriteLine(text);
				result = DateTime.ParseExact(text, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
			}
			thread.Abort();
			return result;
		}
		catch (Exception ex)
		{
			MessageBox.Show((IWin32Window)(object)this, ex.Message);
			thread.Abort();
			return new DateTime(1996, 2, 10);
		}
	}

	private void Renew_Licence_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void Renew_Licence_Shown(object sender, EventArgs e)
	{
		CheckDate();
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
			result = "True";
		}
		if (text == "Running")
		{
			result = "True";
		}
		return result;
	}

	public void Service_Running()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between I4 and Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between I4 and Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between I4 and Unknown
		string text = IsServiceRunning();
		if (text == "True")
		{
			if (((ContainerControl)this).ValidateChildren())
			{
				try
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
					using (StreamWriter streamWriter = File.CreateText(path2))
					{
						streamWriter.WriteLine(new Encryption().EncryptString("True"));
						streamWriter.Close();
					}
					Register();
					return;
				}
				catch (Exception ex)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Something Went Wrong " + ex.Message, "Error ", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						Application.Exit();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All Required Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (4 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "ERROR SER:1 RETRY?", "Error", (MessageBoxButtons)5, (MessageBoxIcon)16))
		{
			Service_Running();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Service_Running();
	}

	private void Register()
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between I4 and Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between I4 and Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Invalid comparison between Unknown and I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Invalid comparison between I4 and Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Invalid comparison between Unknown and I4
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		try
		{
			Thread thread = new Thread(loading);
			thread.Start();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.rhinfinity.com/SOFT_FILE/select_licence.php");
			string s = "emailid=" + ((Control)metroTextBox1).Text;
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			if (text != "false")
			{
				string text2 = new Encryption().DecryptString(text);
				Debug.WriteLine(text2);
				string[] array = text2.Split(new char[1] { '-' });
				int num = new Mac_Address().isValidMac(array[0]);
				if (num > -1)
				{
					using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly())
					{
						using IsolatedStorageFileStream stream2 = new IsolatedStorageFileStream("Details.txt", FileMode.Create, isf);
						using StreamWriter streamWriter = new StreamWriter(stream2);
						streamWriter.WriteLine(text);
					}
					if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "Software is Activated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64) == 1)
					{
						Application.Exit();
					}
				}
				else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "EmailId is not registred in our system", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "Try Again", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16) == 1)
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
			thread.Abort();
		}
		catch (WebException ex)
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Check Your Internet Connection\n" + ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		catch (Exception ex2)
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex2.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
	}

	private void CheckDate()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		DateTime dateTime = GetDateTime();
		if (DateTime.Now.ToShortDateString() == dateTime.ToShortDateString())
		{
			((Control)button1).Enabled = true;
			return;
		}
		((Control)button1).Enabled = false;
		if (dateTime.ToShortDateString() == "10/02/1996")
		{
			if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "Check Your Internet Connection and Try Again", "Error", (MessageBoxButtons)5, (MessageBoxIcon)64) == 4)
			{
				CheckDate();
			}
			else
			{
				((Form)this).Close();
			}
		}
		else
		{
			UpdateDate(dateTime);
			((Control)button1).Enabled = true;
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
}
