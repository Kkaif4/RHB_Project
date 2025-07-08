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

public class r_Bank_management : MetroForm
{
	private string gid = "";

	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox4;

	private MetroTextBox metroTextBox5;

	private MetroComboBox metroComboBox2;

	private MetroTextBox metroTextBox6;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private MetroGrid metroGrid1;

	private MetroTextBox metroTextBox7;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column8;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private ErrorProvider errorProvider1;

	public r_Bank_management()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		Button obj = button2;
		bool enabled = (((Control)button4).Enabled = false);
		((Control)obj).Enabled = enabled;
		bindgrid();
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
				((DbCommand)(object)val2).CommandText = "select * from r_bank_management where account_name like '" + ((Control)metroTextBox7).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[8]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString(),
							((DbDataReader)(object)val3)[4].ToString(),
							((DbDataReader)(object)val3)[5].ToString(),
							((DbDataReader)(object)val3)[6].ToString(),
							((DbDataReader)(object)val3)[7].ToString()
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

	private void metroTextBox7_TextChanged(object sender, EventArgs e)
	{
		bindgrid();
	}

	private void r_Bank_management_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	public void resetMethod()
	{
		gid = "";
		((Control)button1).Enabled = true;
		Button obj = button2;
		bool enabled = (((Control)button4).Enabled = false);
		((Control)obj).Enabled = enabled;
		MetroTextBox obj2 = metroTextBox1;
		MetroTextBox obj3 = metroTextBox2;
		MetroTextBox obj4 = metroTextBox3;
		MetroTextBox obj5 = metroTextBox4;
		MetroTextBox obj6 = metroTextBox5;
		string text = (((Control)metroTextBox6).Text = "");
		text = (((Control)obj6).Text = text);
		text = (((Control)obj5).Text = text);
		text = (((Control)obj4).Text = text);
		text = (((Control)obj3).Text = text);
		((Control)obj2).Text = text;
		((ListControl)metroComboBox2).SelectedIndex = -1;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		resetMethod();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button1).Enabled = false;
		Button obj = button2;
		bool enabled = (((Control)button4).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox1).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[2].Value.ToString();
		((Control)metroTextBox3).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[3].Value.ToString();
		((Control)metroTextBox4).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[4].Value.ToString();
		((Control)metroTextBox5).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[5].Value.ToString();
		((Control)metroComboBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[6].Value.ToString();
		((Control)metroTextBox6).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[7].Value.ToString();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131140)
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
				resetMethod();
				return true;
			case 2:
				break;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		DeleteMethod();
		return true;
	}

	private void SaveFunction()
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Invalid comparison between I4 and Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between I4 and Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("9", "Insert"))
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
							((DbCommand)(object)val2).CommandText = "insert into r_bank_management(account_name,bank_name,branch_name,branch_code,account_no,account_type,ifsc_code) values('" + ((Control)metroTextBox1).Text + "','" + ((Control)metroTextBox2).Text + "','" + ((Control)metroTextBox3).Text + "','" + ((Control)metroTextBox4).Text + "','" + ((Control)metroTextBox5).Text + "','" + ((Control)metroComboBox2).Text + "','" + ((Control)metroTextBox6).Text + "')";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindgrid();
							resetMethod();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Bank Details Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
				catch (Exception ex)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Something Went Wrong\n" + ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void UpdateMethod()
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Invalid comparison between I4 and Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between I4 and Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Invalid comparison between I4 and Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Invalid comparison between I4 and Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("9", "Update"))
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
								((DbCommand)(object)val2).CommandText = "update r_bank_management set account_name='" + ((Control)metroTextBox1).Text + "',bank_name='" + ((Control)metroTextBox2).Text + "',branch_name='" + ((Control)metroTextBox3).Text + "',branch_code='" + ((Control)metroTextBox4).Text + "',account_no='" + ((Control)metroTextBox5).Text + "',account_type='" + ((Control)metroComboBox2).Text + "',ifsc_code='" + ((Control)metroTextBox6).Text + "' where id='" + gid + "'";
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								resetMethod();
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
					catch (Exception ex)
					{
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Something Went Wrong\n" + ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		if (new USER_PERMISSION().Permission("9", "Delete"))
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
								string commandText = "delete from r_bank_management where id='" + gid + "'";
								((DbCommand)(object)val2).CommandText = commandText;
								((DbCommand)(object)val2).ExecuteNonQuery();
								((DbConnection)(object)val).Close();
								bindgrid();
								resetMethod();
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
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		UpdateMethod();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		DeleteMethod();
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Account Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter Bank Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Enter Branch Code");
			e.Cancel = true;
		}
	}

	private void metroTextBox5_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox5).Text == "" || !new RegualarExpress().doublevalue(((Control)metroTextBox5).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox5, "Enter valid Account NO");
			e.Cancel = true;
		}
	}

	private void metroComboBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox5, "Select Account Type");
			e.Cancel = true;
		}
	}

	private void metroTextBox6_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox6).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox6, "Enter IFSC Code");
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

	private void metroTextBox4_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox4, "");
	}

	private void metroTextBox5_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox5, "");
	}

	private void metroComboBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox2, "");
	}

	private void metroTextBox6_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox6, "");
	}

	private void r_Bank_management_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
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
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected O, but got Unknown
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected O, but got Unknown
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Expected O, but got Unknown
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected O, but got Unknown
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected O, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected O, but got Unknown
		//IL_1131: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Expected O, but got Unknown
		//IL_123f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Expected O, but got Unknown
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected O, but got Unknown
		//IL_141e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1428: Expected O, but got Unknown
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f4: Expected O, but got Unknown
		//IL_1863: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Expected O, but got Unknown
		//IL_1957: Unknown result type (might be due to invalid IL or missing references)
		//IL_1961: Expected O, but got Unknown
		//IL_1b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b52: Expected O, but got Unknown
		//IL_1b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b95: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_Bank_management));
		metroTextBox1 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		metroTextBox5 = new MetroTextBox();
		metroComboBox2 = new MetroComboBox();
		metroTextBox6 = new MetroTextBox();
		button3 = new Button();
		button4 = new Button();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		metroTextBox7 = new MetroTextBox();
		errorProvider1 = new ErrorProvider(components);
		button2 = new Button();
		button1 = new Button();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(24, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Account Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(285, 29);
		((Control)metroTextBox1).TabIndex = 1;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Account Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(23, 98);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Bank Name";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(285, 29);
		((Control)metroTextBox2).TabIndex = 2;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Bank Name";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(27, 27);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)1;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(23, 133);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Branch Name";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(285, 29);
		((Control)metroTextBox3).TabIndex = 3;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Branch Name";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(27, 27);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)1;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(23, 168);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Branch Code";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(285, 29);
		((Control)metroTextBox4).TabIndex = 4;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Branch Code";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(27, 27);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)1;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(23, 203);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter Account No";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(285, 29);
		((Control)metroTextBox5).TabIndex = 5;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter Account No";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox5).Validating += metroTextBox5_Validating;
		((Control)metroTextBox5).Validated += metroTextBox5_Validated;
		((ListControl)metroComboBox2).FormattingEnabled = true;
		((ComboBox)metroComboBox2).ItemHeight = 23;
		((ComboBox)metroComboBox2).Items.AddRange(new object[2] { "Saving", "Current" });
		((Control)metroComboBox2).Location = new Point(23, 238);
		((Control)metroComboBox2).Name = "metroComboBox2";
		metroComboBox2.PromptText = "Account Type";
		((Control)metroComboBox2).Size = new Size(285, 29);
		((Control)metroComboBox2).TabIndex = 6;
		metroComboBox2.UseSelectable = true;
		((Control)metroComboBox2).Validating += metroComboBox2_Validating;
		((Control)metroComboBox2).Validated += metroComboBox2_Validated;
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(257, 1);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(27, 27);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)1;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(23, 273);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Enter IFSC Code";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(285, 29);
		((Control)metroTextBox6).TabIndex = 7;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Enter IFSC Code";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox6).Validating += metroTextBox6_Validating;
		((Control)metroTextBox6).Validated += metroTextBox6_Validated;
		((Control)button3).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.reset;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(157, 379);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(144, 51);
		((Control)button3).TabIndex = 11;
		((Control)button3).Text = "   &Reset (R)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.Red;
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.delete;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(23, 379);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(128, 51);
		((Control)button4).TabIndex = 10;
		((Control)button4).Text = "      &Delete (D)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
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
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column8,
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
		((Control)metroGrid1).Location = new Point(317, 63);
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
		((Control)metroGrid1).Size = new Size(774, 371);
		((Control)metroGrid1).TabIndex = 12;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Account Name";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 150;
		((DataGridViewColumn)Column3).HeaderText = "Bank Name";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 150;
		((DataGridViewColumn)Column4).HeaderText = "Branch Name";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column8).HeaderText = "Branch Code";
		((DataGridViewColumn)Column8).Name = "Column8";
		((DataGridViewBand)Column8).ReadOnly = true;
		((DataGridViewBand)Column8).Visible = false;
		((DataGridViewColumn)Column5).HeaderText = "Account No";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column5).Width = 150;
		((DataGridViewColumn)Column6).HeaderText = "Account Type";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column7).HeaderText = "IFSC CODE";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 120;
		metroTextBox7.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox7.CustomButton).Location = new Point(304, 1);
		((Control)metroTextBox7.CustomButton).Name = "";
		((Control)metroTextBox7.CustomButton).Size = new Size(27, 27);
		metroTextBox7.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox7.CustomButton).TabIndex = 1;
		metroTextBox7.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox7.CustomButton.UseSelectable = true;
		metroTextBox7.FontSize = (MetroTextBoxSize)1;
		metroTextBox7.Lines = new string[0];
		((Control)metroTextBox7).Location = new Point(317, 28);
		metroTextBox7.MaxLength = 32767;
		((Control)metroTextBox7).Name = "metroTextBox7";
		metroTextBox7.PasswordChar = '\0';
		metroTextBox7.PromptText = "Search Account Name";
		metroTextBox7.ScrollBars = (ScrollBars)0;
		metroTextBox7.SelectedText = "";
		metroTextBox7.SelectionLength = 0;
		metroTextBox7.SelectionStart = 0;
		metroTextBox7.ShortcutsEnabled = true;
		metroTextBox7.ShowButton = true;
		metroTextBox7.ShowClearButton = true;
		((Control)metroTextBox7).Size = new Size(332, 29);
		((Control)metroTextBox7).TabIndex = 13;
		metroTextBox7.UseSelectable = true;
		metroTextBox7.WaterMark = "Search Account Name";
		metroTextBox7.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox7.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox7).TextChanged += metroTextBox7_TextChanged;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((Control)button2).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(157, 322);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(144, 51);
		((Control)button2).TabIndex = 9;
		((Control)button2).Text = "    &Update (U)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).BackColor = Color.DarkGreen;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.purse;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(23, 322);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(128, 51);
		((Control)button1).TabIndex = 8;
		((Control)button1).Text = "    &Save (S)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1114, 448);
		((Control)this).Controls.Add((Control)(object)metroTextBox7);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox6);
		((Control)this).Controls.Add((Control)(object)metroComboBox2);
		((Control)this).Controls.Add((Control)(object)metroTextBox5);
		((Control)this).Controls.Add((Control)(object)metroTextBox4);
		((Control)this).Controls.Add((Control)(object)metroTextBox3);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_Bank_management";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Bank Management";
		((Form)this).FormClosed += new FormClosedEventHandler(r_Bank_management_FormClosed);
		((Form)this).Load += r_Bank_management_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
