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
using TMBILL.DataSet_STOCKTableAdapters;

namespace TMBILL;

public class Print_Stock_report : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource raw_itemBindingSource;

	private DataSet_STOCK DataSet_STOCK;

	private raw_itemTableAdapter raw_itemTableAdapter;

	private string query = "";

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
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Print_Stock_report));
		raw_itemBindingSource = new BindingSource(components);
		DataSet_STOCK = new DataSet_STOCK();
		reportViewer1 = new ReportViewer();
		raw_itemTableAdapter = new raw_itemTableAdapter();
		((ISupportInitialize)raw_itemBindingSource).BeginInit();
		((ISupportInitialize)DataSet_STOCK).BeginInit();
		((Control)this).SuspendLayout();
		raw_itemBindingSource.DataMember = "raw_item";
		raw_itemBindingSource.DataSource = DataSet_STOCK;
		DataSet_STOCK.DataSetName = "DataSet_STOCK";
		DataSet_STOCK.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = raw_itemBindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_STOCK.rdlc";
		((Control)reportViewer1).Location = new Point(23, 40);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(396, 269);
		((Control)reportViewer1).TabIndex = 0;
		raw_itemTableAdapter.ClearBeforeFill = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(440, 329);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "Print_Stock_report";
		((Form)this).FormClosed += new FormClosedEventHandler(Print_Stock_report_FormClosed);
		((Form)this).Load += Print_Stock_report_Load;
		((ISupportInitialize)raw_itemBindingSource).EndInit();
		((ISupportInitialize)DataSet_STOCK).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Print_Stock_report(string query1)
	{
		InitializeComponent();
		query = query1;
		Debug.WriteLine(query);
	}

	private void Print_Stock_report_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)PRINT_STOCK.s_print_stock).Focus();
		((Form)PRINT_STOCK.s_print_stock).Activate();
	}

	private void Print_Stock_report_Load(object sender, EventArgs e)
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
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
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
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='3'";
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
				((DbCommand)(object)val2).CommandText = query;
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
		ReportDataSource item = new ReportDataSource("DataSet1", dataTable3);
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
				((Control)PRINT_STOCK.s_print_stock).Focus();
				((Form)PRINT_STOCK.s_print_stock).Activate();
				((Form)this).Close();
				return true;
			}
			return ((Form)this).ProcessCmdKey(ref msg, keyData);
		}
		reportViewer1.PrintDialog();
		return true;
	}
}
