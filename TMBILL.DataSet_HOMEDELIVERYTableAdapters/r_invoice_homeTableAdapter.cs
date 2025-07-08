using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL.DataSet_HOMEDELIVERYTableAdapters;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class r_invoice_homeTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal SqlTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if (Adapter != null && Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public r_invoice_homeTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "r_invoice_home";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("waitername", "waitername");
		dataTableMapping.ColumnMappings.Add("customername", "customername");
		dataTableMapping.ColumnMappings.Add("total", "total");
		dataTableMapping.ColumnMappings.Add("selectedtax", "selectedtax");
		dataTableMapping.ColumnMappings.Add("isigst", "isigst");
		dataTableMapping.ColumnMappings.Add("igst", "igst");
		dataTableMapping.ColumnMappings.Add("cgst", "cgst");
		dataTableMapping.ColumnMappings.Add("sgst", "sgst");
		dataTableMapping.ColumnMappings.Add("totalwithtax", "totalwithtax");
		dataTableMapping.ColumnMappings.Add("discounttype", "discounttype");
		dataTableMapping.ColumnMappings.Add("discountamt", "discountamt");
		dataTableMapping.ColumnMappings.Add("grandtotal", "grandtotal");
		dataTableMapping.ColumnMappings.Add("paymenttype", "paymenttype");
		dataTableMapping.ColumnMappings.Add("mydate", "mydate");
		dataTableMapping.ColumnMappings.Add("inwords", "inwords");
		dataTableMapping.ColumnMappings.Add("paidamt", "paidamt");
		dataTableMapping.ColumnMappings.Add("remainingamt", "remainingamt");
		dataTableMapping.ColumnMappings.Add("orderfrom", "orderfrom");
		dataTableMapping.ColumnMappings.Add("extra_tax_s", "extra_tax_s");
		dataTableMapping.ColumnMappings.Add("extra_tax_amt", "extra_tax_amt");
		dataTableMapping.ColumnMappings.Add("extra_tax_tot", "extra_tax_tot");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[r_invoice_home] ([waitername], [customername], [total], [selectedtax], [isigst], [igst], [cgst], [sgst], [totalwithtax], [discounttype], [discountamt], [grandtotal], [paymenttype], [mydate], [inwords], [paidamt], [remainingamt], [orderfrom], [extra_tax_s], [extra_tax_amt], [extra_tax_tot]) VALUES (@waitername, @customername, @total, @selectedtax, @isigst, @igst, @cgst, @sgst, @totalwithtax, @discounttype, @discountamt, @grandtotal, @paymenttype, @mydate, @inwords, @paidamt, @remainingamt, @orderfrom, @extra_tax_s, @extra_tax_amt, @extra_tax_tot)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@waitername", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "waitername", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@customername", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "customername", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@selectedtax", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "selectedtax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@isigst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "isigst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@igst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "igst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@cgst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "cgst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sgst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "sgst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@totalwithtax", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "totalwithtax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@discounttype", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "discounttype", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@discountamt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "discountamt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@grandtotal", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "grandtotal", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@paymenttype", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "paymenttype", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mydate", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mydate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@inwords", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "inwords", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@paidamt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "paidamt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@remainingamt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "remainingamt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@orderfrom", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "orderfrom", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@extra_tax_s", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "extra_tax_s", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@extra_tax_amt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "extra_tax_amt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@extra_tax_tot", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "extra_tax_tot", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitConnection()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		_connection = new SqlConnection();
		((DbConnection)(object)_connection).ConnectionString = Settings.Default.DBASEConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, waitername, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax, discounttype, discountamt, grandtotal, paymenttype, mydate, inwords, paidamt, remainingamt, orderfrom, extra_tax_s, extra_tax_amt, extra_tax_tot FROM dbo.r_invoice_home";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Fill(DataSet_HOMEDELIVERY.r_invoice_homeDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual DataSet_HOMEDELIVERY.r_invoice_homeDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet_HOMEDELIVERY.r_invoice_homeDataTable r_invoice_homeDataTable = new DataSet_HOMEDELIVERY.r_invoice_homeDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)r_invoice_homeDataTable);
		return r_invoice_homeDataTable;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet_HOMEDELIVERY.r_invoice_homeDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet_HOMEDELIVERY dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "r_invoice_home");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(string waitername, string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string mydate, string inwords, string paidamt, string remainingamt, string orderfrom, string extra_tax_s, string extra_tax_amt, string extra_tax_tot)
	{
		if (waitername == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = waitername;
		}
		if (customername == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = customername;
		}
		if (total == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = total;
		}
		if (selectedtax == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = selectedtax;
		}
		if (isigst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = isigst;
		}
		if (igst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = igst;
		}
		if (cgst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = cgst;
		}
		if (sgst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = sgst;
		}
		if (totalwithtax == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = totalwithtax;
		}
		if (discounttype == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = discounttype;
		}
		if (discountamt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = discountamt;
		}
		if (grandtotal == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = grandtotal;
		}
		if (paymenttype == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[12]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[12]).Value = paymenttype;
		}
		if (mydate == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[13]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[13]).Value = mydate;
		}
		if (inwords == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[14]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[14]).Value = inwords;
		}
		if (paidamt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[15]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[15]).Value = paidamt;
		}
		if (remainingamt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[16]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[16]).Value = remainingamt;
		}
		if (orderfrom == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[17]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[17]).Value = orderfrom;
		}
		if (extra_tax_s == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[18]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[18]).Value = extra_tax_s;
		}
		if (extra_tax_amt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[19]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[19]).Value = extra_tax_amt;
		}
		if (extra_tax_tot == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[20]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[20]).Value = extra_tax_tot;
		}
		ConnectionState state = ((DbConnection)(object)Adapter.InsertCommand.Connection).State;
		if ((((DbConnection)(object)Adapter.InsertCommand.Connection).State & ConnectionState.Open) != ConnectionState.Open)
		{
			((DbConnection)(object)Adapter.InsertCommand.Connection).Open();
		}
		try
		{
			return ((DbCommand)(object)Adapter.InsertCommand).ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				((DbConnection)(object)Adapter.InsertCommand.Connection).Close();
			}
		}
	}
}
