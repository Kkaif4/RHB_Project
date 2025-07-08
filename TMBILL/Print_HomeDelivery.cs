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
using TMBILL.DataSet_HOMEDELIVERYTableAdapters;

namespace TMBILL;

public class Print_HomeDelivery : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource r_invoice_homeBindingSource;

	private DataSet_HOMEDELIVERY DataSet_HOMEDELIVERY;

	private BindingSource r_invoice_home_detailBindingSource;

	private r_invoice_homeTableAdapter r_invoice_homeTableAdapter;

	private r_invoice_home_detailTableAdapter r_invoice_home_detailTableAdapter;

	private string id = "";

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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ReportDataSource val2 = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Print_HomeDelivery));
		r_invoice_homeBindingSource = new BindingSource(components);
		DataSet_HOMEDELIVERY = new DataSet_HOMEDELIVERY();
		r_invoice_home_detailBindingSource = new BindingSource(components);
		reportViewer1 = new ReportViewer();
		r_invoice_homeTableAdapter = new r_invoice_homeTableAdapter();
		r_invoice_home_detailTableAdapter = new r_invoice_home_detailTableAdapter();
		((ISupportInitialize)r_invoice_homeBindingSource).BeginInit();
		((ISupportInitialize)DataSet_HOMEDELIVERY).BeginInit();
		((ISupportInitialize)r_invoice_home_detailBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		r_invoice_homeBindingSource.DataMember = "r_invoice_home";
		r_invoice_homeBindingSource.DataSource = DataSet_HOMEDELIVERY;
		DataSet_HOMEDELIVERY.DataSetName = "DataSet_HOMEDELIVERY";
		DataSet_HOMEDELIVERY.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		r_invoice_home_detailBindingSource.DataMember = "r_invoice_home_detail";
		r_invoice_home_detailBindingSource.DataSource = DataSet_HOMEDELIVERY;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = r_invoice_homeBindingSource;
		val2.Name = "DataSet2";
		val2.Value = r_invoice_home_detailBindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val2);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_HOMEDELIVERY.rdlc";
		((Control)reportViewer1).Location = new Point(19, 63);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(396, 246);
		((Control)reportViewer1).TabIndex = 0;
		reportViewer1.RenderingComplete += new RenderingCompleteEventHandler(reportViewer1_RenderingComplete);
		r_invoice_homeTableAdapter.ClearBeforeFill = true;
		r_invoice_home_detailTableAdapter.ClearBeforeFill = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(433, 331);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Print_HomeDelivery";
		((Form)this).FormClosed += new FormClosedEventHandler(Print_HomeDelivery_FormClosed);
		((Form)this).Load += Print_HomeDelivery_Load;
		((ISupportInitialize)r_invoice_homeBindingSource).EndInit();
		((ISupportInitialize)DataSet_HOMEDELIVERY).EndInit();
		((ISupportInitialize)r_invoice_home_detailBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Print_HomeDelivery(string id)
	{
		InitializeComponent();
		this.id = id;
	}

	private void Print_HomeDelivery_Load(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
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
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='7'";
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
		DataTable dataTable3 = new DataTable();
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_invoice_home where id='" + id + "'";
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
		DataTable dataTable4 = new DataTable();
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_invoice_home_detail where invoice_id='" + id + "'";
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
		ReportDataSource item = new ReportDataSource("DataSet1", dataTable3);
		ReportDataSource item2 = new ReportDataSource("DataSet2", dataTable4);
		ReportDataSource item3 = new ReportDataSource("DataSet3", dataTable);
		ReportDataSource item4 = new ReportDataSource("DataSet4", dataTable2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Clear();
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item3);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item4);
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='BILL'";
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

	private void Print_HomeDelivery_FormClosed(object sender, FormClosedEventArgs e)
	{
		try
		{
			((Control)Order.static_order).Focus();
			((Form)Order.static_order).Activate();
		}
		catch (Exception)
		{
			((Control)view_Order.s_view_order).Focus();
			((Form)view_Order.s_view_order).Activate();
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131152)
		{
			if ((int)keyData == 262232)
			{
				try
				{
					((Control)Order.static_order).Focus();
					((Form)Order.static_order).Activate();
				}
				catch (Exception)
				{
					((Control)view_Order.s_view_order).Focus();
					((Form)view_Order.s_view_order).Activate();
				}
				((Form)this).Close();
				return true;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		reportViewer1.PrintDialog();
		return true;
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
