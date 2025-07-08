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

public class r_raw_category : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private MetroTextBox metroTextBox2;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private ErrorProvider errorProvider1;

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
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Expected O, but got Unknown
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected O, but got Unknown
		//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_raw_category));
		metroTextBox1 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		metroTextBox2 = new MetroTextBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox1.CustomButton).Location = new Point(370, 1);
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
		metroTextBox1.PromptText = "Search Category Here . . .";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		metroTextBox1.ShowButton = true;
		((Control)metroTextBox1).Size = new Size(398, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Search Category Here . . .";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
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
		((DataGridView)metroGrid1).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
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
		((Control)metroGrid1).Location = new Point(23, 98);
		((Control)metroGrid1).Name = "metroGrid1";
		((DataGridView)metroGrid1).ReadOnly = true;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = Color.FromArgb(0, 174, 219);
		val3.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val3.ForeColor = Color.FromArgb(255, 255, 255);
		val3.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val3.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).RowHeadersDefaultCellStyle = val3;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(394, 425);
		((Control)metroGrid1).TabIndex = 1;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Category";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 320;
		metroTextBox2.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox2.CustomButton).Location = new Point(370, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(23, 529);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Category Here . .";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(398, 29);
		((Control)metroTextBox2).TabIndex = 2;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Category Here . .";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(20, 572);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(91, 34);
		((Control)button1).TabIndex = 3;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((Control)button2).Location = new Point(117, 572);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(100, 34);
		((Control)button2).TabIndex = 4;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((Control)button3).Location = new Point(223, 572);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(97, 34);
		((Control)button3).TabIndex = 5;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.FromArgb(0, 0, 219);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((Control)button4).Location = new Point(327, 572);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(91, 34);
		((Control)button4).TabIndex = 6;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(458, 620);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "r_raw_category";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Raw Category";
		((Form)this).FormClosed += new FormClosedEventHandler(r_raw_category_FormClosed);
		((Form)this).Load += r_raw_category_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_raw_category()
	{
		InitializeComponent();
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindgrid();
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
				((DbCommand)(object)val2).CommandText = "select * from raw_category where category like '" + ((Control)metroTextBox1).Text + "%'";
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

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void SaveFunction()
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between I4 and Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between I4 and Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("15", "Insert"))
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
							((DbCommand)(object)val2).CommandText = "insert into raw_category(category) values('" + ((Control)metroTextBox2).Text + "')";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetAll();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Category Added successfull", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Category Name Already taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the filds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void ResetAll()
	{
		gid = "";
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		((Control)metroTextBox2).Text = "";
	}

	private void button4_Click(object sender, EventArgs e)
	{
		ResetAll();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter Category");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void UpdateMethod()
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between I4 and Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Invalid comparison between I4 and Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Invalid comparison between I4 and Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("15", "Update"))
		{
			if (gid != "")
			{
				if (((ContainerControl)this).ValidateChildren())
				{
					SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val2 = new SqlCommand();
						try
						{
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							((DbCommand)(object)val2).CommandText = "update raw_category set category='" + ((Control)metroTextBox2).Text + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetAll();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Category Updated successfull", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the filds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Category from table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between I4 and Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between I4 and Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between I4 and Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("15", "Delete"))
		{
			if (gid != "")
			{
				if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to remove", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32))
				{
					if (((ContainerControl)this).ValidateChildren())
					{
						SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val2 = new SqlCommand();
							try
							{
								val2.Connection = val;
								((DbConnection)(object)val).Open();
								((DbCommand)(object)val2).CommandText = "delete from raw_category where id='" + gid + "'";
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetAll();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Category Updated successfull", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the filds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				else
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Category from table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void r_raw_category_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void r_raw_category_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
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
				ResetAll();
				return true;
			case 2:
				break;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		DeleteMethod();
		return true;
	}
}
