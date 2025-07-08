using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using TMBILL.DataSetCheckInTableAdapters;

namespace TMBILL;

public class Report_CheckIn : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource h_checkinBindingSource;

	private DataSetCheckIn DataSetCheckIn;

	private BindingSource h_checkin_planBindingSource;

	private BindingSource h_guest_entryBindingSource;

	private BindingSource roomBindingSource;

	private h_checkinTableAdapter h_checkinTableAdapter;

	private h_checkin_planTableAdapter h_checkin_planTableAdapter;

	private h_guest_entryTableAdapter h_guest_entryTableAdapter;

	private roomTableAdapter roomTableAdapter;

	private string id = "";

	private string mobileno = "";

	private string roomid;

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
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ReportDataSource val2 = new ReportDataSource();
		ReportDataSource val3 = new ReportDataSource();
		ReportDataSource val4 = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Report_CheckIn));
		h_checkinBindingSource = new BindingSource(components);
		DataSetCheckIn = new DataSetCheckIn();
		h_checkin_planBindingSource = new BindingSource(components);
		h_guest_entryBindingSource = new BindingSource(components);
		roomBindingSource = new BindingSource(components);
		reportViewer1 = new ReportViewer();
		h_checkinTableAdapter = new h_checkinTableAdapter();
		h_checkin_planTableAdapter = new h_checkin_planTableAdapter();
		h_guest_entryTableAdapter = new h_guest_entryTableAdapter();
		roomTableAdapter = new roomTableAdapter();
		((ISupportInitialize)h_checkinBindingSource).BeginInit();
		((ISupportInitialize)DataSetCheckIn).BeginInit();
		((ISupportInitialize)h_checkin_planBindingSource).BeginInit();
		((ISupportInitialize)h_guest_entryBindingSource).BeginInit();
		((ISupportInitialize)roomBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		h_checkinBindingSource.DataMember = "h_checkin";
		h_checkinBindingSource.DataSource = DataSetCheckIn;
		DataSetCheckIn.DataSetName = "DataSetCheckIn";
		DataSetCheckIn.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		h_checkin_planBindingSource.DataMember = "h_checkin_plan";
		h_checkin_planBindingSource.DataSource = DataSetCheckIn;
		h_guest_entryBindingSource.DataMember = "h_guest_entry";
		h_guest_entryBindingSource.DataSource = DataSetCheckIn;
		roomBindingSource.DataMember = "room";
		roomBindingSource.DataSource = DataSetCheckIn;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = h_checkinBindingSource;
		val2.Name = "DataSet2";
		val2.Value = h_checkin_planBindingSource;
		val3.Name = "DataSet3";
		val3.Value = h_guest_entryBindingSource;
		val4.Name = "DataSet4";
		val4.Value = roomBindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val3);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val4);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_checkIn.rdlc";
		((Control)reportViewer1).Location = new Point(23, 63);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(453, 334);
		((Control)reportViewer1).TabIndex = 0;
		h_checkinTableAdapter.ClearBeforeFill = true;
		h_checkin_planTableAdapter.ClearBeforeFill = true;
		h_guest_entryTableAdapter.ClearBeforeFill = true;
		roomTableAdapter.ClearBeforeFill = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(499, 420);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Report_CheckIn";
		((Control)this).Text = "Report_CheckIn";
		((Form)this).Load += Report_CheckIn_Load;
		((ISupportInitialize)h_checkinBindingSource).EndInit();
		((ISupportInitialize)DataSetCheckIn).EndInit();
		((ISupportInitialize)h_checkin_planBindingSource).EndInit();
		((ISupportInitialize)h_guest_entryBindingSource).EndInit();
		((ISupportInitialize)roomBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Report_CheckIn(string id, string room_id, string mobile_no)
	{
		InitializeComponent();
		this.id = id;
		mobileno = mobile_no;
		roomid = room_id;
	}

	private void Report_CheckIn_Load(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		DataTable dataTable2 = new DataTable();
		DataTable dataTable3 = new DataTable();
		DataTable dataTable4 = new DataTable();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from h_checkin where id='" + id + "'";
				SqlDataAdapter val3 = new SqlDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable);
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
				((DbCommand)(object)val2).CommandText = "select * from h_checkin_plan where room_id='" + id + "'";
				SqlDataAdapter val3 = new SqlDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable3);
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
				((DbCommand)(object)val2).CommandText = "select * from h_guest_entry where mobile_no='" + mobileno + "'";
				SqlDataAdapter val3 = new SqlDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable2);
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
				((DbCommand)(object)val2).CommandText = "select * from room where id='" + roomid + "'";
				SqlDataAdapter val3 = new SqlDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable4);
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
		ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
		ReportDataSource item2 = new ReportDataSource("DataSet2", dataTable3);
		ReportDataSource item3 = new ReportDataSource("DataSet3", dataTable2);
		ReportDataSource item4 = new ReportDataSource("DataSet4", dataTable4);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Clear();
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item3);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item4);
		reportViewer1.RefreshReport();
	}
}
