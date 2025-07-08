using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using TMBILL.DataSet_DINEINTableAdapters;

namespace TMBILL;

public class SaleReport : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource r_invoiceBindingSource;

	private DataSet_DINEIN DataSet_DINEIN;

	private BindingSource r_invoice_detailBindingSource;

	private r_invoiceTableAdapter r_invoiceTableAdapter;

	private r_invoice_detailTableAdapter r_invoice_detailTableAdapter;

	private Label label1;

	private MetroDateTime metroDateTime1;

	private MetroDateTime metroDateTime2;

	private Label label2;

	private BindingSource DataTable1BindingSource;

	private DataSet_SaleREPORT DataSet_SaleREPORT;

	private BindingSource DataTable11BindingSource;

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
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ReportDataSource val2 = new ReportDataSource();
		ReportDataSource val3 = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SaleReport));
		DataTable1BindingSource = new BindingSource(components);
		DataSet_SaleREPORT = new DataSet_SaleREPORT();
		DataTable11BindingSource = new BindingSource(components);
		r_invoiceBindingSource = new BindingSource(components);
		DataSet_DINEIN = new DataSet_DINEIN();
		r_invoice_detailBindingSource = new BindingSource(components);
		reportViewer1 = new ReportViewer();
		r_invoiceTableAdapter = new r_invoiceTableAdapter();
		r_invoice_detailTableAdapter = new r_invoice_detailTableAdapter();
		label1 = new Label();
		metroDateTime1 = new MetroDateTime();
		metroDateTime2 = new MetroDateTime();
		label2 = new Label();
		((ISupportInitialize)DataTable1BindingSource).BeginInit();
		((ISupportInitialize)DataSet_SaleREPORT).BeginInit();
		((ISupportInitialize)DataTable11BindingSource).BeginInit();
		((ISupportInitialize)r_invoiceBindingSource).BeginInit();
		((ISupportInitialize)DataSet_DINEIN).BeginInit();
		((ISupportInitialize)r_invoice_detailBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataTable1BindingSource.DataMember = "DataTable1";
		DataTable1BindingSource.DataSource = DataSet_SaleREPORT;
		DataSet_SaleREPORT.DataSetName = "DataSet_SaleREPORT";
		DataSet_SaleREPORT.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		DataTable11BindingSource.DataMember = "DataTable11";
		DataTable11BindingSource.DataSource = DataSet_SaleREPORT;
		r_invoiceBindingSource.DataMember = "r_invoice";
		r_invoiceBindingSource.DataSource = DataSet_DINEIN;
		DataSet_DINEIN.DataSetName = "DataSet_DINEIN";
		DataSet_DINEIN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		r_invoice_detailBindingSource.DataMember = "r_invoice_detail";
		r_invoice_detailBindingSource.DataSource = DataSet_DINEIN;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = DataTable1BindingSource;
		val2.Name = "DataSet2";
		val2.Value = DataTable1BindingSource;
		val3.Name = "DataSet3";
		val3.Value = DataTable11BindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val3);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_Sell.rdlc";
		((Control)reportViewer1).Location = new Point(12, 63);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(709, 264);
		((Control)reportViewer1).TabIndex = 0;
		r_invoiceTableAdapter.ClearBeforeFill = true;
		r_invoice_detailTableAdapter.ClearBeforeFill = true;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(202, 25);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(44, 18);
		((Control)label1).TabIndex = 1;
		((Control)label1).Text = "From";
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(252, 19);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 2;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(506, 19);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 4;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(474, 25);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(26, 18);
		((Control)label2).TabIndex = 3;
		((Control)label2).Text = "To";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(729, 337);
		((Control)this).Controls.Add((Control)(object)metroDateTime2);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)metroDateTime1);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "SaleReport";
		((Control)this).Text = "Sale Report";
		((Form)this).Load += SaleReport_Load;
		((ISupportInitialize)DataTable1BindingSource).EndInit();
		((ISupportInitialize)DataSet_SaleREPORT).EndInit();
		((ISupportInitialize)DataTable11BindingSource).EndInit();
		((ISupportInitialize)r_invoiceBindingSource).EndInit();
		((ISupportInitialize)DataSet_DINEIN).EndInit();
		((ISupportInitialize)r_invoice_detailBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public SaleReport()
	{
		InitializeComponent();
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

	private void SaleReport_Load(object sender, EventArgs e)
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
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
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
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='2'";
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
		DataTable dataTable3 = new DataTable();
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "SELECT r_invoice.id, r_invoice.waitername, r_invoice.customername, r_invoice.total, r_invoice.selectedtax, r_invoice.isigst, r_invoice.igst, r_invoice.cgst, r_invoice.sgst,r_invoice.totalwithtax, r_invoice.discounttype, r_invoice.discountamt, r_invoice.grandtotal, r_invoice.paymenttype, r_invoice.tablename, r_invoice.mydate, r_invoice.inwords, r_invoice.paidamt, r_invoice.remainingamt, r_invoice_detail.itemname, r_invoice_detail.qty, r_invoice_detail.price, r_invoice_detail.total AS totalofitem FROM r_invoice INNER JOIN r_invoice_detail ON r_invoice.id = r_invoice_detail.invoice_id where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
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
				((DbCommand)(object)val2).CommandText = "SELECT r_invoice_home.id, r_invoice_home.waitername, r_invoice_home.customername, r_invoice_home.total, r_invoice_home.selectedtax, r_invoice_home.isigst, r_invoice_home.igst, r_invoice_home.cgst, r_invoice_home.sgst,r_invoice_home.totalwithtax, r_invoice_home.discounttype, r_invoice_home.discountamt, r_invoice_home.grandtotal, r_invoice_home.paymenttype, r_invoice_home.mydate, r_invoice_home.inwords, r_invoice_home.paidamt, r_invoice_home.remainingamt, r_invoice_home_detail.itemname, r_invoice_home_detail.qty, r_invoice_home_detail.price, r_invoice_home_detail.total AS totalofitem FROM r_invoice_home INNER JOIN r_invoice_home_detail ON r_invoice_home.id = r_invoice_home_detail.invoice_id  where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
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
		DataTable dataTable5 = new DataTable();
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "SELECT r_invoice_takeaway.id,r_invoice_takeaway.customername, r_invoice_takeaway.total, r_invoice_takeaway.selectedtax, r_invoice_takeaway.isigst, r_invoice_takeaway.igst, r_invoice_takeaway.cgst, r_invoice_takeaway.sgst,r_invoice_takeaway.totalwithtax, r_invoice_takeaway.discounttype, r_invoice_takeaway.discountamt, r_invoice_takeaway.grandtotal, r_invoice_takeaway.paymenttype, r_invoice_takeaway.mydate, r_invoice_takeaway.inwords, r_invoice_takeaway.paidamt, r_invoice_takeaway.remainingamt, r_takeaway_detail.itemname, r_takeaway_detail.qty, r_takeaway_detail.price, r_takeaway_detail.total AS totalofitem FROM r_invoice_takeaway INNER JOIN r_takeaway_detail ON r_invoice_takeaway.id = r_takeaway_detail.invoice_id  where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
				SqlDataAdapter val3 = new SqlDataAdapter(val2);
				((DbDataAdapter)(object)val3).Fill(dataTable5);
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
		ReportDataSource item3 = new ReportDataSource("DataSet3", dataTable5);
		ReportDataSource item4 = new ReportDataSource("DataSet4", dataTable);
		ReportDataSource item5 = new ReportDataSource("DataSet5", dataTable2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Clear();
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item2);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item3);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item4);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item5);
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='Other'";
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

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		SaleReport_Load(sender, e);
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		SaleReport_Load(sender, e);
	}
}
