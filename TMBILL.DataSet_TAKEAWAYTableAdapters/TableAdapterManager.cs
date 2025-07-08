#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TMBILL.DataSet_TAKEAWAYTableAdapters;

[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
[ToolboxItem(true)]
public class TableAdapterManager : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private DataRow GetRoot(DataRow row, out int distance)
		{
			Debug.Assert(row != null);
			DataRow result = row;
			distance = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[row] = row;
			DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
			while (parentRow != null && !dictionary.ContainsKey(parentRow))
			{
				distance++;
				result = parentRow;
				dictionary[parentRow] = parentRow;
				parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
			}
			if (distance == 0)
			{
				dictionary.Clear();
				dictionary[row] = row;
				parentRow = row.GetParentRow(_relation, DataRowVersion.Original);
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					distance++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
				}
			}
			return result;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Compare(DataRow row1, DataRow row2)
		{
			if (object.ReferenceEquals(row1, row2))
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int distance = 0;
			DataRow root = GetRoot(row1, out distance);
			int distance2 = 0;
			DataRow root2 = GetRoot(row2, out distance2);
			if (object.ReferenceEquals(root, root2))
			{
				return _childFirst * distance.CompareTo(distance2);
			}
			Debug.Assert(root.Table != null && root2.Table != null);
			if (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
			{
				return -1;
			}
			return 1;
		}
	}

	private UpdateOrderOption _updateOrder;

	private r_takeaway_detailTableAdapter _r_takeaway_detailTableAdapter;

	private r_invoice_takeawayTableAdapter _r_invoice_takeawayTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public r_takeaway_detailTableAdapter r_takeaway_detailTableAdapter
	{
		get
		{
			return _r_takeaway_detailTableAdapter;
		}
		set
		{
			_r_takeaway_detailTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public r_invoice_takeawayTableAdapter r_invoice_takeawayTableAdapter
	{
		get
		{
			return _r_invoice_takeawayTableAdapter;
		}
		set
		{
			_r_invoice_takeawayTableAdapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if (_r_takeaway_detailTableAdapter != null && _r_takeaway_detailTableAdapter.Connection != null)
			{
				return (IDbConnection)_r_takeaway_detailTableAdapter.Connection;
			}
			if (_r_invoice_takeawayTableAdapter != null && _r_invoice_takeawayTableAdapter.Connection != null)
			{
				return (IDbConnection)_r_invoice_takeawayTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public int TableAdapterInstanceCount
	{
		get
		{
			int num = 0;
			if (_r_takeaway_detailTableAdapter != null)
			{
				num++;
			}
			if (_r_invoice_takeawayTableAdapter != null)
			{
				num++;
			}
			return num;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateUpdatedRows(DataSet_TAKEAWAY dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		int num = 0;
		if (_r_invoice_takeawayTableAdapter != null)
		{
			DataRow[] updatedRows = dataSet.r_invoice_takeaway.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
			if (updatedRows != null && 0 < updatedRows.Length)
			{
				num += _r_invoice_takeawayTableAdapter.Update(updatedRows);
				allChangedRows.AddRange(updatedRows);
			}
		}
		if (_r_takeaway_detailTableAdapter != null)
		{
			DataRow[] updatedRows = dataSet.r_takeaway_detail.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
			if (updatedRows != null && 0 < updatedRows.Length)
			{
				num += _r_takeaway_detailTableAdapter.Update(updatedRows);
				allChangedRows.AddRange(updatedRows);
			}
		}
		return num;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private int UpdateInsertedRows(DataSet_TAKEAWAY dataSet, List<DataRow> allAddedRows)
	{
		int num = 0;
		if (_r_invoice_takeawayTableAdapter != null)
		{
			DataRow[] array = dataSet.r_invoice_takeaway.Select(null, null, DataViewRowState.Added);
			if (array != null && 0 < array.Length)
			{
				num += _r_invoice_takeawayTableAdapter.Update(array);
				allAddedRows.AddRange(array);
			}
		}
		if (_r_takeaway_detailTableAdapter != null)
		{
			DataRow[] array = dataSet.r_takeaway_detail.Select(null, null, DataViewRowState.Added);
			if (array != null && 0 < array.Length)
			{
				num += _r_takeaway_detailTableAdapter.Update(array);
				allAddedRows.AddRange(array);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateDeletedRows(DataSet_TAKEAWAY dataSet, List<DataRow> allChangedRows)
	{
		int num = 0;
		if (_r_takeaway_detailTableAdapter != null)
		{
			DataRow[] array = dataSet.r_takeaway_detail.Select(null, null, DataViewRowState.Deleted);
			if (array != null && 0 < array.Length)
			{
				num += _r_takeaway_detailTableAdapter.Update(array);
				allChangedRows.AddRange(array);
			}
		}
		if (_r_invoice_takeawayTableAdapter != null)
		{
			DataRow[] array = dataSet.r_invoice_takeaway.Select(null, null, DataViewRowState.Deleted);
			if (array != null && 0 < array.Length)
			{
				num += _r_invoice_takeawayTableAdapter.Update(array);
				allChangedRows.AddRange(array);
			}
		}
		return num;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in updatedRows)
		{
			if (!allAddedRows.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int UpdateAll(DataSet_TAKEAWAY dataSet)
	{
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if (_r_takeaway_detailTableAdapter != null && !MatchTableAdapterConnection((IDbConnection)_r_takeaway_detailTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_r_invoice_takeawayTableAdapter != null && !MatchTableAdapterConnection((IDbConnection)_r_invoice_takeawayTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		IDbConnection connection = Connection;
		if (connection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			connection.Close();
		}
		if (connection.State == ConnectionState.Closed)
		{
			connection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = connection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataAdapter> list3 = new List<DataAdapter>();
		Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet2 = null;
		if (BackupDataSetBeforeUpdate)
		{
			dataSet2 = new DataSet();
			dataSet2.Merge(dataSet);
		}
		try
		{
			if (_r_takeaway_detailTableAdapter != null)
			{
				dictionary.Add(_r_takeaway_detailTableAdapter, (IDbConnection)_r_takeaway_detailTableAdapter.Connection);
				_r_takeaway_detailTableAdapter.Connection = (SqlConnection)connection;
				_r_takeaway_detailTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (((DataAdapter)(object)_r_takeaway_detailTableAdapter.Adapter).AcceptChangesDuringUpdate)
				{
					((DataAdapter)(object)_r_takeaway_detailTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
					list3.Add((DataAdapter)(object)_r_takeaway_detailTableAdapter.Adapter);
				}
			}
			if (_r_invoice_takeawayTableAdapter != null)
			{
				dictionary.Add(_r_invoice_takeawayTableAdapter, (IDbConnection)_r_invoice_takeawayTableAdapter.Connection);
				_r_invoice_takeawayTableAdapter.Connection = (SqlConnection)connection;
				_r_invoice_takeawayTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (((DataAdapter)(object)_r_invoice_takeawayTableAdapter.Adapter).AcceptChangesDuringUpdate)
				{
					((DataAdapter)(object)_r_invoice_takeawayTableAdapter.Adapter).AcceptChangesDuringUpdate = false;
					list3.Add((DataAdapter)(object)_r_invoice_takeawayTableAdapter.Adapter);
				}
			}
			if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
			{
				num += UpdateUpdatedRows(dataSet, list, list2);
				num += UpdateInsertedRows(dataSet, list2);
			}
			else
			{
				num += UpdateInsertedRows(dataSet, list2);
				num += UpdateUpdatedRows(dataSet, list, list2);
			}
			num += UpdateDeletedRows(dataSet, list);
			dbTransaction.Commit();
			if (0 < list2.Count)
			{
				DataRow[] array = new DataRow[list2.Count];
				list2.CopyTo(array);
				foreach (DataRow dataRow in array)
				{
					dataRow.AcceptChanges();
				}
			}
			if (0 < list.Count)
			{
				DataRow[] array = new DataRow[list.Count];
				list.CopyTo(array);
				foreach (DataRow dataRow in array)
				{
					dataRow.AcceptChanges();
				}
			}
		}
		catch (Exception ex)
		{
			dbTransaction.Rollback();
			if (BackupDataSetBeforeUpdate)
			{
				Debug.Assert(dataSet2 != null);
				dataSet.Clear();
				dataSet.Merge(dataSet2);
			}
			else if (0 < list2.Count)
			{
				DataRow[] array = new DataRow[list2.Count];
				list2.CopyTo(array);
				foreach (DataRow dataRow in array)
				{
					dataRow.AcceptChanges();
					dataRow.SetAdded();
				}
			}
			throw ex;
		}
		finally
		{
			if (flag)
			{
				connection.Close();
			}
			if (_r_takeaway_detailTableAdapter != null)
			{
				_r_takeaway_detailTableAdapter.Connection = (SqlConnection)dictionary[_r_takeaway_detailTableAdapter];
				_r_takeaway_detailTableAdapter.Transaction = null;
			}
			if (_r_invoice_takeawayTableAdapter != null)
			{
				_r_invoice_takeawayTableAdapter.Connection = (SqlConnection)dictionary[_r_invoice_takeawayTableAdapter];
				_r_invoice_takeawayTableAdapter.Transaction = null;
			}
			if (0 < list3.Count)
			{
				DataAdapter[] array2 = new DataAdapter[list3.Count];
				list3.CopyTo(array2);
				foreach (DataAdapter dataAdapter in array2)
				{
					dataAdapter.AcceptChangesDuringUpdate = true;
				}
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
