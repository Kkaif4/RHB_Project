#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class Licence : MetroForm
{
	public struct SystemDate
	{
		public ushort Year;

		public ushort Month;

		public ushort DayOfWeek;

		public ushort Day;

		public ushort Hour;

		public ushort Minute;

		public ushort Second;

		public ushort Millisecond;
	}

	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox4;

	private Button button1;

	private MetroTextBox metroTextBox5;

	private ErrorProvider errorProvider1;

	public Licence()
	{
		InitializeComponent();
		((Control)button1).Enabled = false;
		string path = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
		if (!File.Exists(path))
		{
			try
			{
				new ServiceManage().StartService();
			}
			catch (Exception)
			{
			}
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
			result = "Stopped";
		}
		if (text == "NOTFOUND")
		{
			result = "NOTFOUND";
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
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "SERVICE ERROR? Visit www.rhinfinity.com for solution", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Service_Running();
	}

	private void Register()
	{
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Invalid comparison between I4 and Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Invalid comparison between I4 and Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Invalid comparison between I4 and Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between Unknown and I4
		try
		{
			Thread thread = new Thread(loading);
			thread.Start();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.rhinfinity.com/SOFT_FILE/Upload.php");
			string text = "hotelname=" + ((Control)metroTextBox1).Text;
			text = text + "&propritername=" + ((Control)metroTextBox2).Text;
			text = text + "&mobileno=" + ((Control)metroTextBox3).Text;
			text = text + "&emailid=" + ((Control)metroTextBox4).Text;
			text = text + "&mac=" + new Mac_Address().Singlemac();
			text = text + "&referedby=" + ((Control)metroTextBox5).Text;
			text = text + "&getmacs=" + new Mac_Address().getmac();
			byte[] bytes = Encoding.ASCII.GetBytes(text);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			if (text2 != "false")
			{
				string text3 = new Encryption().DecryptString(text2);
				Debug.WriteLine(text3);
				string[] array = text3.Split(new char[1] { '-' });
				int num = new Mac_Address().isValidMac(array[0]);
				if (num > -1)
				{
					SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val2 = new SqlCommand();
						try
						{
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							((DbCommand)(object)val2).CommandText = "truncate table shop";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbCommand)(object)val2).Cancel();
							((DbCommand)(object)val2).CommandText = "insert into shop(shop_name,prop_name,contact,email) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox3).Text + "','" + ((Control)metroTextBox4).Text + "')";
							((DbCommand)(object)val2).ExecuteNonQuery();
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
					using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly())
					{
						using IsolatedStorageFileStream stream2 = new IsolatedStorageFileStream("Details.txt", FileMode.Create, isf);
						using StreamWriter streamWriter = new StreamWriter(stream2);
						streamWriter.WriteLine(text2);
					}
					if ((int)MetroMessageBox.Show((IWin32Window)(object)this, "Software is Activated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64) == 1)
					{
						Application.Exit();
					}
				}
				else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Email Id is already Registered on another machine", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void Licence_Load(object sender, EventArgs e)
	{
		((Form)this).Activate();
		((Control)metroTextBox1).Focus();
	}

	[DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
	public static extern bool Win32SetSystemTime(ref SystemDate sysDate);

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

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Hotel Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter Properitor Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox3_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox3).Text == "" || !new RegualarExpress().mobilenofield(((Control)metroTextBox3).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox3, "Enter Valid Mobile No");
			e.Cancel = true;
		}
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "" || !new RegualarExpress().emailfield(((Control)metroTextBox4).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Enter Valid Emailid");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void metroTextBox3_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox3, "");
	}

	private void metroTextBox4_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox4, "");
	}

	private void Licence_Shown(object sender, EventArgs e)
	{
		CheckDate();
	}

	private void Licence_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
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
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Expected O, but got Unknown
		//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected O, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Licence));
		metroTextBox1 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		button1 = new Button();
		metroTextBox5 = new MetroTextBox();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = (Image)(object)Resources.briefcase;
		((Control)metroTextBox1.CustomButton).Location = new Point(387, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(23, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Hotel Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		metroTextBox1.ShowButton = true;
		((Control)metroTextBox1).Size = new Size(415, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Hotel Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox2.CustomButton.Image = (Image)(object)Resources.avtar;
		((Control)metroTextBox2.CustomButton).Location = new Point(387, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(23, 98);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Proprietor Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		metroTextBox2.ShowButton = true;
		((Control)metroTextBox2).Size = new Size(415, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Proprietor Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox3.CustomButton.Image = (Image)(object)Resources.call;
		((Control)metroTextBox3.CustomButton).Location = new Point(387, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(23, 133);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Mobile No";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		metroTextBox3.ShowButton = true;
		((Control)metroTextBox3).Size = new Size(415, 29);
		((Control)metroTextBox3).TabIndex = 2;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Mobile No";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).Validating += metroTextBox3_Validating;
		((Control)metroTextBox3).Validated += metroTextBox3_Validated;
		metroTextBox4.CustomButton.Image = (Image)(object)Resources.at;
		((Control)metroTextBox4.CustomButton).Location = new Point(387, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(23, 168);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Email ID";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		metroTextBox4.ShowButton = true;
		((Control)metroTextBox4).Size = new Size(415, 29);
		((Control)metroTextBox4).TabIndex = 3;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Email ID";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		((Control)button1).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(99, 238);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(256, 48);
		((Control)button1).TabIndex = 5;
		((Control)button1).Text = "REGISTER";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(387, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(23, 203);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Software Refered By";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(415, 29);
		((Control)metroTextBox5).TabIndex = 4;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Software Refered By";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(461, 302);
		((Control)this).Controls.Add((Control)(object)metroTextBox5);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox4);
		((Control)this).Controls.Add((Control)(object)metroTextBox3);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Licence";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Register";
		((Form)this).FormClosed += new FormClosedEventHandler(Licence_FormClosed);
		((Form)this).Load += Licence_Load;
		((Form)this).Shown += Licence_Shown;
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
