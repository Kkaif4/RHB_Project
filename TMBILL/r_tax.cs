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

public class r_tax : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox2;

	private GroupBox groupBox2;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button button1;

	private MetroTextBox metroTextBox4;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private ErrorProvider errorProvider1;

	private Button button5;

	private Button button6;

	private OpenFileDialog openFileDialog1;

	private SaveFileDialog saveFileDialog1;

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
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Expected O, but got Unknown
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected O, but got Unknown
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Expected O, but got Unknown
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected O, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Expected O, but got Unknown
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Expected O, but got Unknown
		//IL_1613: Unknown result type (might be due to invalid IL or missing references)
		//IL_161d: Expected O, but got Unknown
		//IL_164e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_tax));
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		errorProvider1 = new ErrorProvider(components);
		button5 = new Button();
		button6 = new Button();
		openFileDialog1 = new OpenFileDialog();
		saveFileDialog1 = new SaveFileDialog();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)groupBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(295, 500);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Tax";
		((Control)groupBox1).Enter += groupBox1_Enter;
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Location = new Point(25, 224);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(245, 253);
		((Control)groupBox2).TabIndex = 3;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Action";
		((Control)button4).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.reset;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(26, 173);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(189, 41);
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
		((Control)button3).Location = new Point(26, 126);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(189, 41);
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
		((Control)button2).Location = new Point(26, 79);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(189, 41);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = "&Udate (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(26, 32);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(189, 41);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = "&Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(181, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(69, 69);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(20, 115);
		metroTextBox3.MaxLength = 32767;
		metroTextBox3.Multiline = true;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Tax Description";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(251, 71);
		((Control)metroTextBox3).TabIndex = 2;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Tax Description";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(223, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(20, 78);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Tax Percentage";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(251, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Tax Percentage";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(223, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(20, 41);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Tax Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(251, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Tax Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox4.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox4.CustomButton).Location = new Point(330, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(328, 76);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Tax Name";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		metroTextBox4.ShowButton = true;
		metroTextBox4.ShowClearButton = true;
		((Control)metroTextBox4).Size = new Size(358, 29);
		((Control)metroTextBox4).TabIndex = 4;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Tax Name";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).TextChanged += metroTextBox4_TextChanged;
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
		((Control)metroGrid1).Location = new Point(328, 111);
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
		((Control)metroGrid1).Size = new Size(626, 451);
		((Control)metroGrid1).TabIndex = 5;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 200;
		((DataGridViewColumn)Column3).HeaderText = "Percentage";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column4).HeaderText = "Description";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 250;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((Control)button5).BackColor = Color.Green;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(692, 64);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(118, 41);
		((Control)button5).TabIndex = 4;
		((Control)button5).Text = "&Import (I)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button6).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(816, 64);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(118, 41);
		((Control)button6).TabIndex = 6;
		((Control)button6).Text = "&Export (E)";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		((FileDialog)openFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((FileDialog)saveFileDialog1).FileOk += saveFileDialog1_FileOk;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(967, 586);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)metroTextBox4);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_tax";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Tax";
		((Form)this).FormClosed += new FormClosedEventHandler(r_tax_FormClosed);
		((Form)this).Load += r_tax_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_tax()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		ResetMethod();
		bindgrid();
	}

	private void ResetMethod()
	{
		gid = "";
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = false);
		((Control)obj).Enabled = enabled;
		MetroTextBox obj2 = metroTextBox1;
		MetroTextBox obj3 = metroTextBox2;
		string text = (((Control)metroTextBox3).Text = "");
		text = (((Control)obj3).Text = text);
		((Control)obj2).Text = text;
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
				((DbCommand)(object)val2).CommandText = "select * from tax where name like '" + ((Control)metroTextBox4).Text + "%'";
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

	private void groupBox1_Enter(object sender, EventArgs e)
	{
	}

	private void r_tax_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter valid Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox2).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter valid Percentage");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveMethod();
	}

	private void SaveMethod()
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Invalid comparison between I4 and Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Invalid comparison between I4 and Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("4", "Insert"))
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
							((DbCommand)(object)val2).CommandText = "insert into tax(name,percentage,description) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox3).Text + "')";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							ResetMethod();
							bindgrid();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Name already taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all fileds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Invalid comparison between I4 and Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between I4 and Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Invalid comparison between I4 and Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Invalid comparison between I4 and Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("4", "Update"))
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
								((DbCommand)(object)val2).CommandText = "update tax set name='" + ((Control)metroTextBox1).Text + "',percentage='" + ((Control)metroTextBox2).Text + "',description='" + ((Control)metroTextBox3).Text + "' where id='" + gid + "'";
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								ResetMethod();
								bindgrid();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Name already taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
					}
				}
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all fileds", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Tax from table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between I4 and Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Invalid comparison between I4 and Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Invalid comparison between I4 and Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between I4 and Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("4", "Delete"))
		{
			if (gid != "")
			{
				if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want delete?", "Done", (MessageBoxButtons)4, (MessageBoxIcon)32))
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
								((DbCommand)(object)val2).CommandText = "delete from tax where id='" + gid + "'";
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								ResetMethod();
								bindgrid();
								if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Tax from table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		ResetMethod();
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
				((Form)this).Close();
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
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

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button3).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
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
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Invalid comparison between I4 and Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		if (new USER_PERMISSION().Permission("4", "Insert"))
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
						double num = double.Parse(text2);
						SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val3 = new SqlCommand();
							try
							{
								val3.Connection = val2;
								((DbConnection)(object)val2).Open();
								((DbCommand)(object)val3).CommandText = "insert into tax(name,percentage,description) values('" + text + "','" + text2 + "','" + text3 + "')";
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Tax Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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

	private void r_tax_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}
}
