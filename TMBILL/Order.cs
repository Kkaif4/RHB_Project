using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class Order : MetroForm
{
	public static Order static_order;

	private IContainer components = null;

	private MetroComboBox metroComboBox1;

	private GroupBox groupBox1;

	private MetroCheckBox metroCheckBox1;

	private MetroTextBox metroTextBox1;

	private FlowLayoutPanel flowLayoutPanel1;

	private MetroTabControl metroTabControl1;

	private MetroTabPage metroTabPage1;

	private MetroTabPage metroTabPage2;

	private MetroTabPage metroTabPage3;

	private MetroTabControl metroTabControl2;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private GroupBox groupBox2;

	private Button button1;

	private Button button3;

	private Button button2;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem deleteToolStripMenuItem;

	private MetroComboBox metroComboBox2;

	private MetroGrid metroGrid2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private GroupBox groupBox3;

	private Panel panel2;

	private Label label4;

	private Label label3;

	private MetroComboBox metroComboBox4;

	private MetroCheckBox metroCheckBox2;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label9;

	private Label label10;

	private Label label8;

	private Panel panel3;

	private Label label11;

	private Label label12;

	private MetroComboBox metroComboBox5;

	private Label label13;

	private Panel panel4;

	private Label label15;

	private Label label16;

	private Label label14;

	private Button button4;

	private Button button5;

	private MetroComboBox metroComboBox6;

	private MetroTextBox metroTextBox2;

	private GroupBox groupBox4;

	private MetroGrid metroGrid3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

	private Panel panel5;

	private Label label18;

	private Label label17;

	private MetroComboBox metroComboBox3;

	private Label label23;

	private Label label24;

	private Label label21;

	private Label label22;

	private Label label20;

	private Label label19;

	private MetroCheckBox metroCheckBox3;

	private Panel panel6;

	private Panel panel7;

	private Label label25;

	private Label label26;

	private MetroComboBox metroComboBox7;

	private Label label27;

	private Label label28;

	private Panel panel8;

	private Label label29;

	private Label label30;

	private MetroComboBox metroComboBox8;

	private Button button6;

	private Button button7;

	private MetroTextBox metroTextBox3;

	private MetroGrid metroGrid4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

	private GroupBox groupBox5;

	private Panel panel10;

	private Label label33;

	private Label label34;

	private MetroCheckBox metroCheckBox4;

	private Label label35;

	private Label label36;

	private Label label37;

	private Label label38;

	private MetroComboBox metroComboBox9;

	private Panel panel9;

	private Label label31;

	private Label label32;

	private Panel panel11;

	private Label label39;

	private Label label40;

	private Label label41;

	private Label label42;

	private MetroComboBox metroComboBox10;

	private Panel panel12;

	private Label label43;

	private Label label44;

	private MetroComboBox metroComboBox11;

	private MetroTextBox metroTextBox4;

	private MetroComboBox metroComboBox12;

	private ContextMenuStrip contextMenuStrip2;

	private ToolStripMenuItem toolStripMenuItem1;

	private ContextMenuStrip contextMenuStrip3;

	private ToolStripMenuItem toolStripMenuItem2;

	private Button button8;

	private Button button9;

	private MetroCheckBox metroCheckBox5;

	private MetroTextBox metroTextBox5;

	private MetroTextBox metroTextBox6;

	private MetroCheckBox metroCheckBox6;

	private MetroTextBox metroTextBox7;

	private MetroCheckBox metroCheckBox7;

	private MetroComboBox metroComboBox13;

	private Label label45;

	private Panel panel1;

	private Label label2;

	private Label label1;

	private FlowLayoutPanel flowLayoutPanel2;

	private MetroComboBox metroComboBox14;

	private MetroComboBox metroComboBox15;

	private MetroComboBox metroComboBox16;

	private Label label47;

	private Label label46;

	private Label label49;

	private Label label48;

	private Label label51;

	private Label label50;

	public Order()
	{
		InitializeComponent();
		static_order = this;
		bindCombo1();
		bindmenus();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		((DataGridView)metroGrid2).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid2).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid2).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid2).BorderStyle = (BorderStyle)2;
		((DataGridView)metroGrid3).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid3).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid3).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid3).BorderStyle = (BorderStyle)2;
		((DataGridView)metroGrid4).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid4).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid4).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid4).BorderStyle = (BorderStyle)2;
		((TabControl)metroTabControl1).SelectedIndex = 0;
		((TabControl)metroTabControl2).SelectedIndex = 0;
		((Control)metroTextBox5).Visible = false;
		((Control)metroTextBox6).Visible = false;
		((Control)metroTextBox7).Visible = false;
		BindCustomerName();
		BindTaxCombo();
		BindDiscountCombo();
		BindDeliveryBoy();
		BindWaiterName();
		BindOrderFrom();
		BindPaymentType();
		((ListControl)metroComboBox4).SelectedIndex = 0;
		((ListControl)metroComboBox5).SelectedIndex = 0;
		((ListControl)metroComboBox3).SelectedIndex = 0;
		((ListControl)metroComboBox7).SelectedIndex = 0;
		((ListControl)metroComboBox9).SelectedIndex = 0;
		((ListControl)metroComboBox10).SelectedIndex = 0;
		((ListControl)metroComboBox11).SelectedIndex = 0;
		((ListControl)metroComboBox13).SelectedIndex = 0;
		((ListControl)metroComboBox12).SelectedIndex = 0;
		((ListControl)metroComboBox8).SelectedIndex = 0;
		((ListControl)metroComboBox2).SelectedIndex = 0;
		((ListControl)metroComboBox6).SelectedIndex = 0;
		SetTableButtonColor();
	}

	private void BindPaymentType()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		((ComboBox)metroComboBox11).Items.Clear();
		((ComboBox)metroComboBox8).Items.Clear();
		((ComboBox)metroComboBox6).Items.Clear();
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
						((ComboBox)metroComboBox11).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox8).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindOrderFrom()
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
				((DbCommand)(object)val2).CommandText = "select * from r_order_from";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox13).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindWaiterName()
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
				((DbCommand)(object)val2).CommandText = "select * from r_employee";
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

	private void BindDeliveryBoy()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((ComboBox)metroComboBox12).Items.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_deliveryboy";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox12).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindDiscountCombo()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		((ComboBox)metroComboBox5).Items.Clear();
		((ComboBox)metroComboBox7).Items.Clear();
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
						((ComboBox)metroComboBox7).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox10).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindTaxCombo()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		((ComboBox)metroComboBox4).Items.Clear();
		((ComboBox)metroComboBox3).Items.Clear();
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
						((ComboBox)metroComboBox3).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox9).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox14).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox15).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						((ComboBox)metroComboBox16).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void BindCustomerName()
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
				((DbCommand)(object)val3).CommandText = "select * from r_customer";
				SqlDataReader val4 = val3.ExecuteReader();
				if (((DbDataReader)(object)val4).HasRows)
				{
					while (((DbDataReader)(object)val4).Read())
					{
						val.Add(((DbDataReader)(object)val4)[1].ToString());
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
		metroTextBox2.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox2.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox2.AutoCompleteCustomSource = val;
		metroTextBox3.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox3.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox3.AutoCompleteCustomSource = val;
		metroTextBox4.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox4.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox4.AutoCompleteCustomSource = val;
	}

	private void bindmenus()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((Control)flowLayoutPanel1).Controls.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from productitem where itemname like '" + ((Control)metroTextBox1).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					int num = 0;
					while (((DbDataReader)(object)val3).Read())
					{
						Button val4 = AddButton(num, ((DbDataReader)(object)val3)[1].ToString(), ((DbDataReader)(object)val3)["isactive"].ToString());
						((Control)val4).Click += buttonclick;
						((Control)flowLayoutPanel1).Controls.Add((Control)(object)val4);
						num++;
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

	private void buttonclick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Button val = (Button)sender;
		CHECK_WHERE_TO_INSERT(((Control)val).Text, "1");
	}

	private void buttonTableclick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and O
		Button val = (Button)sender;
		((Control)metroComboBox1).Text = ((Control)val).Text;
		foreach (Control item in (ArrangedElementCollection)((Control)flowLayoutPanel2).Controls)
		{
			Control val2 = item;
			if ((object)(Button)val2 == val)
			{
				val2.BackColor = Color.Purple;
			}
			else
			{
				val2.BackColor = Color.Green;
			}
		}
		SetTableButtonColor();
	}

	private void CHECK_WHERE_TO_INSERT(string itemname, string quantity)
	{
		switch (((TabControl)metroTabControl1).SelectedIndex)
		{
		case 0:
			ADD_DINEIN_KOT(itemname, quantity);
			break;
		case 1:
			ADD_TAKEAWAY(itemname, quantity);
			break;
		case 2:
			ADD_HOMEDELIVERY(itemname, quantity);
			break;
		}
		((Control)metroTextBox1).Focus();
	}

	private void ADD_HOMEDELIVERY(string itemname, string quantity)
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
				((DbCommand)(object)val2).CommandText = "select * from productitem where itemname='" + itemname + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						Insert_Into_HOMEDELIVERY(itemname, quantity, ((DbDataReader)(object)val3)["price"].ToString(), gettotal(quantity, ((DbDataReader)(object)val3)["price"].ToString()));
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

	private void Insert_Into_HOMEDELIVERY(string itemname, string quantity, string price, string total)
	{
		string text = isfoundinhomedelivery(itemname);
		if (text != "-1")
		{
			string text2 = ((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[0].Value.ToString();
			string s = ((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[1].Value.ToString();
			string text3 = ((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[2].Value.ToString();
			string s2 = ((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[3].Value.ToString();
			double num = double.Parse(quantity) + double.Parse(s);
			double num2 = double.Parse(total) + double.Parse(s2);
			((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[1].Value = num.ToString();
			((DataGridView)metroGrid4).Rows[int.Parse(text)].Cells[3].Value = num2.ToString();
		}
		else
		{
			((DataGridView)metroGrid4).Rows.Add(new object[4] { itemname, quantity, price, total });
		}
		CalculateHomeTotal();
	}

	private void ADD_TAKEAWAY(string itemname, string quantity)
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
				((DbCommand)(object)val2).CommandText = "select * from productitem where itemname='" + itemname + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						Insert_Into_TakeAway(itemname, quantity, ((DbDataReader)(object)val3)["price"].ToString(), gettotal(quantity, ((DbDataReader)(object)val3)["price"].ToString()));
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

	private void Insert_Into_TakeAway(string itemname, string quantity, string price, string total)
	{
		string text = isfoundintakeaway(itemname);
		if (text != "-1")
		{
			string text2 = ((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[0].Value.ToString();
			string s = ((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[1].Value.ToString();
			string text3 = ((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[2].Value.ToString();
			string s2 = ((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[3].Value.ToString();
			double num = double.Parse(quantity) + double.Parse(s);
			double num2 = double.Parse(total) + double.Parse(s2);
			((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[1].Value = num.ToString();
			((DataGridView)metroGrid3).Rows[int.Parse(text)].Cells[3].Value = num2.ToString();
		}
		else
		{
			((DataGridView)metroGrid3).Rows.Add(new object[4] { itemname, quantity, price, total });
		}
		CalculateTakeAwayTotal();
	}

	private string isfoundintakeaway(string itemname)
	{
		for (int i = 0; i < ((DataGridView)metroGrid3).Rows.Count; i++)
		{
			if (((DataGridView)metroGrid3).Rows[i].Cells[0].Value.ToString() == itemname)
			{
				return i.ToString();
			}
		}
		return "-1";
	}

	private string isfoundinhomedelivery(string itemname)
	{
		for (int i = 0; i < ((DataGridView)metroGrid4).Rows.Count; i++)
		{
			if (((DataGridView)metroGrid4).Rows[i].Cells[0].Value.ToString() == itemname)
			{
				return i.ToString();
			}
		}
		return "-1";
	}

	private void ADD_DINEIN_KOT(string itemname, string quantity)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between I4 and Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		if (((Control)metroComboBox1).Text != "")
		{
			((TabControl)metroTabControl2).SelectedIndex = 0;
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from productitem where itemname='" + itemname + "'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							Insert_Into_KOT(itemname, quantity, ((DbDataReader)(object)val3)["price"].ToString(), gettotal(quantity, ((DbDataReader)(object)val3)["price"].ToString()));
						}
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
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Your Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void Insert_Into_KOT(string itemname, string quantity, string price, string total)
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		string text = isfoundinkot(itemname);
		if (text != "-1")
		{
			string s = "0";
			string s2 = "0";
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from temp_KOT where id='" + text + "'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							s = ((DbDataReader)(object)val3)["qty"].ToString();
							s2 = ((DbDataReader)(object)val3)["amount"].ToString();
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
			double num = double.Parse(s) + double.Parse(quantity);
			double num2 = double.Parse(s2) + double.Parse(total);
			val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "update temp_KOT set qty='" + num.ToString() + "',amount='" + num2 + "' where id='" + text + "'";
					((DbCommand)(object)val2).ExecuteNonQuery();
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
		else
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "insert into temp_KOT(tablename,itemname,qty,price,amount,iskot) values('" + ((Control)metroComboBox1).Text + "','" + itemname + "','" + quantity + "','" + price + "','" + total + "','Yes')";
					((DbCommand)(object)val2).ExecuteNonQuery();
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
		((Control)metroTextBox1).Text = "";
		BindKOT_TABLE();
	}

	public void SetTableButtonColor()
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
				((DbCommand)(object)val2).CommandText = "select distinct tablename from temp_KOT";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						setOrangeColor(((DbDataReader)(object)val3)[0].ToString());
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

	public void setOrangeColor(string name)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)flowLayoutPanel2).Controls)
		{
			Control val = item;
			Button val2 = (Button)val;
			if (((Control)metroComboBox1).Text != ((Control)val2).Text && ((Control)val2).Text == name)
			{
				((Control)val2).BackColor = Color.Orange;
			}
		}
	}

	private void BindKOT_TABLE()
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
				((DbCommand)(object)val2).CommandText = "select * from temp_KOT where tablename='" + ((Control)metroComboBox1).Text + "' and iskot='Yes'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[5]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
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
		CalculateTotal();
	}

	private void CalculateTotal()
	{
		double num = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			num += double.Parse(((DataGridView)metroGrid1).Rows[i].Cells[4].Value.ToString());
		}
		((Control)label2).Text = $"{num:f2}";
	}

	private string isfoundinkot(string itemname)
	{
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			if (((DataGridView)metroGrid1).Rows[i].Cells[1].Value.ToString() == itemname)
			{
				return ((DataGridView)metroGrid1).Rows[i].Cells[0].Value.ToString();
			}
		}
		return "-1";
	}

	private string gettotal(string quantity, string p)
	{
		double num = double.Parse(quantity);
		double num2 = double.Parse(p);
		return (num * num2).ToString();
	}

	private Button AddButton(int i, string name, string status)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		Button val = new Button();
		if (status == "Yes")
		{
			((Control)val).BackColor = Color.FromArgb(0, 174, 219);
		}
		else
		{
			((Control)val).BackColor = Color.Red;
		}
		((ButtonBase)val).FlatStyle = (FlatStyle)0;
		((Control)val).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)val).ForeColor = Color.White;
		((Control)val).Name = "button" + i;
		((Control)val).Size = new Size(190, 49);
		((Control)val).Text = name;
		((ButtonBase)val).UseVisualStyleBackColor = false;
		return val;
	}

	private Button AddTButton(int i, string name, string status)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		Button val = new Button();
		if (status == "Yes")
		{
			((Control)val).BackColor = Color.Green;
		}
		else
		{
			((Control)val).BackColor = Color.Green;
		}
		((ButtonBase)val).FlatStyle = (FlatStyle)0;
		((Control)val).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)val).ForeColor = Color.White;
		((Control)val).Name = "button" + i;
		((Control)val).AutoSize = true;
		((Control)val).Text = name;
		((ButtonBase)val).UseVisualStyleBackColor = false;
		return val;
	}

	private void bindCombo1()
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
				((DbCommand)(object)val2).CommandText = "select * from tbl where isactive='Yes'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					int num = 1000;
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox1).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
						Button val4 = AddTButton(num, ((DbDataReader)(object)val3)[1].ToString(), ((DbDataReader)(object)val3)["isactive"].ToString());
						((Control)val4).Click += buttonTableclick;
						((Control)flowLayoutPanel2).Controls.Add((Control)(object)val4);
						num++;
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

	private void Order_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
	}

	private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox1).Checked)
		{
			metroTextBox1.WaterMark = "Enter Menu Code Here Ex HH*2 (here HH is code and 2 is qty)";
			return;
		}
		metroTextBox1.WaterMark = "Enter Menu Name";
		bindmenus();
	}

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
	{
		if (!((CheckBox)metroCheckBox1).Checked)
		{
			bindmenus();
		}
	}

	private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
	}

	private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Invalid comparison between I4 and Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Invalid comparison between I4 and Unknown
		if (!((CheckBox)metroCheckBox1).Checked || (int)e.KeyData != 13)
		{
			return;
		}
		string[] array = ((Control)metroTextBox1).Text.Split(new char[1] { '*' });
		if (array.Length == 2)
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "select * from productitem where shortname='" + array[0] + "'";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							CHECK_WHERE_TO_INSERT(((DbDataReader)(object)val3)[1].ToString(), array[1]);
							((Control)metroTextBox1).Text = "";
							((Control)metroTextBox1).Focus();
						}
					}
					else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Invalid Short Code", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
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
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter valid Code\nSort code should be, Code followed by Asterisk(*) followed by Quantity\nEx HH*2\nHere HH is code and 2 is quantity", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		BindKOT_TABLE();
		BindBILL_TABLE();
		SetTableButtonColor();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		string s = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		string itemname = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		Q_Dialog q_Dialog = new Q_Dialog(s);
		try
		{
			if ((int)((Form)q_Dialog).ShowDialog() != 1 || q_Dialog.seletedText == null || !new RegualarExpress().doublevalue(q_Dialog.seletedText))
			{
				return;
			}
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "delete from temp_KOT where id='" + text + "'";
					((DbCommand)(object)val2).ExecuteNonQuery();
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
			BindKOT_TABLE();
			CHECK_WHERE_TO_INSERT(itemname, q_Dialog.seletedText);
		}
		finally
		{
			((IDisposable)q_Dialog)?.Dispose();
		}
	}

	private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((TabControl)metroTabControl1).SelectedIndex == 0)
		{
			((TabControl)metroTabControl2).SelectedIndex = 0;
			((Control)flowLayoutPanel2).Visible = true;
		}
		else
		{
			((Control)flowLayoutPanel2).Visible = false;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Print_KOT();
	}

	private void Print_KOT()
	{
		((Control)new KOT_PRINT(((Control)metroComboBox1).Text)).Show();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Delete_KOT();
	}

	private void Delete_KOT()
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between I4 and Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between I4 and Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between I4 and Unknown
		if (((DataGridView)metroGrid1).Rows.Count > 0)
		{
			if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to Delete all information of " + ((Control)metroComboBox1).Text, "Error", (MessageBoxButtons)4, (MessageBoxIcon)16))
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "delete from temp_KOT where tablename='" + ((Control)metroComboBox1).Text + "' and iskot='Yes'";
						val2.ExecuteReader();
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
				BindKOT_TABLE();
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "All Information of " + ((Control)metroComboBox1).Text + " Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Add items to delete", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).Button == 2097152)
		{
			Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
			((ToolStripDropDown)contextMenuStrip1).Show(point);
		}
	}

	private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between I4 and Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		string text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		string text2 = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete " + text2 + " From " + ((Control)metroComboBox1).Text, "Error", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "delete from temp_KOT where id='" + text + "'";
					((DbCommand)(object)val2).ExecuteNonQuery();
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
			BindKOT_TABLE();
		}
		else
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Save_KOT();
	}

	private void Save_KOT()
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Invalid comparison between I4 and Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		if (((DataGridView)metroGrid1).Rows.Count > 0)
		{
			SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
			try
			{
				SqlCommand val2 = new SqlCommand();
				try
				{
					val2.Connection = val;
					((DbConnection)(object)val).Open();
					((DbCommand)(object)val2).CommandText = "update temp_KOT set iskot='NO' where tablename='" + ((Control)metroComboBox1).Text + "'";
					((DbCommand)(object)val2).ExecuteNonQuery();
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
			BindKOT_TABLE();
			BindBILL_TABLE();
			((TabControl)metroTabControl2).SelectedIndex = 1;
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Add items in table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void BindBILL_TABLE()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((DataGridView)metroGrid2).Rows.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from temp_KOT where tablename='" + ((Control)metroComboBox1).Text + "' and iskot='No'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid2).Rows.Add(new object[5]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
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
		CalculateBillTotal();
	}

	public void CalculateTakeAwayTotal()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		double num = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid3).Rows.Count; i++)
		{
			num += double.Parse(((DataGridView)metroGrid3).Rows[i].Cells[3].Value.ToString());
		}
		((Control)label18).Text = $"{num:f2}";
		double num2 = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox3).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num2 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num3 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox16).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num3 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num4 = 0.0;
		double num5 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from discount where name='" + ((Control)metroComboBox7).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						if (((DbDataReader)(object)val3)[4].ToString() == "Fixed")
						{
							num5 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
						}
						else
						{
							num4 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num6 = num * num3 / 100.0;
		double num7 = num * num2 / 100.0;
		if (((CheckBox)metroCheckBox3).Checked)
		{
			((Control)label20).Text = $"{num7:f2}";
			((Control)label21).Text = "0.00";
			((Control)label23).Text = "0.00";
		}
		else
		{
			((Control)label20).Text = "0.00";
			((Control)label21).Text = $"{num7 / 2.0:f2}";
			((Control)label23).Text = $"{num7 / 2.0:f2}";
		}
		((Control)label48).Text = $"{num6:f2}";
		double num8 = num + num7;
		double num9 = num8 + num6;
		((Control)label25).Text = $"{num8:f2}";
		((Control)label49).Text = $"{num9:f2}";
		double num10 = 0.0;
		if (num5 != 0.0)
		{
			((Control)label27).Text = $"{num5:f2}";
			num10 = num9 - num5;
			((Control)label29).Text = $"{num10:f2}";
		}
		else
		{
			double num11 = num9 * num4 / 100.0;
			((Control)label27).Text = $"{num11:f2}";
			num10 = num9 - num11;
			((Control)label29).Text = $"{num10:f2}";
		}
		if (!((CheckBox)metroCheckBox6).Checked)
		{
			((Control)metroTextBox6).Text = num10.ToString();
		}
	}

	public void CalculateHomeTotal()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		double num = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid4).Rows.Count; i++)
		{
			num += double.Parse(((DataGridView)metroGrid4).Rows[i].Cells[3].Value.ToString());
		}
		((Control)label31).Text = $"{num:f2}";
		double num2 = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox9).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num2 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num3 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox15).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num3 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num4 = 0.0;
		double num5 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from discount where name='" + ((Control)metroComboBox10).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						if (((DbDataReader)(object)val3)[4].ToString() == "Fixed")
						{
							num5 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
						}
						else
						{
							num4 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num6 = num * num2 / 100.0;
		double num7 = num * num3 / 100.0;
		((Control)label50).Text = $"{num7:f2}";
		if (((CheckBox)metroCheckBox4).Checked)
		{
			((Control)label36).Text = $"{num6:f2}";
			((Control)label34).Text = "0.00";
			((Control)label37).Text = "0.00";
		}
		else
		{
			((Control)label36).Text = "0.00";
			((Control)label34).Text = $"{num6 / 2.0:f2}";
			((Control)label37).Text = $"{num6 / 2.0:f2}";
		}
		double num8 = num + num6;
		double num9 = num8 + num7;
		((Control)label39).Text = $"{num8:f2}";
		((Control)label51).Text = $"{num9:f2}";
		double num10 = 0.0;
		if (num5 != 0.0)
		{
			((Control)label41).Text = $"{num5:f2}";
			num10 = num9 - num5;
			((Control)label43).Text = $"{num10:f2}";
		}
		else
		{
			double num11 = num9 * num4 / 100.0;
			((Control)label41).Text = $"{num11:f2}";
			num10 = num9 - num11;
			((Control)label43).Text = $"{num10:f2}";
		}
		if (!((CheckBox)metroCheckBox7).Checked)
		{
			((Control)metroTextBox7).Text = num10.ToString();
		}
	}

	private void CalculateBillTotal()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		double num = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid2).Rows.Count; i++)
		{
			num += double.Parse(((DataGridView)metroGrid2).Rows[i].Cells[4].Value.ToString());
		}
		((Control)label4).Text = $"{num:f2}";
		double num2 = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
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
						num2 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num3 = 0.0;
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from tax where name='" + ((Control)metroComboBox14).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num3 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num4 = 0.0;
		double num5 = 0.0;
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
						if (((DbDataReader)(object)val3)[4].ToString() == "Fixed")
						{
							num5 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
						}
						else
						{
							num4 = double.Parse(((DbDataReader)(object)val3)[2].ToString());
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
		double num6 = num * num2 / 100.0;
		double num7 = num * num3 / 100.0;
		((Control)label46).Text = $"{num7:f2}";
		if (((CheckBox)metroCheckBox2).Checked)
		{
			((Control)label9).Text = $"{num6:f2}";
			((Control)label6).Text = "0.00";
			((Control)label8).Text = "0.00";
		}
		else
		{
			((Control)label9).Text = "0.00";
			((Control)label6).Text = $"{num6 / 2.0:f2}";
			((Control)label8).Text = $"{num6 / 2.0:f2}";
		}
		double num8 = num + num6;
		((Control)label11).Text = $"{num8:f2}";
		double num9 = num8 + num7;
		((Control)label47).Text = $"{num9:f2}";
		double num10 = 0.0;
		if (num5 != 0.0)
		{
			((Control)label14).Text = $"{num5:f2}";
			num10 = num9 - num5;
			((Control)label15).Text = $"{num10:f2}";
		}
		else
		{
			double num11 = num9 * num4 / 100.0;
			((Control)label14).Text = $"{num11:f2}";
			num10 = num9 - num11;
			((Control)label15).Text = $"{num10:f2}";
		}
		if (!((CheckBox)metroCheckBox5).Checked)
		{
			((Control)metroTextBox5).Text = num10.ToString();
		}
	}

	private void groupBox3_Enter(object sender, EventArgs e)
	{
	}

	private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateBillTotal();
	}

	private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateBillTotal();
	}

	private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		CalculateBillTotal();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		Delete_Bill();
	}

	private void Delete_Bill()
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between I4 and Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between I4 and Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between I4 and Unknown
		if (((Control)metroComboBox1).Text != "")
		{
			if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete all items from bill?", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32))
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "delete from temp_KOT where tablename='" + ((Control)metroComboBox1).Text + "' and iskot='No'";
						((DbCommand)(object)val2).ExecuteNonQuery();
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Your Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Print_Bill();
	}

	private void Print_Bill()
	{
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Invalid comparison between I4 and Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between I4 and Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between I4 and Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between I4 and Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between I4 and Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between I4 and Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Invalid comparison between I4 and Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Invalid comparison between I4 and Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Invalid comparison between I4 and Unknown
		if (((DataGridView)metroGrid2).Rows.Count > 0)
		{
			if (((Control)metroComboBox2).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Waiter Name", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroTextBox2).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Customer Name", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox4).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Tax", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox5).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Discount", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox6).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Payment Type", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((CheckBox)metroCheckBox5).Checked && !isuserAvaliable(((Control)metroTextBox2).Text))
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Customer Not Avaliable to Leave Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (!(((Control)metroTextBox5).Text == "") && new RegualarExpress().doublevalue(((Control)metroTextBox5).Text))
			{
				CalculateBillTotal();
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
						((DbCommand)(object)val2).CommandText = "r_invoice_proc";
						((DbParameter)(object)val2.Parameters.Add("@waitername", SqlDbType.VarChar)).Value = ((Control)metroComboBox2).Text;
						((DbParameter)(object)val2.Parameters.Add("@customername", SqlDbType.VarChar)).Value = ((Control)metroTextBox2).Text;
						((DbParameter)(object)val2.Parameters.Add("@total", SqlDbType.VarChar)).Value = ((Control)label4).Text;
						((DbParameter)(object)val2.Parameters.Add("@selectedtax", SqlDbType.VarChar)).Value = ((Control)metroComboBox4).Text;
						((DbParameter)(object)val2.Parameters.Add("@isigst", SqlDbType.VarChar)).Value = (((CheckBox)metroCheckBox2).Checked ? "Yes" : "No");
						((DbParameter)(object)val2.Parameters.Add("@igst", SqlDbType.VarChar)).Value = ((Control)label9).Text;
						((DbParameter)(object)val2.Parameters.Add("@cgst", SqlDbType.VarChar)).Value = ((Control)label6).Text;
						((DbParameter)(object)val2.Parameters.Add("@sgst", SqlDbType.VarChar)).Value = ((Control)label8).Text;
						((DbParameter)(object)val2.Parameters.Add("@totalwithtax", SqlDbType.VarChar)).Value = ((Control)label11).Text;
						((DbParameter)(object)val2.Parameters.Add("@discounttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox5).Text;
						((DbParameter)(object)val2.Parameters.Add("@discountamt", SqlDbType.VarChar)).Value = ((Control)label14).Text;
						((DbParameter)(object)val2.Parameters.Add("@grandtotal", SqlDbType.VarChar)).Value = ((Control)label15).Text;
						((DbParameter)(object)val2.Parameters.Add("@paymenttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox6).Text;
						((DbParameter)(object)val2.Parameters.Add("@tablename", SqlDbType.VarChar)).Value = ((Control)metroComboBox1).Text;
						((DbParameter)(object)val2.Parameters.Add("@mydate", SqlDbType.VarChar)).Value = DateTime.Now.ToString();
						((DbParameter)(object)val2.Parameters.Add("@inwords", SqlDbType.VarChar)).Value = new inwords().changeToWords(((Control)label15).Text);
						string value = $"{double.Parse(((Control)metroTextBox5).Text):f2}".ToString();
						string value2 = $"{double.Parse(RemainingAmt(((Control)label15).Text, ((Control)metroTextBox5).Text)):f2}".ToString();
						((DbParameter)(object)val2.Parameters.Add("@paidamt", SqlDbType.VarChar)).Value = value;
						((DbParameter)(object)val2.Parameters.Add("@remainingamt", SqlDbType.VarChar)).Value = value2;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_s", SqlDbType.VarChar)).Value = ((Control)metroComboBox14).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_amt", SqlDbType.VarChar)).Value = ((Control)label46).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_tot", SqlDbType.VarChar)).Value = ((Control)label47).Text;
						((DbParameter)(object)val2.Parameters.Add("@id", SqlDbType.VarChar, 50)).Direction = ParameterDirection.Output;
						((DbCommand)(object)val2).ExecuteNonQuery();
						string text = ((DbParameter)(object)val2.Parameters["@id"]).Value.ToString();
						UPDATE_CUSTOMER_BALANCE(RemainingAmt(((Control)label15).Text, ((Control)metroTextBox5).Text), ((Control)metroTextBox5).Text, ((Control)metroTextBox2).Text, text, "Dine In");
						SqlConnection val3;
						for (int i = 0; i < ((DataGridView)metroGrid2).Rows.Count; i++)
						{
							val3 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val4 = new SqlCommand();
								try
								{
									val4.Connection = val3;
									((DbConnection)(object)val3).Open();
									new UpdateRawItem(((DataGridView)metroGrid2).Rows[i].Cells[1].Value.ToString(), ((DataGridView)metroGrid2).Rows[i].Cells[2].Value.ToString());
									((DbCommand)(object)val4).CommandText = "insert into r_invoice_detail(invoice_id,itemname,qty,price,total) values('" + text + "','" + ((DataGridView)metroGrid2).Rows[i].Cells[1].Value.ToString() + "','" + ((DataGridView)metroGrid2).Rows[i].Cells[2].Value.ToString() + "','" + ((DataGridView)metroGrid2).Rows[i].Cells[3].Value.ToString() + "','" + ((DataGridView)metroGrid2).Rows[i].Cells[4].Value.ToString() + "')";
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
						((DbConnection)(object)val).Close();
						val3 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
						try
						{
							SqlCommand val4 = new SqlCommand();
							try
							{
								val4.Connection = val3;
								((DbConnection)(object)val3).Open();
								((DbCommand)(object)val4).CommandText = "delete from temp_KOT where tablename='" + ((Control)metroComboBox1).Text + "'";
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
						ResetAllDineIn();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Invoice Created Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
							((Control)new PRINT_INVOICE(text)).Show();
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
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Valid Paid Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "No Items to print", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void UPDATE_CUSTOMER_BALANCE(string remaining_amt, string paidamt, string customer_name, string billno, string from)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		double num = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_customer where name='" + customer_name + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						num = double.Parse(((DbDataReader)(object)val3)["balance"].ToString());
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "update r_customer set balance='" + $"{num + double.Parse(remaining_amt):f2}" + "' where name='" + customer_name + "'";
				((DbCommand)(object)val2).ExecuteNonQuery();
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				string text = from + " Bill No: " + billno + " " + customer_name + " Paid :" + $"{double.Parse(paidamt):f2}" + " And Remaining Amt :" + $"{double.Parse(remaining_amt):f2}" + " On Dated : " + DateTime.Now.ToShortDateString();
				((DbCommand)(object)val2).CommandText = "insert into r_customer_transaction(customer_name,note,mydate) values('" + customer_name + "','" + text + "','" + DateTime.Now.ToString() + "')";
				((DbCommand)(object)val2).ExecuteNonQuery();
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

	private string RemainingAmt(string total, string paid)
	{
		return (double.Parse(total) - double.Parse(paid)).ToString();
	}

	private bool isuserAvaliable(string name)
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
				((DbCommand)(object)val2).CommandText = "select * from r_customer where name='" + name + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					return true;
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
		return false;
	}

	private void ResetAllDineIn()
	{
		((ListControl)metroComboBox2).SelectedIndex = 0;
		((Control)metroTextBox2).Text = "Default";
		((ListControl)metroComboBox4).SelectedIndex = 0;
		((ListControl)metroComboBox5).SelectedIndex = 0;
		((ListControl)metroComboBox6).SelectedIndex = 0;
		((CheckBox)metroCheckBox5).Checked = false;
		((Control)metroTextBox5).Text = "";
		((CheckBox)metroCheckBox1).Checked = false;
		BindKOT_TABLE();
		BindBILL_TABLE();
	}

	private void metroGrid3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		string itemname = ((DataGridView)metroGrid3).SelectedRows[0].Cells[0].Value.ToString();
		string s = ((DataGridView)metroGrid3).SelectedRows[0].Cells[1].Value.ToString();
		Q_Dialog q_Dialog = new Q_Dialog(s);
		try
		{
			if ((int)((Form)q_Dialog).ShowDialog() == 1 && q_Dialog.seletedText != null && new RegualarExpress().doublevalue(q_Dialog.seletedText))
			{
				((DataGridView)metroGrid3).Rows.Remove(((DataGridView)metroGrid3).SelectedRows[0]);
				ADD_TAKEAWAY(itemname, q_Dialog.seletedText);
			}
		}
		finally
		{
			((IDisposable)q_Dialog)?.Dispose();
		}
	}

	private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
	}

	private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
	}

	private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
	}

	private void metroComboBox8_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Delete_TakeAway();
	}

	private void Delete_TakeAway()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between I4 and Unknown
		if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete all items in TakeAway", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			((DataGridView)metroGrid3).Rows.Clear();
			CalculateTakeAwayTotal();
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		Print_TakeAway();
	}

	private void Print_TakeAway()
	{
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Invalid comparison between I4 and Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between I4 and Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between I4 and Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between I4 and Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between I4 and Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Invalid comparison between I4 and Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Invalid comparison between I4 and Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Invalid comparison between I4 and Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		if (((DataGridView)metroGrid3).Rows.Count > 0)
		{
			if (((Control)metroComboBox3).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Tax Type", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox7).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Discount Type", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox8).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Payment Type", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroTextBox3).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Customer Name", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((CheckBox)metroCheckBox6).Checked && !isuserAvaliable(((Control)metroTextBox3).Text))
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Customer Not Avaliable to Leave Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (!(((Control)metroTextBox6).Text == "") && new RegualarExpress().doublevalue(((Control)metroTextBox6).Text))
			{
				CalculateTakeAwayTotal();
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
						((DbCommand)(object)val2).CommandText = "r_takeaway";
						((DbParameter)(object)val2.Parameters.Add("@customername", SqlDbType.VarChar)).Value = ((Control)metroTextBox3).Text;
						((DbParameter)(object)val2.Parameters.Add("@total", SqlDbType.VarChar)).Value = ((Control)label18).Text;
						((DbParameter)(object)val2.Parameters.Add("@selectedtax", SqlDbType.VarChar)).Value = ((Control)metroComboBox3).Text;
						((DbParameter)(object)val2.Parameters.Add("@isigst", SqlDbType.VarChar)).Value = (((CheckBox)metroCheckBox3).Checked ? "Yes" : "No");
						((DbParameter)(object)val2.Parameters.Add("@igst", SqlDbType.VarChar)).Value = ((Control)label20).Text;
						((DbParameter)(object)val2.Parameters.Add("@cgst", SqlDbType.VarChar)).Value = ((Control)label23).Text;
						((DbParameter)(object)val2.Parameters.Add("@sgst", SqlDbType.VarChar)).Value = ((Control)label21).Text;
						((DbParameter)(object)val2.Parameters.Add("@totalwithtax", SqlDbType.VarChar)).Value = ((Control)label25).Text;
						((DbParameter)(object)val2.Parameters.Add("@discounttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox7).Text;
						((DbParameter)(object)val2.Parameters.Add("@discountamt", SqlDbType.VarChar)).Value = ((Control)label27).Text;
						((DbParameter)(object)val2.Parameters.Add("@grandtotal", SqlDbType.VarChar)).Value = ((Control)label29).Text;
						((DbParameter)(object)val2.Parameters.Add("@paymenttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox8).Text;
						((DbParameter)(object)val2.Parameters.Add("@mydate", SqlDbType.VarChar)).Value = DateTime.Now.ToString();
						((DbParameter)(object)val2.Parameters.Add("@inwords", SqlDbType.VarChar)).Value = new inwords().changeToWords(((Control)label29).Text);
						string value = $"{double.Parse(((Control)metroTextBox6).Text):f2}".ToString();
						string value2 = $"{double.Parse(RemainingAmt(((Control)label29).Text, ((Control)metroTextBox6).Text)):f2}".ToString();
						((DbParameter)(object)val2.Parameters.Add("@paidamt", SqlDbType.VarChar)).Value = value;
						((DbParameter)(object)val2.Parameters.Add("@remainingamt", SqlDbType.VarChar)).Value = value2;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_s", SqlDbType.VarChar)).Value = ((Control)metroComboBox16).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_amt", SqlDbType.VarChar)).Value = ((Control)label48).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_tot", SqlDbType.VarChar)).Value = ((Control)label49).Text;
						((DbParameter)(object)val2.Parameters.Add("@id", SqlDbType.VarChar, 50)).Direction = ParameterDirection.Output;
						((DbCommand)(object)val2).ExecuteNonQuery();
						string text = ((DbParameter)(object)val2.Parameters["@id"]).Value.ToString();
						UPDATE_CUSTOMER_BALANCE(RemainingAmt(((Control)label29).Text, ((Control)metroTextBox6).Text), ((Control)metroTextBox6).Text, ((Control)metroTextBox3).Text, text, "Takeaway");
						for (int i = 0; i < ((DataGridView)metroGrid3).Rows.Count; i++)
						{
							SqlConnection val3 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val4 = new SqlCommand();
								try
								{
									val4.Connection = val3;
									((DbConnection)(object)val3).Open();
									new UpdateRawItem(((DataGridView)metroGrid3).Rows[i].Cells[0].Value.ToString(), ((DataGridView)metroGrid3).Rows[i].Cells[1].Value.ToString());
									((DbCommand)(object)val4).CommandText = "insert into r_takeaway_detail(invoice_id,itemname,qty,price,total) values('" + text + "','" + ((DataGridView)metroGrid3).Rows[i].Cells[0].Value.ToString() + "','" + ((DataGridView)metroGrid3).Rows[i].Cells[1].Value.ToString() + "','" + ((DataGridView)metroGrid3).Rows[i].Cells[2].Value.ToString() + "','" + ((DataGridView)metroGrid3).Rows[i].Cells[3].Value.ToString() + "')";
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
						((DbConnection)(object)val).Close();
						((DataGridView)metroGrid3).Rows.Clear();
						ResetTakaway();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Invoice Created Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
							((Control)new Print_TakeAway(text)).Show();
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
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Valid Paid Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "No Items to print", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void ResetTakaway()
	{
		((ListControl)metroComboBox3).SelectedIndex = 0;
		((ListControl)metroComboBox7).SelectedIndex = 0;
		((ListControl)metroComboBox8).SelectedIndex = 0;
		((Control)metroTextBox3).Text = "Default";
		((Control)metroTextBox6).Text = "";
		((CheckBox)metroCheckBox6).Checked = false;
		((CheckBox)metroCheckBox3).Checked = false;
	}

	private void metroGrid3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).Button == 2097152)
		{
			Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
			((ToolStripDropDown)contextMenuStrip2).Show(point);
		}
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between I4 and Unknown
		string text = ((DataGridView)metroGrid3).SelectedRows[0].Cells[0].Value.ToString();
		if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete " + text + " From TakeAway", "Error", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			((DataGridView)metroGrid3).Rows.Remove(((DataGridView)metroGrid3).SelectedRows[0]);
			CalculateTakeAwayTotal();
		}
		else
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroComboBox9_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateHomeTotal();
	}

	private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
	{
		CalculateHomeTotal();
	}

	private void metroComboBox10_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateHomeTotal();
	}

	private void metroGrid4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		string itemname = ((DataGridView)metroGrid4).SelectedRows[0].Cells[0].Value.ToString();
		string s = ((DataGridView)metroGrid4).SelectedRows[0].Cells[1].Value.ToString();
		Q_Dialog q_Dialog = new Q_Dialog(s);
		try
		{
			if ((int)((Form)q_Dialog).ShowDialog() == 1 && q_Dialog.seletedText != null && new RegualarExpress().doublevalue(q_Dialog.seletedText))
			{
				((DataGridView)metroGrid4).Rows.Remove(((DataGridView)metroGrid4).SelectedRows[0]);
				ADD_HOMEDELIVERY(itemname, q_Dialog.seletedText);
			}
		}
		finally
		{
			((IDisposable)q_Dialog)?.Dispose();
		}
	}

	private void metroGrid4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((MouseEventArgs)e).Button == 2097152)
		{
			Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
			((ToolStripDropDown)contextMenuStrip3).Show(point);
		}
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between I4 and Unknown
		string text = ((DataGridView)metroGrid4).SelectedRows[0].Cells[0].Value.ToString();
		if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete " + text + " From TakeAway", "Error", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			((DataGridView)metroGrid4).Rows.Remove(((DataGridView)metroGrid4).SelectedRows[0]);
			CalculateHomeTotal();
		}
		else
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button8_Click(object sender, EventArgs e)
	{
		Delete_HomeDelivery();
	}

	private void Delete_HomeDelivery()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between I4 and Unknown
		if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete all items in Home Delivery", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32))
		{
			((DataGridView)metroGrid4).Rows.Clear();
			CalculateHomeTotal();
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		Print_HomeDelivery();
	}

	private void Print_HomeDelivery()
	{
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Invalid comparison between I4 and Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between I4 and Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between I4 and Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between I4 and Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Invalid comparison between I4 and Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between I4 and Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Invalid comparison between I4 and Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Invalid comparison between I4 and Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Invalid comparison between I4 and Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Invalid comparison between I4 and Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		if (((DataGridView)metroGrid4).Rows.Count > 0)
		{
			if (((Control)metroComboBox9).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Tax", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox10).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Discount", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox11).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Payment Type", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroTextBox4).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Customer Name", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox12).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Delivery Boy", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((Control)metroComboBox13).Text == "")
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Order From", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (((CheckBox)metroCheckBox7).Checked && !isuserAvaliable(((Control)metroTextBox4).Text))
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Customer Not Avaliable to Leave Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
			if (!(((Control)metroTextBox7).Text == "") && new RegualarExpress().doublevalue(((Control)metroTextBox7).Text))
			{
				CalculateHomeTotal();
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
						((DbCommand)(object)val2).CommandText = "r_home_proc";
						((DbParameter)(object)val2.Parameters.Add("@waitername", SqlDbType.VarChar)).Value = ((Control)metroComboBox12).Text;
						((DbParameter)(object)val2.Parameters.Add("@customername", SqlDbType.VarChar)).Value = ((Control)metroTextBox4).Text;
						((DbParameter)(object)val2.Parameters.Add("@total", SqlDbType.VarChar)).Value = ((Control)label31).Text;
						((DbParameter)(object)val2.Parameters.Add("@selectedtax", SqlDbType.VarChar)).Value = ((Control)metroComboBox9).Text;
						((DbParameter)(object)val2.Parameters.Add("@isigst", SqlDbType.VarChar)).Value = (((CheckBox)metroCheckBox4).Checked ? "Yes" : "No");
						((DbParameter)(object)val2.Parameters.Add("@igst", SqlDbType.VarChar)).Value = ((Control)label36).Text;
						((DbParameter)(object)val2.Parameters.Add("@cgst", SqlDbType.VarChar)).Value = ((Control)label37).Text;
						((DbParameter)(object)val2.Parameters.Add("@sgst", SqlDbType.VarChar)).Value = ((Control)label34).Text;
						((DbParameter)(object)val2.Parameters.Add("@totalwithtax", SqlDbType.VarChar)).Value = ((Control)label39).Text;
						((DbParameter)(object)val2.Parameters.Add("@discounttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox10).Text;
						((DbParameter)(object)val2.Parameters.Add("@discountamt", SqlDbType.VarChar)).Value = ((Control)label41).Text;
						((DbParameter)(object)val2.Parameters.Add("@grandtotal", SqlDbType.VarChar)).Value = ((Control)label43).Text;
						((DbParameter)(object)val2.Parameters.Add("@paymenttype", SqlDbType.VarChar)).Value = ((Control)metroComboBox11).Text;
						((DbParameter)(object)val2.Parameters.Add("@mydate", SqlDbType.VarChar)).Value = DateTime.Now.ToString();
						((DbParameter)(object)val2.Parameters.Add("@inwords", SqlDbType.VarChar)).Value = new inwords().changeToWords(((Control)label43).Text);
						string value = $"{double.Parse(((Control)metroTextBox7).Text):f2}".ToString();
						string value2 = $"{double.Parse(RemainingAmt(((Control)label43).Text, ((Control)metroTextBox7).Text)):f2}".ToString();
						((DbParameter)(object)val2.Parameters.Add("@paidamt", SqlDbType.VarChar)).Value = value;
						((DbParameter)(object)val2.Parameters.Add("@remainingamt", SqlDbType.VarChar)).Value = value2;
						((DbParameter)(object)val2.Parameters.Add("@orderfrom", SqlDbType.VarChar)).Value = ((Control)metroComboBox13).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_s", SqlDbType.VarChar)).Value = ((Control)metroComboBox15).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_amt", SqlDbType.VarChar)).Value = ((Control)label50).Text;
						((DbParameter)(object)val2.Parameters.Add("@extra_tax_tot", SqlDbType.VarChar)).Value = ((Control)label51).Text;
						((DbParameter)(object)val2.Parameters.Add("@id", SqlDbType.VarChar, 50)).Direction = ParameterDirection.Output;
						((DbCommand)(object)val2).ExecuteNonQuery();
						string text = ((DbParameter)(object)val2.Parameters["@id"]).Value.ToString();
						UPDATE_CUSTOMER_BALANCE(RemainingAmt(((Control)label43).Text, ((Control)metroTextBox7).Text), ((Control)metroTextBox7).Text, ((Control)metroTextBox4).Text, text, "HomeDelivery");
						for (int i = 0; i < ((DataGridView)metroGrid4).Rows.Count; i++)
						{
							SqlConnection val3 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
							try
							{
								SqlCommand val4 = new SqlCommand();
								try
								{
									val4.Connection = val3;
									((DbConnection)(object)val3).Open();
									new UpdateRawItem(((DataGridView)metroGrid4).Rows[i].Cells[0].Value.ToString(), ((DataGridView)metroGrid4).Rows[i].Cells[1].Value.ToString());
									((DbCommand)(object)val4).CommandText = "insert into r_invoice_home_detail(invoice_id,itemname,qty,price,total) values('" + text + "','" + ((DataGridView)metroGrid4).Rows[i].Cells[0].Value.ToString() + "','" + ((DataGridView)metroGrid4).Rows[i].Cells[1].Value.ToString() + "','" + ((DataGridView)metroGrid4).Rows[i].Cells[2].Value.ToString() + "','" + ((DataGridView)metroGrid4).Rows[i].Cells[3].Value.ToString() + "')";
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
						((DbConnection)(object)val).Close();
						((DataGridView)metroGrid4).Rows.Clear();
						ResetHomeDelivery();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Invoice Created Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
							((Control)new Print_HomeDelivery(text)).Show();
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
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Valid Paid Amt", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Add items in table to print", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void ResetHomeDelivery()
	{
		((DataGridView)metroGrid4).Rows.Clear();
		MetroComboBox obj = metroComboBox9;
		int selectedIndex = (((ListControl)metroComboBox10).SelectedIndex = 0);
		((ListControl)obj).SelectedIndex = selectedIndex;
		((ListControl)metroComboBox12).SelectedIndex = 0;
		((Control)metroTextBox4).Text = "Default";
		((Control)metroTextBox7).Text = "";
		((CheckBox)metroCheckBox7).Checked = false;
		((CheckBox)metroCheckBox4).Checked = false;
		((ListControl)metroComboBox13).SelectedIndex = 0;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected I4, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData <= 131152)
		{
			switch (keyData - 131121)
			{
			case 0:
				((TabControl)metroTabControl1).SelectedIndex = 0;
				return true;
			case 1:
				((TabControl)metroTabControl1).SelectedIndex = 1;
				return true;
			case 2:
				((TabControl)metroTabControl1).SelectedIndex = 2;
				return true;
			}
			switch (keyData - 131140)
			{
			default:
				if ((int)keyData != 131152)
				{
					break;
				}
				switch (((TabControl)metroTabControl1).SelectedIndex)
				{
				case 0:
					switch (((TabControl)metroTabControl2).SelectedIndex)
					{
					case 0:
						Print_KOT();
						break;
					case 1:
						Print_Bill();
						break;
					}
					break;
				case 1:
					Print_TakeAway();
					break;
				case 2:
					Print_HomeDelivery();
					break;
				}
				return true;
			case 1:
				if (((CheckBox)metroCheckBox1).Checked)
				{
					((CheckBox)metroCheckBox1).Checked = false;
					((Control)metroTextBox1).Focus();
				}
				else
				{
					((CheckBox)metroCheckBox1).Checked = true;
					((Control)metroTextBox1).Focus();
				}
				break;
			case 0:
				switch (((TabControl)metroTabControl1).SelectedIndex)
				{
				case 0:
					switch (((TabControl)metroTabControl2).SelectedIndex)
					{
					case 0:
						Delete_KOT();
						break;
					case 1:
						Delete_Bill();
						break;
					}
					break;
				case 1:
					Delete_TakeAway();
					break;
				case 2:
					Delete_HomeDelivery();
					break;
				}
				return true;
			}
		}
		else
		{
			if ((int)keyData == 131155)
			{
				if (((TabControl)metroTabControl1).SelectedIndex == 0 && ((TabControl)metroTabControl2).SelectedIndex == 0)
				{
					Save_KOT();
				}
				return true;
			}
			switch (keyData - 262193)
			{
			case 0:
				((TabControl)metroTabControl1).SelectedIndex = 0;
				((TabControl)metroTabControl2).SelectedIndex = 0;
				return true;
			case 1:
				((TabControl)metroTabControl1).SelectedIndex = 0;
				((TabControl)metroTabControl2).SelectedIndex = 1;
				return true;
			}
			if ((int)keyData == 262232)
			{
				((Control)MainFrom.static_mainform).Focus();
				((Form)MainFrom.static_mainform).Activate();
				((Form)this).Close();
				return true;
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
	{
		CalculateBillTotal();
		if (((CheckBox)metroCheckBox5).Checked)
		{
			((Control)metroTextBox5).Text = "";
			((Control)metroTextBox5).Visible = true;
		}
		else
		{
			((Control)metroTextBox5).Visible = false;
		}
	}

	private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
		if (((CheckBox)metroCheckBox6).Checked)
		{
			((Control)metroTextBox6).Text = "";
			((Control)metroTextBox6).Visible = true;
		}
		else
		{
			((Control)metroTextBox6).Visible = false;
		}
	}

	private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
	{
		CalculateHomeTotal();
		if (((CheckBox)metroCheckBox7).Checked)
		{
			((Control)metroTextBox7).Text = "";
			((Control)metroTextBox7).Visible = true;
		}
		else
		{
			((Control)metroTextBox7).Visible = false;
		}
	}

	private void Order_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)MainFrom.static_mainform).Focus();
		((Form)MainFrom.static_mainform).Activate();
	}

	private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void groupBox4_Enter(object sender, EventArgs e)
	{
	}

	private void metroComboBox14_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateBillTotal();
	}

	private void metroComboBox16_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateTakeAwayTotal();
	}

	private void metroComboBox15_SelectedIndexChanged(object sender, EventArgs e)
	{
		CalculateHomeTotal();
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
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Expected O, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Expected O, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Expected O, but got Unknown
		//IL_11e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Expected O, but got Unknown
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e7: Expected O, but got Unknown
		//IL_155b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Expected O, but got Unknown
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected O, but got Unknown
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected O, but got Unknown
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1808: Expected O, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_188b: Expected O, but got Unknown
		//IL_1919: Unknown result type (might be due to invalid IL or missing references)
		//IL_1923: Expected O, but got Unknown
		//IL_19d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e3: Expected O, but got Unknown
		//IL_19f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fb: Expected O, but got Unknown
		//IL_1a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a13: Expected O, but got Unknown
		//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Expected O, but got Unknown
		//IL_2044: Unknown result type (might be due to invalid IL or missing references)
		//IL_204e: Expected O, but got Unknown
		//IL_2422: Unknown result type (might be due to invalid IL or missing references)
		//IL_242c: Expected O, but got Unknown
		//IL_25c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d3: Expected O, but got Unknown
		//IL_26c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d1: Expected O, but got Unknown
		//IL_284c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2856: Expected O, but got Unknown
		//IL_28e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ee: Expected O, but got Unknown
		//IL_2b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba6: Expected O, but got Unknown
		//IL_2c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c3d: Expected O, but got Unknown
		//IL_3118: Unknown result type (might be due to invalid IL or missing references)
		//IL_3122: Expected O, but got Unknown
		//IL_31af: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b9: Expected O, but got Unknown
		//IL_32cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d6: Expected O, but got Unknown
		//IL_33bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c9: Expected O, but got Unknown
		//IL_3447: Unknown result type (might be due to invalid IL or missing references)
		//IL_3451: Expected O, but got Unknown
		//IL_34e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ec: Expected O, but got Unknown
		//IL_3a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a13: Expected O, but got Unknown
		//IL_3dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df6: Expected O, but got Unknown
		//IL_40ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b7: Expected O, but got Unknown
		//IL_40f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4101: Expected O, but got Unknown
		//IL_41f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ff: Expected O, but got Unknown
		//IL_445d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4467: Expected O, but got Unknown
		//IL_44f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_44fc: Expected O, but got Unknown
		//IL_47b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_47bf: Expected O, but got Unknown
		//IL_4849: Unknown result type (might be due to invalid IL or missing references)
		//IL_4853: Expected O, but got Unknown
		//IL_4e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e8d: Expected O, but got Unknown
		//IL_4f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f21: Expected O, but got Unknown
		//IL_5033: Unknown result type (might be due to invalid IL or missing references)
		//IL_503d: Expected O, but got Unknown
		//IL_511e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5128: Expected O, but got Unknown
		//IL_51a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_51ad: Expected O, but got Unknown
		//IL_523a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5244: Expected O, but got Unknown
		//IL_5309: Unknown result type (might be due to invalid IL or missing references)
		//IL_5313: Expected O, but got Unknown
		//IL_5321: Unknown result type (might be due to invalid IL or missing references)
		//IL_532b: Expected O, but got Unknown
		//IL_56e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_56f0: Expected O, but got Unknown
		//IL_5b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b82: Expected O, but got Unknown
		//IL_5c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c68: Expected O, but got Unknown
		//IL_5d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d67: Expected O, but got Unknown
		//IL_60fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_6108: Expected O, but got Unknown
		//IL_629c: Unknown result type (might be due to invalid IL or missing references)
		//IL_62a6: Expected O, but got Unknown
		//IL_6331: Unknown result type (might be due to invalid IL or missing references)
		//IL_633b: Expected O, but got Unknown
		//IL_65f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_6601: Expected O, but got Unknown
		//IL_668b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6695: Expected O, but got Unknown
		//IL_6cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cd3: Expected O, but got Unknown
		//IL_6d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d67: Expected O, but got Unknown
		//IL_6e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e84: Expected O, but got Unknown
		//IL_6f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f73: Expected O, but got Unknown
		//IL_6ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ffc: Expected O, but got Unknown
		//IL_708a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7094: Expected O, but got Unknown
		//IL_715d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7167: Expected O, but got Unknown
		//IL_7175: Unknown result type (might be due to invalid IL or missing references)
		//IL_717f: Expected O, but got Unknown
		//IL_72d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_72df: Expected O, but got Unknown
		//IL_738d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7397: Expected O, but got Unknown
		//IL_7445: Unknown result type (might be due to invalid IL or missing references)
		//IL_744f: Expected O, but got Unknown
		//IL_757c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7586: Expected O, but got Unknown
		//IL_759b: Unknown result type (might be due to invalid IL or missing references)
		//IL_75a5: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		DataGridViewCellStyle val7 = new DataGridViewCellStyle();
		DataGridViewCellStyle val8 = new DataGridViewCellStyle();
		DataGridViewCellStyle val9 = new DataGridViewCellStyle();
		DataGridViewCellStyle val10 = new DataGridViewCellStyle();
		DataGridViewCellStyle val11 = new DataGridViewCellStyle();
		DataGridViewCellStyle val12 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Order));
		metroComboBox1 = new MetroComboBox();
		groupBox1 = new GroupBox();
		label45 = new Label();
		flowLayoutPanel1 = new FlowLayoutPanel();
		metroTextBox1 = new MetroTextBox();
		metroCheckBox1 = new MetroCheckBox();
		metroTabControl1 = new MetroTabControl();
		metroTabPage1 = new MetroTabPage();
		metroTabControl2 = new MetroTabControl();
		tabPage1 = new TabPage();
		groupBox2 = new GroupBox();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		panel1 = new Panel();
		label2 = new Label();
		label1 = new Label();
		metroGrid1 = new MetroGrid();
		Column5 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		tabPage2 = new TabPage();
		metroTextBox2 = new MetroTextBox();
		groupBox3 = new GroupBox();
		label47 = new Label();
		label46 = new Label();
		metroComboBox14 = new MetroComboBox();
		metroTextBox5 = new MetroTextBox();
		metroCheckBox5 = new MetroCheckBox();
		metroComboBox6 = new MetroComboBox();
		button5 = new Button();
		button4 = new Button();
		panel4 = new Panel();
		label15 = new Label();
		label16 = new Label();
		label14 = new Label();
		label13 = new Label();
		metroComboBox5 = new MetroComboBox();
		panel3 = new Panel();
		label11 = new Label();
		label12 = new Label();
		label9 = new Label();
		label10 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		metroCheckBox2 = new MetroCheckBox();
		metroComboBox4 = new MetroComboBox();
		panel2 = new Panel();
		label4 = new Label();
		label3 = new Label();
		metroGrid2 = new MetroGrid();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		metroComboBox2 = new MetroComboBox();
		metroTabPage2 = new MetroTabPage();
		groupBox4 = new GroupBox();
		label49 = new Label();
		label48 = new Label();
		metroComboBox16 = new MetroComboBox();
		metroTextBox6 = new MetroTextBox();
		metroCheckBox6 = new MetroCheckBox();
		metroTextBox3 = new MetroTextBox();
		button6 = new Button();
		button7 = new Button();
		metroComboBox8 = new MetroComboBox();
		panel8 = new Panel();
		label29 = new Label();
		label30 = new Label();
		label27 = new Label();
		label28 = new Label();
		metroComboBox7 = new MetroComboBox();
		panel7 = new Panel();
		label25 = new Label();
		label26 = new Label();
		panel6 = new Panel();
		label19 = new Label();
		label23 = new Label();
		metroCheckBox3 = new MetroCheckBox();
		label24 = new Label();
		label20 = new Label();
		label21 = new Label();
		label22 = new Label();
		metroComboBox3 = new MetroComboBox();
		panel5 = new Panel();
		label18 = new Label();
		label17 = new Label();
		metroGrid3 = new MetroGrid();
		dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
		metroTabPage3 = new MetroTabPage();
		groupBox5 = new GroupBox();
		label51 = new Label();
		label50 = new Label();
		metroComboBox15 = new MetroComboBox();
		metroComboBox13 = new MetroComboBox();
		metroTextBox7 = new MetroTextBox();
		metroCheckBox7 = new MetroCheckBox();
		button8 = new Button();
		button9 = new Button();
		metroComboBox12 = new MetroComboBox();
		metroTextBox4 = new MetroTextBox();
		metroComboBox11 = new MetroComboBox();
		panel12 = new Panel();
		label43 = new Label();
		label44 = new Label();
		label41 = new Label();
		label42 = new Label();
		metroComboBox10 = new MetroComboBox();
		panel11 = new Panel();
		label39 = new Label();
		label40 = new Label();
		panel10 = new Panel();
		label33 = new Label();
		label34 = new Label();
		metroCheckBox4 = new MetroCheckBox();
		label35 = new Label();
		label36 = new Label();
		label37 = new Label();
		label38 = new Label();
		metroComboBox9 = new MetroComboBox();
		panel9 = new Panel();
		label31 = new Label();
		label32 = new Label();
		metroGrid4 = new MetroGrid();
		dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
		contextMenuStrip1 = new ContextMenuStrip(components);
		deleteToolStripMenuItem = new ToolStripMenuItem();
		contextMenuStrip2 = new ContextMenuStrip(components);
		toolStripMenuItem1 = new ToolStripMenuItem();
		contextMenuStrip3 = new ContextMenuStrip(components);
		toolStripMenuItem2 = new ToolStripMenuItem();
		flowLayoutPanel2 = new FlowLayoutPanel();
		((Control)groupBox1).SuspendLayout();
		((Control)metroTabControl1).SuspendLayout();
		((Control)metroTabPage1).SuspendLayout();
		((Control)metroTabControl2).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)tabPage2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)metroGrid2).BeginInit();
		((Control)metroTabPage2).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)panel8).SuspendLayout();
		((Control)panel7).SuspendLayout();
		((Control)panel6).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((ISupportInitialize)metroGrid3).BeginInit();
		((Control)metroTabPage3).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)panel12).SuspendLayout();
		((Control)panel11).SuspendLayout();
		((Control)panel10).SuspendLayout();
		((Control)panel9).SuspendLayout();
		((ISupportInitialize)metroGrid4).BeginInit();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)contextMenuStrip2).SuspendLayout();
		((Control)contextMenuStrip3).SuspendLayout();
		((Control)this).SuspendLayout();
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(7, 3);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Table";
		((Control)metroComboBox1).Size = new Size(373, 29);
		((Control)metroComboBox1).TabIndex = 1;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((Control)groupBox1).Anchor = (AnchorStyles)7;
		((Control)groupBox1).Controls.Add((Control)(object)label45);
		((Control)groupBox1).Controls.Add((Control)(object)flowLayoutPanel1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 101);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(641, 607);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Menu ";
		((Control)label45).AutoSize = true;
		((Control)label45).Location = new Point(23, 52);
		((Control)label45).Name = "label45";
		((Control)label45).Size = new Size(62, 18);
		((Control)label45).TabIndex = 4;
		((Control)label45).Text = "Menu : -";
		((Control)flowLayoutPanel1).Anchor = (AnchorStyles)7;
		((ScrollableControl)flowLayoutPanel1).AutoScroll = true;
		((Control)flowLayoutPanel1).Location = new Point(16, 76);
		((Control)flowLayoutPanel1).Name = "flowLayoutPanel1";
		((Control)flowLayoutPanel1).Size = new Size(608, 518);
		((Control)flowLayoutPanel1).TabIndex = 2;
		((Control)flowLayoutPanel1).Paint += new PaintEventHandler(flowLayoutPanel1_Paint);
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(418, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(164, 19);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Menu Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(446, 29);
		((Control)metroTextBox1).TabIndex = 1;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Menu Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
		((Control)metroTextBox1).KeyDown += new KeyEventHandler(metroTextBox1_KeyDown);
		((Control)metroTextBox1).KeyPress += new KeyPressEventHandler(metroTextBox1_KeyPress);
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(26, 23);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(120, 19);
		((Control)metroCheckBox1).TabIndex = 0;
		((Control)metroCheckBox1).Text = "Search By Code";
		metroCheckBox1.UseSelectable = true;
		((CheckBox)metroCheckBox1).CheckedChanged += metroCheckBox1_CheckedChanged;
		((Control)metroTabControl1).Anchor = (AnchorStyles)15;
		((TabControl)metroTabControl1).Appearance = (TabAppearance)2;
		((Control)metroTabControl1).Controls.Add((Control)(object)metroTabPage1);
		((Control)metroTabControl1).Controls.Add((Control)(object)metroTabPage2);
		((Control)metroTabControl1).Controls.Add((Control)(object)metroTabPage3);
		metroTabControl1.FontWeight = (MetroTabControlWeight)1;
		((TabControl)metroTabControl1).ItemSize = new Size(54, 34);
		((Control)metroTabControl1).Location = new Point(677, 78);
		((Control)metroTabControl1).Name = "metroTabControl1";
		((TabControl)metroTabControl1).SelectedIndex = 0;
		((Control)metroTabControl1).Size = new Size(597, 630);
		((Control)metroTabControl1).TabIndex = 2;
		metroTabControl1.TextAlign = (ContentAlignment)32;
		metroTabControl1.Theme = (MetroThemeStyle)2;
		metroTabControl1.UseSelectable = true;
		((TabControl)metroTabControl1).SelectedIndexChanged += metroTabControl1_SelectedIndexChanged;
		((Control)metroTabPage1).Controls.Add((Control)(object)metroTabControl2);
		((Control)metroTabPage1).Controls.Add((Control)(object)metroComboBox1);
		metroTabPage1.HorizontalScrollbarBarColor = true;
		metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
		metroTabPage1.HorizontalScrollbarSize = 10;
		((TabPage)metroTabPage1).Location = new Point(4, 38);
		((Control)metroTabPage1).Name = "metroTabPage1";
		((Control)metroTabPage1).Size = new Size(589, 588);
		((TabPage)metroTabPage1).TabIndex = 0;
		((Control)metroTabPage1).Text = "Dine In";
		metroTabPage1.VerticalScrollbarBarColor = true;
		metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
		metroTabPage1.VerticalScrollbarSize = 10;
		((Control)metroTabControl2).Anchor = (AnchorStyles)15;
		((Control)metroTabControl2).Controls.Add((Control)(object)tabPage1);
		((Control)metroTabControl2).Controls.Add((Control)(object)tabPage2);
		metroTabControl2.FontWeight = (MetroTabControlWeight)1;
		((Control)metroTabControl2).Location = new Point(3, 38);
		((Control)metroTabControl2).Name = "metroTabControl2";
		((TabControl)metroTabControl2).SelectedIndex = 1;
		((Control)metroTabControl2).Size = new Size(583, 547);
		metroTabControl2.Style = (MetroColorStyle)5;
		((Control)metroTabControl2).TabIndex = 2;
		metroTabControl2.UseSelectable = true;
		((Control)tabPage1).BackColor = Color.White;
		((Control)tabPage1).Controls.Add((Control)(object)groupBox2);
		((Control)tabPage1).Controls.Add((Control)(object)metroGrid1);
		((Control)tabPage1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		tabPage1.Location = new Point(4, 38);
		((Control)tabPage1).Name = "tabPage1";
		((Control)tabPage1).Size = new Size(575, 505);
		tabPage1.TabIndex = 0;
		((Control)tabPage1).Text = "KOT";
		((Control)groupBox2).Anchor = (AnchorStyles)15;
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button2);
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Controls.Add((Control)(object)panel1);
		((Control)groupBox2).Location = new Point(384, 13);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(188, 485);
		((Control)groupBox2).TabIndex = 1;
		groupBox2.TabStop = false;
		((Control)button3).Anchor = (AnchorStyles)13;
		((Control)button3).BackColor = Color.Red;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.delete;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(26, 162);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(135, 42);
		((Control)button3).TabIndex = 5;
		((Control)button3).Text = "     Delete (D)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button2).Anchor = (AnchorStyles)13;
		((Control)button2).BackColor = Color.DeepPink;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.printer;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(26, 114);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(135, 42);
		((Control)button2).TabIndex = 4;
		((Control)button2).Text = "   Print (P)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).Anchor = (AnchorStyles)13;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(26, 66);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(135, 42);
		((Control)button1).TabIndex = 3;
		((Control)button1).Text = "   Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)panel1).Anchor = (AnchorStyles)13;
		((Control)panel1).BackColor = Color.FromArgb(0, 174, 219);
		((Control)panel1).Controls.Add((Control)(object)label2);
		((Control)panel1).Controls.Add((Control)(object)label1);
		((Control)panel1).Location = new Point(5, 15);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(176, 37);
		((Control)panel1).TabIndex = 2;
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label2).ForeColor = Color.White;
		((Control)label2).Location = new Point(101, 9);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(17, 18);
		((Control)label2).TabIndex = 1;
		((Control)label2).Text = "0";
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(45, 9);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(56, 18);
		((Control)label1).TabIndex = 0;
		((Control)label1).Text = "Total :";
		((DataGridView)metroGrid1).AllowUserToAddRows = false;
		((DataGridView)metroGrid1).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid1).AllowUserToResizeRows = false;
		((Control)metroGrid1).Anchor = (AnchorStyles)7;
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
			(DataGridViewColumn)Column5,
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
		((Control)metroGrid1).Location = new Point(11, 12);
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
		((DataGridView)metroGrid1).RowHeadersVisible = false;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(362, 485);
		((Control)metroGrid1).TabIndex = 0;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridView)metroGrid1).CellDoubleClick += new DataGridViewCellEventHandler(metroGrid1_CellDoubleClick);
		((DataGridView)metroGrid1).CellMouseClick += new DataGridViewCellMouseEventHandler(metroGrid1_CellMouseClick);
		((DataGridViewColumn)Column5).HeaderText = "id";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewBand)Column5).Visible = false;
		((DataGridViewColumn)Column1).HeaderText = "Item Name";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Width = 150;
		((DataGridViewColumn)Column2).HeaderText = "Qty";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 70;
		((DataGridViewColumn)Column3).HeaderText = "Price";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 70;
		((DataGridViewColumn)Column4).HeaderText = "Amount";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column4).Width = 70;
		((Control)tabPage2).BackColor = Color.White;
		((Control)tabPage2).Controls.Add((Control)(object)metroTextBox2);
		((Control)tabPage2).Controls.Add((Control)(object)groupBox3);
		((Control)tabPage2).Controls.Add((Control)(object)metroGrid2);
		((Control)tabPage2).Controls.Add((Control)(object)metroComboBox2);
		tabPage2.Location = new Point(4, 38);
		((Control)tabPage2).Name = "tabPage2";
		((Control)tabPage2).Size = new Size(575, 505);
		tabPage2.TabIndex = 1;
		((Control)tabPage2).Text = "Bill";
		((Control)metroTextBox2).Anchor = (AnchorStyles)13;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(179, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[1] { "Default" };
		((Control)metroTextBox2).Location = new Point(365, 7);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Customer Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(207, 29);
		((Control)metroTextBox2).TabIndex = 2;
		((Control)metroTextBox2).Text = "Default";
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Customer Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).Anchor = (AnchorStyles)15;
		((Control)groupBox3).Controls.Add((Control)(object)label47);
		((Control)groupBox3).Controls.Add((Control)(object)label46);
		((Control)groupBox3).Controls.Add((Control)(object)metroComboBox14);
		((Control)groupBox3).Controls.Add((Control)(object)metroTextBox5);
		((Control)groupBox3).Controls.Add((Control)(object)metroCheckBox5);
		((Control)groupBox3).Controls.Add((Control)(object)metroComboBox6);
		((Control)groupBox3).Controls.Add((Control)(object)button5);
		((Control)groupBox3).Controls.Add((Control)(object)button4);
		((Control)groupBox3).Controls.Add((Control)(object)panel4);
		((Control)groupBox3).Controls.Add((Control)(object)label14);
		((Control)groupBox3).Controls.Add((Control)(object)label13);
		((Control)groupBox3).Controls.Add((Control)(object)metroComboBox5);
		((Control)groupBox3).Controls.Add((Control)(object)panel3);
		((Control)groupBox3).Controls.Add((Control)(object)label9);
		((Control)groupBox3).Controls.Add((Control)(object)label10);
		((Control)groupBox3).Controls.Add((Control)(object)label8);
		((Control)groupBox3).Controls.Add((Control)(object)label7);
		((Control)groupBox3).Controls.Add((Control)(object)label6);
		((Control)groupBox3).Controls.Add((Control)(object)label5);
		((Control)groupBox3).Controls.Add((Control)(object)metroCheckBox2);
		((Control)groupBox3).Controls.Add((Control)(object)metroComboBox4);
		((Control)groupBox3).Controls.Add((Control)(object)panel2);
		((Control)groupBox3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).Location = new Point(381, 35);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(191, 467);
		((Control)groupBox3).TabIndex = 4;
		groupBox3.TabStop = false;
		((Control)groupBox3).Enter += groupBox3_Enter;
		((Control)label47).AutoSize = true;
		((Control)label47).Location = new Point(164, 165);
		((Control)label47).Name = "label47";
		((Control)label47).Size = new Size(52, 18);
		((Control)label47).TabIndex = 15;
		((Control)label47).Text = "100.00";
		((Control)label46).AutoSize = true;
		((Control)label46).Location = new Point(111, 164);
		((Control)label46).Name = "label46";
		((Control)label46).Size = new Size(52, 18);
		((Control)label46).TabIndex = 14;
		((Control)label46).Text = "100.00";
		((ListControl)metroComboBox14).FormattingEnabled = true;
		((ComboBox)metroComboBox14).ItemHeight = 23;
		((Control)metroComboBox14).Location = new Point(15, 161);
		((Control)metroComboBox14).Name = "metroComboBox14";
		metroComboBox14.PromptText = "Other Tax";
		((Control)metroComboBox14).Size = new Size(90, 29);
		((Control)metroComboBox14).TabIndex = 13;
		metroComboBox14.UseSelectable = true;
		((ComboBox)metroComboBox14).SelectedIndexChanged += metroComboBox14_SelectedIndexChanged;
		((Control)metroTextBox5).Anchor = (AnchorStyles)13;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(79, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(72, 338);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter Paid Amt";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(107, 29);
		((Control)metroTextBox5).TabIndex = 6;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter Paid Amt";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroCheckBox5).AutoSize = true;
		metroCheckBox5.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox5).Location = new Point(15, 342);
		((Control)metroCheckBox5).Name = "metroCheckBox5";
		((Control)metroCheckBox5).Size = new Size(51, 19);
		((Control)metroCheckBox5).TabIndex = 5;
		((Control)metroCheckBox5).Text = "Paid";
		metroCheckBox5.UseSelectable = true;
		((CheckBox)metroCheckBox5).CheckedChanged += metroCheckBox5_CheckedChanged;
		((Control)metroComboBox6).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox6).FormattingEnabled = true;
		((ComboBox)metroComboBox6).ItemHeight = 23;
		((ComboBox)metroComboBox6).Items.AddRange(new object[2] { "Online", "Cash" });
		((Control)metroComboBox6).Location = new Point(15, 307);
		((Control)metroComboBox6).Name = "metroComboBox6";
		metroComboBox6.PromptText = "Select Payment Type";
		((Control)metroComboBox6).Size = new Size(164, 29);
		((Control)metroComboBox6).TabIndex = 4;
		metroComboBox6.UseSelectable = true;
		((Control)button5).Anchor = (AnchorStyles)13;
		((Control)button5).BackColor = Color.Red;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).Image = (Image)(object)Resources.delete;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(15, 418);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(164, 47);
		((Control)button5).TabIndex = 8;
		((Control)button5).Text = "Delete (D)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button4).Anchor = (AnchorStyles)13;
		((Control)button4).BackColor = Color.DeepPink;
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.printer;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(15, 369);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(164, 47);
		((Control)button4).TabIndex = 7;
		((Control)button4).Text = "Print (P)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)panel4).Anchor = (AnchorStyles)13;
		((Control)panel4).BackColor = Color.FromArgb(0, 174, 219);
		((Control)panel4).Controls.Add((Control)(object)label15);
		((Control)panel4).Controls.Add((Control)(object)label16);
		((Control)panel4).Location = new Point(15, 262);
		((Control)panel4).Name = "panel4";
		((Control)panel4).Size = new Size(164, 39);
		((Control)panel4).TabIndex = 3;
		((Control)label15).AutoSize = true;
		((Control)label15).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label15).ForeColor = Color.White;
		((Control)label15).Location = new Point(142, 10);
		((Control)label15).Name = "label15";
		((Control)label15).Size = new Size(17, 18);
		((Control)label15).TabIndex = 1;
		((Control)label15).Text = "0";
		((Control)label16).AutoSize = true;
		((Control)label16).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label16).ForeColor = Color.White;
		((Control)label16).Location = new Point(3, 10);
		((Control)label16).Name = "label16";
		((Control)label16).Size = new Size(107, 18);
		((Control)label16).TabIndex = 0;
		((Control)label16).Text = "Grand Total :";
		((Control)label14).AutoSize = true;
		((Control)label14).Location = new Point(89, 236);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(16, 18);
		((Control)label14).TabIndex = 11;
		((Control)label14).Text = "0";
		((Control)label13).AutoSize = true;
		((Control)label13).Location = new Point(12, 236);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(67, 18);
		((Control)label13).TabIndex = 10;
		((Control)label13).Text = "Discount";
		((Control)metroComboBox5).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox5).FormattingEnabled = true;
		((ComboBox)metroComboBox5).ItemHeight = 23;
		((Control)metroComboBox5).Location = new Point(15, 199);
		((Control)metroComboBox5).Name = "metroComboBox5";
		metroComboBox5.PromptText = "Select Discount";
		((Control)metroComboBox5).Size = new Size(164, 29);
		((Control)metroComboBox5).TabIndex = 3;
		metroComboBox5.UseSelectable = true;
		((ComboBox)metroComboBox5).SelectedIndexChanged += metroComboBox5_SelectedIndexChanged;
		((Control)panel3).Anchor = (AnchorStyles)13;
		((Control)panel3).BackColor = Color.FromArgb(0, 174, 219);
		((Control)panel3).Controls.Add((Control)(object)label11);
		((Control)panel3).Controls.Add((Control)(object)label12);
		((Control)panel3).Location = new Point(15, 123);
		((Control)panel3).Name = "panel3";
		((Control)panel3).Size = new Size(164, 30);
		((Control)panel3).TabIndex = 2;
		((Control)label11).AutoSize = true;
		((Control)label11).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label11).ForeColor = Color.White;
		((Control)label11).Location = new Point(142, 6);
		((Control)label11).Name = "label11";
		((Control)label11).Size = new Size(17, 18);
		((Control)label11).TabIndex = 1;
		((Control)label11).Text = "0";
		((Control)label12).AutoSize = true;
		((Control)label12).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label12).ForeColor = Color.White;
		((Control)label12).Location = new Point(3, 6);
		((Control)label12).Name = "label12";
		((Control)label12).Size = new Size(122, 18);
		((Control)label12).TabIndex = 0;
		((Control)label12).Text = "Total With Tax:";
		((Control)label9).AutoSize = true;
		((Control)label9).Location = new Point(180, 77);
		((Control)label9).Name = "label9";
		((Control)label9).Size = new Size(16, 18);
		((Control)label9).TabIndex = 8;
		((Control)label9).Text = "0";
		((Control)label10).AutoSize = true;
		((Control)label10).Location = new Point(132, 77);
		((Control)label10).Name = "label10";
		((Control)label10).Size = new Size(42, 18);
		((Control)label10).TabIndex = 7;
		((Control)label10).Text = "IGST";
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(180, 98);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(50, 18);
		((Control)label8).TabIndex = 6;
		((Control)label8).Text = "CGST";
		((Control)label7).AutoSize = true;
		((Control)label7).Location = new Point(125, 98);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(49, 18);
		((Control)label7).TabIndex = 5;
		((Control)label7).Text = "SGST";
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(71, 98);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(16, 18);
		((Control)label6).TabIndex = 4;
		((Control)label6).Text = "0";
		((Control)label5).AutoSize = true;
		((Control)label5).Location = new Point(15, 98);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(50, 18);
		((Control)label5).TabIndex = 3;
		((Control)label5).Text = "CGST";
		((Control)metroCheckBox2).AutoSize = true;
		metroCheckBox2.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox2).Location = new Point(15, 76);
		((Control)metroCheckBox2).Name = "metroCheckBox2";
		((Control)metroCheckBox2).Size = new Size(53, 19);
		((Control)metroCheckBox2).TabIndex = 2;
		((Control)metroCheckBox2).Text = "IGST";
		metroCheckBox2.UseSelectable = true;
		((CheckBox)metroCheckBox2).CheckedChanged += metroCheckBox2_CheckedChanged;
		((Control)metroComboBox4).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox4).FormattingEnabled = true;
		((ComboBox)metroComboBox4).ItemHeight = 23;
		((Control)metroComboBox4).Location = new Point(15, 44);
		((Control)metroComboBox4).Name = "metroComboBox4";
		metroComboBox4.PromptText = "Select Tax";
		((Control)metroComboBox4).Size = new Size(164, 29);
		((Control)metroComboBox4).TabIndex = 1;
		metroComboBox4.UseSelectable = true;
		((ComboBox)metroComboBox4).SelectedIndexChanged += metroComboBox4_SelectedIndexChanged;
		((Control)panel2).Anchor = (AnchorStyles)13;
		((Control)panel2).BackColor = Color.FromArgb(0, 174, 219);
		((Control)panel2).Controls.Add((Control)(object)label4);
		((Control)panel2).Controls.Add((Control)(object)label3);
		((Control)panel2).Location = new Point(15, 13);
		((Control)panel2).Name = "panel2";
		((Control)panel2).Size = new Size(164, 28);
		((Control)panel2).TabIndex = 0;
		((Control)label4).AutoSize = true;
		((Control)label4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label4).ForeColor = Color.White;
		((Control)label4).Location = new Point(142, 5);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(17, 18);
		((Control)label4).TabIndex = 1;
		((Control)label4).Text = "0";
		((Control)label3).AutoSize = true;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label3).ForeColor = Color.White;
		((Control)label3).Location = new Point(16, 5);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(56, 18);
		((Control)label3).TabIndex = 0;
		((Control)label3).Text = "Total :";
		((DataGridView)metroGrid2).AllowUserToAddRows = false;
		((DataGridView)metroGrid2).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid2).AllowUserToResizeRows = false;
		((Control)metroGrid2).Anchor = (AnchorStyles)7;
		((DataGridView)metroGrid2).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid2).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid2).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid2).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val4.Alignment = (DataGridViewContentAlignment)32;
		val4.BackColor = Color.FromArgb(0, 174, 219);
		val4.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val4.ForeColor = Color.FromArgb(255, 255, 255);
		val4.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val4.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val4.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid2).ColumnHeadersDefaultCellStyle = val4;
		((DataGridView)metroGrid2).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid2).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn1,
			(DataGridViewColumn)dataGridViewTextBoxColumn2,
			(DataGridViewColumn)dataGridViewTextBoxColumn3,
			(DataGridViewColumn)dataGridViewTextBoxColumn4,
			(DataGridViewColumn)dataGridViewTextBoxColumn5
		});
		val5.Alignment = (DataGridViewContentAlignment)32;
		val5.BackColor = Color.FromArgb(255, 255, 255);
		val5.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val5.ForeColor = Color.FromArgb(136, 136, 136);
		val5.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val5.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val5.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid2).DefaultCellStyle = val5;
		((DataGridView)metroGrid2).EnableHeadersVisualStyles = false;
		((Control)metroGrid2).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid2).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid2).Location = new Point(13, 43);
		((Control)metroGrid2).Name = "metroGrid2";
		((DataGridView)metroGrid2).ReadOnly = true;
		((DataGridView)metroGrid2).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val6.Alignment = (DataGridViewContentAlignment)32;
		val6.BackColor = Color.FromArgb(0, 174, 219);
		val6.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val6.ForeColor = Color.FromArgb(255, 255, 255);
		val6.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val6.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val6.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid2).RowHeadersDefaultCellStyle = val6;
		((DataGridView)metroGrid2).RowHeadersVisible = false;
		((DataGridView)metroGrid2).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid2).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid2).Size = new Size(362, 459);
		((Control)metroGrid2).TabIndex = 3;
		((DataGridViewColumn)dataGridViewTextBoxColumn1).HeaderText = "id";
		((DataGridViewColumn)dataGridViewTextBoxColumn1).Name = "dataGridViewTextBoxColumn1";
		((DataGridViewBand)dataGridViewTextBoxColumn1).ReadOnly = true;
		((DataGridViewBand)dataGridViewTextBoxColumn1).Visible = false;
		((DataGridViewColumn)dataGridViewTextBoxColumn2).HeaderText = "Item Name";
		((DataGridViewColumn)dataGridViewTextBoxColumn2).Name = "dataGridViewTextBoxColumn2";
		((DataGridViewBand)dataGridViewTextBoxColumn2).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn2).Width = 150;
		((DataGridViewColumn)dataGridViewTextBoxColumn3).HeaderText = "Qty";
		((DataGridViewColumn)dataGridViewTextBoxColumn3).Name = "dataGridViewTextBoxColumn3";
		((DataGridViewBand)dataGridViewTextBoxColumn3).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn3).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn4).HeaderText = "Price";
		((DataGridViewColumn)dataGridViewTextBoxColumn4).Name = "dataGridViewTextBoxColumn4";
		((DataGridViewBand)dataGridViewTextBoxColumn4).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn4).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn5).HeaderText = "Amount";
		((DataGridViewColumn)dataGridViewTextBoxColumn5).Name = "dataGridViewTextBoxColumn5";
		((DataGridViewBand)dataGridViewTextBoxColumn5).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn5).Width = 70;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((ComboBox)metroComboBox2).Items.AddRange(new object[1] { "Default" });
		((Control)metroComboBox2).Location = new Point(12, 8);
		((Control)metroComboBox2).Name = "metroComboBox2";
		metroComboBox2.PromptText = "Select Waiter";
		((Control)metroComboBox2).Size = new Size(319, 29);
		((Control)metroComboBox2).TabIndex = 1;
		metroComboBox2.UseSelectable = true;
		((Control)metroTabPage2).Controls.Add((Control)(object)groupBox4);
		((Control)metroTabPage2).Controls.Add((Control)(object)metroGrid3);
		metroTabPage2.HorizontalScrollbarBarColor = true;
		metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
		metroTabPage2.HorizontalScrollbarSize = 10;
		((TabPage)metroTabPage2).Location = new Point(4, 38);
		((Control)metroTabPage2).Name = "metroTabPage2";
		((Control)metroTabPage2).Size = new Size(589, 588);
		((TabPage)metroTabPage2).TabIndex = 1;
		((Control)metroTabPage2).Text = "TakeAway";
		metroTabPage2.VerticalScrollbarBarColor = true;
		metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
		metroTabPage2.VerticalScrollbarSize = 10;
		((Control)groupBox4).Anchor = (AnchorStyles)15;
		((Control)groupBox4).BackColor = Color.White;
		((Control)groupBox4).Controls.Add((Control)(object)label49);
		((Control)groupBox4).Controls.Add((Control)(object)label48);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox16);
		((Control)groupBox4).Controls.Add((Control)(object)metroTextBox6);
		((Control)groupBox4).Controls.Add((Control)(object)metroCheckBox6);
		((Control)groupBox4).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox4).Controls.Add((Control)(object)button6);
		((Control)groupBox4).Controls.Add((Control)(object)button7);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox8);
		((Control)groupBox4).Controls.Add((Control)(object)panel8);
		((Control)groupBox4).Controls.Add((Control)(object)label27);
		((Control)groupBox4).Controls.Add((Control)(object)label28);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox7);
		((Control)groupBox4).Controls.Add((Control)(object)panel7);
		((Control)groupBox4).Controls.Add((Control)(object)panel6);
		((Control)groupBox4).Controls.Add((Control)(object)metroComboBox3);
		((Control)groupBox4).Controls.Add((Control)(object)panel5);
		((Control)groupBox4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox4).Location = new Point(371, 3);
		((Control)groupBox4).Name = "groupBox4";
		((Control)groupBox4).Size = new Size(215, 576);
		((Control)groupBox4).TabIndex = 5;
		groupBox4.TabStop = false;
		((Control)groupBox4).Enter += groupBox4_Enter;
		((Control)label49).AutoSize = true;
		((Control)label49).Location = new Point(192, 193);
		((Control)label49).Name = "label49";
		((Control)label49).Size = new Size(52, 18);
		((Control)label49).TabIndex = 23;
		((Control)label49).Text = "100.00";
		((Control)label48).AutoSize = true;
		((Control)label48).Location = new Point(134, 193);
		((Control)label48).Name = "label48";
		((Control)label48).Size = new Size(52, 18);
		((Control)label48).TabIndex = 22;
		((Control)label48).Text = "100.00";
		((ListControl)metroComboBox16).FormattingEnabled = true;
		((ComboBox)metroComboBox16).ItemHeight = 23;
		((Control)metroComboBox16).Location = new Point(8, 187);
		((Control)metroComboBox16).Name = "metroComboBox16";
		metroComboBox16.PromptText = "Other Tax";
		((Control)metroComboBox16).Size = new Size(120, 29);
		((Control)metroComboBox16).TabIndex = 21;
		metroComboBox16.UseSelectable = true;
		((ComboBox)metroComboBox16).SelectedIndexChanged += metroComboBox16_SelectedIndexChanged;
		((Control)metroTextBox6).Anchor = (AnchorStyles)13;
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(108, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(71, 413);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Enter Paid Amt";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(136, 29);
		((Control)metroTextBox6).TabIndex = 18;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Enter Paid Amt";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroCheckBox6).AutoSize = true;
		metroCheckBox6.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox6).Location = new Point(14, 415);
		((Control)metroCheckBox6).Name = "metroCheckBox6";
		((Control)metroCheckBox6).Size = new Size(51, 19);
		((Control)metroCheckBox6).TabIndex = 17;
		((Control)metroCheckBox6).Text = "Paid";
		metroCheckBox6.UseSelectable = true;
		((CheckBox)metroCheckBox6).CheckedChanged += metroCheckBox6_CheckedChanged;
		((Control)metroTextBox3).Anchor = (AnchorStyles)13;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(173, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[1] { "Default" };
		((Control)metroTextBox3).Location = new Point(7, 374);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Customer Name";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(201, 29);
		metroTextBox3.Style = (MetroColorStyle)5;
		((Control)metroTextBox3).TabIndex = 16;
		((Control)metroTextBox3).Text = "Default";
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Customer Name";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button6).Anchor = (AnchorStyles)13;
		((Control)button6).BackColor = Color.Red;
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).Image = (Image)(object)Resources.delete;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(8, 515);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(201, 47);
		((Control)button6).TabIndex = 20;
		((Control)button6).Text = "Delete (D)";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		((Control)button7).Anchor = (AnchorStyles)13;
		((Control)button7).BackColor = Color.DeepPink;
		((ButtonBase)button7).FlatStyle = (FlatStyle)0;
		((Control)button7).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button7).ForeColor = Color.White;
		((ButtonBase)button7).Image = (Image)(object)Resources.printer;
		((ButtonBase)button7).ImageAlign = (ContentAlignment)16;
		((Control)button7).Location = new Point(8, 462);
		((Control)button7).Name = "button7";
		((Control)button7).Size = new Size(201, 47);
		((Control)button7).TabIndex = 19;
		((Control)button7).Text = "Print (P)";
		((ButtonBase)button7).UseVisualStyleBackColor = false;
		((Control)button7).Click += button7_Click;
		((Control)metroComboBox8).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox8).FormattingEnabled = true;
		((ComboBox)metroComboBox8).ItemHeight = 23;
		((ComboBox)metroComboBox8).Items.AddRange(new object[2] { "Online", "Cash" });
		((Control)metroComboBox8).Location = new Point(8, 339);
		((Control)metroComboBox8).Name = "metroComboBox8";
		metroComboBox8.PromptText = "Select Payment Type";
		((Control)metroComboBox8).Size = new Size(199, 29);
		metroComboBox8.Style = (MetroColorStyle)5;
		((Control)metroComboBox8).TabIndex = 15;
		metroComboBox8.UseSelectable = true;
		((ComboBox)metroComboBox8).SelectedIndexChanged += metroComboBox8_SelectedIndexChanged;
		((Control)panel8).Anchor = (AnchorStyles)13;
		((Control)panel8).BackColor = Color.FromArgb(0, 177, 89);
		((Control)panel8).Controls.Add((Control)(object)label29);
		((Control)panel8).Controls.Add((Control)(object)label30);
		((Control)panel8).Location = new Point(7, 288);
		((Control)panel8).Name = "panel8";
		((Control)panel8).Size = new Size(200, 45);
		((Control)panel8).TabIndex = 3;
		((Control)label29).AutoSize = true;
		((Control)label29).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label29).ForeColor = Color.White;
		((Control)label29).Location = new Point(127, 13);
		((Control)label29).Name = "label29";
		((Control)label29).Size = new Size(61, 18);
		((Control)label29).TabIndex = 1;
		((Control)label29).Text = "label29";
		((Control)label30).AutoSize = true;
		((Control)label30).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label30).ForeColor = Color.White;
		((Control)label30).Location = new Point(3, 13);
		((Control)label30).Name = "label30";
		((Control)label30).Size = new Size(97, 18);
		((Control)label30).TabIndex = 0;
		((Control)label30).Text = "Grand Total";
		((Control)label27).AutoSize = true;
		((Control)label27).Location = new Point(85, 255);
		((Control)label27).Name = "label27";
		((Control)label27).Size = new Size(16, 18);
		((Control)label27).TabIndex = 13;
		((Control)label27).Text = "0";
		((Control)label28).AutoSize = true;
		((Control)label28).Location = new Point(8, 255);
		((Control)label28).Name = "label28";
		((Control)label28).Size = new Size(67, 18);
		((Control)label28).TabIndex = 12;
		((Control)label28).Text = "Discount";
		((Control)metroComboBox7).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox7).FormattingEnabled = true;
		((ComboBox)metroComboBox7).ItemHeight = 23;
		((Control)metroComboBox7).Location = new Point(8, 222);
		((Control)metroComboBox7).Name = "metroComboBox7";
		metroComboBox7.PromptText = "Select Discount";
		((Control)metroComboBox7).Size = new Size(199, 29);
		metroComboBox7.Style = (MetroColorStyle)5;
		((Control)metroComboBox7).TabIndex = 10;
		metroComboBox7.UseSelectable = true;
		((ComboBox)metroComboBox7).SelectedIndexChanged += metroComboBox7_SelectedIndexChanged;
		((Control)panel7).Anchor = (AnchorStyles)13;
		((Control)panel7).BackColor = Color.FromArgb(0, 177, 89);
		((Control)panel7).Controls.Add((Control)(object)label25);
		((Control)panel7).Controls.Add((Control)(object)label26);
		((Control)panel7).Location = new Point(8, 145);
		((Control)panel7).Name = "panel7";
		((Control)panel7).Size = new Size(200, 35);
		((Control)panel7).TabIndex = 2;
		((Control)label25).AutoSize = true;
		((Control)label25).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label25).ForeColor = Color.White;
		((Control)label25).Location = new Point(126, 8);
		((Control)label25).Name = "label25";
		((Control)label25).Size = new Size(61, 18);
		((Control)label25).TabIndex = 1;
		((Control)label25).Text = "label25";
		((Control)label26).AutoSize = true;
		((Control)label26).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label26).ForeColor = Color.White;
		((Control)label26).Location = new Point(3, 8);
		((Control)label26).Name = "label26";
		((Control)label26).Size = new Size(117, 18);
		((Control)label26).TabIndex = 0;
		((Control)label26).Text = "Total With Tax";
		((Control)panel6).Anchor = (AnchorStyles)13;
		((Control)panel6).Controls.Add((Control)(object)label19);
		((Control)panel6).Controls.Add((Control)(object)label23);
		((Control)panel6).Controls.Add((Control)(object)metroCheckBox3);
		((Control)panel6).Controls.Add((Control)(object)label24);
		((Control)panel6).Controls.Add((Control)(object)label20);
		((Control)panel6).Controls.Add((Control)(object)label21);
		((Control)panel6).Controls.Add((Control)(object)label22);
		((Control)panel6).Location = new Point(8, 86);
		((Control)panel6).Name = "panel6";
		((Control)panel6).Size = new Size(199, 56);
		((Control)panel6).TabIndex = 9;
		((Control)label19).Anchor = (AnchorStyles)0;
		((Control)label19).AutoSize = true;
		((Control)label19).Location = new Point(117, 5);
		((Control)label19).Name = "label19";
		((Control)label19).Size = new Size(42, 18);
		((Control)label19).TabIndex = 2;
		((Control)label19).Text = "IGST";
		((Control)label23).Anchor = (AnchorStyles)0;
		((Control)label23).AutoSize = true;
		((Control)label23).Location = new Point(168, 31);
		((Control)label23).Name = "label23";
		((Control)label23).Size = new Size(42, 18);
		((Control)label23).TabIndex = 8;
		((Control)label23).Text = "IGST";
		((Control)metroCheckBox3).Anchor = (AnchorStyles)4;
		((Control)metroCheckBox3).AutoSize = true;
		metroCheckBox3.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox3).Location = new Point(3, 4);
		((Control)metroCheckBox3).Name = "metroCheckBox3";
		((Control)metroCheckBox3).Size = new Size(53, 19);
		metroCheckBox3.Style = (MetroColorStyle)5;
		((Control)metroCheckBox3).TabIndex = 3;
		((Control)metroCheckBox3).Text = "IGST";
		metroCheckBox3.UseSelectable = true;
		((CheckBox)metroCheckBox3).CheckedChanged += metroCheckBox3_CheckedChanged;
		((Control)label24).Anchor = (AnchorStyles)0;
		((Control)label24).AutoSize = true;
		((Control)label24).Location = new Point(117, 30);
		((Control)label24).Name = "label24";
		((Control)label24).Size = new Size(42, 18);
		((Control)label24).TabIndex = 7;
		((Control)label24).Text = "IGST";
		((Control)label20).Anchor = (AnchorStyles)0;
		((Control)label20).AutoSize = true;
		((Control)label20).Location = new Point(168, 4);
		((Control)label20).Name = "label20";
		((Control)label20).Size = new Size(42, 18);
		((Control)label20).TabIndex = 4;
		((Control)label20).Text = "IGST";
		((Control)label21).AutoSize = true;
		((Control)label21).Location = new Point(50, 31);
		((Control)label21).Name = "label21";
		((Control)label21).Size = new Size(42, 18);
		((Control)label21).TabIndex = 6;
		((Control)label21).Text = "IGST";
		((Control)label22).Anchor = (AnchorStyles)4;
		((Control)label22).AutoSize = true;
		((Control)label22).Location = new Point(2, 30);
		((Control)label22).Name = "label22";
		((Control)label22).Size = new Size(42, 18);
		((Control)label22).TabIndex = 5;
		((Control)label22).Text = "IGST";
		((Control)metroComboBox3).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox3).FormattingEnabled = true;
		((ComboBox)metroComboBox3).ItemHeight = 23;
		((Control)metroComboBox3).Location = new Point(8, 54);
		((Control)metroComboBox3).Name = "metroComboBox3";
		metroComboBox3.PromptText = "Select Tax";
		((Control)metroComboBox3).Size = new Size(200, 29);
		metroComboBox3.Style = (MetroColorStyle)5;
		((Control)metroComboBox3).TabIndex = 2;
		metroComboBox3.UseSelectable = true;
		((ComboBox)metroComboBox3).SelectedIndexChanged += metroComboBox3_SelectedIndexChanged;
		((Control)panel5).Anchor = (AnchorStyles)13;
		((Control)panel5).BackColor = Color.FromArgb(0, 177, 89);
		((Control)panel5).Controls.Add((Control)(object)label18);
		((Control)panel5).Controls.Add((Control)(object)label17);
		((Control)panel5).Location = new Point(8, 15);
		((Control)panel5).Name = "panel5";
		((Control)panel5).Size = new Size(200, 35);
		((Control)panel5).TabIndex = 0;
		((Control)label18).AutoSize = true;
		((Control)label18).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label18).ForeColor = Color.White;
		((Control)label18).Location = new Point(126, 8);
		((Control)label18).Name = "label18";
		((Control)label18).Size = new Size(61, 18);
		((Control)label18).TabIndex = 1;
		((Control)label18).Text = "label18";
		((Control)label17).AutoSize = true;
		((Control)label17).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label17).ForeColor = Color.White;
		((Control)label17).Location = new Point(3, 8);
		((Control)label17).Name = "label17";
		((Control)label17).Size = new Size(46, 18);
		((Control)label17).TabIndex = 0;
		((Control)label17).Text = "Total";
		((DataGridView)metroGrid3).AllowUserToAddRows = false;
		((DataGridView)metroGrid3).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid3).AllowUserToResizeRows = false;
		((Control)metroGrid3).Anchor = (AnchorStyles)7;
		((DataGridView)metroGrid3).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid3).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid3).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid3).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val7.Alignment = (DataGridViewContentAlignment)32;
		val7.BackColor = Color.FromArgb(0, 177, 89);
		val7.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val7.ForeColor = Color.FromArgb(255, 255, 255);
		val7.SelectionBackColor = Color.FromArgb(0, 208, 104);
		val7.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val7.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid3).ColumnHeadersDefaultCellStyle = val7;
		((DataGridView)metroGrid3).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid3).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn7,
			(DataGridViewColumn)dataGridViewTextBoxColumn8,
			(DataGridViewColumn)dataGridViewTextBoxColumn9,
			(DataGridViewColumn)dataGridViewTextBoxColumn10
		});
		val8.Alignment = (DataGridViewContentAlignment)32;
		val8.BackColor = Color.FromArgb(255, 255, 255);
		val8.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val8.ForeColor = Color.FromArgb(136, 136, 136);
		val8.SelectionBackColor = Color.FromArgb(0, 208, 104);
		val8.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val8.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid3).DefaultCellStyle = val8;
		((DataGridView)metroGrid3).EnableHeadersVisualStyles = false;
		((Control)metroGrid3).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid3).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid3).Location = new Point(3, 16);
		((Control)metroGrid3).Name = "metroGrid3";
		((DataGridView)metroGrid3).ReadOnly = true;
		((DataGridView)metroGrid3).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val9.Alignment = (DataGridViewContentAlignment)32;
		val9.BackColor = Color.FromArgb(0, 177, 89);
		val9.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val9.ForeColor = Color.FromArgb(255, 255, 255);
		val9.SelectionBackColor = Color.FromArgb(0, 208, 104);
		val9.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val9.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid3).RowHeadersDefaultCellStyle = val9;
		((DataGridView)metroGrid3).RowHeadersVisible = false;
		((DataGridView)metroGrid3).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid3).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid3).Size = new Size(362, 563);
		metroGrid3.Style = (MetroColorStyle)5;
		((Control)metroGrid3).TabIndex = 4;
		((DataGridView)metroGrid3).CellDoubleClick += new DataGridViewCellEventHandler(metroGrid3_CellDoubleClick);
		((DataGridView)metroGrid3).CellMouseClick += new DataGridViewCellMouseEventHandler(metroGrid3_CellMouseClick);
		((DataGridViewColumn)dataGridViewTextBoxColumn7).HeaderText = "Item Name";
		((DataGridViewColumn)dataGridViewTextBoxColumn7).Name = "dataGridViewTextBoxColumn7";
		((DataGridViewBand)dataGridViewTextBoxColumn7).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn7).Width = 150;
		((DataGridViewColumn)dataGridViewTextBoxColumn8).HeaderText = "Qty";
		((DataGridViewColumn)dataGridViewTextBoxColumn8).Name = "dataGridViewTextBoxColumn8";
		((DataGridViewBand)dataGridViewTextBoxColumn8).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn8).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn9).HeaderText = "Price";
		((DataGridViewColumn)dataGridViewTextBoxColumn9).Name = "dataGridViewTextBoxColumn9";
		((DataGridViewBand)dataGridViewTextBoxColumn9).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn9).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn10).HeaderText = "Amount";
		((DataGridViewColumn)dataGridViewTextBoxColumn10).Name = "dataGridViewTextBoxColumn10";
		((DataGridViewBand)dataGridViewTextBoxColumn10).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn10).Width = 70;
		((Control)metroTabPage3).Controls.Add((Control)(object)groupBox5);
		((Control)metroTabPage3).Controls.Add((Control)(object)metroGrid4);
		metroTabPage3.HorizontalScrollbarBarColor = true;
		metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
		metroTabPage3.HorizontalScrollbarSize = 10;
		((TabPage)metroTabPage3).Location = new Point(4, 38);
		((Control)metroTabPage3).Name = "metroTabPage3";
		((Control)metroTabPage3).Size = new Size(589, 588);
		((TabPage)metroTabPage3).TabIndex = 2;
		((Control)metroTabPage3).Text = "Home Delivery";
		metroTabPage3.VerticalScrollbarBarColor = true;
		metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
		metroTabPage3.VerticalScrollbarSize = 10;
		((Control)groupBox5).Anchor = (AnchorStyles)15;
		((Control)groupBox5).BackColor = Color.White;
		((Control)groupBox5).Controls.Add((Control)(object)label51);
		((Control)groupBox5).Controls.Add((Control)(object)label50);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox15);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox13);
		((Control)groupBox5).Controls.Add((Control)(object)metroTextBox7);
		((Control)groupBox5).Controls.Add((Control)(object)metroCheckBox7);
		((Control)groupBox5).Controls.Add((Control)(object)button8);
		((Control)groupBox5).Controls.Add((Control)(object)button9);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox12);
		((Control)groupBox5).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox11);
		((Control)groupBox5).Controls.Add((Control)(object)panel12);
		((Control)groupBox5).Controls.Add((Control)(object)label41);
		((Control)groupBox5).Controls.Add((Control)(object)label42);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox10);
		((Control)groupBox5).Controls.Add((Control)(object)panel11);
		((Control)groupBox5).Controls.Add((Control)(object)panel10);
		((Control)groupBox5).Controls.Add((Control)(object)metroComboBox9);
		((Control)groupBox5).Controls.Add((Control)(object)panel9);
		((Control)groupBox5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox5).Location = new Point(371, 3);
		((Control)groupBox5).Name = "groupBox5";
		((Control)groupBox5).Size = new Size(215, 576);
		((Control)groupBox5).TabIndex = 6;
		groupBox5.TabStop = false;
		((Control)label51).AutoSize = true;
		((Control)label51).Location = new Point(193, 191);
		((Control)label51).Name = "label51";
		((Control)label51).Size = new Size(52, 18);
		((Control)label51).TabIndex = 28;
		((Control)label51).Text = "100.00";
		((Control)label50).AutoSize = true;
		((Control)label50).Location = new Point(135, 191);
		((Control)label50).Name = "label50";
		((Control)label50).Size = new Size(52, 18);
		((Control)label50).TabIndex = 27;
		((Control)label50).Text = "100.00";
		((ListControl)metroComboBox15).FormattingEnabled = true;
		((ComboBox)metroComboBox15).ItemHeight = 23;
		((Control)metroComboBox15).Location = new Point(9, 186);
		((Control)metroComboBox15).Name = "metroComboBox15";
		metroComboBox15.PromptText = "Other Tax";
		((Control)metroComboBox15).Size = new Size(120, 29);
		((Control)metroComboBox15).TabIndex = 26;
		metroComboBox15.UseSelectable = true;
		((ComboBox)metroComboBox15).SelectedIndexChanged += metroComboBox15_SelectedIndexChanged;
		((Control)metroComboBox13).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox13).FormattingEnabled = true;
		((ComboBox)metroComboBox13).ItemHeight = 23;
		((ComboBox)metroComboBox13).Items.AddRange(new object[1] { "Self" });
		((Control)metroComboBox13).Location = new Point(8, 466);
		((Control)metroComboBox13).Name = "metroComboBox13";
		metroComboBox13.PromptText = "Order From";
		((Control)metroComboBox13).Size = new Size(199, 29);
		metroComboBox13.Style = (MetroColorStyle)8;
		((Control)metroComboBox13).TabIndex = 23;
		metroComboBox13.UseSelectable = true;
		((Control)metroTextBox7).Anchor = (AnchorStyles)13;
		metroTextBox7.CustomButton.Image = null;
		((Control)metroTextBox7.CustomButton).Location = new Point(108, 1);
		((Control)metroTextBox7.CustomButton).Name = "";
		((Control)metroTextBox7.CustomButton).Size = new Size(27, 27);
		metroTextBox7.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox7.CustomButton).TabIndex = 1;
		metroTextBox7.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox7.CustomButton.UseSelectable = true;
		((Control)metroTextBox7.CustomButton).Visible = false;
		metroTextBox7.FontSize = (MetroTextBoxSize)1;
		metroTextBox7.Lines = new string[0];
		((Control)metroTextBox7).Location = new Point(71, 431);
		metroTextBox7.MaxLength = 32767;
		((Control)metroTextBox7).Name = "metroTextBox7";
		metroTextBox7.PasswordChar = '\0';
		metroTextBox7.PromptText = "Enter Paid Amt";
		metroTextBox7.ScrollBars = (ScrollBars)0;
		metroTextBox7.SelectedText = "";
		metroTextBox7.SelectionLength = 0;
		metroTextBox7.SelectionStart = 0;
		metroTextBox7.ShortcutsEnabled = true;
		((Control)metroTextBox7).Size = new Size(136, 29);
		((Control)metroTextBox7).TabIndex = 22;
		metroTextBox7.UseSelectable = true;
		metroTextBox7.WaterMark = "Enter Paid Amt";
		metroTextBox7.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox7.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroCheckBox7).AutoSize = true;
		metroCheckBox7.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox7).Location = new Point(14, 433);
		((Control)metroCheckBox7).Name = "metroCheckBox7";
		((Control)metroCheckBox7).Size = new Size(51, 19);
		((Control)metroCheckBox7).TabIndex = 21;
		((Control)metroCheckBox7).Text = "Paid";
		metroCheckBox7.UseSelectable = true;
		((CheckBox)metroCheckBox7).CheckedChanged += metroCheckBox7_CheckedChanged;
		((Control)button8).Anchor = (AnchorStyles)13;
		((Control)button8).BackColor = Color.Red;
		((ButtonBase)button8).FlatStyle = (FlatStyle)0;
		((Control)button8).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button8).ForeColor = Color.White;
		((ButtonBase)button8).Image = (Image)(object)Resources.delete;
		((ButtonBase)button8).ImageAlign = (ContentAlignment)16;
		((Control)button8).Location = new Point(9, 549);
		((Control)button8).Name = "button8";
		((Control)button8).Size = new Size(201, 39);
		((Control)button8).TabIndex = 25;
		((Control)button8).Text = "Delete (D)";
		((ButtonBase)button8).UseVisualStyleBackColor = false;
		((Control)button8).Click += button8_Click;
		((Control)button9).Anchor = (AnchorStyles)13;
		((Control)button9).BackColor = Color.DeepPink;
		((ButtonBase)button9).FlatStyle = (FlatStyle)0;
		((Control)button9).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button9).ForeColor = Color.White;
		((ButtonBase)button9).Image = (Image)(object)Resources.printer;
		((ButtonBase)button9).ImageAlign = (ContentAlignment)16;
		((Control)button9).Location = new Point(9, 504);
		((Control)button9).Name = "button9";
		((Control)button9).Size = new Size(201, 39);
		((Control)button9).TabIndex = 24;
		((Control)button9).Text = "Print (P)";
		((ButtonBase)button9).UseVisualStyleBackColor = false;
		((Control)button9).Click += button9_Click;
		((Control)metroComboBox12).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox12).FormattingEnabled = true;
		((ComboBox)metroComboBox12).ItemHeight = 23;
		((ComboBox)metroComboBox12).Items.AddRange(new object[1] { "Default" });
		((Control)metroComboBox12).Location = new Point(9, 396);
		((Control)metroComboBox12).Name = "metroComboBox12";
		metroComboBox12.PromptText = "Select Delivery Boy";
		((Control)metroComboBox12).Size = new Size(199, 29);
		metroComboBox12.Style = (MetroColorStyle)8;
		((Control)metroComboBox12).TabIndex = 20;
		metroComboBox12.UseSelectable = true;
		((Control)metroTextBox4).Anchor = (AnchorStyles)13;
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(173, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[1] { "Default" };
		((Control)metroTextBox4).Location = new Point(8, 361);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Customer Name";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(201, 29);
		metroTextBox4.Style = (MetroColorStyle)8;
		((Control)metroTextBox4).TabIndex = 19;
		((Control)metroTextBox4).Text = "Default";
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Customer Name";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroComboBox11).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox11).FormattingEnabled = true;
		((ComboBox)metroComboBox11).ItemHeight = 23;
		((ComboBox)metroComboBox11).Items.AddRange(new object[2] { "Online", "Cash" });
		((Control)metroComboBox11).Location = new Point(8, 326);
		((Control)metroComboBox11).Name = "metroComboBox11";
		metroComboBox11.PromptText = "Select Payment Type";
		((Control)metroComboBox11).Size = new Size(199, 29);
		metroComboBox11.Style = (MetroColorStyle)8;
		((Control)metroComboBox11).TabIndex = 17;
		metroComboBox11.UseSelectable = true;
		((Control)panel12).Anchor = (AnchorStyles)13;
		((Control)panel12).BackColor = Color.FromArgb(243, 119, 53);
		((Control)panel12).Controls.Add((Control)(object)label43);
		((Control)panel12).Controls.Add((Control)(object)label44);
		((Control)panel12).Location = new Point(8, 281);
		((Control)panel12).Name = "panel12";
		((Control)panel12).Size = new Size(200, 40);
		((Control)panel12).TabIndex = 16;
		((Control)label43).AutoSize = true;
		((Control)label43).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label43).ForeColor = Color.White;
		((Control)label43).Location = new Point(127, 11);
		((Control)label43).Name = "label43";
		((Control)label43).Size = new Size(61, 18);
		((Control)label43).TabIndex = 1;
		((Control)label43).Text = "label43";
		((Control)label44).AutoSize = true;
		((Control)label44).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label44).ForeColor = Color.White;
		((Control)label44).Location = new Point(3, 11);
		((Control)label44).Name = "label44";
		((Control)label44).Size = new Size(97, 18);
		((Control)label44).TabIndex = 0;
		((Control)label44).Text = "Grand Total";
		((Control)label41).AutoSize = true;
		((Control)label41).Location = new Point(83, 255);
		((Control)label41).Name = "label41";
		((Control)label41).Size = new Size(16, 18);
		((Control)label41).TabIndex = 15;
		((Control)label41).Text = "0";
		((Control)label42).AutoSize = true;
		((Control)label42).Location = new Point(6, 255);
		((Control)label42).Name = "label42";
		((Control)label42).Size = new Size(67, 18);
		((Control)label42).TabIndex = 14;
		((Control)label42).Text = "Discount";
		((Control)metroComboBox10).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox10).FormattingEnabled = true;
		((ComboBox)metroComboBox10).ItemHeight = 23;
		((Control)metroComboBox10).Location = new Point(8, 221);
		((Control)metroComboBox10).Name = "metroComboBox10";
		metroComboBox10.PromptText = "Select Discount";
		((Control)metroComboBox10).Size = new Size(200, 29);
		metroComboBox10.Style = (MetroColorStyle)8;
		((Control)metroComboBox10).TabIndex = 12;
		metroComboBox10.UseSelectable = true;
		((ComboBox)metroComboBox10).SelectedIndexChanged += metroComboBox10_SelectedIndexChanged;
		((Control)panel11).Anchor = (AnchorStyles)13;
		((Control)panel11).BackColor = Color.FromArgb(243, 119, 53);
		((Control)panel11).Controls.Add((Control)(object)label39);
		((Control)panel11).Controls.Add((Control)(object)label40);
		((Control)panel11).Location = new Point(9, 145);
		((Control)panel11).Name = "panel11";
		((Control)panel11).Size = new Size(200, 35);
		((Control)panel11).TabIndex = 11;
		((Control)label39).AutoSize = true;
		((Control)label39).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label39).ForeColor = Color.White;
		((Control)label39).Location = new Point(126, 8);
		((Control)label39).Name = "label39";
		((Control)label39).Size = new Size(61, 18);
		((Control)label39).TabIndex = 1;
		((Control)label39).Text = "label39";
		((Control)label40).AutoSize = true;
		((Control)label40).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label40).ForeColor = Color.White;
		((Control)label40).Location = new Point(3, 8);
		((Control)label40).Name = "label40";
		((Control)label40).Size = new Size(117, 18);
		((Control)label40).TabIndex = 0;
		((Control)label40).Text = "Total With Tax";
		((Control)panel10).Anchor = (AnchorStyles)13;
		((Control)panel10).Controls.Add((Control)(object)label33);
		((Control)panel10).Controls.Add((Control)(object)label34);
		((Control)panel10).Controls.Add((Control)(object)metroCheckBox4);
		((Control)panel10).Controls.Add((Control)(object)label35);
		((Control)panel10).Controls.Add((Control)(object)label36);
		((Control)panel10).Controls.Add((Control)(object)label37);
		((Control)panel10).Controls.Add((Control)(object)label38);
		((Control)panel10).Location = new Point(9, 83);
		((Control)panel10).Name = "panel10";
		((Control)panel10).Size = new Size(199, 56);
		((Control)panel10).TabIndex = 10;
		((Control)label33).Anchor = (AnchorStyles)0;
		((Control)label33).AutoSize = true;
		((Control)label33).Location = new Point(117, 5);
		((Control)label33).Name = "label33";
		((Control)label33).Size = new Size(42, 18);
		((Control)label33).TabIndex = 2;
		((Control)label33).Text = "IGST";
		((Control)label34).Anchor = (AnchorStyles)0;
		((Control)label34).AutoSize = true;
		((Control)label34).Location = new Point(168, 31);
		((Control)label34).Name = "label34";
		((Control)label34).Size = new Size(42, 18);
		((Control)label34).TabIndex = 8;
		((Control)label34).Text = "IGST";
		((Control)metroCheckBox4).Anchor = (AnchorStyles)4;
		((Control)metroCheckBox4).AutoSize = true;
		metroCheckBox4.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox4).Location = new Point(3, 4);
		((Control)metroCheckBox4).Name = "metroCheckBox4";
		((Control)metroCheckBox4).Size = new Size(53, 19);
		metroCheckBox4.Style = (MetroColorStyle)8;
		((Control)metroCheckBox4).TabIndex = 3;
		((Control)metroCheckBox4).Text = "IGST";
		metroCheckBox4.UseSelectable = true;
		((CheckBox)metroCheckBox4).CheckedChanged += metroCheckBox4_CheckedChanged;
		((Control)label35).Anchor = (AnchorStyles)0;
		((Control)label35).AutoSize = true;
		((Control)label35).Location = new Point(117, 30);
		((Control)label35).Name = "label35";
		((Control)label35).Size = new Size(42, 18);
		((Control)label35).TabIndex = 7;
		((Control)label35).Text = "IGST";
		((Control)label36).Anchor = (AnchorStyles)0;
		((Control)label36).AutoSize = true;
		((Control)label36).Location = new Point(168, 4);
		((Control)label36).Name = "label36";
		((Control)label36).Size = new Size(42, 18);
		((Control)label36).TabIndex = 4;
		((Control)label36).Text = "IGST";
		((Control)label37).AutoSize = true;
		((Control)label37).Location = new Point(50, 31);
		((Control)label37).Name = "label37";
		((Control)label37).Size = new Size(42, 18);
		((Control)label37).TabIndex = 6;
		((Control)label37).Text = "IGST";
		((Control)label38).Anchor = (AnchorStyles)4;
		((Control)label38).AutoSize = true;
		((Control)label38).Location = new Point(2, 30);
		((Control)label38).Name = "label38";
		((Control)label38).Size = new Size(42, 18);
		((Control)label38).TabIndex = 5;
		((Control)label38).Text = "IGST";
		((Control)metroComboBox9).Anchor = (AnchorStyles)13;
		((ListControl)metroComboBox9).FormattingEnabled = true;
		((ComboBox)metroComboBox9).ItemHeight = 23;
		((Control)metroComboBox9).Location = new Point(9, 51);
		((Control)metroComboBox9).Name = "metroComboBox9";
		metroComboBox9.PromptText = "Select Tax";
		((Control)metroComboBox9).Size = new Size(200, 29);
		metroComboBox9.Style = (MetroColorStyle)8;
		((Control)metroComboBox9).TabIndex = 3;
		metroComboBox9.UseSelectable = true;
		((ComboBox)metroComboBox9).SelectedIndexChanged += metroComboBox9_SelectedIndexChanged;
		((Control)panel9).Anchor = (AnchorStyles)13;
		((Control)panel9).BackColor = Color.FromArgb(243, 119, 53);
		((Control)panel9).Controls.Add((Control)(object)label31);
		((Control)panel9).Controls.Add((Control)(object)label32);
		((Control)panel9).Location = new Point(9, 13);
		((Control)panel9).Name = "panel9";
		((Control)panel9).Size = new Size(200, 35);
		((Control)panel9).TabIndex = 1;
		((Control)label31).AutoSize = true;
		((Control)label31).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label31).ForeColor = Color.White;
		((Control)label31).Location = new Point(126, 8);
		((Control)label31).Name = "label31";
		((Control)label31).Size = new Size(61, 18);
		((Control)label31).TabIndex = 1;
		((Control)label31).Text = "label31";
		((Control)label32).AutoSize = true;
		((Control)label32).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label32).ForeColor = Color.White;
		((Control)label32).Location = new Point(3, 8);
		((Control)label32).Name = "label32";
		((Control)label32).Size = new Size(46, 18);
		((Control)label32).TabIndex = 0;
		((Control)label32).Text = "Total";
		((DataGridView)metroGrid4).AllowUserToAddRows = false;
		((DataGridView)metroGrid4).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid4).AllowUserToResizeRows = false;
		((Control)metroGrid4).Anchor = (AnchorStyles)7;
		((DataGridView)metroGrid4).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid4).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid4).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid4).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val10.Alignment = (DataGridViewContentAlignment)32;
		val10.BackColor = Color.FromArgb(243, 119, 53);
		val10.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val10.ForeColor = Color.FromArgb(255, 255, 255);
		val10.SelectionBackColor = Color.FromArgb(244, 133, 72);
		val10.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val10.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid4).ColumnHeadersDefaultCellStyle = val10;
		((DataGridView)metroGrid4).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid4).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)dataGridViewTextBoxColumn6,
			(DataGridViewColumn)dataGridViewTextBoxColumn11,
			(DataGridViewColumn)dataGridViewTextBoxColumn12,
			(DataGridViewColumn)dataGridViewTextBoxColumn13
		});
		val11.Alignment = (DataGridViewContentAlignment)32;
		val11.BackColor = Color.FromArgb(255, 255, 255);
		val11.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val11.ForeColor = Color.FromArgb(136, 136, 136);
		val11.SelectionBackColor = Color.FromArgb(244, 133, 72);
		val11.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val11.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid4).DefaultCellStyle = val11;
		((DataGridView)metroGrid4).EnableHeadersVisualStyles = false;
		((Control)metroGrid4).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid4).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid4).Location = new Point(3, 16);
		((Control)metroGrid4).Name = "metroGrid4";
		((DataGridView)metroGrid4).ReadOnly = true;
		((DataGridView)metroGrid4).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val12.Alignment = (DataGridViewContentAlignment)32;
		val12.BackColor = Color.FromArgb(243, 119, 53);
		val12.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val12.ForeColor = Color.FromArgb(255, 255, 255);
		val12.SelectionBackColor = Color.FromArgb(244, 133, 72);
		val12.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val12.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid4).RowHeadersDefaultCellStyle = val12;
		((DataGridView)metroGrid4).RowHeadersVisible = false;
		((DataGridView)metroGrid4).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid4).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid4).Size = new Size(362, 563);
		metroGrid4.Style = (MetroColorStyle)8;
		((Control)metroGrid4).TabIndex = 5;
		((DataGridView)metroGrid4).CellDoubleClick += new DataGridViewCellEventHandler(metroGrid4_CellDoubleClick);
		((DataGridView)metroGrid4).CellMouseClick += new DataGridViewCellMouseEventHandler(metroGrid4_CellMouseClick);
		((DataGridViewColumn)dataGridViewTextBoxColumn6).HeaderText = "Item Name";
		((DataGridViewColumn)dataGridViewTextBoxColumn6).Name = "dataGridViewTextBoxColumn6";
		((DataGridViewBand)dataGridViewTextBoxColumn6).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn6).Width = 150;
		((DataGridViewColumn)dataGridViewTextBoxColumn11).HeaderText = "Qty";
		((DataGridViewColumn)dataGridViewTextBoxColumn11).Name = "dataGridViewTextBoxColumn11";
		((DataGridViewBand)dataGridViewTextBoxColumn11).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn11).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn12).HeaderText = "Price";
		((DataGridViewColumn)dataGridViewTextBoxColumn12).Name = "dataGridViewTextBoxColumn12";
		((DataGridViewBand)dataGridViewTextBoxColumn12).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn12).Width = 70;
		((DataGridViewColumn)dataGridViewTextBoxColumn13).HeaderText = "Amount";
		((DataGridViewColumn)dataGridViewTextBoxColumn13).Name = "dataGridViewTextBoxColumn13";
		((DataGridViewBand)dataGridViewTextBoxColumn13).ReadOnly = true;
		((DataGridViewColumn)dataGridViewTextBoxColumn13).Width = 70;
		((ToolStrip)contextMenuStrip1).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)deleteToolStripMenuItem });
		((Control)contextMenuStrip1).Name = "contextMenuStrip1";
		((Control)contextMenuStrip1).Size = new Size(121, 28);
		((ToolStripItem)deleteToolStripMenuItem).Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStripItem)deleteToolStripMenuItem).Name = "deleteToolStripMenuItem";
		((ToolStripItem)deleteToolStripMenuItem).Size = new Size(120, 24);
		((ToolStripItem)deleteToolStripMenuItem).Text = "Delete";
		((ToolStripItem)deleteToolStripMenuItem).Click += deleteToolStripMenuItem_Click;
		((ToolStrip)contextMenuStrip2).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripMenuItem1 });
		((Control)contextMenuStrip2).Name = "contextMenuStrip1";
		((Control)contextMenuStrip2).Size = new Size(121, 28);
		((ToolStripItem)toolStripMenuItem1).Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStripItem)toolStripMenuItem1).Name = "toolStripMenuItem1";
		((ToolStripItem)toolStripMenuItem1).Size = new Size(120, 24);
		((ToolStripItem)toolStripMenuItem1).Text = "Delete";
		((ToolStripItem)toolStripMenuItem1).Click += toolStripMenuItem1_Click;
		((ToolStrip)contextMenuStrip3).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripMenuItem2 });
		((Control)contextMenuStrip3).Name = "contextMenuStrip1";
		((Control)contextMenuStrip3).Size = new Size(121, 28);
		((ToolStripItem)toolStripMenuItem2).Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStripItem)toolStripMenuItem2).Name = "toolStripMenuItem2";
		((ToolStripItem)toolStripMenuItem2).Size = new Size(120, 24);
		((ToolStripItem)toolStripMenuItem2).Text = "Delete";
		((ToolStripItem)toolStripMenuItem2).Click += toolStripMenuItem2_Click;
		((Control)flowLayoutPanel2).Anchor = (AnchorStyles)13;
		((ScrollableControl)flowLayoutPanel2).AutoScroll = true;
		((Control)flowLayoutPanel2).Location = new Point(23, 9);
		((Control)flowLayoutPanel2).Name = "flowLayoutPanel2";
		((Control)flowLayoutPanel2).Size = new Size(1197, 72);
		((Control)flowLayoutPanel2).TabIndex = 3;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1297, 718);
		((Control)this).Controls.Add((Control)(object)flowLayoutPanel2);
		((Control)this).Controls.Add((Control)(object)metroTabControl1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Order";
		((Form)this).FormClosed += new FormClosedEventHandler(Order_FormClosed);
		((Form)this).Load += Order_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)metroTabControl1).ResumeLayout(false);
		((Control)metroTabPage1).ResumeLayout(false);
		((Control)metroTabControl2).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)tabPage2).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)metroGrid2).EndInit();
		((Control)metroTabPage2).ResumeLayout(false);
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((Control)panel8).ResumeLayout(false);
		((Control)panel8).PerformLayout();
		((Control)panel7).ResumeLayout(false);
		((Control)panel7).PerformLayout();
		((Control)panel6).ResumeLayout(false);
		((Control)panel6).PerformLayout();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((ISupportInitialize)metroGrid3).EndInit();
		((Control)metroTabPage3).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)panel12).ResumeLayout(false);
		((Control)panel12).PerformLayout();
		((Control)panel11).ResumeLayout(false);
		((Control)panel11).PerformLayout();
		((Control)panel10).ResumeLayout(false);
		((Control)panel10).PerformLayout();
		((Control)panel9).ResumeLayout(false);
		((Control)panel9).PerformLayout();
		((ISupportInitialize)metroGrid4).EndInit();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)contextMenuStrip2).ResumeLayout(false);
		((Control)contextMenuStrip3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
