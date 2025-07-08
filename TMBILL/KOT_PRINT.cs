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

namespace TMBILL;

public class KOT_PRINT : MetroForm
{
	private IContainer components = null;

	private ReportViewer reportViewer1;

	private string tablename;

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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KOT_PRINT));
		reportViewer1 = new ReportViewer();
		((Control)this).SuspendLayout();
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_KOT.rdlc";
		((Control)reportViewer1).Location = new Point(19, 59);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(407, 338);
		((Control)reportViewer1).TabIndex = 0;
		reportViewer1.RenderingComplete += new RenderingCompleteEventHandler(reportViewer1_RenderingComplete);
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(447, 420);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "KOT_PRINT";
		((Control)this).Text = "KOT PRINT";
		((Form)this).FormClosed += new FormClosedEventHandler(KOT_PRINT_FormClosed);
		((Form)this).Load += KOT_PRINT_Load;
		((Control)this).ResumeLayout(false);
	}

	public KOT_PRINT(string tablename)
	{
		InitializeComponent();
		this.tablename = tablename;
	}

	private void KOT_PRINT_Load(object sender, EventArgs e)
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
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
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
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='4'";
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
		((Control)this).Focus();
		((Form)this).Activate();
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
				((DbCommand)(object)val2).CommandText = "select * from temp_KOT where tablename='" + tablename + "'";
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
		ReportDataSource item2 = new ReportDataSource("DataSet3", dataTable);
		ReportDataSource item3 = new ReportDataSource("DataSet4", dataTable2);
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
				((DbCommand)(object)val2).CommandText = "select * from printer_management where onprint='KOT'";
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

	private void KOT_PRINT_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Order.static_order).Focus();
		((Form)Order.static_order).Activate();
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
				((Control)Order.static_order).Focus();
				((Form)Order.static_order).Activate();
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
