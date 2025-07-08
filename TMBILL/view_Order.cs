#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class view_Order : MetroForm
{
	public static view_Order s_view_order;

	private IContainer components = null;

	private GroupBox groupBox1;

	private MetroComboBox metroComboBox1;

	private MetroDateTime metroDateTime2;

	private Label label2;

	private Label label1;

	private MetroDateTime metroDateTime1;

	private Label label3;

	private MetroComboBox metroComboBox2;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column7;

	private DataGridViewTextBoxColumn Column8;

	public view_Order()
	{
		InitializeComponent();
		s_view_order = this;
		bindordertype();
		((ListControl)metroComboBox1).SelectedIndex = 0;
		((ListControl)metroComboBox2).SelectedIndex = 0;
		Label obj = label3;
		bool visible = (((Control)metroComboBox2).Visible = false);
		((Control)obj).Visible = visible;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
	}

	private void bindordertype()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		((ComboBox)metroComboBox2).Items.Add((object)"ALL");
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

	private void view_Order_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
		bindgrid();
	}

	public void bindgrid()
	{
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		if (((ListControl)metroComboBox1).SelectedIndex == 2)
		{
			Label obj = label3;
			bool visible = (((Control)metroComboBox2).Visible = true);
			((Control)obj).Visible = visible;
		}
		else
		{
			Label obj2 = label3;
			bool visible = (((Control)metroComboBox2).Visible = false);
			((Control)obj2).Visible = visible;
		}
		string text = "";
		switch (((ListControl)metroComboBox1).SelectedIndex)
		{
		case 0:
			text = "select * from r_invoice where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
			break;
		case 1:
			text = "select * from r_invoice_takeaway where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
			break;
		case 2:
			text = ((((ListControl)metroComboBox2).SelectedIndex != 0) ? ("select * from r_invoice_home where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103) and orderfrom='" + ((Control)metroComboBox2).Text + "'") : ("select * from r_invoice_home where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)"));
			break;
		}
		((DataGridView)metroGrid1).Rows.Clear();
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
					Debug.WriteLine(text);
					((DbCommand)(object)val2).CommandText = text;
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							((DataGridView)metroGrid1).Rows.Add(new object[8]
							{
								((DbDataReader)(object)val3)["id"].ToString(),
								((DbDataReader)(object)val3)["mydate"].ToString(),
								((DbDataReader)(object)val3)["customername"].ToString(),
								((DbDataReader)(object)val3)["total"].ToString(),
								((DbDataReader)(object)val3)["totalwithtax"].ToString(),
								((DbDataReader)(object)val3)["grandtotal"].ToString(),
								((DbDataReader)(object)val3)["paidamt"].ToString(),
								((DbDataReader)(object)val3)["remainingamt"].ToString()
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
		catch (Exception)
		{
		}
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		string id = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		switch (((ListControl)metroComboBox1).SelectedIndex)
		{
		case 0:
			((Control)new PRINT_INVOICE(id)).Show();
			break;
		case 1:
			((Control)new Print_TakeAway(id)).Show();
			break;
		case 2:
			((Control)new Print_HomeDelivery(id)).Show();
			break;
		}
	}

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
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Expected O, but got Unknown
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(view_Order));
		groupBox1 = new GroupBox();
		metroComboBox2 = new MetroComboBox();
		label3 = new Label();
		metroDateTime2 = new MetroDateTime();
		label2 = new Label();
		label1 = new Label();
		metroDateTime1 = new MetroDateTime();
		metroComboBox1 = new MetroComboBox();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Anchor = (AnchorStyles)13;
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox2);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime2);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(26, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(992, 100);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Search By";
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((Control)metroComboBox2).Location = new Point(817, 34);
		((Control)metroComboBox2).Name = "metroComboBox2";
		((Control)metroComboBox2).Size = new Size(141, 29);
		((Control)metroComboBox2).TabIndex = 7;
		metroComboBox2.UseSelectable = true;
		((ComboBox)metroComboBox2).SelectedIndexChanged += metroComboBox2_SelectedIndexChanged;
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(715, 41);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(86, 18);
		((Control)label3).TabIndex = 6;
		((Control)label3).Text = "Order From";
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(474, 34);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 4;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(442, 41);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(26, 18);
		((Control)label2).TabIndex = 3;
		((Control)label2).Text = "To";
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(180, 41);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(44, 18);
		((Control)label1).TabIndex = 2;
		((Control)label1).Text = "From";
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(230, 34);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 1;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((ComboBox)metroComboBox1).Items.AddRange(new object[3] { "Dine In", "Take Away", "Home Delivery" });
		((Control)metroComboBox1).Location = new Point(19, 34);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Bill Type";
		((Control)metroComboBox1).Size = new Size(121, 29);
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8
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
		((Control)metroGrid1).Location = new Point(23, 168);
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
		((Control)metroGrid1).Size = new Size(995, 323);
		((Control)metroGrid1).TabIndex = 1;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridView)metroGrid1).CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(metroGrid1_CellMouseDoubleClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column6).HeaderText = "Date";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column6).Width = 170;
		((DataGridViewColumn)Column2).HeaderText = "Customer Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 250;
		((DataGridViewColumn)Column3).HeaderText = "Total";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 150;
		((DataGridViewColumn)Column4).HeaderText = "Total With Tax";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 160;
		((DataGridViewColumn)Column5).HeaderText = "Grand Total";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Width = 130;
		((DataGridViewColumn)Column7).HeaderText = "Paid Amt";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 150;
		((DataGridViewColumn)Column8).HeaderText = "Remaining Amount";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewBand)Column8).ReadOnly = true;
		((DataGridViewColumn)Column8).Width = 160;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1030, 517);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "view_Order";
		((Control)this).Text = "View Receipts";
		((Form)this).Load += view_Order_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
