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

[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class h_guest_entryTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public h_guest_entryTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "h_guest_entry";
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("guest_name", "guest_name");
		dataTableMapping.ColumnMappings.Add("gender", "gender");
		dataTableMapping.ColumnMappings.Add("company_name", "company_name");
		dataTableMapping.ColumnMappings.Add("address", "address");
		dataTableMapping.ColumnMappings.Add("city", "city");
		dataTableMapping.ColumnMappings.Add("mobile_no", "mobile_no");
		dataTableMapping.ColumnMappings.Add("emailid", "emailid");
		dataTableMapping.ColumnMappings.Add("documenttype", "documenttype");
		dataTableMapping.ColumnMappings.Add("document_no", "document_no");
		dataTableMapping.ColumnMappings.Add("remark", "remark");
		dataTableMapping.ColumnMappings.Add("photo", "photo");
		dataTableMapping.ColumnMappings.Add("document_photo", "document_photo");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		((DbCommand)(object)_adapter.InsertCommand).CommandText = "INSERT INTO [dbo].[h_guest_entry] ([guest_name], [gender], [company_name], [address], [city], [mobile_no], [emailid], [documenttype], [document_no], [remark], [photo], [document_photo]) VALUES (@guest_name, @gender, @company_name, @address, @city, @mobile_no, @emailid, @documenttype, @document_no, @remark, @photo, @document_photo)";
		((DbCommand)(object)_adapter.InsertCommand).CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@guest_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "guest_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@gender", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "gender", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@company_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "company_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "address", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "city", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mobile_no", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mobile_no", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@emailid", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "emailid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@documenttype", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "documenttype", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@document_no", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "document_no", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@remark", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "remark", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.Image, 0, ParameterDirection.Input, (byte)0, (byte)0, "photo", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@document_photo", SqlDbType.Image, 0, ParameterDirection.Input, (byte)0, (byte)0, "document_photo", DataRowVersion.Current, false, (object)null, "", "", ""));
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
		((DbCommand)(object)_commandCollection[0]).CommandText = "SELECT id, guest_name, gender, company_name, address, city, mobile_no, emailid, documenttype, document_no, remark, photo, document_photo FROM dbo.h_guest_entry";
		((DbCommand)(object)_commandCollection[0]).CommandType = CommandType.Text;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(DataSetCheckIn.h_guest_entryDataTable dataTable)
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
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual DataSetCheckIn.h_guest_entryDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSetCheckIn.h_guest_entryDataTable h_guest_entryDataTable = new DataSetCheckIn.h_guest_entryDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)h_guest_entryDataTable);
		return h_guest_entryDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSetCheckIn.h_guest_entryDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataSetCheckIn dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "h_guest_entry");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Insert(string guest_name, string gender, string company_name, string address, string city, string mobile_no, string emailid, string documenttype, string document_no, string remark, byte[] photo, byte[] document_photo)
	{
		if (guest_name == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[0]).Value = guest_name;
		}
		if (gender == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[1]).Value = gender;
		}
		if (company_name == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[2]).Value = company_name;
		}
		if (address == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[3]).Value = address;
		}
		if (city == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[4]).Value = city;
		}
		if (mobile_no == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[5]).Value = mobile_no;
		}
		if (emailid == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[6]).Value = emailid;
		}
		if (documenttype == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[7]).Value = documenttype;
		}
		if (document_no == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[8]).Value = document_no;
		}
		if (remark == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[9]).Value = remark;
		}
		if (photo == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[10]).Value = photo;
		}
		if (document_photo == null)
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = DBNull.Value;
		}
		else
		{
			((DbParameter)(object)Adapter.InsertCommand.Parameters[11]).Value = document_photo;
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
