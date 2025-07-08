using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL.DataSet_purchaseTableAdapters;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
public class purchase_detailTableAdapter : Component
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
	public purchase_detailTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "purchase_detail";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("p_id", "p_id");
		dataTableMapping.ColumnMappings.Add("name", "name");
		dataTableMapping.ColumnMappings.Add("price", "price");
		dataTableMapping.ColumnMappings.Add("qty", "qty");
		dataTableMapping.ColumnMappings.Add("igst", "igst");
		dataTableMapping.ColumnMappings.Add("cgst", "cgst");
		dataTableMapping.ColumnMappings.Add("sgst", "sgst");
		dataTableMapping.ColumnMappings.Add("total", "total");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[purchase_detail] ([p_id], [name], [price], [qty], [igst], [cgst], [sgst], [total]) VALUES (@p_id, @name, @price, @qty, @igst, @cgst, @sgst, @total)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "p_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "price", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@qty", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "qty", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@igst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "igst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@cgst", SqlDbType.NChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "cgst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sgst", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "sgst", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total", DataRowVersion.Current, false, (object)null, "", "", ""));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		_commandCollection = (SqlCommand[])(object)new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, p_id, name, price, qty, igst, cgst, sgst, total FROM dbo.purchase_detail";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	public virtual int Fill(DataSet_purchase.purchase_detailDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual DataSet_purchase.purchase_detailDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet_purchase.purchase_detailDataTable purchase_detailDataTable = new DataSet_purchase.purchase_detailDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)purchase_detailDataTable);
		return purchase_detailDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSet_purchase.purchase_detailDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataSet_purchase dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "purchase_detail");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Insert(int? p_id, string name, string price, string qty, string igst, string cgst, string sgst, string total)
	{
		if (p_id.HasValue)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = p_id.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		if (name == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = name;
		}
		if (price == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = price;
		}
		if (qty == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = qty;
		}
		if (igst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = igst;
		}
		if (cgst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = cgst;
		}
		if (sgst == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = sgst;
		}
		if (total == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = total;
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
