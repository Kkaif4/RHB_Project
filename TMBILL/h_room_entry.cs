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

public class h_room_entry : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroGrid metroGrid1;

	private MetroTextBox metroTextBox1;

	private MetroComboBox metroComboBox1;

	private MetroTextBox metroTextBox2;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private ErrorProvider errorProvider1;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox4;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Expected O, but got Unknown
		//IL_0b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected O, but got Unknown
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Expected O, but got Unknown
		//IL_1298: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a2: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		groupBox1 = new GroupBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroTextBox2 = new MetroTextBox();
		metroComboBox1 = new MetroComboBox();
		metroTextBox1 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		errorProvider1 = new ErrorProvider(components);
		metroTextBox3 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox1).Controls.Add((Control)(object)button4);
		((Control)groupBox1).Controls.Add((Control)(object)button3);
		((Control)groupBox1).Controls.Add((Control)(object)button2);
		((Control)groupBox1).Controls.Add((Control)(object)button1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(279, 449);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Details";
		((Control)button4).Location = new Point(27, 380);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(225, 52);
		((Control)button4).TabIndex = 7;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = true;
		((Control)button4).Click += button4_Click;
		((Control)button3).Location = new Point(27, 322);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(225, 52);
		((Control)button3).TabIndex = 6;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		((Control)button2).Location = new Point(27, 264);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(225, 52);
		((Control)button2).TabIndex = 5;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((Control)button1).Location = new Point(27, 206);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(225, 52);
		((Control)button1).TabIndex = 4;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(197, 2);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(47, 47);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(15, 104);
		metroTextBox2.MaxLength = 32767;
		metroTextBox2.Multiline = true;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Room Description";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(247, 52);
		((Control)metroTextBox2).TabIndex = 2;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Room Description";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(15, 69);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Room Type";
		((Control)metroComboBox1).Size = new Size(247, 29);
		((Control)metroComboBox1).TabIndex = 1;
		metroComboBox1.UseSelectable = true;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(219, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(15, 34);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Room Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(247, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Room Name";
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5
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
		((Control)metroGrid1).Location = new Point(308, 108);
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
		((Control)metroGrid1).Size = new Size(627, 394);
		((Control)metroGrid1).TabIndex = 1;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		metroTextBox3.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox3.CustomButton).Location = new Point(492, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(308, 73);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Room Name";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		metroTextBox3.ShowButton = true;
		metroTextBox3.ShowClearButton = true;
		((Control)metroTextBox3).Size = new Size(520, 29);
		((Control)metroTextBox3).TabIndex = 7;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Room Name";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).TextChanged += metroTextBox3_TextChanged;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(219, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(15, 162);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Room Charges";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(247, 29);
		((Control)metroTextBox4).TabIndex = 3;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Room Charges";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Room Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 120;
		((DataGridViewColumn)Column3).HeaderText = "Room Type";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 130;
		((DataGridViewColumn)Column4).HeaderText = "Description";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 230;
		((DataGridViewColumn)Column5).HeaderText = "Charges";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(958, 525);
		((Control)this).Controls.Add((Control)(object)metroTextBox3);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "h_room_entry";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Room Entry";
		((Form)this).FormClosed += new FormClosedEventHandler(h_room_entry_FormClosed);
		((Control)groupBox1).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public h_room_entry()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindcombo();
		ResetFunction();
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
				((DbCommand)(object)val2).CommandText = "select * from h_room_type";
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

	public void ResetFunction()
	{
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		MetroTextBox obj2 = metroTextBox1;
		string text = (((Control)metroTextBox2).Text = "");
		((Control)obj2).Text = text;
		((Control)metroTextBox4).Text = "";
		((ListControl)metroComboBox1).SelectedIndex = -1;
		gid = "";
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
				((DbCommand)(object)val2).CommandText = "select * from room where roomname like '" + ((Control)metroTextBox3).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[5]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[5].ToString()
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

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "field is mandatory");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "Select Your Room type");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void metroTextBox3_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void SaveFunction()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between I4 and Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between I4 and Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between I4 and Unknown
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
						((DbCommand)(object)val2).CommandText = "insert into room(roomname,roomtype,description,charges) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroComboBox1).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox4).Text + "')";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetFunction();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Name Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
						((DbCommand)(object)val2).CommandText = "delete from room where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetFunction();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room information deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between I4 and Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between I4 and Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Invalid comparison between I4 and Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Invalid comparison between I4 and Unknown
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
							((DbCommand)(object)val2).CommandText = "update room set roomname='" + ((Control)metroTextBox1).Text + "',roomtype='" + ((Control)metroComboBox1).Text + "',description='" + ((Control)metroTextBox2).Text + "',charges='" + ((Control)metroTextBox4).Text + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Name Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				ResetFunction();
				((Control)metroTextBox2).Text = "";
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
		ResetFunction();
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
				((Control)metroTextBox1).Text = "-";
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

	private void h_room_entry_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)metroTextBox4).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox4).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Enter Valid AMount");
			e.Cancel = true;
		}
	}

	private void metroTextBox4_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox4, "");
	}
}
