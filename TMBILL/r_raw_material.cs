using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
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

public class r_raw_material : MetroForm
{
	private IContainer components = null;

	private ErrorProvider errorProvider1;

	private SaveFileDialog saveFileDialog1;

	private OpenFileDialog openFileDialog1;

	private GroupBox groupBox1;

	private MetroTextBox metroTextBox1;

	private MetroComboBox metroComboBox2;

	private MetroTextBox metroTextBox4;

	private MetroComboBox metroComboBox1;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox2;

	private GroupBox groupBox2;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private MetroTextBox metroTextBox5;

	private Button button6;

	private Button button5;

	private MetroGrid metroGrid1;

	private MetroCheckBox metroCheckBox1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column11;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn Column10;

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
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected O, but got Unknown
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_1262: Expected O, but got Unknown
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Expected O, but got Unknown
		//IL_14d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14de: Expected O, but got Unknown
		//IL_15be: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Expected O, but got Unknown
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_1720: Expected O, but got Unknown
		//IL_1845: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected O, but got Unknown
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Expected O, but got Unknown
		//IL_1964: Unknown result type (might be due to invalid IL or missing references)
		//IL_196e: Expected O, but got Unknown
		//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2e: Expected O, but got Unknown
		//IL_1d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d71: Expected O, but got Unknown
		//IL_1daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db4: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_raw_material));
		errorProvider1 = new ErrorProvider(components);
		saveFileDialog1 = new SaveFileDialog();
		openFileDialog1 = new OpenFileDialog();
		groupBox1 = new GroupBox();
		metroCheckBox1 = new MetroCheckBox();
		groupBox2 = new GroupBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroComboBox2 = new MetroComboBox();
		metroTextBox4 = new MetroTextBox();
		metroComboBox1 = new MetroComboBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		metroTextBox5 = new MetroTextBox();
		button5 = new Button();
		button6 = new Button();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column11 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column9 = new DataGridViewTextBoxColumn();
		Column10 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)this).SuspendLayout();
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((FileDialog)saveFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).FileOk += saveFileDialog1_FileOk;
		((FileDialog)openFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((Control)groupBox1).Anchor = (AnchorStyles)7;
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox1).Controls.Add((Control)(object)groupBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(29, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(310, 555);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Material Information";
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(17, 253);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(53, 19);
		((Control)metroCheckBox1).TabIndex = 6;
		((Control)metroCheckBox1).Text = "IGST";
		metroCheckBox1.UseSelectable = true;
		((Control)groupBox2).Anchor = (AnchorStyles)7;
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Location = new Point(17, 285);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(273, 247);
		((Control)groupBox2).TabIndex = 6;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Action";
		((Control)button4).Anchor = (AnchorStyles)0;
		((Control)button4).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.reset;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(30, 177);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(211, 41);
		((Control)button4).TabIndex = 3;
		((Control)button4).Text = "&Reset (R)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button3).Anchor = (AnchorStyles)0;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.delete;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(30, 130);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(211, 41);
		((Control)button3).TabIndex = 2;
		((Control)button3).Text = "&Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button2).Anchor = (AnchorStyles)0;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(30, 83);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(211, 41);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = "&Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).Anchor = (AnchorStyles)0;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(30, 36);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(211, 41);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(17, 218);
		((Control)metroComboBox2).Name = "metroComboBox2";
		metroComboBox2.PromptText = "Category";
		((Control)metroComboBox2).Size = new Size(273, 29);
		((Control)metroComboBox2).TabIndex = 5;
		metroComboBox2.UseSelectable = true;
		((Control)metroComboBox2).Validating += metroComboBox2_Validating;
		((Control)metroComboBox2).Validated += metroComboBox2_Validated;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(246, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(17, 181);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Tax";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(274, 29);
		((Control)metroTextBox4).TabIndex = 4;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Tax";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(17, 144);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Unit";
		((Control)metroComboBox1).Size = new Size(273, 29);
		((Control)metroComboBox1).TabIndex = 3;
		metroComboBox1.UseSelectable = true;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(246, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(17, 107);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Qty";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(274, 29);
		((Control)metroTextBox3).TabIndex = 2;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Qty";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).Validating += metroTextBox3_Validating;
		((Control)metroTextBox3).Validated += metroTextBox3_Validated;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(246, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(17, 70);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Price";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(274, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Price";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(246, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(17, 33);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(274, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox5.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox5.CustomButton).Location = new Point(369, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(350, 74);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Search Material Name Here . . .";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		metroTextBox5.ShowButton = true;
		metroTextBox5.ShowClearButton = true;
		((Control)metroTextBox5).Size = new Size(397, 29);
		((Control)metroTextBox5).TabIndex = 1;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Search Material Name Here . . .";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox5).TextChanged += metroTextBox5_TextChanged;
		((Control)button5).BackColor = Color.Green;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(753, 62);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(211, 41);
		((Control)button5).TabIndex = 4;
		((Control)button5).Text = "&Import From Excel (I)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button6).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(984, 62);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(211, 41);
		((Control)button6).TabIndex = 5;
		((Control)button6).Text = "&Export To Excel (E)";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
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
		((DataGridView)metroGrid1).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[11]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column11,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column10
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
		((Control)metroGrid1).Location = new Point(351, 110);
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
		((Control)metroGrid1).Size = new Size(878, 508);
		((Control)metroGrid1).TabIndex = 6;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 230;
		((DataGridViewColumn)Column3).HeaderText = "Unit";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 80;
		((DataGridViewColumn)Column4).HeaderText = "Category";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 130;
		((DataGridViewColumn)Column6).HeaderText = "Price";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column6).Width = 70;
		((DataGridViewColumn)Column5).HeaderText = "Qty";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Width = 70;
		((DataGridViewColumn)Column11).HeaderText = "Amount";
		((DataGridViewColumn)Column11).Name = "Column11";
		((DataGridViewBand)Column11).ReadOnly = true;
		((DataGridViewColumn)Column7).HeaderText = "IGST";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 70;
		((DataGridViewColumn)Column8).HeaderText = "CGST";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewBand)Column8).ReadOnly = true;
		((DataGridViewColumn)Column8).Width = 70;
		((DataGridViewColumn)Column9).HeaderText = "SGST";
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewBand)Column9).ReadOnly = true;
		((DataGridViewColumn)Column9).Width = 70;
		((DataGridViewColumn)Column10).HeaderText = "IGST Active?";
		((DataGridViewColumn)Column10).Name = "Column10";
		((DataGridViewBand)Column10).ReadOnly = true;
		((DataGridViewColumn)Column10).Width = 80;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1252, 626);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)metroTextBox5);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "r_raw_material";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Raw Material";
		((Form)this).WindowState = (FormWindowState)2;
		((Form)this).FormClosed += new FormClosedEventHandler(r_raw_material_FormClosed);
		((Form)this).Load += r_raw_material_Load;
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_raw_material()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindgrid();
		bindcategory();
		bindunit();
		ResetMethod();
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
				((DbCommand)(object)val2).CommandText = "select * from raw_item where name like '" + ((Control)metroTextBox5).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[11]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
							((DbDataReader)(object)val3)[5].ToString(),
							((DbDataReader)(object)val3)[6].ToString(),
							((DbDataReader)(object)val3)[7].ToString(),
							((DbDataReader)(object)val3)[8].ToString(),
							((DbDataReader)(object)val3)[9].ToString(),
							((DbDataReader)(object)val3)[10].ToString()
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

	private void bindcategory()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((ComboBox)metroComboBox2).Items.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from raw_category";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox2).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void bindunit()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((ComboBox)metroComboBox1).Items.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_unit";
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

	private void r_raw_material_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	private void button5_Click(object sender, EventArgs e)
	{
		ImportFunction();
	}

	private void ImportFunction()
	{
		//IL_150d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1512: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Invalid comparison between I4 and Unknown
		//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected O, but got Unknown
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected O, but got Unknown
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Expected O, but got Unknown
		//IL_111c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1123: Expected O, but got Unknown
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e3: Expected O, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected O, but got Unknown
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected O, but got Unknown
		//IL_1254: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected O, but got Unknown
		//IL_1314: Unknown result type (might be due to invalid IL or missing references)
		//IL_131b: Expected O, but got Unknown
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1323: Expected O, but got Unknown
		if (new USER_PERMISSION().Permission("16", "Insert"))
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
						string text4 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 5]).Value2.ToString()));
						string text5 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 6]).Value2.ToString()));
						string text6 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 7]).Value2.ToString()));
						string text7 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 8]).Value2.ToString()));
						string text8 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 9]).Value2.ToString()));
						string text9 = string.Format("{0:f2}", double.Parse(((dynamic)usedRange.Cells[i, 10]).Value2.ToString()));
						string text10 = ((dynamic)usedRange.Cells[i, 11]).Value2.ToString();
						SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val3 = new SqlCommand();
							try
							{
								val3.Connection = val2;
								((DbConnection)(object)val2).Open();
								((DbCommand)(object)val3).CommandText = "select * from r_unit where unit='" + text2 + "'";
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
											((DbCommand)(object)val6).CommandText = "insert into r_unit(unit) values('" + text2 + "')";
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
								((DbCommand)(object)val3).CommandText = "select * from raw_category where raw_category='" + text3 + "'";
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
											((DbCommand)(object)val6).CommandText = "insert into raw_category(raw_category) values('" + text3 + "')";
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
								((DbCommand)(object)val3).CommandText = "insert into raw_item(name,unit,category,price,qty,amount,igst,cgst,sgst,igstactive) values('" + text + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "','" + text8 + "','" + text9 + "','" + text10 + "')";
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "RawMaterial Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				bindgrid();
				thread.Abort();
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

	private void metroTextBox5_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
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
		ResetMethod();
	}

	private void ResetMethod()
	{
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		((Control)button1).Enabled = true;
		MetroTextBox obj2 = metroTextBox1;
		MetroTextBox obj3 = metroTextBox2;
		MetroTextBox obj4 = metroTextBox3;
		string text = (((Control)metroTextBox4).Text = "");
		text = (((Control)obj4).Text = text);
		text = (((Control)obj3).Text = text);
		((Control)obj2).Text = text;
		MetroComboBox obj5 = metroComboBox1;
		int selectedIndex = (((ListControl)metroComboBox2).SelectedIndex = -1);
		((ListControl)obj5).SelectedIndex = selectedIndex;
		((CheckBox)metroCheckBox1).Checked = false;
		gid = "";
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveMethod();
	}

	private void SaveMethod()
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between I4 and Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Invalid comparison between I4 and Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("16", "Insert"))
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
							string iGST = getIGST();
							string text = gstGST();
							string text2 = gstGST();
							string amount = getAmount();
							((DbCommand)(object)val2).CommandText = "insert into raw_item(name,unit,category,price,qty,amount,igst,cgst,sgst,igstactive) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroComboBox1).Text + "','" + ((Control)metroComboBox2).Text + "','" + $"{double.Parse(((Control)metroTextBox2).Text):f2}" + "','" + $"{double.Parse(((Control)metroTextBox3).Text):f2}" + "','" + amount + "','" + iGST + "','" + text + "','" + text2 + "','" + (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No") + "')";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetMethod();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Material Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Material Name already taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the fileds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private string gstGST()
	{
		double num = 0.0;
		if (!((CheckBox)metroCheckBox1).Checked)
		{
			num = double.Parse(((Control)metroTextBox4).Text);
			num /= 2.0;
		}
		else
		{
			num = 0.0;
		}
		return $"{num:f2}";
	}

	private string getIGST()
	{
		double num = 0.0;
		num = ((!((CheckBox)metroCheckBox1).Checked) ? 0.0 : double.Parse(((Control)metroTextBox4).Text));
		return $"{num:f2}";
	}

	private string getAmount()
	{
		double num = 0.0;
		double num2 = 0.0;
		num = ((!(((Control)metroTextBox2).Text == "") && new RegualarExpress().doublevalue(((Control)metroTextBox2).Text)) ? double.Parse(((Control)metroTextBox2).Text) : 0.0);
		num2 = ((!(((Control)metroTextBox3).Text == "") && new RegualarExpress().doublevalue(((Control)metroTextBox3).Text)) ? double.Parse(((Control)metroTextBox3).Text) : 0.0);
		return $"{num * num2:f2}";
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter valid Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox2).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter valid Price");
			e.Cancel = true;
		}
	}

	private void metroTextBox3_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox3).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox3).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox3, "Enter valid Qty");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "Select valid Unit");
			e.Cancel = true;
		}
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox4).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Enter valid TAX");
			e.Cancel = true;
		}
	}

	private void metroComboBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox2, "Select valid Category");
			e.Cancel = true;
		}
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
		((Control)button1).Enabled = false;
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroComboBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[10].Value.ToString();
		if (text == "Yes")
		{
			((CheckBox)metroCheckBox1).Checked = true;
			((Control)metroTextBox4).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[7].Value.ToString();
		}
		else
		{
			((CheckBox)metroCheckBox1).Checked = false;
			((Control)metroTextBox4).Text = (double.Parse(((DataGridView)metroGrid1).SelectedRows[0].Cells[8].Value.ToString()) + double.Parse(((DataGridView)metroGrid1).SelectedRows[0].Cells[9].Value.ToString())).ToString();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void UpdateMethod()
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between I4 and Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Invalid comparison between I4 and Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Invalid comparison between I4 and Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Invalid comparison between I4 and Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("16", "Update"))
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
								string iGST = getIGST();
								string text = gstGST();
								string text2 = gstGST();
								string amount = getAmount();
								((DbCommand)(object)val2).CommandText = "update raw_item set name='" + ((Control)metroTextBox1).Text + "',unit='" + ((Control)metroComboBox1).Text + "',category='" + ((Control)metroComboBox2).Text + "',price='" + $"{double.Parse(((Control)metroTextBox2).Text):f2}" + "',qty='" + $"{((Control)metroTextBox3).Text:f2}" + "',amount='" + amount + "',igst='" + iGST + "',cgst='" + text + "',sgst='" + text2 + "',igstactive='" + (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No") + "' where id='" + gid + "'";
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								ResetMethod();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Material Udated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Material Name already taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
					}
				}
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the fileds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Matrial From table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between I4 and Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between I4 and Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("16", "Delete"))
		{
			if (gid != "")
			{
				if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete?", "Confirm?", (MessageBoxButtons)4, (MessageBoxIcon)32))
				{
					SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val2 = new SqlCommand();
						try
						{
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							((DbCommand)(object)val2).CommandText = "delete from raw_item where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							ResetMethod();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Material Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Matrial From table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
				ImportFunction();
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
					SaveMethod();
				}
				return true;
			case 3:
				UpdateMethod();
				return true;
			case 0:
				ResetMethod();
				return true;
			case 2:
				break;
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void r_raw_material_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
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

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void metroTextBox4_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox4, "");
	}

	private void metroComboBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox2, "");
	}
}
