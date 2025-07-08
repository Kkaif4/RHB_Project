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

public class r_color_management : MetroForm
{
	private IContainer components = null;

	private MetroGrid metroGrid1;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private GroupBox groupBox1;

	private MetroComboBox metroComboBox2;

	private Label label2;

	private Button button1;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private Label label1;

	private Label label3;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

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
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc7: Expected O, but got Unknown
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected O, but got Unknown
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_1290: Expected O, but got Unknown
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_color_management));
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		groupBox1 = new GroupBox();
		label3 = new Label();
		label1 = new Label();
		metroTextBox2 = new MetroTextBox();
		metroComboBox2 = new MetroComboBox();
		label2 = new Label();
		button1 = new Button();
		metroTextBox1 = new MetroTextBox();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6
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
		((Control)metroGrid1).Location = new Point(22, 63);
		((DataGridView)metroGrid1).MultiSelect = false;
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
		((Control)metroGrid1).Size = new Size(421, 358);
		((Control)metroGrid1).TabIndex = 1;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridView)metroGrid1).CellContentClick += new DataGridViewCellEventHandler(metroGrid1_CellContentClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "On";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Smaller Value";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column4).HeaderText = "Larger Value";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column5).HeaderText = "Color";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column6).HeaderText = "Colo";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewBand)Column6).Visible = false;
		((Control)button3).BackColor = Color.Green;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.purse;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(40, 517);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(165, 42);
		((Control)button3).TabIndex = 2;
		((Control)button3).Text = "&Save (S)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(279, 517);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(164, 42);
		((Control)button4).TabIndex = 3;
		((Control)button4).Text = "&Update (U)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button5).BackColor = Color.Red;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).Image = (Image)(object)Resources.delete;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(40, 565);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(165, 42);
		((Control)button5).TabIndex = 4;
		((Control)button5).Text = "&Delete (D)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button6).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).Image = (Image)(object)Resources.reset;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(279, 565);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(164, 42);
		((Control)button6).TabIndex = 5;
		((Control)button6).Text = "&Reset (R)";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)button1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(22, 427);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(421, 80);
		((Control)groupBox1).TabIndex = 6;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Color Condition";
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(239, 40);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(26, 18);
		((Control)label3).TabIndex = 7;
		((Control)label3).Text = "To";
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(80, 40);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(65, 18);
		((Control)label1).TabIndex = 6;
		((Control)label1).Text = "Between";
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(47, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(151, 35);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Qty";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(75, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Qty";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((ComboBox)metroComboBox2).Items.AddRange(new object[1] { "Stock" });
		((Control)metroComboBox2).Location = new Point(17, 35);
		((Control)metroComboBox2).Name = "metroComboBox2";
		((Control)metroComboBox2).Size = new Size(57, 29);
		((Control)metroComboBox2).TabIndex = 0;
		metroComboBox2.UseSelectable = true;
		((Control)metroComboBox2).Validating += metroComboBox2_Validating;
		((Control)metroComboBox2).Validated += metroComboBox2_Validated;
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(356, 14);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(45, 18);
		((Control)label2).TabIndex = 4;
		((Control)label2).Text = "Color";
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Location = new Point(359, 35);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(38, 29);
		((Control)button1).TabIndex = 3;
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(47, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(278, 35);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Qty";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(75, 29);
		((Control)metroTextBox1).TabIndex = 2;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Qty";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(466, 619);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_color_management";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Color Management";
		((Form)this).FormClosed += new FormClosedEventHandler(r_color_management_FormClosed);
		((Form)this).Load += r_color_management_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_color_management()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		ResetMethod();
	}

	public void ResetMethod()
	{
		bindGrid();
		((Control)button3).Enabled = true;
		Button obj = button4;
		bool enabled = (((Control)button5).Enabled = false);
		((Control)obj).Enabled = enabled;
		gid = "";
		((ListControl)metroComboBox2).SelectedIndex = -1;
		((Control)metroTextBox1).Text = "";
		((Control)button1).BackColor = Color.White;
		((DataGridView)metroGrid1).ClearSelection();
	}

	public void bindGrid()
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
				((DbCommand)(object)val2).CommandText = "select * from color_codes";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[6]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							"",
							((DbDataReader)(object)val3)[4].ToString()
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
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			string text = ((DataGridView)metroGrid1).Rows[i].Cells[5].Value.ToString();
			string[] array = text.Split(new char[1] { '*' });
			((DataGridView)metroGrid1).Rows[i].Cells[4].Style.BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
		((DataGridView)metroGrid1).ClearSelection();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		ColorDialog val = new ColorDialog();
		val.AllowFullOpen = false;
		val.AnyColor = true;
		val.SolidColorOnly = true;
		val.Color = Color.Red;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string text = val.Color.R + "*" + val.Color.G + "*" + val.Color.B;
			string[] array = text.Split(new char[1] { '*' });
			((Control)button1).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void SaveFunction()
	{
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between I4 and Unknown
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
					Color backColor = ((Control)button1).BackColor;
					string text = backColor.R + "*" + backColor.G + "*" + backColor.B;
					((DbCommand)(object)val2).CommandText = "insert into color_codes(onwhom,bet1,bet2,code) values('" + ((Control)metroComboBox2).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox1).Text + "','" + text + "')";
					((DbCommand)(object)val2).ExecuteNonQuery();
					ResetMethod();
					((DbConnection)(object)val).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Saved", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void updateFunction()
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between I4 and Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between I4 and Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Invalid comparison between I4 and Unknown
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
							Color backColor = ((Control)button1).BackColor;
							string text = backColor.R + "*" + backColor.G + "*" + backColor.B;
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							((DbCommand)(object)val2).CommandText = "update color_codes set onwhom='" + ((Control)metroComboBox2).Text + "',bet1='" + ((Control)metroTextBox2).Text + "',bet2='" + ((Control)metroTextBox1).Text + "',code='" + text + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Something Went Wrong", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void button6_Click(object sender, EventArgs e)
	{
		ResetMethod();
	}

	private void r_color_management_Load(object sender, EventArgs e)
	{
		ResetMethod();
	}

	private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void metroComboBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox2, "Select your Apply Option");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox2).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter valid No");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox1).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter valid No");
			e.Cancel = true;
		}
	}

	private void metroComboBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox2, "");
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		DeleteMethod();
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
						((DbCommand)(object)val2).CommandText = "delete from color_codes where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						ResetMethod();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button3).Enabled = false;
		Button obj = button4;
		bool enabled = (((Control)button5).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroComboBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		string[] array = text.Split(new char[1] { '*' });
		((Control)button1).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
	}

	private void button4_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData <= 131157)
		{
			if ((int)keyData == 131140)
			{
				DeleteMethod();
				return true;
			}
			switch (keyData - 131155)
			{
			case 0:
				SaveFunction();
				return true;
			case 2:
				updateFunction();
				return true;
			}
		}
		else
		{
			if ((int)keyData == 131162)
			{
				ResetMethod();
				return true;
			}
			if ((int)keyData == 262232)
			{
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
				((Form)this).Close();
				return true;
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void r_color_management_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}
}
