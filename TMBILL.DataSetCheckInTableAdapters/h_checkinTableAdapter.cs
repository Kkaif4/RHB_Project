using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using TMBILL.Properties;

namespace TMBILL.DataSetCheckInTableAdapters;

[DataObject(true)]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
public class h_checkinTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private SqlConnection _connection;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	public h_checkinTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected O, but got Unknown
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "h_checkin";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("ref_by", "ref_by");
		dataTableMapping.ColumnMappings.Add("ref_name", "ref_name");
		dataTableMapping.ColumnMappings.Add("mobile_no", "mobile_no");
		dataTableMapping.ColumnMappings.Add("check_date", "check_date");
		dataTableMapping.ColumnMappings.Add("check_out_date", "check_out_date");
		dataTableMapping.ColumnMappings.Add("p_male", "p_male");
		dataTableMapping.ColumnMappings.Add("p_female", "p_female");
		dataTableMapping.ColumnMappings.Add("p_child", "p_child");
		dataTableMapping.ColumnMappings.Add("room_charge", "room_charge");
		dataTableMapping.ColumnMappings.Add("total_room_charge", "total_room_charge");
		dataTableMapping.ColumnMappings.Add("extra_charge", "extra_charge");
		dataTableMapping.ColumnMappings.Add("total_charge", "total_charge");
		dataTableMapping.ColumnMappings.Add("tax_amt", "tax_amt");
		dataTableMapping.ColumnMappings.Add("after_tax", "after_tax");
		dataTableMapping.ColumnMappings.Add("dis_amt", "dis_amt");
		dataTableMapping.ColumnMappings.Add("tax_plan", "tax_plan");
		dataTableMapping.ColumnMappings.Add("dis_plan", "dis_plan");
		dataTableMapping.ColumnMappings.Add("grand_total", "grand_total");
		dataTableMapping.ColumnMappings.Add("paid_amt", "paid_amt");
		dataTableMapping.ColumnMappings.Add("remaining", "remaining");
		dataTableMapping.ColumnMappings.Add("onlinebooked", "onlinebooked");
		dataTableMapping.ColumnMappings.Add("payment_method", "payment_method");
		dataTableMapping.ColumnMappings.Add("booking_date", "booking_date");
		dataTableMapping.ColumnMappings.Add("room_id", "room_id");
		dataTableMapping.ColumnMappings.Add("total_days", "total_days");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[h_checkin] ([ref_by], [ref_name], [mobile_no], [check_date], [check_out_date], [p_male], [p_female], [p_child], [room_charge], [total_room_charge], [extra_charge], [total_charge], [tax_amt], [after_tax], [dis_amt], [tax_plan], [dis_plan], [grand_total], [paid_amt], [remaining], [onlinebooked], [payment_method], [booking_date], [room_id], [total_days]) VALUES (@ref_by, @ref_name, @mobile_no, @check_date, @check_out_date, @p_male, @p_female, @p_child, @room_charge, @total_room_charge, @extra_charge, @total_charge, @tax_amt, @after_tax, @dis_amt, @tax_plan, @dis_plan, @grand_total, @paid_amt, @remaining, @onlinebooked, @payment_method, @booking_date, @room_id, @total_days)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ref_by", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ref_by", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ref_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ref_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mobile_no", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mobile_no", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@check_date", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "check_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@check_out_date", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "check_out_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p_male", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "p_male", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p_female", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "p_female", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p_child", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "p_child", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@room_charge", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "room_charge", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total_room_charge", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total_room_charge", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@extra_charge", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "extra_charge", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total_charge", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total_charge", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tax_amt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax_amt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@after_tax", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "after_tax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@dis_amt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "dis_amt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tax_plan", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax_plan", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@dis_plan", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "dis_plan", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@grand_total", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "grand_total", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@paid_amt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "paid_amt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@remaining", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "remaining", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@onlinebooked", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "onlinebooked", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payment_method", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_method", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@booking_date", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "booking_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@room_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "room_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total_days", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "total_days", DataRowVersion.Current, false, (object)null, "", "", ""));
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
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, ref_by, ref_name, mobile_no, check_date, check_out_date, p_male, p_female, p_child, room_charge, total_room_charge, extra_charge, total_charge, tax_amt, after_tax, dis_amt, tax_plan, dis_plan, grand_total, paid_amt, remaining, onlinebooked, payment_method, booking_date, room_id, total_days FROM dbo.h_checkin";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(DataSetCheckIn.h_checkinDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual DataSetCheckIn.h_checkinDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSetCheckIn.h_checkinDataTable h_checkinDataTable = new DataSetCheckIn.h_checkinDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)h_checkinDataTable);
		return h_checkinDataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataSetCheckIn.h_checkinDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSetCheckIn dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "h_checkin");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Insert(string ref_by, string ref_name, string mobile_no, string check_date, string check_out_date, string p_male, string p_female, string p_child, string room_charge, string total_room_charge, string extra_charge, string total_charge, string tax_amt, string after_tax, string dis_amt, string tax_plan, string dis_plan, string grand_total, string paid_amt, string remaining, string onlinebooked, string payment_method, string booking_date, string room_id, string total_days)
	{
		if (ref_by == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = ref_by;
		}
		if (ref_name == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = ref_name;
		}
		if (mobile_no == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = mobile_no;
		}
		if (check_date == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = check_date;
		}
		if (check_out_date == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = check_out_date;
		}
		if (p_male == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = p_male;
		}
		if (p_female == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = p_female;
		}
		if (p_child == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = p_child;
		}
		if (room_charge == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = room_charge;
		}
		if (total_room_charge == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = total_room_charge;
		}
		if (extra_charge == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = extra_charge;
		}
		if (total_charge == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = total_charge;
		}
		if (tax_amt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[12]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[12]).Value = tax_amt;
		}
		if (after_tax == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[13]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[13]).Value = after_tax;
		}
		if (dis_amt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[14]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[14]).Value = dis_amt;
		}
		if (tax_plan == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[15]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[15]).Value = tax_plan;
		}
		if (dis_plan == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[16]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[16]).Value = dis_plan;
		}
		if (grand_total == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[17]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[17]).Value = grand_total;
		}
		if (paid_amt == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[18]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[18]).Value = paid_amt;
		}
		if (remaining == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[19]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[19]).Value = remaining;
		}
		if (onlinebooked == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[20]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[20]).Value = onlinebooked;
		}
		if (payment_method == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[21]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[21]).Value = payment_method;
		}
		if (booking_date == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[22]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[22]).Value = booking_date;
		}
		if (room_id == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[23]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[23]).Value = room_id;
		}
		if (total_days == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[24]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[24]).Value = total_days;
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
