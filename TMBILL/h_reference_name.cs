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

public class h_reference_name : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroTextBox metroTextBox1;

	private MetroComboBox metroComboBox1;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private MetroGrid metroGrid1;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Expected O, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected O, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected O, but got Unknown
		//IL_0fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		groupBox1 = new GroupBox();
		metroTextBox3 = new MetroTextBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroComboBox1 = new MetroComboBox();
		metroTextBox1 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		metroTextBox2 = new MetroTextBox();
		errorProvider1 = new ErrorProvider(components);
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)button4);
		((Control)groupBox1).Controls.Add((Control)(object)button3);
		((Control)groupBox1).Controls.Add((Control)(object)button2);
		((Control)groupBox1).Controls.Add((Control)(object)button1);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Location = new Point(34, 65);
		((Control)groupBox1).Margin = new Padding(4);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Padding = new Padding(4);
		((Control)groupBox1).Size = new Size(329, 446);
		((Control)groupBox1).TabIndex = 1;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Details";
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(252, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(22, 109);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Mobile No";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(280, 29);
		((Control)metroTextBox3).TabIndex = 2;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Mobile No";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button4).Location = new Point(37, 365);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(243, 56);
		((Control)button4).TabIndex = 6;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = true;
		((Control)button4).Click += button4_Click;
		((Control)button3).Location = new Point(37, 303);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(243, 56);
		((Control)button3).TabIndex = 5;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		((Control)button2).Location = new Point(37, 241);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(243, 56);
		((Control)button2).TabIndex = 4;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((Control)button1).Location = new Point(37, 179);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(243, 56);
		((Control)button1).TabIndex = 3;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(22, 39);
		((Control)metroComboBox1).Name = "metroComboBox1";
		((Control)metroComboBox1).Size = new Size(280, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(252, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(22, 74);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Referal Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(280, 29);
		((Control)metroTextBox1).TabIndex = 1;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Referal Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4
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
		((Control)metroGrid1).Location = new Point(377, 104);
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
		((Control)metroGrid1).Size = new Size(565, 407);
		((Control)metroGrid1).TabIndex = 3;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Refered By";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 170;
		((DataGridViewColumn)Column3).HeaderText = "Name";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 200;
		((DataGridViewColumn)Column4).HeaderText = "Mobile No";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 120;
		metroTextBox2.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox2.CustomButton).Location = new Point(385, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(377, 65);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Search Referal Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		metroTextBox2.ShowButton = true;
		metroTextBox2.ShowClearButton = true;
		((Control)metroTextBox2).Size = new Size(413, 29);
		((Control)metroTextBox2).TabIndex = 0;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Search Referal Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).TextChanged += metroTextBox2_TextChanged;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(9f, 18f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(960, 528);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Form)this).Margin = new Padding(4);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "h_reference_name";
		((MetroForm)this).Padding = new Padding(30, 83, 30, 28);
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Gust Reference Name";
		((Form)this).FormClosed += new FormClosedEventHandler(h_reference_name_FormClosed);
		((Form)this).Load += h_reference_name_Load;
		((Control)groupBox1).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public h_reference_name()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindcombo();
		ResetMethod();
	}

	private void bindcombo()
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
				((DbCommand)(object)val2).CommandText = "select * from h_refered_bu";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox1).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void ResetMethod()
	{
		((ListControl)metroComboBox1).SelectedIndex = -1;
		((Control)metroTextBox1).Text = "";
		((Control)metroTextBox3).Text = "";
		gid = "";
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
				((DbCommand)(object)val2).CommandText = "select * from h_referal_details where name like '" + ((Control)metroTextBox1).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[4]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString()
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

	private void h_reference_name_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "fill field");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "fill field");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroTextBox2_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void SaveFunction()
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between I4 and Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Invalid comparison between I4 and Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between I4 and Unknown
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
						((DbCommand)(object)val2).CommandText = "insert into h_referal_details(referedby,name,mobileno) values('" + ((Control)metroComboBox1).Text + "','" + ((Control)metroTextBox1).Text + "','" + ((Control)metroTextBox3).Text + "')";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetMethod();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Referal Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Name Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void DeleteMethod()
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Invalid comparison between I4 and Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between I4 and Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between I4 and Unknown
		if (gid != "")
		{
			if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete record", "Confirm?", (MessageBoxButtons)4, (MessageBoxIcon)32))
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "delete from h_referal_details where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetMethod();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Referal information deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
			((Control)this).Focus();
			((Form)this).Activate();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void updateFunction()
	{
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between I4 and Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Invalid comparison between I4 and Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between I4 and Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between I4 and Unknown
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
							((DbCommand)(object)val2).CommandText = "update h_referal_details set referedby='" + ((Control)metroComboBox1).Text + "',name='" + ((Control)metroTextBox1).Text + "',mobileno='" + ((Control)metroTextBox3).Text + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Referal Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)this).Focus();
								((Form)this).Activate();
							}
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Referal Name Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				ResetMethod();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
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
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131140)
		{
			switch (keyData - 131154)
			{
			default:
				if ((int)keyData != 262232)
				{
					break;
				}
				((Control)metroComboBox1).Text = "-";
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
				((Form)this).Close();
				return true;
			case 1:
				SaveFunction();
				return true;
			case 3:
				updateFunction();
				return true;
			case 0:
				ResetMethod();
				return true;
			case 2:
				break;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		DeleteMethod();
		return true;
	}

	private void h_reference_name_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		DeleteMethod();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		ResetMethod();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
	}
}
