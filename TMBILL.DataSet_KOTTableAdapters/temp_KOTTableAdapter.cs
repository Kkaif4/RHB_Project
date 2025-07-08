using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL.DataSet_KOTTableAdapters;

[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
public class temp_KOTTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private SqlConnection _connection;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private SqlDataAdapter Adapter
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public temp_KOTTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		dataTableMapping.DataSetTable = "temp_KOT";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("tablename", "tablename");
		dataTableMapping.ColumnMappings.Add("itemname", "itemname");
		dataTableMapping.ColumnMappings.Add("qty", "qty");
		dataTableMapping.ColumnMappings.Add("price", "price");
		dataTableMapping.ColumnMappings.Add("amount", "amount");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[temp_KOT] ([tablename], [itemname], [qty], [price], [amount]) VALUES (@tablename, @itemname, @qty, @price, @amount)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tablename", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tablename", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "itemname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@qty", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "qty", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "price", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@amount", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "amount", DataRowVersion.Current, false, (object)null, "", "", ""));
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
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, tablename, itemname, qty, price, amount FROM dbo.temp_KOT";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(DataSet_KOT.temp_KOTDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual DataSet_KOT.temp_KOTDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet_KOT.temp_KOTDataTable temp_KOTDataTable = new DataSet_KOT.temp_KOTDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)temp_KOTDataTable);
		return temp_KOTDataTable;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet_KOT.temp_KOTDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet_KOT dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "temp_KOT");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Insert(string tablename, string itemname, string qty, string price, string amount)
	{
		if (tablename == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = tablename;
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
		if (amount == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = amount;
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
