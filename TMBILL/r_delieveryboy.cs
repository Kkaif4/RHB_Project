using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using TMBILL.Properties;

namespace TMBILL;

public class r_delieveryboy : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private MetroCheckBox metroCheckBox1;

	private MetroDateTime metroDateTime1;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox5;

	private MetroTextBox metroTextBox4;

	private MetroTextBox metroTextBox1;

	private MetroComboBox metroComboBox1;

	private MetroGrid metroGrid1;

	private MetroTextBox metroTextBox6;

	private Button button5;

	private ErrorProvider errorProvider1;

	private SaveFileDialog saveFileDialog1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected O, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Expected O, but got Unknown
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e7: Expected O, but got Unknown
		//IL_13f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1400: Expected O, but got Unknown
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Expected O, but got Unknown
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ff: Expected O, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected O, but got Unknown
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Expected O, but got Unknown
		//IL_17c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Expected O, but got Unknown
		//IL_17e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ea: Expected O, but got Unknown
		//IL_18fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected O, but got Unknown
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c14: Expected O, but got Unknown
		//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c73: Expected O, but got Unknown
		//IL_1dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected O, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e13: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_delieveryboy));
		groupBox1 = new GroupBox();
		metroComboBox1 = new MetroComboBox();
		metroTextBox4 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		groupBox2 = new GroupBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroCheckBox1 = new MetroCheckBox();
		metroDateTime1 = new MetroDateTime();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox5 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		metroTextBox6 = new MetroTextBox();
		button5 = new Button();
		errorProvider1 = new ErrorProvider(components);
		saveFileDialog1 = new SaveFileDialog();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)groupBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox5);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(12, 80);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(283, 568);
		((Control)groupBox1).TabIndex = 1;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Details";
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((ComboBox)metroComboBox1).Items.AddRange(new object[2] { "Day", "Night" });
		((Control)metroComboBox1).Location = new Point(26, 217);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Shift";
		((Control)metroComboBox1).Size = new Size(235, 29);
		((Control)metroComboBox1).TabIndex = 5;
		((Control)metroComboBox1).Tag = "";
		metroComboBox1.UseSelectable = true;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(210, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(25, 146);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Address";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(238, 29);
		((Control)metroTextBox4).TabIndex = 3;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Address";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(210, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(25, 181);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Salary";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(238, 29);
		((Control)metroTextBox1).TabIndex = 4;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Salary";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Location = new Point(26, 331);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(237, 214);
		((Control)groupBox2).TabIndex = 8;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Action";
		((Control)button4).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.reset;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(36, 166);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(168, 42);
		((Control)button4).TabIndex = 12;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.delete;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(36, 118);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(168, 42);
		((Control)button3).TabIndex = 11;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(36, 70);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(168, 42);
		((Control)button2).TabIndex = 10;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(36, 22);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(168, 42);
		((Control)button1).TabIndex = 9;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(31, 299);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(68, 19);
		((Control)metroCheckBox1).TabIndex = 7;
		((Control)metroCheckBox1).Text = "Active?";
		metroCheckBox1.UseSelectable = true;
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(25, 252);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(238, 29);
		((Control)metroDateTime1).TabIndex = 6;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(210, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(26, 111);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter City";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(238, 29);
		((Control)metroTextBox3).TabIndex = 2;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter City";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).Validating += metroTextBox3_Validating;
		((Control)metroTextBox3).Validated += metroTextBox3_Validated;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(210, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(26, 76);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Mobile No";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(238, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Mobile No";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(210, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(26, 41);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter Name";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(238, 29);
		((Control)metroTextBox5).TabIndex = 0;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter Name";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox5).Validating += metroTextBox5_Validating;
		((Control)metroTextBox5).Validated += metroTextBox5_Validated;
		((DataGridView)metroGrid1).AllowUserToAddRows = false;
		((DataGridView)metroGrid1).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid1).AllowUserToResizeRows = false;
		((Control)metroGrid1).Anchor = (AnchorStyles)15;
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
		((DataGridView)metroGrid1).ColumnHeadersHeight = 40;
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[9]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9
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
		((Control)metroGrid1).Location = new Point(314, 91);
		((Control)metroGrid1).Name = "metroGrid1";
		((DataGridView)metroGrid1).ReadOnly = true;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)32;
		val3.BackColor = Color.FromArgb(0, 174, 219);
		val3.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val3.ForeColor = Color.FromArgb(255, 255, 255);
		val3.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val3.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).RowHeadersDefaultCellStyle = val3;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(712, 559);
		((Control)metroGrid1).TabIndex = 15;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		val4.Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((DataGridViewBand)Column1).DefaultCellStyle = val4;
		((DataGridViewColumn)Column1).HeaderText = "Sr No";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column1).Width = 60;
		((DataGridViewColumn)Column2).HeaderText = "Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Mobile No";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 90;
		((DataGridViewColumn)Column4).HeaderText = "City";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 80;
		val5.Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((DataGridViewBand)Column5).DefaultCellStyle = val5;
		((DataGridViewColumn)Column5).HeaderText = "Address";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column6).HeaderText = "Salary";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column6).Width = 50;
		((DataGridViewColumn)Column7).HeaderText = "Shift";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 80;
		((DataGridViewColumn)Column8).HeaderText = "Date Of Join";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewBand)Column8).ReadOnly = true;
		((DataGridViewColumn)Column9).HeaderText = "Active?";
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewBand)Column9).ReadOnly = true;
		((DataGridViewColumn)Column9).Width = 70;
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(466, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(314, 47);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Search";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(494, 29);
		((Control)metroTextBox6).TabIndex = 13;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Search";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox6).TextChanged += metroTextBox6_TextChanged;
		((Control)button5).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((Control)button5).Location = new Point(845, 43);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(168, 42);
		((Control)button5).TabIndex = 14;
		((Control)button5).Text = "&Export To Excel (E)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((FileDialog)saveFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).FileOk += saveFileDialog1_FileOk;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1059, 673);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)metroTextBox6);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "r_delieveryboy";
		((Control)this).Text = "Delivery Boy";
		((Form)this).FormClosed += new FormClosedEventHandler(r_delieveryboy_FormClosed);
		((Form)this).Load += Form2_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_delieveryboy()
	{
		InitializeComponent();
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindgrid();
	}

	private void SaveFunction()
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between I4 and Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between I4 and Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("6", "Insert"))
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
							string text = (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No");
							string commandText = "insert into r_deliveryboy(name,mobileno,city,address,salary,dateofjoin,shift,status) values('" + ((Control)metroTextBox5).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox3).Text + "','" + ((Control)metroTextBox4).Text + "','" + ((Control)metroTextBox1).Text + "','" + ((Control)metroDateTime1).Text + "','" + ((Control)metroComboBox1).Text + "','" + text + "')";
							((DbCommand)(object)val2).CommandText = commandText;
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetFunction();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Delivery Boy Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perfrom this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
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
				((DbCommand)(object)val2).CommandText = "select * from r_deliveryboy where name like '" + ((Control)metroTextBox6).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[9]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
							((DbDataReader)(object)val3)[5].ToString(),
							((DbDataReader)(object)val3)[7].ToString(),
							((DbDataReader)(object)val3)[6].ToString(),
							((DbDataReader)(object)val3)[8].ToString()
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

	private void Form2_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
	}

	private void metroTextBox5_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox5).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox5, "Enter Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox5).Text == "" || !new RegualarExpress().mobilenofield(((Control)metroTextBox2).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter valid Mobile No");
			e.Cancel = true;
		}
	}

	private void metroTextBox3_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox3).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox3, "Enter City");
			e.Cancel = true;
		}
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Enter Address");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox1).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Valid Salary");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "Select Shift");
			e.Cancel = true;
		}
	}

	private void metroTextBox5_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox5, "");
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

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		ExporttoExcel();
	}

	private void ExporttoExcel()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (((DataGridView)metroGrid1).Rows.Count > 0)
		{
			((CommonDialog)saveFileDialog1).ShowDialog();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Table is empty", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Invalid comparison between I4 and Unknown
		Thread thread = new Thread(loading);
		thread.Start();
		string fileName = ((FileDialog)saveFileDialog1).FileName;
		_Application application = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		_Workbook workbook = application.Workbooks.Add(Type.Missing);
		_Worksheet worksheet = null;
		application.Visible = false;
		worksheet = (dynamic)workbook.Sheets["Sheet1"];
		worksheet = (dynamic)workbook.ActiveSheet;
		worksheet.Name = "Exported Items from Table";
		for (int i = 1; i < ((BaseCollection)((DataGridView)metroGrid1).Columns).Count + 1; i++)
		{
			worksheet.Cells[1, i] = ((DataGridView)metroGrid1).Columns[i - 1].HeaderText;
		}
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			for (int j = 0; j < ((BaseCollection)((DataGridView)metroGrid1).Columns).Count; j++)
			{
				worksheet.Cells[i + 2, j + 1] = ((DataGridView)metroGrid1).Rows[i].Cells[j].Value.ToString();
			}
		}
		workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Missing.Value);
		application.Quit();
		thread.Abort();
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Excel File Created", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		ResetFunction();
	}

	private void ResetFunction()
	{
		gid = "";
		MetroTextBox obj = metroTextBox1;
		MetroTextBox obj2 = metroTextBox2;
		MetroTextBox obj3 = metroTextBox3;
		MetroTextBox obj4 = metroTextBox4;
		string text = (((Control)metroTextBox5).Text = "");
		text = (((Control)obj4).Text = text);
		text = (((Control)obj3).Text = text);
		text = (((Control)obj2).Text = text);
		((Control)obj).Text = text;
		((ListControl)metroComboBox1).SelectedIndex = -1;
		((CheckBox)metroCheckBox1).Checked = false;
		((Control)button1).Enabled = true;
		Button obj5 = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj5).Enabled = enabled;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void metroTextBox6_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void UpdateMethod()
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between I4 and Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Invalid comparison between I4 and Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between I4 and Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Invalid comparison between I4 and Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("6", "Update"))
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
								string text = (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No");
								string commandText = "update r_deliveryboy set name='" + ((Control)metroTextBox5).Text + "',mobileno='" + ((Control)metroTextBox2).Text + "',city='" + ((Control)metroTextBox3).Text + "',address='" + ((Control)metroTextBox4).Text + "',salary='" + ((Control)metroTextBox1).Text + "',dateofjoin='" + ((Control)metroDateTime1).Text + "',shift='" + ((Control)metroComboBox1).Text + "',status='" + text + "' where id='" + gid + "'";
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
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox5).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)metroTextBox4).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[6].Value.ToString();
		((Control)metroDateTime1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[7].Value.ToString();
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[8].Value.ToString();
		if (text == "Yes")
		{
			((CheckBox)metroCheckBox1).Checked = true;
		}
		else
		{
			((CheckBox)metroCheckBox1).Checked = false;
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
		if (new USER_PERMISSION().Permission("6", "Delete"))
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
								string commandText = "delete from r_deliveryboy where id='" + gid + "'";
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

	private void r_delieveryboy_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		switch (keyData - 131140)
		{
		default:
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
		case 0:
			DeleteMethod();
			return true;
		case 1:
			ExporttoExcel();
			return true;
		}
	}
}
