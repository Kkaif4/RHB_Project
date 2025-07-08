using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL.DataSet_TAKEAWAYTableAdapters;

[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class r_takeaway_detailTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public r_takeaway_detailTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "r_takeaway_detail";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("invoice_id", "invoice_id");
		dataTableMapping.ColumnMappings.Add("itemname", "itemname");
		dataTableMapping.ColumnMappings.Add("qty", "qty");
		dataTableMapping.ColumnMappings.Add("price", "price");
		dataTableMapping.ColumnMappings.Add("total", "total");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[r_takeaway_detail] ([invoice_id], [itemname], [qty], [price], [total]) VALUES (@invoice_id, @itemname, @qty, @price, @total)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@invoice_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "invoice_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "itemname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@qty", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "qty", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "price", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitConnection()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		_connection = new SqlConnection();
		((DbConnection)(object)_connection).ConnectionString = Settings.Default.DBASEConnectionString;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, invoice_id, itemname, qty, price, total FROM dbo.r_takeaway_detail";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(DataSet_TAKEAWAY.r_takeaway_detailDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual DataSet_TAKEAWAY.r_takeaway_detailDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet_TAKEAWAY.r_takeaway_detailDataTable r_takeaway_detailDataTable = new DataSet_TAKEAWAY.r_takeaway_detailDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)r_takeaway_detailDataTable);
		return r_takeaway_detailDataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet_TAKEAWAY.r_takeaway_detailDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet_TAKEAWAY dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "r_takeaway_detail");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Insert(string invoice_id, string itemname, string qty, string price, string total)
	{
		if (invoice_id == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = invoice_id;
		}
		if (itemname == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = itemname;
		}
		if (qty == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = qty;
		}
		if (price == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = price;
		}
		if (total == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = total;
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
