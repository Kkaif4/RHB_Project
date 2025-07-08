using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class room_checkin_ : MetroForm
{
	private IContainer components = null;

	private MetroComboBox metroComboBox1;

	private MetroComboBox metroComboBox2;

	private MetroTextBox metroTextBox1;

	private GroupBox groupBox1;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Label label11;

	private Label label12;

	private Label label9;

	private Label label10;

	private Label label13;

	private Label label14;

	private GroupBox groupBox2;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private GroupBox groupBox3;

	private Label label15;

	private MetroDateTime metroDateTime1;

	private Label label16;

	private MetroTextBox metroTextBox4;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox2;

	private MetroComboBox metroComboBox3;

	private NumericUpDown numericUpDown1;

	private MetroGrid metroGrid1;

	private Button button2;

	private Button button1;

	private MetroTextBox metroTextBox5;

	private GroupBox groupBox4;

	private MetroDateTime metroDateTime2;

	private Label label17;

	private MetroComboBox metroComboBox4;

	private Label label18;

	private MetroComboBox metroComboBox5;

	private Label label20;

	private Label label21;

	private Label label22;

	private Label label24;

	private Label label23;

	private Label label25;

	private Label label28;

	private Label label29;

	private Label label26;

	private Label label27;

	private MetroComboBox metroComboBox6;

	private Label label30;

	private Label label32;

	private Label label31;

	private Label label19;

	private Label label33;

	private Label label34;

	private Label label35;

	private MetroTextBox metroTextBox6;

	private Label label36;

	private Label label37;

	private MetroCheckBox metroCheckBox1;

	private Button button3;

	private ErrorProvider errorProvider1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column2;

	private string roomid;

	private string mydate;

	private string total_days_count = "";

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
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Expected O, but got Unknown
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected O, but got Unknown
		//IL_139a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Expected O, but got Unknown
		//IL_1441: Unknown result type (might be due to invalid IL or missing references)
		//IL_144b: Expected O, but got Unknown
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected O, but got Unknown
		//IL_159b: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Expected O, but got Unknown
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Expected O, but got Unknown
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1701: Expected O, but got Unknown
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Expected O, but got Unknown
		//IL_1d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d19: Expected O, but got Unknown
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1a: Expected O, but got Unknown
		//IL_228c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2296: Expected O, but got Unknown
		//IL_2d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3d: Expected O, but got Unknown
		//IL_2f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f89: Expected O, but got Unknown
		//IL_2faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb9: Expected O, but got Unknown
		//IL_300a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3014: Expected O, but got Unknown
		//IL_3095: Unknown result type (might be due to invalid IL or missing references)
		//IL_309f: Expected O, but got Unknown
		//IL_319a: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a4: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		metroComboBox1 = new MetroComboBox();
		metroComboBox2 = new MetroComboBox();
		metroTextBox1 = new MetroTextBox();
		groupBox1 = new GroupBox();
		label13 = new Label();
		label14 = new Label();
		label11 = new Label();
		label12 = new Label();
		label9 = new Label();
		label10 = new Label();
		label7 = new Label();
		label8 = new Label();
		label5 = new Label();
		label6 = new Label();
		label3 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		groupBox2 = new GroupBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		groupBox3 = new GroupBox();
		metroTextBox5 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		button2 = new Button();
		button1 = new Button();
		numericUpDown1 = new NumericUpDown();
		metroComboBox3 = new MetroComboBox();
		metroTextBox4 = new MetroTextBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		label16 = new Label();
		metroDateTime1 = new MetroDateTime();
		label15 = new Label();
		groupBox4 = new GroupBox();
		label35 = new Label();
		label34 = new Label();
		label33 = new Label();
		label32 = new Label();
		label31 = new Label();
		metroComboBox6 = new MetroComboBox();
		label28 = new Label();
		label29 = new Label();
		label26 = new Label();
		label27 = new Label();
		label25 = new Label();
		label24 = new Label();
		label23 = new Label();
		label22 = new Label();
		metroComboBox5 = new MetroComboBox();
		label20 = new Label();
		label21 = new Label();
		metroComboBox4 = new MetroComboBox();
		label19 = new Label();
		label18 = new Label();
		metroDateTime2 = new MetroDateTime();
		label17 = new Label();
		label30 = new Label();
		metroTextBox6 = new MetroTextBox();
		label36 = new Label();
		label37 = new Label();
		metroCheckBox1 = new MetroCheckBox();
		button3 = new Button();
		errorProvider1 = new ErrorProvider(components);
		Column1 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)numericUpDown1).BeginInit();
		((Control)groupBox4).SuspendLayout();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(16, 23);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Refered By";
		((Control)metroComboBox1).Size = new Size(301, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(16, 58);
		((Control)metroComboBox2).Name = "metroComboBox2";
		metroComboBox2.PromptText = "Select Referal Name";
		((Control)metroComboBox2).Size = new Size(301, 29);
		((Control)metroComboBox2).TabIndex = 1;
		metroComboBox2.UseSelectable = true;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(273, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(16, 93);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Guest Mobile No";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(301, 29);
		((Control)metroTextBox1).TabIndex = 2;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Guest Mobile No";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)groupBox1).Controls.Add((Control)(object)label13);
		((Control)groupBox1).Controls.Add((Control)(object)label14);
		((Control)groupBox1).Controls.Add((Control)(object)label11);
		((Control)groupBox1).Controls.Add((Control)(object)label12);
		((Control)groupBox1).Controls.Add((Control)(object)label9);
		((Control)groupBox1).Controls.Add((Control)(object)label10);
		((Control)groupBox1).Controls.Add((Control)(object)label7);
		((Control)groupBox1).Controls.Add((Control)(object)label8);
		((Control)groupBox1).Controls.Add((Control)(object)label5);
		((Control)groupBox1).Controls.Add((Control)(object)label6);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)label4);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(333, 510);
		((Control)groupBox1).TabIndex = 3;
		groupBox1.TabStop = false;
		((Control)label13).AutoSize = true;
		((Control)label13).Location = new Point(89, 160);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(56, 18);
		((Control)label13).TabIndex = 16;
		((Control)label13).Text = "Name: ";
		((Control)label14).AutoSize = true;
		((Control)label14).Location = new Point(13, 160);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(57, 18);
		((Control)label14).TabIndex = 15;
		((Control)label14).Text = "Gender";
		((Control)label11).AutoSize = true;
		((Control)label11).Location = new Point(89, 330);
		((Control)label11).Name = "label11";
		((Control)label11).Size = new Size(56, 18);
		((Control)label11).TabIndex = 14;
		((Control)label11).Text = "Name: ";
		((Control)label12).AutoSize = true;
		((Control)label12).Location = new Point(13, 330);
		((Control)label12).Name = "label12";
		((Control)label12).Size = new Size(60, 18);
		((Control)label12).TabIndex = 13;
		((Control)label12).Text = "Doc No";
		((Control)label9).AutoSize = true;
		((Control)label9).Location = new Point(89, 296);
		((Control)label9).Name = "label9";
		((Control)label9).Size = new Size(56, 18);
		((Control)label9).TabIndex = 12;
		((Control)label9).Text = "Name: ";
		((Control)label10).AutoSize = true;
		((Control)label10).Location = new Point(13, 296);
		((Control)label10).Name = "label10";
		((Control)label10).Size = new Size(72, 18);
		((Control)label10).TabIndex = 11;
		((Control)label10).Text = "Doc Type";
		((Control)label7).AutoSize = true;
		((Control)label7).Location = new Point(89, 262);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(56, 18);
		((Control)label7).TabIndex = 10;
		((Control)label7).Text = "Name: ";
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(13, 262);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(45, 18);
		((Control)label8).TabIndex = 9;
		((Control)label8).Text = "Email";
		((Control)label5).AutoSize = true;
		((Control)label5).Location = new Point(89, 228);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(56, 18);
		((Control)label5).TabIndex = 8;
		((Control)label5).Text = "Name: ";
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(13, 228);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(33, 18);
		((Control)label6).TabIndex = 7;
		((Control)label6).Text = "City";
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(89, 194);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(56, 18);
		((Control)label3).TabIndex = 6;
		((Control)label3).Text = "Name: ";
		((Control)label4).AutoSize = true;
		((Control)label4).Location = new Point(13, 194);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(62, 18);
		((Control)label4).TabIndex = 5;
		((Control)label4).Text = "Address";
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(89, 126);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(56, 18);
		((Control)label2).TabIndex = 4;
		((Control)label2).Text = "Name: ";
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(13, 126);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(56, 18);
		((Control)label1).TabIndex = 3;
		((Control)label1).Text = "Name: ";
		((Control)groupBox2).Controls.Add((Control)(object)pictureBox2);
		((Control)groupBox2).Controls.Add((Control)(object)pictureBox1);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(363, 63);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(212, 510);
		((Control)groupBox2).TabIndex = 4;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Documents";
		((Control)pictureBox2).Location = new Point(15, 228);
		((Control)pictureBox2).Name = "pictureBox2";
		((Control)pictureBox2).Size = new Size(182, 188);
		pictureBox2.SizeMode = (PictureBoxSizeMode)1;
		pictureBox2.TabIndex = 1;
		pictureBox2.TabStop = false;
		((Control)pictureBox1).Location = new Point(15, 23);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(182, 188);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		((Control)groupBox3).Controls.Add((Control)(object)metroTextBox5);
		((Control)groupBox3).Controls.Add((Control)(object)metroGrid1);
		((Control)groupBox3).Controls.Add((Control)(object)button2);
		((Control)groupBox3).Controls.Add((Control)(object)button1);
		((Control)groupBox3).Controls.Add((Control)(object)numericUpDown1);
		((Control)groupBox3).Controls.Add((Control)(object)metroComboBox3);
		((Control)groupBox3).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox3).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox3).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox3).Controls.Add((Control)(object)label16);
		((Control)groupBox3).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox3).Controls.Add((Control)(object)label15);
		((Control)groupBox3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).Location = new Point(581, 70);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(234, 503);
		((Control)groupBox3).TabIndex = 5;
		groupBox3.TabStop = false;
		((Control)groupBox3).Text = "Check In Details";
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(172, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(16, 187);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Charges";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(200, 29);
		((Control)metroTextBox5).TabIndex = 11;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Charges";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column3,
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
		((Control)metroGrid1).Location = new Point(13, 298);
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
		((DataGridView)metroGrid1).RowHeadersVisible = false;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(203, 185);
		((Control)metroGrid1).TabIndex = 10;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((Control)button2).Location = new Point(133, 255);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(83, 36);
		((Control)button2).TabIndex = 9;
		((Control)button2).Text = "Remove";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((Control)button1).Location = new Point(16, 256);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(83, 36);
		((Control)button1).TabIndex = 8;
		((Control)button1).Text = "Add";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		((Control)numericUpDown1).Location = new Point(16, 222);
		((Control)numericUpDown1).Name = "numericUpDown1";
		((Control)numericUpDown1).Size = new Size(200, 24);
		((Control)numericUpDown1).TabIndex = 7;
		numericUpDown1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		((ListControl)metroComboBox3).FormattingEnabled = true;
		((ComboBox)metroComboBox3).ItemHeight = 23;
		((Control)metroComboBox3).Location = new Point(16, 148);
		((Control)metroComboBox3).Name = "metroComboBox3";
		metroComboBox3.PromptText = "Extra Things && Charges";
		((Control)metroComboBox3).Size = new Size(200, 29);
		((Control)metroComboBox3).TabIndex = 6;
		metroComboBox3.UseSelectable = true;
		((ComboBox)metroComboBox3).SelectedIndexChanged += metroComboBox3_SelectedIndexChanged;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(32, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[1] { "0" };
		((Control)metroTextBox4).Location = new Point(148, 113);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Child";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(60, 29);
		((Control)metroTextBox4).TabIndex = 5;
		((Control)metroTextBox4).Text = "0";
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Child";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(32, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[1] { "0" };
		((Control)metroTextBox3).Location = new Point(82, 113);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Female";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(60, 29);
		((Control)metroTextBox3).TabIndex = 4;
		((Control)metroTextBox3).Text = "0";
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Female";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(32, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[1] { "0" };
		((Control)metroTextBox2).Location = new Point(16, 113);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Male";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(60, 29);
		((Control)metroTextBox2).TabIndex = 3;
		((Control)metroTextBox2).Text = "0";
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Male";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)label16).AutoSize = true;
		((Control)label16).Location = new Point(13, 86);
		((Control)label16).Name = "label16";
		((Control)label16).Size = new Size(86, 18);
		((Control)label16).TabIndex = 2;
		((Control)label16).Text = "PAX Details";
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy hh:mm tt";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(16, 51);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 1;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((Control)label15).AutoSize = true;
		((Control)label15).Location = new Point(13, 27);
		((Control)label15).Name = "label15";
		((Control)label15).Size = new Size(152, 18);
		((Control)label15).TabIndex = 0;
		((Control)label15).Text = "Check In Date && Time";
		((Control)groupBox4).Controls.Add((Control)(object)label35);
		((Control)groupBox4).Controls.Add((Control)(object)label34);
		((Control)groupBox4).Controls.Add((Control)(object)label33);
		((Control)groupBox4).Controls.Add((Control)(object)label32);
		((Control)groupBox4).Controls.Add((Control)(object)label31);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox6);
		((Control)groupBox4).Controls.Add((Control)(object)label28);
		((Control)groupBox4).Controls.Add((Control)(object)label29);
		((Control)groupBox4).Controls.Add((Control)(object)label26);
		((Control)groupBox4).Controls.Add((Control)(object)label27);
		((Control)groupBox4).Controls.Add((Control)(object)label25);
		((Control)groupBox4).Controls.Add((Control)(object)label24);
		((Control)groupBox4).Controls.Add((Control)(object)label23);
		((Control)groupBox4).Controls.Add((Control)(object)label22);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox5);
		((Control)groupBox4).Controls.Add((Control)(object)label20);
		((Control)groupBox4).Controls.Add((Control)(object)label21);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox4);
		((Control)groupBox4).Controls.Add((Control)(object)label19);
		((Control)groupBox4).Controls.Add((Control)(object)label18);
		((Control)groupBox4).Controls.Add((Control)(object)metroDateTime2);
		((Control)groupBox4).Controls.Add((Control)(object)label17);
		((Control)groupBox4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox4).Location = new Point(821, 70);
		((Control)groupBox4).Name = "groupBox4";
		((Control)groupBox4).Size = new Size(255, 503);
		((Control)groupBox4).TabIndex = 6;
		groupBox4.TabStop = false;
		((Control)groupBox4).Text = "Payment Details";
		((Control)label35).AutoSize = true;
		((Control)label35).Location = new Point(154, 266);
		((Control)label35).Name = "label35";
		((Control)label35).Size = new Size(21, 18);
		((Control)label35).TabIndex = 24;
		((Control)label35).Text = "T.";
		((Control)label34).AutoSize = true;
		((Control)label34).Location = new Point(173, 266);
		((Control)label34).Name = "label34";
		((Control)label34).Size = new Size(68, 18);
		((Control)label34).TabIndex = 23;
		((Control)label34).Text = "99999.00";
		((Control)label33).AutoSize = true;
		((Control)label33).Location = new Point(9, 113);
		((Control)label33).Name = "label33";
		((Control)label33).Size = new Size(139, 18);
		((Control)label33).TabIndex = 22;
		((Control)label33).Text = "Total Room Charge";
		((Control)label32).AutoSize = true;
		((Control)label32).Location = new Point(173, 138);
		((Control)label32).Name = "label32";
		((Control)label32).Size = new Size(41, 18);
		((Control)label32).TabIndex = 21;
		((Control)label32).Text = "Total";
		((Control)label31).AutoSize = true;
		((Control)label31).Location = new Point(9, 138);
		((Control)label31).Name = "label31";
		((Control)label31).Size = new Size(139, 18);
		((Control)label31).TabIndex = 20;
		((Control)label31).Text = "Total Room Charge";
		((ListControl)metroComboBox6).FormattingEnabled = true;
		((ComboBox)metroComboBox6).ItemHeight = 23;
		((Control)metroComboBox6).Location = new Point(10, 396);
		((Control)metroComboBox6).Name = "metroComboBox6";
		metroComboBox6.PromptText = "Select Payment Method";
		((Control)metroComboBox6).Size = new Size(226, 29);
		((Control)metroComboBox6).TabIndex = 19;
		metroComboBox6.UseSelectable = true;
		((Control)metroComboBox6).Validating += metroComboBox6_Validating;
		((Control)metroComboBox6).Validated += metroComboBox6_Validated;
		((Control)label28).AutoSize = true;
		((Control)label28).Location = new Point(173, 190);
		((Control)label28).Name = "label28";
		((Control)label28).Size = new Size(41, 18);
		((Control)label28).TabIndex = 18;
		((Control)label28).Text = "Total";
		((Control)label29).AutoSize = true;
		((Control)label29).Location = new Point(9, 190);
		((Control)label29).Name = "label29";
		((Control)label29).Size = new Size(93, 18);
		((Control)label29).TabIndex = 17;
		((Control)label29).Text = "Total Charge";
		((Control)label26).AutoSize = true;
		((Control)label26).Location = new Point(173, 86);
		((Control)label26).Name = "label26";
		((Control)label26).Size = new Size(41, 18);
		((Control)label26).TabIndex = 16;
		((Control)label26).Text = "Total";
		((Control)label27).AutoSize = true;
		((Control)label27).Location = new Point(9, 86);
		((Control)label27).Name = "label27";
		((Control)label27).Size = new Size(102, 18);
		((Control)label27).TabIndex = 15;
		((Control)label27).Text = "Room Charge";
		((Control)label25).AutoSize = true;
		((Control)label25).Location = new Point(173, 368);
		((Control)label25).Name = "label25";
		((Control)label25).Size = new Size(41, 18);
		((Control)label25).TabIndex = 14;
		((Control)label25).Text = "Total";
		((Control)label24).AutoSize = true;
		((Control)label24).Location = new Point(6, 368);
		((Control)label24).Name = "label24";
		((Control)label24).Size = new Size(86, 18);
		((Control)label24).TabIndex = 13;
		((Control)label24).Text = "Grand Total";
		((Control)label23).AutoSize = true;
		((Control)label23).Location = new Point(173, 334);
		((Control)label23).Name = "label23";
		((Control)label23).Size = new Size(41, 18);
		((Control)label23).TabIndex = 12;
		((Control)label23).Text = "Total";
		((Control)label22).AutoSize = true;
		((Control)label22).Location = new Point(6, 334);
		((Control)label22).Name = "label22";
		((Control)label22).Size = new Size(97, 18);
		((Control)label22).TabIndex = 11;
		((Control)label22).Text = "Discount Amt";
		((ListControl)metroComboBox5).FormattingEnabled = true;
		((ComboBox)metroComboBox5).ItemHeight = 23;
		((Control)metroComboBox5).Location = new Point(9, 289);
		((Control)metroComboBox5).Name = "metroComboBox5";
		metroComboBox5.PromptText = "Select Discount";
		((Control)metroComboBox5).Size = new Size(226, 29);
		((Control)metroComboBox5).TabIndex = 10;
		metroComboBox5.UseSelectable = true;
		((ComboBox)metroComboBox5).SelectedIndexChanged += metroComboBox5_SelectedIndexChanged;
		((Control)label20).AutoSize = true;
		((Control)label20).Location = new Point(99, 266);
		((Control)label20).Name = "label20";
		((Control)label20).Size = new Size(52, 18);
		((Control)label20).TabIndex = 9;
		((Control)label20).Text = "777.00";
		((Control)label21).AutoSize = true;
		((Control)label21).Location = new Point(6, 266);
		((Control)label21).Name = "label21";
		((Control)label21).Size = new Size(87, 18);
		((Control)label21).TabIndex = 8;
		((Control)label21).Text = "Tax Amount";
		((ListControl)metroComboBox4).FormattingEnabled = true;
		((ComboBox)metroComboBox4).ItemHeight = 23;
		((Control)metroComboBox4).Location = new Point(9, 226);
		((Control)metroComboBox4).Name = "metroComboBox4";
		metroComboBox4.PromptText = "Select Tax";
		((Control)metroComboBox4).Size = new Size(226, 29);
		((Control)metroComboBox4).TabIndex = 7;
		metroComboBox4.UseSelectable = true;
		((ComboBox)metroComboBox4).SelectedIndexChanged += metroComboBox4_SelectedIndexChanged;
		((Control)label19).AutoSize = true;
		((Control)label19).Location = new Point(173, 164);
		((Control)label19).Name = "label19";
		((Control)label19).Size = new Size(41, 18);
		((Control)label19).TabIndex = 5;
		((Control)label19).Text = "Total";
		((Control)label18).AutoSize = true;
		((Control)label18).Location = new Point(9, 164);
		((Control)label18).Name = "label18";
		((Control)label18).Size = new Size(94, 18);
		((Control)label18).TabIndex = 4;
		((Control)label18).Text = "Extra Charge";
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy hh:mm tt";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(9, 51);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(226, 29);
		((Control)metroDateTime2).TabIndex = 3;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((Control)label17).AutoSize = true;
		((Control)label17).Location = new Point(6, 27);
		((Control)label17).Name = "label17";
		((Control)label17).Size = new Size(165, 18);
		((Control)label17).TabIndex = 2;
		((Control)label17).Text = "Check Out Date && Time";
		((Control)label30).AutoSize = true;
		((Control)label30).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)label30).Location = new Point(862, 51);
		((Control)label30).Name = "label30";
		((Control)label30).Size = new Size(195, 16);
		((Control)label30).TabIndex = 7;
		((Control)label30).Text = "Room Charges are as per day..";
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(172, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(1082, 97);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Paid Amount";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(200, 29);
		((Control)metroTextBox6).TabIndex = 12;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Paid Amount";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox6).TextChanged += metroTextBox6_TextChanged;
		((Control)metroTextBox6).KeyPress += new KeyPressEventHandler(metroTextBox6_KeyPress);
		((Control)metroTextBox6).Validating += metroTextBox6_Validating;
		((Control)metroTextBox6).Validated += metroTextBox6_Validated;
		((Control)label36).AutoSize = true;
		((Control)label36).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label36).Location = new Point(1082, 137);
		((Control)label36).Name = "label36";
		((Control)label36).Size = new Size(70, 18);
		((Control)label36).TabIndex = 13;
		((Control)label36).Text = "Remining";
		((Control)label37).AutoSize = true;
		((Control)label37).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label37).Location = new Point(1212, 137);
		((Control)label37).Name = "label37";
		((Control)label37).Size = new Size(36, 18);
		((Control)label37).TabIndex = 14;
		((Control)label37).Text = "0.00";
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(1085, 170);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(115, 19);
		((Control)metroCheckBox1).TabIndex = 15;
		((Control)metroCheckBox1).Text = "Online Booked";
		metroCheckBox1.UseSelectable = true;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button3).Location = new Point(1095, 208);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(177, 44);
		((Control)button3).TabIndex = 16;
		((Control)button3).Text = "Save";
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((DataGridViewColumn)Column1).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)Column1).HeaderText = "Plan Name";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Qty";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 50;
		((DataGridViewColumn)Column2).AutoSizeMode = (DataGridViewAutoSizeColumnMode)16;
		((DataGridViewColumn)Column2).HeaderText = "Charge";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1285, 589);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)metroCheckBox1);
		((Control)this).Controls.Add((Control)(object)label37);
		((Control)this).Controls.Add((Control)(object)label36);
		((Control)this).Controls.Add((Control)(object)metroTextBox6);
		((Control)this).Controls.Add((Control)(object)label30);
		((Control)this).Controls.Add((Control)(object)groupBox4);
		((Control)this).Controls.Add((Control)(object)groupBox3);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Name = "room_checkin_";
		((Control)this).Text = "Room CheckIn";
		((Form)this).Activated += room_checkin__Activated;
		((Form)this).Load += room_checkin__Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)numericUpDown1).EndInit();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public room_checkin_(string roomid, string mydate)
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		this.roomid = roomid;
		this.mydate = mydate;
		BindForm();
		BindTax();
		BindDiscount();
		BindPaymentType();
		BindReferedBy();
		BindPlanCharges();
		ResetLeftPanel();
		SetAmountToLabel();
		((DateTimePicker)metroDateTime1).MaxDate = ((DateTimePicker)metroDateTime2).Value;
		((DateTimePicker)metroDateTime2).MinDate = ((DateTimePicker)metroDateTime1).Value;
	}

	private void SetAmountToLabel()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from room where id='" + roomid + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)label26).Text = string.Format("{0:f2}", double.Parse(((DbDataReader)(object)val3)["charges"].ToString()));
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
		double num = double.Parse(((Control)label26).Text);
		DateTime value = ((DateTimePicker)metroDateTime1).Value;
		DateTime value2 = ((DateTimePicker)metroDateTime2).Value;
		int num2 = 0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				string commandText = "SELECT DATEDIFF(dd,'" + ((DateTimePicker)metroDateTime1).Value.Date.Year + "/" + ((DateTimePicker)metroDateTime1).Value.Date.Month + "/" + ((DateTimePicker)metroDateTime1).Value.Date.Day + "', '" + ((DateTimePicker)metroDateTime2).Value.Date.Year + "/" + ((DateTimePicker)metroDateTime2).Value.Date.Month + "/" + ((DateTimePicker)metroDateTime2).Value.Date.Day + "') AS DateDiff";
				((DbCommand)(object)val2).CommandText = commandText;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num2 = int.Parse(((DbDataReader)(object)val3)[0].ToString());
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
		if (num2 == 0)
		{
			num2 = 1;
		}
		total_days_count = num2.ToString();
		((Control)label33).Text = "( Total " + num2 + " Days )";
		double num3 = num * (double)num2;
		((Control)label32).Text = $"{num3:f2}";
		double num4 = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			num4 += double.Parse(((DataGridView)metroGrid1).Rows[i].Cells[2].Value.ToString());
		}
		((Control)label19).Text = $"{num4:f2}";
		double num5 = num3 + num4;
		((Control)label28).Text = $"{num5:f2}";
		double num6 = 0.0;
		double num7 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox4).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num7 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		num6 = num5 * num7 / 100.0;
		((Control)label20).Text = $"{num6:f2}";
		((Control)label34).Text = $"{num5 + num6:f2}";
		double num8 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from discount where name='" + ((Control)metroComboBox5).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						double num9 = double.Parse(((Control)label34).Text);
						double num10 = double.Parse(((DbDataReader)(object)val3)["minamt"].ToString());
						string text = ((DbDataReader)(object)val3)["type"].ToString();
						if (text != null && text == "Fixed")
						{
							if (num9 >= num10)
							{
								num8 = double.Parse(((DbDataReader)(object)val3)["percentage"].ToString());
							}
						}
						else if (num9 >= num10)
						{
							double num11 = double.Parse(((DbDataReader)(object)val3)["percentage"].ToString());
							num8 = num9 * num11 / 100.0;
						}
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
		((Control)label23).Text = $"{num8:f2}";
		((Control)label25).Text = $"{double.Parse(((Control)label34).Text) - num8:f2}";
		((Control)metroTextBox6).Text = ((Control)label25).Text;
	}

	private void BindPaymentType()
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
				((DbCommand)(object)val2).CommandText = "select * from r_payment_tye";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox6).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindDiscount()
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
				((DbCommand)(object)val2).CommandText = "select * from discount";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox5).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
					}
					((ListControl)metroComboBox5).SelectedIndex = 0;
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

	private void BindTax()
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
				((DbCommand)(object)val2).CommandText = "select * from tax";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox4).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
					}
					((ListControl)metroComboBox4).SelectedIndex = 0;
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

	private void BindPlanCharges()
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
				((DbCommand)(object)val2).CommandText = "select * from h_plan_type";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox3).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindForm()
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
				((DbCommand)(object)val2).CommandText = "select * from room where id='" + roomid + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)this).Text = ((DbDataReader)(object)val3)["roomname"].ToString() + " CheckIn Date " + mydate;
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

	private void BindReferalName()
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
				((DbCommand)(object)val2).CommandText = "select * from h_referal_details where referedby='" + ((Control)metroComboBox1).Text + "'";
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

	private void BindReferedBy()
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

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		BindReferalName();
	}

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
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
				((DbCommand)(object)val2).CommandText = "select * from h_guest_entry where mobile_no='" + ((Control)metroTextBox1).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)label2).Text = ((DbDataReader)(object)val3)["guest_name"].ToString();
						((Control)label13).Text = ((DbDataReader)(object)val3)["gender"].ToString();
						((Control)label3).Text = ((DbDataReader)(object)val3)["address"].ToString();
						((Control)label5).Text = ((DbDataReader)(object)val3)["city"].ToString();
						((Control)label7).Text = ((DbDataReader)(object)val3)["emailid"].ToString();
						((Control)label9).Text = ((DbDataReader)(object)val3)["documenttype"].ToString();
						((Control)label11).Text = ((DbDataReader)(object)val3)["document_no"].ToString();
						byte[] array = (byte[])((DbDataReader)(object)val3)["photo"];
						byte[] array2 = (byte[])((DbDataReader)(object)val3)["document_photo"];
						string text = Convert.ToString(DateTime.Now.ToFileTime());
						FileStream fileStream = new FileStream(text, FileMode.CreateNew, FileAccess.Write);
						fileStream.Write(array, 0, array.Length);
						fileStream.Flush();
						fileStream.Close();
						pictureBox1.Image = Image.FromFile(text);
						string text2 = Convert.ToString(DateTime.Now.ToFileTime());
						FileStream fileStream2 = new FileStream(text2, FileMode.CreateNew, FileAccess.Write);
						fileStream2.Write(array2, 0, array2.Length);
						fileStream2.Flush();
						fileStream2.Close();
						pictureBox2.Image = Image.FromFile(text2);
					}
				}
				else
				{
					ResetLeftPanel();
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

	private void ResetLeftPanel()
	{
		Label obj = label2;
		Label obj2 = label3;
		Label obj3 = label5;
		Label obj4 = label7;
		Label obj5 = label9;
		Label obj6 = label11;
		string text = (((Control)label13).Text = "");
		text = (((Control)obj6).Text = text);
		text = (((Control)obj5).Text = text);
		text = (((Control)obj4).Text = text);
		text = (((Control)obj3).Text = text);
		text = (((Control)obj2).Text = text);
		((Control)obj).Text = text;
		pictureBox1.Image = (Image)(object)Resources.Nophoto;
		pictureBox2.Image = (Image)(object)Resources.Nophoto;
	}

	private void room_checkin__Activated(object sender, EventArgs e)
	{
		AutoCompleteMobile();
	}

	private void AutoCompleteMobile()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		AutoCompleteStringCollection val = new AutoCompleteStringCollection();
		SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val3 = new SqlCommand();
			try
			{
				val3.Connection = val2;
				((DbConnection)(object)val2).Open();
				((DbCommand)(object)val3).CommandText = "select * from h_guest_entry";
				SqlDataReader val4 = val3.ExecuteReader();
				if (((DbDataReader)(object)val4).HasRows)
				{
					while (((DbDataReader)(object)val4).Read())
					{
						val.Add(((DbDataReader)(object)val4)["mobile_no"].ToString());
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
		metroTextBox1.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox1.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox1.AutoCompleteCustomSource = val;
	}

	private void room_checkin__Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
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
				((DbCommand)(object)val2).CommandText = "select * from h_plan_type where plan_name='" + ((Control)metroComboBox3).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroTextBox5).Text = ((DbDataReader)(object)val3)["charge"].ToString();
					}
				}
				else
				{
					((Control)metroTextBox5).Text = "";
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
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		if (((Control)metroComboBox3).Text == "" && (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter valid Plan", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16) == 1)
		{
			((Control)this).Focus();
			((Form)this).Activate();
			return;
		}
		if ((((Control)metroTextBox5).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox5).Text)) && (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter valid charge", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16) == 1)
		{
			((Control)this).Focus();
			((Form)this).Activate();
			return;
		}
		if ((((Control)numericUpDown1).Text == "" || numericUpDown1.Value <= 0m) && (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter valid Quantity", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16) == 1)
		{
			((Control)this).Focus();
			((Form)this).Activate();
			return;
		}
		double num = double.Parse(((Control)metroTextBox5).Text);
		double num2 = double.Parse(numericUpDown1.Value.ToString());
		((DataGridView)metroGrid1).Rows.Add(new object[3]
		{
			((Control)metroComboBox3).Text,
			num2,
			(num * num2).ToString()
		});
		((ListControl)metroComboBox3).SelectedIndex = -1;
		((Control)metroTextBox5).Text = "";
		numericUpDown1.Value = 1m;
		SetAmountToLabel();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		string s = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		double num = double.Parse(s);
		((Control)metroComboBox3).Text = text;
		double num2 = double.Parse(((Control)metroTextBox5).Text);
		((Control)numericUpDown1).Text = (num / num2).ToString();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((DataGridView)metroGrid1).Rows.Remove(((DataGridView)metroGrid1).SelectedRows[0]);
		((ListControl)metroComboBox3).SelectedIndex = -1;
		((Control)metroTextBox5).Text = "";
		numericUpDown1.Value = 1m;
		SetAmountToLabel();
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		SetAmountToLabel();
		((DateTimePicker)metroDateTime2).MinDate = ((DateTimePicker)metroDateTime1).Value;
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		SetAmountToLabel();
		((DateTimePicker)metroDateTime1).MaxDate = ((DateTimePicker)metroDateTime2).Value;
	}

	private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
	{
		SetAmountToLabel();
	}

	private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
	{
		SetAmountToLabel();
	}

	private void metroTextBox6_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox6).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox6).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox6, "Enter Valid Amount");
			e.Cancel = true;
		}
	}

	private void metroTextBox6_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox6, "");
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "" || !new RegualarExpress().mobilenofield(((Control)metroTextBox1).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Valid Mobile No");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	public void SaveFunction()
	{
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Invalid comparison between I4 and Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Invalid comparison between I4 and Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		if (((ContainerControl)this).ValidateChildren())
		{
			if (((Control)label2).Text != "")
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
						((DbCommand)(object)val2).CommandText = "h_s_checkIn";
						((DbParameter)(object)val2.Parameters.Add("@ref_by", SqlDbType.VarChar)).Value = ((Control)metroComboBox1).Text;
						((DbParameter)(object)val2.Parameters.Add("@ref_name", SqlDbType.VarChar)).Value = ((Control)metroComboBox2).Text;
						((DbParameter)(object)val2.Parameters.Add("@mobile_no", SqlDbType.VarChar)).Value = ((Control)metroTextBox1).Text;
						((DbParameter)(object)val2.Parameters.Add("@check_date", SqlDbType.VarChar)).Value = ((Control)metroDateTime1).Text;
						((DbParameter)(object)val2.Parameters.Add("@check_out_date", SqlDbType.VarChar)).Value = ((Control)metroDateTime2).Text;
						((DbParameter)(object)val2.Parameters.Add("@p_male", SqlDbType.VarChar)).Value = ((Control)metroTextBox2).Text;
						((DbParameter)(object)val2.Parameters.Add("@p_female", SqlDbType.VarChar)).Value = ((Control)metroTextBox3).Text;
						((DbParameter)(object)val2.Parameters.Add("@p_child", SqlDbType.VarChar)).Value = ((Control)metroTextBox4).Text;
						((DbParameter)(object)val2.Parameters.Add("@room_charge", SqlDbType.VarChar)).Value = ((Control)label26).Text;
						((DbParameter)(object)val2.Parameters.Add("@total_room_charge", SqlDbType.VarChar)).Value = ((Control)label32).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_charge", SqlDbType.VarChar)).Value = ((Control)label19).Text;
						((DbParameter)(object)val2.Parameters.Add("@total_charge", SqlDbType.VarChar)).Value = ((Control)label28).Text;
						((DbParameter)(object)val2.Parameters.Add("@tax_amt", SqlDbType.VarChar)).Value = ((Control)label20).Text;
						((DbParameter)(object)val2.Parameters.Add("@after_tax", SqlDbType.VarChar)).Value = ((Control)label34).Text;
						((DbParameter)(object)val2.Parameters.Add("@dis_amt", SqlDbType.VarChar)).Value = ((Control)label23).Text;
						((DbParameter)(object)val2.Parameters.Add("@tax_plan", SqlDbType.VarChar)).Value = ((Control)metroComboBox4).Text;
						((DbParameter)(object)val2.Parameters.Add("@dis_plan", SqlDbType.VarChar)).Value = ((Control)metroComboBox5).Text;
						((DbParameter)(object)val2.Parameters.Add("@grand_total", SqlDbType.VarChar)).Value = ((Control)label25).Text;
						((DbParameter)(object)val2.Parameters.Add("@paid_amt", SqlDbType.VarChar)).Value = ((Control)metroTextBox6).Text;
						((DbParameter)(object)val2.Parameters.Add("@remaining", SqlDbType.VarChar)).Value = ((Control)label37).Text;
						((DbParameter)(object)val2.Parameters.Add("@onlinebooked", SqlDbType.VarChar)).Value = (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No");
						((DbParameter)(object)val2.Parameters.Add("@payment_method", SqlDbType.VarChar)).Value = ((Control)metroComboBox6).Text;
						((DbParameter)(object)val2.Parameters.Add("@booking_date", SqlDbType.VarChar)).Value = mydate;
						((DbParameter)(object)val2.Parameters.Add("@room_id", SqlDbType.VarChar)).Value = roomid;
						((DbParameter)(object)val2.Parameters.Add("@total_days", SqlDbType.VarChar)).Value = total_days_count;
						((DbParameter)(object)val2.Parameters.Add("@id", SqlDbType.VarChar, 50)).Direction = ParameterDirection.Output;
						((DbCommand)(object)val2).ExecuteNonQuery();
						string text = ((DbParameter)(object)val2.Parameters["@id"]).Value.ToString();
						if (((DataGridView)metroGrid1).Rows.Count > 0)
						{
							for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
							{
								SqlConnection val3 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
								try
								{
									SqlCommand val4 = new SqlCommand();
									try
									{
										val4.Connection = val3;
										((DbConnection)(object)val3).Open();
										((DbCommand)(object)val4).CommandText = "insert into h_checkin_plan(room_id,plan_charge,qty,charge) values('" + text + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[0].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[1].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[2].Value.ToString() + "')";
										((DbCommand)(object)val4).ExecuteNonQuery();
										((DbConnection)(object)val3).Close();
									}
									finally
									{
										((IDisposable)val4)?.Dispose();
									}
								}
								finally
								{
									((IDisposable)val3)?.Dispose();
								}
							}
						}
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Saved", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
							((Control)new Report_CheckIn(text, roomid, ((Control)metroTextBox1).Text)).Show();
							((Form)this).Close();
						}
						((DbConnection)(object)val).Close();
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
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Guest Details Not Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All Fileds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroComboBox6_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox6).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox6, "Select Payment Method");
			e.Cancel = true;
		}
	}

	private void metroComboBox6_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox6, "");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void metroTextBox6_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
		{
			e.Handled = true;
		}
	}

	private void metroTextBox6_TextChanged(object sender, EventArgs e)
	{
		try
		{
			double num = double.Parse(((Control)label25).Text);
			double num2 = double.Parse(((Control)metroTextBox6).Text);
			((Control)label37).Text = $"{num - num2:f2}";
		}
		catch (Exception)
		{
			((Control)metroTextBox6).Text = "0";
		}
	}
}
