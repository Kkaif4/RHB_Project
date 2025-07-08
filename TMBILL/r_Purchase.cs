#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using TMBILL.Properties;

namespace TMBILL;

public class r_Purchase : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroTextBox metroTextBox2;

	private Button button1;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column5;

	private DataGridViewTextBoxColumn Column6;

	private DataGridViewTextBoxColumn Column7;

	private MetroComboBox metroComboBox1;

	private MetroDateTime metroDateTime1;

	private Label label1;

	private Label label2;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private ErrorProvider errorProvider1;

	private SaveFileDialog saveFileDialog1;

	public r_Purchase()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindRawText();
		bindcombo();
	}

	private void bindcombo()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((ComboBox)metroComboBox1).Items.Clear();
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
					((DbCommand)(object)val2).CommandText = "select * from r_vendor";
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
		catch
		{
		}
	}

	private void bindRawText()
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
				((DbCommand)(object)val3).CommandText = "select * from raw_item";
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
		metroTextBox1.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox1.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox1.AutoCompleteCustomSource = val;
	}

	private void r_Purchase_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		ResetMethod();
	}

	private void ResetMethod()
	{
		((DataGridView)metroGrid1).Rows.Clear();
		((ListControl)metroComboBox1).SelectedIndex = -1;
		((Control)metroTextBox1).Text = "";
		((Control)metroTextBox2).Text = "";
		((Control)label2).Text = "";
	}

	private void button1_Click(object sender, EventArgs e)
	{
		AddMethod();
	}

	private void AddMethod()
	{
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Invalid comparison between I4 and Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Invalid comparison between I4 and Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		if (((ContainerControl)this).ValidateChildren())
		{
			if (validateName())
			{
				string text = priviousexixt();
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "select * from raw_item where name='" + ((Control)metroTextBox1).Text + "'";
						SqlDataReader val3 = val2.ExecuteReader();
						if (((DbDataReader)(object)val3).HasRows)
						{
							while (((DbDataReader)(object)val3).Read())
							{
								text2 = ((DbDataReader)(object)val3)["igst"].ToString();
								text3 = ((DbDataReader)(object)val3)["sgst"].ToString();
								text4 = ((DbDataReader)(object)val3)["cgst"].ToString();
								text5 = ((DbDataReader)(object)val3)["price"].ToString();
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
				double num = gettoal(text5);
				if (text == "-1")
				{
					((DataGridView)metroGrid1).Rows.Add(new object[7]
					{
						((Control)metroTextBox1).Text,
						text5,
						((Control)metroTextBox2).Text,
						text2,
						text3,
						text4,
						num.ToString()
					});
				}
				else
				{
					double num2 = double.Parse(((DataGridView)metroGrid1).Rows[int.Parse(text)].Cells[2].Value.ToString());
					double num3 = double.Parse(((DataGridView)metroGrid1).Rows[int.Parse(text)].Cells[6].Value.ToString());
					double num4 = num2 + double.Parse(((Control)metroTextBox2).Text);
					double num5 = num3 + num;
					((DataGridView)metroGrid1).Rows[int.Parse(text)].Cells[2].Value = num4.ToString();
					((DataGridView)metroGrid1).Rows[int.Parse(text)].Cells[6].Value = num5.ToString();
				}
				((Control)metroTextBox1).Text = "";
				((Control)metroTextBox2).Text = "";
				((Control)metroTextBox1).Focus();
				((DataGridView)metroGrid1).ClearSelection();
				calculatetotal();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Item name not avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill item Name/Quantity", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void calculatetotal()
	{
		double num = 0.0;
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			num += double.Parse(((DataGridView)metroGrid1).Rows[i].Cells[6].Value.ToString());
		}
		((Control)label2).Text = num.ToString();
	}

	private double gettoal(string price)
	{
		Debug.WriteLine(price);
		double num = double.Parse(((Control)metroTextBox2).Text);
		double num2 = double.Parse(price);
		return num * num2;
	}

	private string priviousexixt()
	{
		string result = "-1";
		for (int i = 0; i < ((DataGridView)metroGrid1).Rows.Count; i++)
		{
			string text = ((DataGridView)metroGrid1).Rows[i].Cells[0].Value.ToString();
			if (text == ((Control)metroTextBox1).Text)
			{
				result = i.ToString();
			}
		}
		return result;
	}

	private bool validateName()
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
				((DbCommand)(object)val2).CommandText = "select * from raw_item where name='" + ((Control)metroTextBox1).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					return true;
				}
				return false;
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
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Raw Material Name");
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
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter Quantity");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		RemoveMethod();
	}

	private void RemoveMethod()
	{
		((DataGridView)metroGrid1).Rows.Remove(((DataGridView)metroGrid1).SelectedRows[0]);
		calculatetotal();
		((Control)metroTextBox1).Focus();
	}

	private void button4_Click(object sender, EventArgs e)
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

	private void loading()
	{
		Application.Run((Form)(object)new Loading());
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

	private void button2_Click(object sender, EventArgs e)
	{
		SaveMethod();
	}

	private void SaveMethod()
	{
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Invalid comparison between I4 and Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Invalid comparison between I4 and Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Invalid comparison between I4 and Unknown
		if (((DataGridView)metroGrid1).Rows.Count > 0)
		{
			if (((Control)metroComboBox1).Text != "")
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
						((DbCommand)(object)val2).CommandText = "purchase_stored";
						((DbParameter)(object)val2.Parameters.Add("@name", SqlDbType.VarChar)).Value = ((Control)metroComboBox1).Text;
						((DbParameter)(object)val2.Parameters.Add("@total", SqlDbType.VarChar)).Value = ((Control)label2).Text;
						((DbParameter)(object)val2.Parameters.Add("@mydate", SqlDbType.VarChar)).Value = ((Control)metroDateTime1).Text;
						((DbParameter)(object)val2.Parameters.Add("@id", SqlDbType.VarChar, 50)).Direction = ParameterDirection.Output;
						((DbCommand)(object)val2).ExecuteNonQuery();
						string text = ((DbParameter)(object)val2.Parameters["@id"]).Value.ToString();
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
									((DbCommand)(object)val4).CommandText = "insert into purchase_detail(p_id,name,price,qty,igst,cgst,sgst,total) values('" + text + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[0].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[1].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[2].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[3].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[4].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[5].Value.ToString() + "','" + ((DataGridView)metroGrid1).Rows[i].Cells[6].Value.ToString() + "')";
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
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Purchase Added in Database", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
					ResetMethod();
					((Control)this).Focus();
					((Form)this).Activate();
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Vendor Name", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Add Data in table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData <= 131141)
		{
			switch (keyData - 112)
			{
			case 0:
				AddMethod();
				return true;
			case 1:
				RemoveMethod();
				return true;
			}
			if ((int)keyData == 131141)
			{
				ExporttoExcel();
				return true;
			}
		}
		else
		{
			switch (keyData - 131154)
			{
			case 1:
				SaveMethod();
				return true;
			case 0:
				ResetMethod();
				return true;
			}
			if ((int)keyData == 262232)
			{
				errorProvider1.Clear();
				((Control)metroTextBox1).Text = "-";
				((Control)MainFrom.static_mainform).Focus();
				((Form)MainFrom.static_mainform).Activate();
				((Form)this).Close();
				return true;
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void r_Purchase_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)MainFrom.static_mainform).Focus();
		((Form)MainFrom.static_mainform).Activate();
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
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected O, but got Unknown
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected O, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected O, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected O, but got Unknown
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f70: Expected O, but got Unknown
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected O, but got Unknown
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected O, but got Unknown
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1267: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_Purchase));
		metroTextBox1 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		button1 = new Button();
		metroGrid1 = new MetroGrid();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		metroComboBox1 = new MetroComboBox();
		metroDateTime1 = new MetroDateTime();
		label1 = new Label();
		label2 = new Label();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		errorProvider1 = new ErrorProvider(components);
		saveFileDialog1 = new SaveFileDialog();
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox1.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox1.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox1.CustomButton).Location = new Point(276, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(23, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Search Raw Material";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(304, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Search Raw Material";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		metroTextBox2.AutoCompleteMode = (AutoCompleteMode)3;
		metroTextBox2.AutoCompleteSource = (AutoCompleteSource)64;
		metroTextBox2.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox2.CustomButton).Location = new Point(276, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(345, 63);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Quantity";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(304, 29);
		((Control)metroTextBox2).TabIndex = 1;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Quantity";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		((Control)button1).BackColor = Color.Green;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(666, 50);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(132, 41);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "Add (F1)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
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
		((Control)metroGrid1).Location = new Point(23, 105);
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
		((Control)metroGrid1).Size = new Size(1055, 444);
		((Control)metroGrid1).TabIndex = 4;
		((DataGridViewColumn)Column1).HeaderText = "Item Name";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Width = 250;
		((DataGridViewColumn)Column2).HeaderText = "Price";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column3).HeaderText = "Qty";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column4).HeaderText = "IGST";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewColumn)Column5).HeaderText = "CGST";
		((DataGridViewColumn)Column5).Name = "Column5";
		((DataGridViewBand)Column5).ReadOnly = true;
		((DataGridViewColumn)Column6).HeaderText = "SGST";
		((DataGridViewColumn)Column6).Name = "Column6";
		((DataGridViewBand)Column6).ReadOnly = true;
		((DataGridViewColumn)Column7).HeaderText = "Total Amount";
		((DataGridViewColumn)Column7).Name = "Column7";
		((DataGridViewBand)Column7).ReadOnly = true;
		((DataGridViewColumn)Column7).Width = 170;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((ComboBox)metroComboBox1).Items.AddRange(new object[1] { "Default" });
		((Control)metroComboBox1).Location = new Point(23, 575);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Vendor";
		((Control)metroComboBox1).Size = new Size(276, 29);
		((Control)metroComboBox1).TabIndex = 5;
		metroComboBox1.UseSelectable = true;
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(314, 575);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 6;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(557, 581);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(49, 18);
		((Control)label1).TabIndex = 6;
		((Control)label1).Text = "Total :";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(629, 581);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(0, 18);
		((Control)label2).TabIndex = 7;
		((Control)button2).BackColor = Color.Green;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((Control)button2).Location = new Point(720, 571);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(132, 42);
		((Control)button2).TabIndex = 7;
		((Control)button2).Text = "Save (S)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button3).BackColor = Color.FromArgb(0, 0, 192);
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((Control)button3).Location = new Point(881, 572);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(132, 42);
		((Control)button3).TabIndex = 9;
		((Control)button3).Text = "Reset (R)";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((Control)button4).Location = new Point(963, 50);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(132, 41);
		((Control)button4).TabIndex = 8;
		((Control)button4).Text = "&Export (E)";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button5).BackColor = Color.Red;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((Control)button5).Location = new Point(814, 50);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(132, 41);
		((Control)button5).TabIndex = 3;
		((Control)button5).Text = "Remove (F2)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((FileDialog)saveFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1118, 627);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)metroDateTime1);
		((Control)this).Controls.Add((Control)(object)metroComboBox1);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_Purchase";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Purchase";
		((Form)this).FormClosed += new FormClosedEventHandler(r_Purchase_FormClosed);
		((Form)this).Load += r_Purchase_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
