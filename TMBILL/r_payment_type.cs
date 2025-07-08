using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class r_payment_type : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox6;

	private MetroGrid metroGrid1;

	private MetroTextBox metroTextBox5;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private ErrorProvider errorProvider1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private string gid = "";

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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected O, but got Unknown
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected O, but got Unknown
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_payment_type));
		metroTextBox6 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		metroTextBox5 = new MetroTextBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox6.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox6.CustomButton).Location = new Point(249, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(23, 66);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Search";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		metroTextBox6.ShowButton = true;
		metroTextBox6.ShowClearButton = true;
		((Control)metroTextBox6).Size = new Size(277, 29);
		((Control)metroTextBox6).TabIndex = 11;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Search";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox6).TextChanged += metroTextBox6_TextChanged;
		((DataGridView)metroGrid1).AllowUserToAddRows = false;
		((DataGridView)metroGrid1).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid1).AllowUserToResizeRows = false;
		((DataGridView)metroGrid1).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = Color.FromArgb(0, 174, 219);
		val.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = Color.FromArgb(255, 255, 255);
		val.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)metroGrid1).ColumnHeadersHeight = 30;
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2
		});
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.BackColor = Color.FromArgb(255, 255, 255);
		val2.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = Color.FromArgb(136, 136, 136);
		val2.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val2.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid1).DefaultCellStyle = val2;
		((DataGridView)metroGrid1).EnableHeadersVisualStyles = false;
		((Control)metroGrid1).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid1).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid1).Location = new Point(23, 101);
		((Control)metroGrid1).Name = "metroGrid1";
		((DataGridView)metroGrid1).ReadOnly = true;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = Color.FromArgb(0, 174, 219);
		val3.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = Color.FromArgb(255, 255, 255);
		val3.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val3.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).RowHeadersDefaultCellStyle = val3;
		((DataGridView)metroGrid1).RowHeadersVisible = false;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(277, 297);
		((Control)metroGrid1).TabIndex = 15;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridView)metroGrid1).CellContentClick += new DataGridViewCellEventHandler(metroGrid1_CellContentClick);
		((DataGridViewColumn)Column1).HeaderText = "Id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Width = 50;
		((DataGridViewColumn)Column2).HeaderText = "Payment Type";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 223;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(249, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(23, 404);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter Payment Type";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(277, 29);
		((Control)metroTextBox5).TabIndex = 16;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter Payment Type";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox5).Validating += metroTextBox5_Validating;
		((Control)metroTextBox5).Validated += metroTextBox5_Validated;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(23, 439);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(128, 42);
		((Control)button1).TabIndex = 17;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((Control)button2).Location = new Point(172, 439);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(128, 42);
		((Control)button2).TabIndex = 18;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((Control)button3).Location = new Point(23, 487);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(128, 42);
		((Control)button3).TabIndex = 19;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((Control)button4).Location = new Point(172, 487);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(128, 42);
		((Control)button4).TabIndex = 20;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(326, 560);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox5);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)metroTextBox6);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_payment_type";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Payment Type";
		((Form)this).FormClosed += new FormClosedEventHandler(r_payment_type_FormClosed);
		((Form)this).Load += r_order_type_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_payment_type()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindgrid();
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
	}

	private void bindgrid()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((DataGridView)metroGrid1).Rows.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_payment_tye where payment_type like '" + ((Control)metroTextBox6).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[2]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString()
						});
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

	private void SaveFunction()
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between I4 and Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between I4 and Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("8", "Insert"))
		{
			if (((ContainerControl)this).ValidateChildren())
			{
				try
				{
					SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val2 = new SqlCommand();
						try
						{
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							string commandText = "insert into r_payment_tye(payment_type) values('" + ((Control)metroTextBox5).Text + "')";
							((DbCommand)(object)val2).CommandText = commandText;
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetFunction();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Payment Type Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				catch (Exception)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Type already Added", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all and correct Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perfrom this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void ResetFunction()
	{
		((Control)metroTextBox5).Text = "";
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		gid = "";
	}

	private void UpdateMethod()
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between I4 and Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Invalid comparison between I4 and Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Invalid comparison between I4 and Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Invalid comparison between I4 and Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("8", "Update"))
		{
			if (gid != "")
			{
				if (((ContainerControl)this).ValidateChildren())
				{
					try
					{
						SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val2 = new SqlCommand();
							try
							{
								val2.Connection = val;
								((DbConnection)(object)val).Open();
								string commandText = "update r_payment_tye set payment_type='" + ((Control)metroTextBox5).Text + "' where id='" + gid + "'";
								((DbCommand)(object)val2).CommandText = commandText;
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetFunction();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					catch (Exception)
					{
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Name already Taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
					}
				}
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all and correct Fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Name From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perfrom this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		DeleteMethod();
	}

	private void DeleteMethod()
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between I4 and Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Invalid comparison between I4 and Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between I4 and Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between I4 and Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("8", "Delete"))
		{
			if (gid != "")
			{
				if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete Information?", "Done", (MessageBoxButtons)4, (MessageBoxIcon)32))
				{
					try
					{
						SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val2 = new SqlCommand();
							try
							{
								val2.Connection = val;
								((DbConnection)(object)val).Open();
								string commandText = "delete from r_payment_tye where id='" + gid + "'";
								((DbCommand)(object)val2).CommandText = commandText;
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetFunction();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					catch (Exception)
					{
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Something Went Wrong", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
					}
				}
				((Control)this).Focus();
				((Form)this).Activate();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Name From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perfrom this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void r_order_type_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroTextBox5_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox5).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox5, "Enter Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox5_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox5, "");
	}

	private void metroTextBox6_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		ResetFunction();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox5).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131140)
		{
			switch (keyData - 131154)
			{
			default:
				if ((int)keyData != 262232)
				{
					break;
				}
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
				((Form)this).Close();
				return true;
			case 1:
				if (gid == "")
				{
					SaveFunction();
				}
				return true;
			case 3:
				UpdateMethod();
				return true;
			case 0:
				ResetFunction();
				return true;
			case 2:
				break;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		DeleteMethod();
		return true;
	}

	private void r_payment_type_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}
}
