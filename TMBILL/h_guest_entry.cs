#define DEBUG
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class h_guest_entry : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroRadioButton metroRadioButton2;

	private MetroRadioButton metroRadioButton1;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox6;

	private MetroTextBox metroTextBox5;

	private MetroTextBox metroTextBox4;

	private MetroTextBox metroTextBox3;

	private MetroComboBox metroComboBox1;

	private MetroTextBox metroTextBox8;

	private MetroTextBox metroTextBox7;

	private GroupBox groupBox2;

	private Label label2;

	private Button button2;

	private Button button1;

	private PictureBox pictureBox1;

	private Button button3;

	private Button button4;

	private PictureBox pictureBox2;

	private Label label3;

	private GroupBox groupBox3;

	private MetroGrid metroGrid1;

	private Button button8;

	private Button button7;

	private Button button6;

	private Button button5;

	private OpenFileDialog openFileDialog1;

	private Button button9;

	private Button button10;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column9;

	private DataGridViewTextBoxColumn Column10;

	private DataGridViewTextBoxColumn Column11;

	private ErrorProvider errorProvider1;

	private string gid = "";

	private VideoCaptureDevice capture;

	private VideoCaptureDevice capture1;

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
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected O, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected O, but got Unknown
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Expected O, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Expected O, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected O, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Expected O, but got Unknown
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1776: Expected O, but got Unknown
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b7: Expected O, but got Unknown
		//IL_1e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e88: Expected O, but got Unknown
		//IL_1fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fac: Expected O, but got Unknown
		//IL_20c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ce: Expected O, but got Unknown
		//IL_2147: Unknown result type (might be due to invalid IL or missing references)
		//IL_2151: Expected O, but got Unknown
		//IL_21df: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e9: Expected O, but got Unknown
		//IL_2292: Unknown result type (might be due to invalid IL or missing references)
		//IL_229c: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		groupBox1 = new GroupBox();
		button8 = new Button();
		button7 = new Button();
		button6 = new Button();
		button5 = new Button();
		metroTextBox8 = new MetroTextBox();
		metroTextBox7 = new MetroTextBox();
		metroComboBox1 = new MetroComboBox();
		metroTextBox6 = new MetroTextBox();
		metroTextBox5 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroRadioButton2 = new MetroRadioButton();
		metroRadioButton1 = new MetroRadioButton();
		metroTextBox1 = new MetroTextBox();
		groupBox2 = new GroupBox();
		button10 = new Button();
		button9 = new Button();
		button3 = new Button();
		button4 = new Button();
		pictureBox2 = new PictureBox();
		label3 = new Label();
		button2 = new Button();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		label2 = new Label();
		groupBox3 = new GroupBox();
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
		Column10 = new DataGridViewTextBoxColumn();
		Column11 = new DataGridViewTextBoxColumn();
		openFileDialog1 = new OpenFileDialog();
		errorProvider1 = new ErrorProvider(components);
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Anchor = (AnchorStyles)7;
		((Control)groupBox1).Controls.Add((Control)(object)button8);
		((Control)groupBox1).Controls.Add((Control)(object)button7);
		((Control)groupBox1).Controls.Add((Control)(object)button6);
		((Control)groupBox1).Controls.Add((Control)(object)button5);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox8);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox7);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox6);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox5);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroRadioButton2);
		((Control)groupBox1).Controls.Add((Control)(object)metroRadioButton1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(326, 633);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Guest Details";
		((Control)button8).Location = new Point(188, 501);
		((Control)button8).Name = "button8";
		((Control)button8).Size = new Size(119, 49);
		((Control)button8).TabIndex = 14;
		((Control)button8).Text = "&Reset (R)";
		((ButtonBase)button8).UseVisualStyleBackColor = true;
		((Control)button8).Click += button8_Click;
		((Control)button7).Location = new Point(24, 501);
		((Control)button7).Name = "button7";
		((Control)button7).Size = new Size(119, 49);
		((Control)button7).TabIndex = 13;
		((Control)button7).Text = "&Delete (D)";
		((ButtonBase)button7).UseVisualStyleBackColor = true;
		((Control)button7).Click += button7_Click;
		((Control)button6).Location = new Point(188, 439);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(119, 49);
		((Control)button6).TabIndex = 12;
		((Control)button6).Text = "&Update (U)";
		((ButtonBase)button6).UseVisualStyleBackColor = true;
		((Control)button6).Click += button6_Click;
		((Control)button5).Location = new Point(24, 439);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(119, 49);
		((Control)button5).TabIndex = 11;
		((Control)button5).Text = "&Save (S)";
		((ButtonBase)button5).UseVisualStyleBackColor = true;
		((Control)button5).Click += button5_Click;
		metroTextBox8.CustomButton.Image = null;
		((Control)metroTextBox8.CustomButton).Location = new Point(211, 2);
		((Control)metroTextBox8.CustomButton).Name = "";
		((Control)metroTextBox8.CustomButton).Size = new Size(69, 69);
		metroTextBox8.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox8.CustomButton).TabIndex = 1;
		metroTextBox8.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox8.CustomButton.UseSelectable = true;
		((Control)metroTextBox8.CustomButton).Visible = false;
		metroTextBox8.FontSize = (MetroTextBoxSize)1;
		metroTextBox8.Lines = new string[0];
		((Control)metroTextBox8).Location = new Point(24, 349);
		metroTextBox8.MaxLength = 32767;
		metroTextBox8.Multiline = true;
		((Control)metroTextBox8).Name = "metroTextBox8";
		metroTextBox8.PasswordChar = '\0';
		metroTextBox8.PromptText = "Enter Remark";
		metroTextBox8.ScrollBars = (ScrollBars)0;
		metroTextBox8.SelectedText = "";
		metroTextBox8.SelectionLength = 0;
		metroTextBox8.SelectionStart = 0;
		metroTextBox8.ShortcutsEnabled = true;
		((Control)metroTextBox8).Size = new Size(283, 74);
		((Control)metroTextBox8).TabIndex = 10;
		metroTextBox8.UseSelectable = true;
		metroTextBox8.WaterMark = "Enter Remark";
		metroTextBox8.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox8.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox7.CustomButton.Image = null;
		((Control)metroTextBox7.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox7.CustomButton).Name = "";
		((Control)metroTextBox7.CustomButton).Size = new Size(27, 27);
		metroTextBox7.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox7.CustomButton).TabIndex = 1;
		metroTextBox7.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox7.CustomButton.UseSelectable = true;
		((Control)metroTextBox7.CustomButton).Visible = false;
		metroTextBox7.FontSize = (MetroTextBoxSize)1;
		metroTextBox7.Lines = new string[0];
		((Control)metroTextBox7).Location = new Point(24, 314);
		metroTextBox7.MaxLength = 32767;
		((Control)metroTextBox7).Name = "metroTextBox7";
		metroTextBox7.PasswordChar = '\0';
		metroTextBox7.PromptText = "Enter Document No";
		metroTextBox7.ScrollBars = (ScrollBars)0;
		metroTextBox7.SelectedText = "";
		metroTextBox7.SelectionLength = 0;
		metroTextBox7.SelectionStart = 0;
		metroTextBox7.ShortcutsEnabled = true;
		((Control)metroTextBox7).Size = new Size(283, 29);
		((Control)metroTextBox7).TabIndex = 9;
		metroTextBox7.UseSelectable = true;
		metroTextBox7.WaterMark = "Enter Document No";
		metroTextBox7.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox7.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(24, 279);
		((Control)metroComboBox1).Name = "metroComboBox1";
		((Control)metroComboBox1).Size = new Size(283, 29);
		((Control)metroComboBox1).TabIndex = 8;
		metroComboBox1.UseSelectable = true;
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(24, 244);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Enter Email Id";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(283, 29);
		((Control)metroTextBox6).TabIndex = 7;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Enter Email Id";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(24, 209);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter Mobile No";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(283, 29);
		((Control)metroTextBox5).TabIndex = 6;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter Mobile No";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox5).Validating += metroTextBox5_Validating;
		((Control)metroTextBox5).Validated += metroTextBox5_Validated;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(24, 174);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter City";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(283, 29);
		((Control)metroTextBox4).TabIndex = 5;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter City";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(24, 139);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Address";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(283, 29);
		((Control)metroTextBox3).TabIndex = 4;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Address";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(24, 104);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Company Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(283, 29);
		((Control)metroTextBox2).TabIndex = 3;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Company Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroRadioButton2).AutoSize = true;
		metroRadioButton2.FontSize = (MetroCheckBoxSize)1;
		((Control)metroRadioButton2).Location = new Point(131, 79);
		((Control)metroRadioButton2).Name = "metroRadioButton2";
		((Control)metroRadioButton2).Size = new Size(68, 19);
		((Control)metroRadioButton2).TabIndex = 2;
		((Control)metroRadioButton2).Text = "Female";
		metroRadioButton2.UseSelectable = true;
		((Control)metroRadioButton1).AutoSize = true;
		((RadioButton)metroRadioButton1).Checked = true;
		metroRadioButton1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroRadioButton1).Location = new Point(24, 79);
		((Control)metroRadioButton1).Name = "metroRadioButton1";
		((Control)metroRadioButton1).Size = new Size(55, 19);
		((Control)metroRadioButton1).TabIndex = 1;
		((RadioButton)metroRadioButton1).TabStop = true;
		((Control)metroRadioButton1).Text = "Male";
		metroRadioButton1.UseSelectable = true;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(255, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(24, 35);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Guest Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(283, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Guest Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)groupBox2).Anchor = (AnchorStyles)7;
		((Control)groupBox2).Controls.Add((Control)(object)button10);
		((Control)groupBox2).Controls.Add((Control)(object)button9);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Controls.Add((Control)(object)pictureBox2);
		((Control)groupBox2).Controls.Add((Control)(object)label3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Controls.Add((Control)(object)pictureBox1);
		((Control)groupBox2).Controls.Add((Control)(object)label2);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(355, 63);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(248, 633);
		((Control)groupBox2).TabIndex = 1;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Document Proofs";
		((ButtonBase)button10).FlatStyle = (FlatStyle)0;
		((ButtonBase)button10).Image = (Image)(object)Resources.reset;
		((Control)button10).Location = new Point(161, 501);
		((Control)button10).Name = "button10";
		((Control)button10).Size = new Size(55, 44);
		((Control)button10).TabIndex = 9;
		((ButtonBase)button10).UseVisualStyleBackColor = true;
		((Control)button10).Click += button10_Click;
		((ButtonBase)button9).FlatStyle = (FlatStyle)0;
		((ButtonBase)button9).Image = (Image)(object)Resources.reset;
		((Control)button9).Location = new Point(161, 232);
		((Control)button9).Name = "button9";
		((Control)button9).Size = new Size(55, 44);
		((Control)button9).TabIndex = 8;
		((ButtonBase)button9).UseVisualStyleBackColor = true;
		((Control)button9).Click += button9_Click;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((ButtonBase)button3).Image = (Image)(object)Resources.capture;
		((Control)button3).Location = new Point(100, 501);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(55, 44);
		((Control)button3).TabIndex = 7;
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((ButtonBase)button4).Image = (Image)(object)Resources.file_open;
		((Control)button4).Location = new Point(39, 501);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(55, 44);
		((Control)button4).TabIndex = 6;
		((ButtonBase)button4).UseVisualStyleBackColor = true;
		((Control)button4).Click += button4_Click;
		pictureBox2.Image = (Image)(object)Resources.Nophoto;
		((Control)pictureBox2).Location = new Point(39, 314);
		((Control)pictureBox2).Name = "pictureBox2";
		((Control)pictureBox2).Size = new Size(171, 174);
		pictureBox2.SizeMode = (PictureBoxSizeMode)1;
		pictureBox2.TabIndex = 5;
		pictureBox2.TabStop = false;
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(24, 293);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(118, 18);
		((Control)label3).TabIndex = 4;
		((Control)label3).Text = "Document Proof";
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((ButtonBase)button2).Image = (Image)(object)Resources.capture;
		((Control)button2).Location = new Point(100, 232);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(55, 44);
		((Control)button2).TabIndex = 3;
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((ButtonBase)button1).Image = (Image)(object)Resources.file_open;
		((Control)button1).Location = new Point(39, 232);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(55, 44);
		((Control)button1).TabIndex = 2;
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		pictureBox1.Image = (Image)(object)Resources.Nophoto;
		((Control)pictureBox1).Location = new Point(39, 52);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(171, 174);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 1;
		pictureBox1.TabStop = false;
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(24, 31);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(48, 18);
		((Control)label2).TabIndex = 0;
		((Control)label2).Text = "Photo";
		((Control)groupBox3).Anchor = (AnchorStyles)13;
		((Control)groupBox3).Controls.Add((Control)(object)metroGrid1);
		((Control)groupBox3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).Location = new Point(609, 63);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(616, 633);
		((Control)groupBox3).TabIndex = 2;
		groupBox3.TabStop = false;
		((Control)groupBox3).Text = "View";
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
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8,
			(DataGridViewColumn)Column9,
			(DataGridViewColumn)Column10,
			(DataGridViewColumn)Column11
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
		((Control)metroGrid1).Location = new Point(24, 32);
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
		((Control)metroGrid1).Size = new Size(575, 585);
		((Control)metroGrid1).TabIndex = 0;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Guest Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Gender";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column4).HeaderText = "compan Name";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewBand)Column4).Visible = false;
		((DataGridViewColumn)Column5).HeaderText = "Address";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column6).HeaderText = "City";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column7).HeaderText = "Mobile No";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column8).HeaderText = "Email Id";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewBand)Column8).ReadOnly = true;
		((DataGridViewColumn)Column9).HeaderText = "Doc Type";
		((DataGridViewColumn)Column9).Name = "Column9";
		((DataGridViewBand)Column9).ReadOnly = true;
		((DataGridViewColumn)Column10).HeaderText = "Doc No";
		((DataGridViewColumn)Column10).Name = "Column10";
		((DataGridViewBand)Column10).ReadOnly = true;
		((DataGridViewColumn)Column11).HeaderText = "Remark";
		((DataGridViewColumn)Column11).Name = "Column11";
		((DataGridViewBand)Column11).ReadOnly = true;
		((DataGridViewBand)Column11).Visible = false;
		((FileDialog)openFileDialog1).Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1241, 719);
		((Control)this).Controls.Add((Control)(object)groupBox3);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Name = "h_guest_entry";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Guest Entry";
		((Form)this).Load += h_guest_entry_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)groupBox3).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public h_guest_entry()
	{
		InitializeComponent();
		ResetFunction();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
	}

	private void ResetFunction()
	{
		gid = "";
		((Control)button5).Enabled = true;
		Button obj = button6;
		bool enabled = (((Control)button7).Enabled = false);
		((Control)obj).Enabled = enabled;
		MetroTextBox obj2 = metroTextBox1;
		MetroTextBox obj3 = metroTextBox2;
		MetroTextBox obj4 = metroTextBox3;
		MetroTextBox obj5 = metroTextBox4;
		MetroTextBox obj6 = metroTextBox5;
		MetroTextBox obj7 = metroTextBox6;
		MetroTextBox obj8 = metroTextBox7;
		string text = (((Control)metroTextBox8).Text = "");
		text = (((Control)obj8).Text = text);
		text = (((Control)obj7).Text = text);
		text = (((Control)obj6).Text = text);
		text = (((Control)obj5).Text = text);
		text = (((Control)obj4).Text = text);
		text = (((Control)obj3).Text = text);
		((Control)obj2).Text = text;
		((ListControl)metroComboBox1).SelectedIndex = -1;
		BindGrid();
		if (capture1 != null)
		{
			capture1.SignalToStop();
			capture1 = null;
		}
		if (capture != null)
		{
			capture.SignalToStop();
			capture = null;
		}
		pictureBox1.Image = (Image)(object)Resources.Nophoto;
		pictureBox2.Image = (Image)(object)Resources.Nophoto;
	}

	private void BindGrid()
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
				((DbCommand)(object)val2).CommandText = "select * from h_guest_entry";
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

	private void h_guest_entry_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
		BindDocumentType();
	}

	private void BindDocumentType()
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
				((DbCommand)(object)val2).CommandText = "select * from h_doc_type";
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

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)openFileDialog1).ShowDialog((IWin32Window)(object)this);
		string fileName = ((FileDialog)openFileDialog1).FileName;
		pictureBox1.Image = Image.FromFile(fileName);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)openFileDialog1).ShowDialog((IWin32Window)(object)this);
		string fileName = ((FileDialog)openFileDialog1).FileName;
		pictureBox2.Image = Image.FromFile(fileName);
	}

	public static byte[] ImageToByte(Image img)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ImageConverter val = new ImageConverter();
		return (byte[])((TypeConverter)(object)val).ConvertTo((object?)img, typeof(byte[]));
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Invalid comparison between I4 and Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		FilterInfoCollection val = new FilterInfoCollection(FilterCategory.VideoInputDevice);
		string text = "";
		foreach (FilterInfo item in (CollectionBase)(object)val)
		{
			FilterInfo val2 = item;
			text = val2.Name;
		}
		if (text != "")
		{
			if (capture == null)
			{
				capture = new VideoCaptureDevice(val[0].MonikerString);
				Debug.WriteLine(capture.IsRunning.ToString());
				capture.NewFrame += new NewFrameEventHandler(Cam_newFrame);
				capture.Start();
			}
			else
			{
				capture.SignalToStop();
				capture = null;
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Webcam not found", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void SaveFunction()
	{
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Invalid comparison between I4 and Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Invalid comparison between I4 and Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Invalid comparison between I4 and Unknown
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
						((DbCommand)(object)val2).CommandText = "insert into h_guest_entry(guest_name,gender,company_name,address,city,mobile_no,emailid,documenttype,document_no,remark,photo,document_photo) values('" + ((Control)metroTextBox1).Text + "','" + (((RadioButton)metroRadioButton1).Checked ? "Male" : "Female") + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox3).Text + "','" + ((Control)metroTextBox4).Text + "','" + ((Control)metroTextBox5).Text + "','" + ((Control)metroTextBox6).Text + "','" + ((Control)metroComboBox1).Text + "','" + ((Control)metroTextBox7).Text + "','" + ((Control)metroTextBox8).Text + "',@photo,@docphoto)";
						val2.Parameters.Add("@photo", SqlDbType.Image);
						val2.Parameters.Add("@docphoto", SqlDbType.Image);
						((DbParameter)(object)val2.Parameters["@photo"]).Value = ImageToByte(pictureBox1.Image);
						((DbParameter)(object)val2.Parameters["@docphoto"]).Value = ImageToByte(pictureBox2.Image);
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetFunction();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Guest Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Mobile No Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	public void Cam_newFrame(object sender, NewFrameEventArgs eventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap image = (Bitmap)((Image)eventArgs.Frame).Clone();
		pictureBox1.Image = (Image)(object)image;
	}

	public void Cam_newFramepic2(object sender, NewFrameEventArgs eventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap image = (Bitmap)((Image)eventArgs.Frame).Clone();
		pictureBox2.Image = (Image)(object)image;
	}

	private void button9_Click(object sender, EventArgs e)
	{
		if (capture != null)
		{
			capture.SignalToStop();
			capture = null;
		}
		pictureBox1.Image = (Image)(object)Resources.Nophoto;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between I4 and Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		FilterInfoCollection val = new FilterInfoCollection(FilterCategory.VideoInputDevice);
		string text = "";
		foreach (FilterInfo item in (CollectionBase)(object)val)
		{
			FilterInfo val2 = item;
			text = val2.Name;
		}
		if (text != "")
		{
			if (capture1 == null)
			{
				capture1 = new VideoCaptureDevice(val[0].MonikerString);
				capture1.NewFrame += new NewFrameEventHandler(Cam_newFramepic2);
				capture1.Start();
			}
			else
			{
				capture1.SignalToStop();
				capture1 = null;
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Webcam not found", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button10_Click(object sender, EventArgs e)
	{
		if (capture1 != null)
		{
			capture1.SignalToStop();
			capture1 = null;
		}
		pictureBox2.Image = (Image)(object)Resources.Nophoto;
	}

	private void button5_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void updateFunction()
	{
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Invalid comparison between I4 and Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Invalid comparison between I4 and Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Invalid comparison between I4 and Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Invalid comparison between I4 and Unknown
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
							((DbCommand)(object)val2).CommandText = "update h_guest_entry set guest_name='" + ((Control)metroTextBox1).Text + "',gender='" + (((RadioButton)metroRadioButton1).Checked ? "Male" : "Female") + "',company_name='" + ((Control)metroTextBox2).Text + "',address='" + ((Control)metroTextBox3).Text + "',city='" + ((Control)metroTextBox4).Text + "',mobile_no='" + ((Control)metroTextBox5).Text + "',emailid='" + ((Control)metroTextBox6).Text + "',documenttype='" + ((Control)metroComboBox1).Text + "',document_no='" + ((Control)metroTextBox7).Text + "',remark='" + ((Control)metroTextBox8).Text + "',photo=@photo,document_photo=@docphoto where id='" + gid + "'";
							val2.Parameters.Add("@photo", SqlDbType.Image);
							val2.Parameters.Add("@docphoto", SqlDbType.Image);
							((DbParameter)(object)val2.Parameters["@photo"]).Value = ImageToByte(pictureBox1.Image);
							((DbParameter)(object)val2.Parameters["@docphoto"]).Value = ImageToByte(pictureBox2.Image);
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Guest Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)metroTextBox2).Text = "";
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Mobile Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				ResetFunction();
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
						((DbCommand)(object)val2).CommandText = "delete from h_guest_entry where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetFunction();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Guest deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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

	private void button6_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	private void button7_Click(object sender, EventArgs e)
	{
		DeleteMethod();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		ResetFunction();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button5).Enabled = false;
		Button obj = button6;
		bool enabled = (((Control)button7).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		if (text == "Male")
		{
			((RadioButton)metroRadioButton1).Checked = true;
			((RadioButton)metroRadioButton2).Checked = false;
		}
		else
		{
			((RadioButton)metroRadioButton1).Checked = false;
			((RadioButton)metroRadioButton2).Checked = true;
		}
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)metroTextBox4).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)metroTextBox5).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		((Control)metroTextBox6).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[6].Value.ToString();
		((Control)metroComboBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[7].Value.ToString();
		((Control)metroTextBox7).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[8].Value.ToString();
		((Control)metroTextBox8).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[9].Value.ToString();
		SetPhoto();
	}

	private void SetPhoto()
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
				string text = "select * from h_guest_entry where id='" + gid + "'";
				Debug.WriteLine(text);
				((DbCommand)(object)val2).CommandText = text;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						byte[] array = (byte[])((DbDataReader)(object)val3)["photo"];
						string text2 = Convert.ToString(DateTime.Now.ToFileTime());
						FileStream fileStream = new FileStream(text2, FileMode.CreateNew, FileAccess.Write);
						fileStream.Write(array, 0, array.Length);
						fileStream.Flush();
						fileStream.Close();
						pictureBox1.Image = Image.FromFile(text2);
						byte[] array2 = (byte[])((DbDataReader)(object)val3)["document_photo"];
						string text3 = Convert.ToString(DateTime.Now.ToFileTime());
						FileStream fileStream2 = new FileStream(text3, FileMode.CreateNew, FileAccess.Write);
						fileStream2.Write(array2, 0, array2.Length);
						fileStream2.Flush();
						fileStream2.Close();
						pictureBox2.Image = Image.FromFile(text3);
					}
				}
				else
				{
					Debug.WriteLine("No Poto avaliable");
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
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Valid Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroTextBox5_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox5).Text == "" || !new RegualarExpress().mobilenofield(((Control)metroTextBox5).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Valid Mobile No");
			e.Cancel = true;
		}
	}

	private void metroTextBox5_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}
}
