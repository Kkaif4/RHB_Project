#define DEBUG
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace TMBILL;

public class Print_BILLREPORT : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource DataTable1BindingSource;

	private DataSet_ALLREPORT DataSet_ALLREPORT;

	private DataTable dt;

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
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Print_BILLREPORT));
		DataTable1BindingSource = new BindingSource(components);
		DataSet_ALLREPORT = new DataSet_ALLREPORT();
		reportViewer1 = new ReportViewer();
		((ISupportInitialize)DataTable1BindingSource).BeginInit();
		((ISupportInitialize)DataSet_ALLREPORT).BeginInit();
		((Control)this).SuspendLayout();
		DataTable1BindingSource.DataMember = "DataTable1";
		DataTable1BindingSource.DataSource = DataSet_ALLREPORT;
		DataSet_ALLREPORT.DataSetName = "DataSet_ALLREPORT";
		DataSet_ALLREPORT.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = DataTable1BindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_BILLREPORT.rdlc";
		((Control)reportViewer1).Location = new Point(23, 42);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(408, 345);
		((Control)reportViewer1).TabIndex = 0;
		reportViewer1.RenderingComplete += new RenderingCompleteEventHandler(reportViewer1_RenderingComplete);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(454, 410);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Print_BILLREPORT";
		((Form)this).FormClosed += new FormClosedEventHandler(Print_BILLREPORT_FormClosed);
		((Form)this).Load += Print_BILLREPORT_Load;
		((ISupportInitialize)DataTable1BindingSource).EndInit();
		((ISupportInitialize)DataSet_ALLREPORT).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Print_BILLREPORT(DataTable dt)
	{
		InitializeComponent();
		this.dt = dt;
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131152)
		{
			if ((int)keyData == 262232)
			{
				((Control)BillReport.s_bill_report).Focus();
				((Form)BillReport.s_bill_report).Activate();
				((Form)this).Close();
				return true;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		reportViewer1.PrintDialog();
		return true;
	}

	private void Print_BILLREPORT_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)BillReport.s_bill_report).Focus();
		((Form)BillReport.s_bill_report).Activate();
	}

	private void Print_BILLREPORT_Load(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from shop";
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
		DataTable dataTable2 = new DataTable();
		dataTable2.Columns.Add("print_header");
		dataTable2.Columns.Add("hotelname");
		dataTable2.Columns.Add("prop_name");
		dataTable2.Columns.Add("address");
		dataTable2.Columns.Add("contact");
		dataTable2.Columns.Add("email");
		dataTable2.Columns.Add("gstno");
		dataTable2.Columns.Add("phoneno");
		dataTable2.Columns.Add("shop_image");
		dataTable2.Columns.Add("customer");
		dataTable2.Columns.Add("prop");
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='1'";
				SqlDataReader val4 = val2.ExecuteReader();
				if (((DbDataReader)(object)val4).HasRows)
				{
					while (((DbDataReader)(object)val4).Read())
					{
						string text = ((DbDataReader)(object)val4)["header"].ToString();
						string text2 = ((DbDataReader)(object)val4)["footer"].ToString();
						string text3 = ((DbDataReader)(object)val4)["print_header"].ToString();
						string text4 = ((DbDataReader)(object)val4)["print_footer"].ToString();
						string[] array = text.Split(new char[1] { '*' });
						string[] array2 = text2.Split(new char[1] { '*' });
						Debug.WriteLine(array[7]);
						dataTable2.Rows.Add(text3, array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array2[0], array2[1]);
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
		((Form)this).WindowState = (FormWindowState)2;
		ReportDataSource item = new ReportDataSource("DataSet1", dt);
		ReportDataSource item2 = new ReportDataSource("DataSet2", dataTable);
		ReportDataSource item3 = new ReportDataSource("DataSet3", dataTable2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Clear();
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item3);
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='OTHER'";
				SqlDataReader val4 = val2.ExecuteReader();
				if (((DbDataReader)(object)val4).HasRows)
				{
					while (((DbDataReader)(object)val4).Read())
					{
						string s = ((DbDataReader)(object)val4)["copies"].ToString();
						string printerName = ((DbDataReader)(object)val4)["printername"].ToString();
						reportViewer1.PrinterSettings.Copies = short.Parse(s);
						reportViewer1.PrinterSettings.PrinterName = printerName;
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
		reportViewer1.RefreshReport();
	}

	private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between I4 and Unknown
		if (1 == (int)reportViewer1.PrintDialog())
		{
			((Form)this).Close();
		}
	}
}
