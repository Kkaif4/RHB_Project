using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class BillReport : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private Label label1;

	private MetroComboBox metroComboBox1;

	private Label label2;

	private Label label3;

	private MetroDateTime metroDateTime1;

	private MetroDateTime metroDateTime2;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private Button button1;

	private Label label4;

	private MetroComboBox metroComboBox2;

	public static BillReport s_bill_report;

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
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
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected O, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da2: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BillReport));
		groupBox1 = new GroupBox();
		button1 = new Button();
		metroDateTime2 = new MetroDateTime();
		label3 = new Label();
		metroDateTime1 = new MetroDateTime();
		label2 = new Label();
		label1 = new Label();
		metroComboBox1 = new MetroComboBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		metroComboBox2 = new MetroComboBox();
		label4 = new Label();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Anchor = (AnchorStyles)13;
		((Control)groupBox1).Controls.Add((Control)(object)label4);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Controls.Add((Control)(object)button1);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime2);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(1052, 100);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Filter";
		((Control)button1).Anchor = (AnchorStyles)0;
		((Control)button1).BackColor = Color.FromArgb(225, 19, 139);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.printer;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(931, 33);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(112, 44);
		((Control)button1).TabIndex = 6;
		((Control)button1).Text = "Print";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)metroDateTime2).Anchor = (AnchorStyles)0;
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(714, 37);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 5;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((Control)label3).Anchor = (AnchorStyles)0;
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(680, 40);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(26, 18);
		((Control)label3).TabIndex = 4;
		((Control)label3).Text = "To";
		((Control)metroDateTime1).Anchor = (AnchorStyles)0;
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(465, 37);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 3;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((Control)label2).Anchor = (AnchorStyles)0;
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(415, 40);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(44, 18);
		((Control)label2).TabIndex = 2;
		((Control)label2).Text = "From";
		((Control)label1).Anchor = (AnchorStyles)0;
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(154, 40);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(82, 18);
		((Control)label1).TabIndex = 1;
		((Control)label1).Text = "Order Type";
		((Control)metroComboBox1).Anchor = (AnchorStyles)0;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((ComboBox)metroComboBox1).Items.AddRange(new object[4] { "ALL", "Dine In", "Take Away", "Home Delivery" });
		((Control)metroComboBox1).Location = new Point(242, 33);
		((Control)metroComboBox1).Name = "metroComboBox1";
		((Control)metroComboBox1).Size = new Size(133, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
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
		((Control)metroGrid1).Location = new Point(25, 173);
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
		((Control)metroGrid1).Size = new Size(1050, 327);
		((Control)metroGrid1).TabIndex = 1;
		((DataGridViewColumn)Column1).HeaderText = "Bill No";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Width = 50;
		((DataGridViewColumn)Column2).HeaderText = "Date";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 200;
		((DataGridViewColumn)Column3).HeaderText = "Amount";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 200;
		((DataGridViewColumn)Column4).HeaderText = "Tax";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 200;
		((DataGridViewColumn)Column5).HeaderText = "Discount";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Width = 200;
		((DataGridViewColumn)Column6).HeaderText = "Order Type";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column6).Width = 200;
		((DataGridViewColumn)Column7).HeaderText = "Order From";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 200;
		((Control)metroComboBox2).Anchor = (AnchorStyles)0;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(242, 65);
		((Control)metroComboBox2).Name = "metroComboBox2";
		((Control)metroComboBox2).Size = new Size(133, 29);
		((Control)metroComboBox2).TabIndex = 7;
		metroComboBox2.UseSelectable = true;
		((Control)metroComboBox2).Visible = false;
		((ComboBox)metroComboBox2).SelectedIndexChanged += metroComboBox2_SelectedIndexChanged;
		((Control)label4).Anchor = (AnchorStyles)0;
		((Control)label4).AutoSize = true;
		((Control)label4).Location = new Point(154, 68);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(86, 18);
		((Control)label4).TabIndex = 8;
		((Control)label4).Text = "Order From";
		((Control)label4).Visible = false;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1098, 523);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "BillReport";
		((Control)this).Text = "Bill Report";
		((Form)this).Load += SalesReport_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public BillReport()
	{
		InitializeComponent();
		s_bill_report = this;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
	}

	public void bindorderfrom()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		((ComboBox)metroComboBox2).Items.Add((object)"All");
		((ComboBox)metroComboBox2).Items.Add((object)"Self");
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_order_from";
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

	private void SalesReport_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((ListControl)metroComboBox1).SelectedIndex = 0;
		bindorderfrom();
		((ListControl)metroComboBox2).SelectedIndex = 0;
		((Form)this).WindowState = (FormWindowState)2;
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	public void bindgrid()
	{
		((DataGridView)metroGrid1).Rows.Clear();
		Label obj = label4;
		bool visible = (((Control)metroComboBox2).Visible = false);
		((Control)obj).Visible = visible;
		switch (((ListControl)metroComboBox1).SelectedIndex)
		{
		case 0:
			ExtractDINEIN();
			ExtractTakeaway();
			ExtractHome();
			break;
		case 1:
			ExtractDINEIN();
			break;
		case 2:
			ExtractTakeaway();
			break;
		case 3:
		{
			ExtractHome();
			Label obj2 = label4;
			visible = (((Control)metroComboBox2).Visible = true);
			((Control)obj2).Visible = visible;
			break;
		}
		}
	}

	private void ExtractDINEIN()
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
				((DbCommand)(object)val2).CommandText = "select * from r_invoice where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string s = ((DbDataReader)(object)val3)["sgst"].ToString();
						double num = double.Parse(s) * 2.0;
						string text = ((double.Parse(((DbDataReader)(object)val3)["igst"].ToString()) == 0.0) ? num.ToString() : ((DbDataReader)(object)val3)["igst"].ToString()).ToString();
						((DataGridView)metroGrid1).Rows.Add(new object[7]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)["mydate"].ToString(),
							((DbDataReader)(object)val3)["grandtotal"].ToString(),
							text,
							((DbDataReader)(object)val3)["discountamt"].ToString(),
							"Dine In",
							"Offline"
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

	private void ExtractTakeaway()
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
				((DbCommand)(object)val2).CommandText = "select * from r_invoice_takeaway where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string s = ((DbDataReader)(object)val3)["sgst"].ToString();
						double num = double.Parse(s) * 2.0;
						string text = ((double.Parse(((DbDataReader)(object)val3)["igst"].ToString()) == 0.0) ? num.ToString() : ((DbDataReader)(object)val3)["igst"].ToString()).ToString();
						((DataGridView)metroGrid1).Rows.Add(new object[7]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)["mydate"].ToString(),
							((DbDataReader)(object)val3)["grandtotal"].ToString(),
							text,
							((DbDataReader)(object)val3)["discountamt"].ToString(),
							"Take Away",
							"Offline"
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

	private void ExtractHome()
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		string text = "";
		text = ((((ListControl)metroComboBox2).SelectedIndex != 0) ? ("select * from r_invoice_home where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103) and orderfrom='" + ((Control)metroComboBox2).Text + "'") : ("select * from r_invoice_home where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)"));
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = text;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string s = ((DbDataReader)(object)val3)["sgst"].ToString();
						double num = double.Parse(s) * 2.0;
						string text2 = ((double.Parse(((DbDataReader)(object)val3)["igst"].ToString()) == 0.0) ? num.ToString() : ((DbDataReader)(object)val3)["igst"].ToString()).ToString();
						((DataGridView)metroGrid1).Rows.Add(new object[7]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)["mydate"].ToString(),
							((DbDataReader)(object)val3)["grandtotal"].ToString(),
							text2,
							((DbDataReader)(object)val3)["discountamt"].ToString(),
							"Home Delivery",
							((DbDataReader)(object)val3)["orderfrom"].ToString()
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

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		PrintMethod();
	}

	private void PrintMethod()
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Invalid comparison between I4 and Unknown
		if (((DataGridView)metroGrid1).Rows.Count > 0)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("billno", typeof(string));
			dataTable.Columns.Add("mydate", typeof(string));
			dataTable.Columns.Add("amount", typeof(string));
			dataTable.Columns.Add("tax", typeof(string));
			dataTable.Columns.Add("discount", typeof(string));
			dataTable.Columns.Add("ordertype", typeof(string));
			dataTable.Columns.Add("orderfrom", typeof(string));
			for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
			{
				dataTable.Rows.Add(((DataGridView)metroGrid1).Rows[i].Cells[0].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[1].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[2].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[3].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[4].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[5].Value.ToString(), ((DataGridView)metroGrid1).Rows[i].Cells[6].Value.ToString());
			}
			((Control)new Print_BILLREPORT(dataTable)).Show();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "No Record to print", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131152)
		{
			if ((int)keyData == 262232)
			{
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
				((Form)this).Close();
				return true;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		PrintMethod();
		return true;
	}

	private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		bindgrid();
	}
}
