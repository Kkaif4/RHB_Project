#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using TMBILL.Properties;

namespace TMBILL;

public class r_product_item : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private MetroComboBox metroComboBox1;

	private MetroComboBox metroComboBox2;

	private MetroTextBox metroTextBox3;

	private MetroCheckBox metroCheckBox1;

	private GroupBox groupBox2;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private MetroTextBox metroTextBox4;

	private Button button5;

	private Button button6;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private OpenFileDialog openFileDialog1;

	private SaveFileDialog saveFileDialog1;

	private ErrorProvider errorProvider1;

	public static r_product_item r_s_product_item;

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
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected O, but got Unknown
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected O, but got Unknown
		//IL_1178: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Expected O, but got Unknown
		//IL_11cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d6: Expected O, but got Unknown
		//IL_12b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c0: Expected O, but got Unknown
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected O, but got Unknown
		//IL_1505: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Expected O, but got Unknown
		//IL_1588: Unknown result type (might be due to invalid IL or missing references)
		//IL_1592: Expected O, but got Unknown
		//IL_1623: Unknown result type (might be due to invalid IL or missing references)
		//IL_162d: Expected O, but got Unknown
		//IL_16d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e1: Expected O, but got Unknown
		//IL_1980: Unknown result type (might be due to invalid IL or missing references)
		//IL_198a: Expected O, but got Unknown
		//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cd: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_product_item));
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroCheckBox1 = new MetroCheckBox();
		metroTextBox3 = new MetroTextBox();
		metroComboBox2 = new MetroComboBox();
		metroComboBox1 = new MetroComboBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		button5 = new Button();
		button6 = new Button();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		openFileDialog1 = new OpenFileDialog();
		saveFileDialog1 = new SaveFileDialog();
		errorProvider1 = new ErrorProvider(components);
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)groupBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(305, 532);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Location = new Point(22, 248);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(265, 257);
		((Control)groupBox2).TabIndex = 6;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Action";
		((Control)button4).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.reset;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(44, 175);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(173, 42);
		((Control)button4).TabIndex = 3;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.delete;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(44, 127);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(173, 42);
		((Control)button3).TabIndex = 2;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(44, 79);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(173, 42);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(44, 31);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(173, 42);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(18, 208);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(76, 19);
		((Control)metroCheckBox1).TabIndex = 5;
		((Control)metroCheckBox1).Text = "Is Active";
		metroCheckBox1.UseSelectable = true;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(248, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(14, 172);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Price";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(276, 29);
		((Control)metroTextBox3).TabIndex = 4;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Price";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).Validating += metroTextBox3_Validating;
		((Control)metroTextBox3).Validated += metroTextBox3_Validated;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(14, 137);
		((Control)metroComboBox2).Name = "metroComboBox2";
		metroComboBox2.PromptText = "Select SubCategory";
		((Control)metroComboBox2).Size = new Size(274, 29);
		((Control)metroComboBox2).TabIndex = 3;
		metroComboBox2.UseSelectable = true;
		((Control)metroComboBox2).Validating += metroComboBox2_Validating;
		((Control)metroComboBox2).Validated += metroComboBox2_Validated;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(14, 102);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Category";
		((Control)metroComboBox1).Size = new Size(274, 29);
		((Control)metroComboBox1).TabIndex = 2;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(248, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(14, 66);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Short Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(276, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Short Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(248, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(14, 31);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Item Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(276, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Item Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox4.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox4.CustomButton).Location = new Point(325, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(346, 74);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Item Name";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		metroTextBox4.ShowButton = true;
		metroTextBox4.ShowClearButton = true;
		((Control)metroTextBox4).Size = new Size(353, 29);
		((Control)metroTextBox4).TabIndex = 7;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Item Name";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).TextChanged += metroTextBox4_TextChanged;
		((Control)button5).BackColor = Color.Green;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(728, 66);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(187, 42);
		((Control)button5).TabIndex = 8;
		((Control)button5).Text = "&Import From Excel (I)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button6).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(957, 66);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(173, 42);
		((Control)button6).TabIndex = 9;
		((Control)button6).Text = "&Export To Excel (E)";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7
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
		((Control)metroGrid1).Location = new Point(346, 114);
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
		((Control)metroGrid1).Size = new Size(905, 481);
		((Control)metroGrid1).TabIndex = 10;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Item Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 250;
		((DataGridViewColumn)Column3).HeaderText = "Short Name";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 150;
		((DataGridViewColumn)Column4).HeaderText = "Category";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 130;
		((DataGridViewColumn)Column5).HeaderText = "Subcategory";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Width = 130;
		((DataGridViewColumn)Column6).HeaderText = "Price";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column6).Width = 70;
		((DataGridViewColumn)Column7).HeaderText = "Is Active";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((FileDialog)openFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).FileOk += saveFileDialog1_FileOk;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1278, 618);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)metroTextBox4);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "r_product_item";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Menu Management";
		((Form)this).FormClosed += new FormClosedEventHandler(r_product_item_FormClosed);
		((Form)this).Load += r_product_item_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_product_item()
	{
		InitializeComponent();
		r_s_product_item = this;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		bindcombo();
		bindgrid();
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
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
				((DbCommand)(object)val2).CommandText = "select * from r_category";
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
				((DbCommand)(object)val2).CommandText = "select * from productitem where  itemname like '" + ((Control)metroTextBox4).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[7]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
							((DbDataReader)(object)val3)[5].ToString(),
							((DbDataReader)(object)val3)[6].ToString()
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

	private void r_product_item_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((ComboBox)metroComboBox2).Items.Clear();
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
					((DbCommand)(object)val2).CommandText = "select * from r_subcategory where category='" + ((Control)metroComboBox1).Text + "'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							((ComboBox)metroComboBox2).Items.Add((object)((DbDataReader)(object)val3)[2].ToString());
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
		catch (Exception)
		{
			((ComboBox)metroComboBox2).Items.Clear();
		}
	}

	private void metroTextBox4_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		ImportMethod();
	}

	private void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	private void ImportMethod()
	{
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Invalid comparison between I4 and Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected O, but got Unknown
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected O, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Expected O, but got Unknown
		if (new USER_PERMISSION().Permission("18", "Insert"))
		{
			DialogResult val = ((CommonDialog)openFileDialog1).ShowDialog();
			if ((int)val != 1)
			{
				return;
			}
			string fileName = ((FileDialog)openFileDialog1).FileName;
			try
			{
				Thread thread = new Thread(loading);
				thread.Start();
				Application application = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				Workbook workbook = application.Workbooks.Open(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				_Worksheet worksheet = (dynamic)workbook.Sheets[1];
				Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
				int count = usedRange.Rows.Count;
				int count2 = usedRange.Columns.Count;
				for (int i = 2; i <= count; i++)
				{
					try
					{
						string text = ((dynamic)usedRange.Cells[i, 2]).Value2.ToString();
						string text2 = ((dynamic)usedRange.Cells[i, 3]).Value2.ToString();
						string text3 = ((dynamic)usedRange.Cells[i, 4]).Value2.ToString();
						string text4 = ((dynamic)usedRange.Cells[i, 5]).Value2.ToString();
						string text5 = ((dynamic)usedRange.Cells[i, 6]).Value2.ToString();
						string text6 = ((dynamic)usedRange.Cells[i, 7]).Value2.ToString();
						SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val3 = new SqlCommand();
							try
							{
								val3.Connection = val2;
								((DbConnection)(object)val2).Open();
								((DbCommand)(object)val3).CommandText = "select * from r_category where category='" + text3 + "'";
								SqlDataReader val4 = val3.ExecuteReader();
								if (!((DbDataReader)(object)val4).HasRows)
								{
									SqlConnection val5 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
									try
									{
										SqlCommand val6 = new SqlCommand();
										try
										{
											val6.Connection = val5;
											((DbConnection)(object)val5).Open();
											((DbCommand)(object)val6).CommandText = "insert into r_category(category) values('" + text3 + "')";
											((DbCommand)(object)val6).ExecuteNonQuery();
											((DbConnection)(object)val5).Close();
										}
										finally
										{
											((IDisposable)val6)?.Dispose();
										}
									}
									finally
									{
										((IDisposable)val5)?.Dispose();
									}
								}
								((DbConnection)(object)val2).Close();
							}
							finally
							{
								((IDisposable)val3)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
						val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val3 = new SqlCommand();
							try
							{
								val3.Connection = val2;
								((DbConnection)(object)val2).Open();
								((DbCommand)(object)val3).CommandText = "select * from r_subcategory where category='" + text3 + "' and subcategory='" + text4 + "'";
								SqlDataReader val4 = val3.ExecuteReader();
								if (!((DbDataReader)(object)val4).HasRows)
								{
									SqlConnection val5 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
									try
									{
										SqlCommand val6 = new SqlCommand();
										try
										{
											val6.Connection = val5;
											((DbConnection)(object)val5).Open();
											((DbCommand)(object)val6).CommandText = "insert into r_subcategory(category,subcategory) values('" + text3 + "','" + text4 + "')";
											((DbCommand)(object)val6).ExecuteNonQuery();
											((DbConnection)(object)val5).Close();
										}
										finally
										{
											((IDisposable)val6)?.Dispose();
										}
									}
									finally
									{
										((IDisposable)val5)?.Dispose();
									}
								}
								((DbConnection)(object)val2).Close();
							}
							finally
							{
								((IDisposable)val3)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
						val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val3 = new SqlCommand();
							try
							{
								val3.Connection = val2;
								((DbConnection)(object)val2).Open();
								((DbCommand)(object)val3).CommandText = "insert into productitem(itemname,shortname,category,subcategory,price,isactive) values('" + text + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "')";
								((DbCommand)(object)val3).ExecuteNonQuery();
								((DbConnection)(object)val2).Close();
							}
							finally
							{
								((IDisposable)val3)?.Dispose();
							}
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
					}
					catch (Exception)
					{
					}
				}
				thread.Abort();
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Items Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				bindgrid();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				Marshal.ReleaseComObject(usedRange);
				Marshal.ReleaseComObject(worksheet);
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				Marshal.ReleaseComObject(workbook);
				application.Quit();
				Marshal.ReleaseComObject(application);
				return;
			}
			catch (IOException)
			{
				((Control)this).Focus();
				((Form)this).Activate();
				return;
			}
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button6_Click(object sender, EventArgs e)
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

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Item Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter Short Name");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "Select Category");
			e.Cancel = true;
		}
	}

	private void metroComboBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox2, "Select Category");
			e.Cancel = true;
		}
	}

	private void metroTextBox3_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox3).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox3).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox3, "Enter Price");
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

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void metroComboBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox2, "");
	}

	private void metroTextBox3_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox3, "");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void SaveFunction()
	{
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Invalid comparison between I4 and Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Invalid comparison between I4 and Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("18", "Insert"))
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
							string text2 = "insert into productitem(itemname,shortname,category,subcategory,price,isactive) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroComboBox1).Text + "','" + ((Control)metroComboBox2).Text + "','" + ((Control)metroTextBox3).Text + "','" + text + "')";
							Debug.WriteLine(text2);
							((DbCommand)(object)val2).CommandText = text2;
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetFunction();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item Name or Short Name already Taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void UpdateMethod()
	{
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between I4 and Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between I4 and Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Invalid comparison between I4 and Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Invalid comparison between I4 and Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("18", "Update"))
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
								string text2 = "update productitem set itemname='" + ((Control)metroTextBox1).Text + "',shortname='" + ((Control)metroTextBox2).Text + "',category='" + ((Control)metroComboBox1).Text + "',subcategory='" + ((Control)metroComboBox2).Text + "',price='" + ((Control)metroTextBox3).Text + "',isactive='" + text + "' where id='" + gid + "'";
								Debug.WriteLine(text2);
								((DbCommand)(object)val2).CommandText = text2;
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetFunction();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item Name or Short Name already Taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		MetroTextBox obj = metroTextBox1;
		MetroTextBox obj2 = metroTextBox2;
		string text = (((Control)metroTextBox3).Text = "");
		text = (((Control)obj2).Text = text);
		((Control)obj).Text = text;
		((ListControl)metroComboBox1).SelectedIndex = -1;
		((ComboBox)metroComboBox2).Items.Clear();
		((ListControl)metroComboBox2).SelectedIndex = -1;
		metroComboBox2.PromptText = "Select Subcategory";
		((Control)button1).Enabled = true;
		Button obj3 = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj3).Enabled = enabled;
		gid = "";
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)metroComboBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		if (((DataGridView)metroGrid1).SelectedRows[0].Cells[6].Value.ToString() == "Yes")
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
		if (new USER_PERMISSION().Permission("18", "Delete"))
		{
			if (gid != "")
			{
				if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete item?", "Done", (MessageBoxButtons)4, (MessageBoxIcon)32))
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
								string commandText = "delete from productitem where id='" + gid + "'";
								((DbCommand)(object)val2).CommandText = commandText;
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetFunction();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void r_product_item_FormClosed(object sender, FormClosedEventArgs e)
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData <= 131145)
		{
			switch (keyData - 131140)
			{
			case 0:
				DeleteMethod();
				return true;
			case 1:
				ExporttoExcel();
				return true;
			}
			if ((int)keyData == 131145)
			{
				ImportMethod();
				return true;
			}
		}
		else
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
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}
}
