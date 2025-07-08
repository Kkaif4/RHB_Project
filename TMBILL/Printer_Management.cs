using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class Printer_Management : MetroForm
{
	public static class myPrinters
	{
		[DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetDefaultPrinter(string Name);
	}

	private IContainer components = null;

	private MetroComboBox metroComboBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private MetroComboBox metroComboBox2;

	private MetroComboBox metroComboBox3;

	private MetroTextBox metroTextBox1;

	private Button button1;

	private Button button2;

	private MetroTextBox metroTextBox2;

	private Button button3;

	private MetroTextBox metroTextBox3;

	public Printer_Management()
	{
		InitializeComponent();
		InititalizePrinters();
		BindKOTPRINTER();
		BindBILLPRINTER();
		BindOTHERPRINTER();
	}

	private void BindKOTPRINTER()
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
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='KOT'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroComboBox1).Text = ((DbDataReader)(object)val3)["printername"].ToString();
						((Control)metroTextBox1).Text = ((DbDataReader)(object)val3)[3].ToString();
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
	}

	private void BindOTHERPRINTER()
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
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='OTHER'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroComboBox3).Text = ((DbDataReader)(object)val3)["printername"].ToString();
						((Control)metroTextBox3).Text = ((DbDataReader)(object)val3)[3].ToString();
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
	}

	private void BindBILLPRINTER()
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
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='BILL'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroComboBox2).Text = ((DbDataReader)(object)val3)["printername"].ToString();
						((Control)metroTextBox2).Text = ((DbDataReader)(object)val3)[3].ToString();
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
	}

	private void InititalizePrinters()
	{
		foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
		{
			((ComboBox)metroComboBox1).Items.Add((object)installedPrinter.ToString());
			((ComboBox)metroComboBox2).Items.Add((object)installedPrinter.ToString());
			((ComboBox)metroComboBox3).Items.Add((object)installedPrinter.ToString());
		}
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Invalid comparison between I4 and Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between I4 and Unknown
		if (((Control)metroTextBox1).Text != "" && new RegualarExpress().doublevalue(((Control)metroTextBox1).Text))
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='KOT'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val5 = new SqlCommand();
								try
								{
									val5.Connection = val4;
									((DbConnection)(object)val4).Open();
									((DbCommand)(object)val5).CommandText = "update printer_management set printername='" + ((Control)metroComboBox1).Text + "',copies='" + ((Control)metroTextBox1).Text + "' where onprint='KOT'";
									((DbCommand)(object)val5).ExecuteNonQuery();
									((DbConnection)(object)val4).Close();
								}
								finally
								{
									((IDisposable)val5)?.Dispose();
								}
							}
							finally
							{
								((IDisposable)val4)?.Dispose();
							}
						}
					}
					else
					{
						SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val5 = new SqlCommand();
							try
							{
								val5.Connection = val4;
								((DbConnection)(object)val4).Open();
								((DbCommand)(object)val5).CommandText = "insert into printer_management(onprint,printername,copies) values('KOT','" + ((Control)metroComboBox1).Text + "','" + ((Control)metroTextBox1).Text + "')";
								((DbCommand)(object)val5).ExecuteNonQuery();
								((DbConnection)(object)val4).Close();
							}
							finally
							{
								((IDisposable)val5)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					((DbConnection)(object)val).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
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
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Copies Should be Number", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Invalid comparison between I4 and Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between I4 and Unknown
		if (((Control)metroTextBox2).Text != "" && new RegualarExpress().doublevalue(((Control)metroTextBox2).Text))
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='BILL'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val5 = new SqlCommand();
								try
								{
									val5.Connection = val4;
									((DbConnection)(object)val4).Open();
									((DbCommand)(object)val5).CommandText = "update printer_management set printername='" + ((Control)metroComboBox2).Text + "',copies='" + ((Control)metroTextBox2).Text + "' where onprint='BILL'";
									((DbCommand)(object)val5).ExecuteNonQuery();
									((DbConnection)(object)val4).Close();
								}
								finally
								{
									((IDisposable)val5)?.Dispose();
								}
							}
							finally
							{
								((IDisposable)val4)?.Dispose();
							}
						}
					}
					else
					{
						SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val5 = new SqlCommand();
							try
							{
								val5.Connection = val4;
								((DbConnection)(object)val4).Open();
								((DbCommand)(object)val5).CommandText = "insert into printer_management(onprint,printername,copies) values('BILL','" + ((Control)metroComboBox2).Text + "','" + ((Control)metroTextBox2).Text + "')";
								((DbCommand)(object)val5).ExecuteNonQuery();
								((DbConnection)(object)val4).Close();
							}
							finally
							{
								((IDisposable)val5)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					((DbConnection)(object)val).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
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
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Copies Should be Number", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Invalid comparison between I4 and Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between I4 and Unknown
		if (((Control)metroTextBox3).Text != "" && new RegualarExpress().doublevalue(((Control)metroTextBox3).Text))
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='OTHER'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val5 = new SqlCommand();
								try
								{
									val5.Connection = val4;
									((DbConnection)(object)val4).Open();
									((DbCommand)(object)val5).CommandText = "update printer_management set printername='" + ((Control)metroComboBox3).Text + "',copies='" + ((Control)metroTextBox3).Text + "' where onprint='OTHER'";
									((DbCommand)(object)val5).ExecuteNonQuery();
									((DbConnection)(object)val4).Close();
								}
								finally
								{
									((IDisposable)val5)?.Dispose();
								}
							}
							finally
							{
								((IDisposable)val4)?.Dispose();
							}
						}
					}
					else
					{
						SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val5 = new SqlCommand();
							try
							{
								val5.Connection = val4;
								((DbConnection)(object)val4).Open();
								((DbCommand)(object)val5).CommandText = "insert into printer_management(onprint,printername,copies) values('OTHER','" + ((Control)metroComboBox3).Text + "','" + ((Control)metroTextBox3).Text + "')";
								((DbCommand)(object)val5).ExecuteNonQuery();
								((DbConnection)(object)val4).Close();
							}
							finally
							{
								((IDisposable)val5)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					((DbConnection)(object)val).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
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
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Copies Should be Number", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected O, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected O, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Printer_Management));
		metroComboBox1 = new MetroComboBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		metroComboBox2 = new MetroComboBox();
		metroComboBox3 = new MetroComboBox();
		metroTextBox1 = new MetroTextBox();
		button1 = new Button();
		button2 = new Button();
		metroTextBox2 = new MetroTextBox();
		button3 = new Button();
		metroTextBox3 = new MetroTextBox();
		((Control)this).SuspendLayout();
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(147, 63);
		((Control)metroComboBox1).Name = "metroComboBox1";
		((Control)metroComboBox1).Size = new Size(261, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(32, 63);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(86, 18);
		((Control)label1).TabIndex = 1;
		((Control)label1).Text = "KOT Printer";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(32, 107);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(74, 18);
		((Control)label2).TabIndex = 2;
		((Control)label2).Text = "Bill Printer";
		((Control)label3).AutoSize = true;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label3).Location = new Point(32, 153);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(100, 18);
		((Control)label3).TabIndex = 3;
		((Control)label3).Text = "Report Printer";
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(147, 108);
		((Control)metroComboBox2).Name = "metroComboBox2";
		((Control)metroComboBox2).Size = new Size(261, 29);
		((Control)metroComboBox2).TabIndex = 4;
		metroComboBox2.UseSelectable = true;
		((ComboBox)metroComboBox2).SelectedIndexChanged += metroComboBox2_SelectedIndexChanged;
		((ListControl)metroComboBox3).FormattingEnabled = true;
		((ComboBox)metroComboBox3).ItemHeight = 23;
		((Control)metroComboBox3).Location = new Point(147, 153);
		((Control)metroComboBox3).Name = "metroComboBox3";
		((Control)metroComboBox3).Size = new Size(261, 29);
		((Control)metroComboBox3).TabIndex = 5;
		metroComboBox3.UseSelectable = true;
		((ComboBox)metroComboBox3).SelectedIndexChanged += metroComboBox3_SelectedIndexChanged;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(47, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[1] { "1" };
		((Control)metroTextBox1).Location = new Point(423, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Copies";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(75, 29);
		((Control)metroTextBox1).TabIndex = 6;
		((Control)metroTextBox1).Text = "1";
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Copies";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button1).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(515, 63);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(75, 29);
		((Control)button1).TabIndex = 7;
		((Control)button1).Text = "Set";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button2).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((Control)button2).Location = new Point(515, 108);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(75, 29);
		((Control)button2).TabIndex = 9;
		((Control)button2).Text = "Set";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(47, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[1] { "1" };
		((Control)metroTextBox2).Location = new Point(423, 108);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Copies";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(75, 29);
		((Control)metroTextBox2).TabIndex = 8;
		((Control)metroTextBox2).Text = "1";
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Copies";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button3).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((Control)button3).Location = new Point(515, 153);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(75, 29);
		((Control)button3).TabIndex = 11;
		((Control)button3).Text = "Set";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(47, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[1] { "1" };
		((Control)metroTextBox3).Location = new Point(423, 153);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Copies";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(75, 29);
		((Control)metroTextBox3).TabIndex = 10;
		((Control)metroTextBox3).Text = "1";
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Copies";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(613, 212);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)metroTextBox3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Control)this).Controls.Add((Control)(object)metroComboBox3);
		((Control)this).Controls.Add((Control)(object)metroComboBox2);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)metroComboBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Printer_Management";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Printer Management";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
