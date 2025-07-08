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
using TMBILL.DataSet_purchaseTableAdapters;

namespace TMBILL;

public class purchase_history : MetroForm
{
	private string id = "";

	private IContainer components = null;

	private ReportViewer reportViewer1;

	private BindingSource purchaseBindingSource;

	private DataSet_purchase DataSet_purchase;

	private BindingSource purchase_detailBindingSource;

	private purchaseTableAdapter purchaseTableAdapter;

	private purchase_detailTableAdapter purchase_detailTableAdapter;

	public purchase_history(string id)
	{
		InitializeComponent();
		this.id = id;
	}

	private void purchase_history_Load(object sender, EventArgs e)
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
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
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
				((DbCommand)(object)val2).CommandText = "select * from r_header where id='8'";
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
		DataTable dataTable3 = new DataTable();
		DataTable dataTable4 = new DataTable();
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from purchase where id='" + id + "'";
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
				((DbCommand)(object)val2).CommandText = "select * from purchase_detail where p_id='" + id + "'";
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
		reportViewer1.RefreshReport();
	}

	private void purchase_history_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)r_Purchase_history.ph).Focus();
		((Form)r_Purchase_history.ph).Activate();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 262232)
		{
			((Control)r_Purchase_history.ph).Focus();
			((Form)r_Purchase_history.ph).Activate();
			((Form)this).Close();
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

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
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		ReportDataSource val2 = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(purchase_history));
		purchaseBindingSource = new BindingSource(components);
		DataSet_purchase = new DataSet_purchase();
		purchase_detailBindingSource = new BindingSource(components);
		reportViewer1 = new ReportViewer();
		purchaseTableAdapter = new purchaseTableAdapter();
		purchase_detailTableAdapter = new purchase_detailTableAdapter();
		((ISupportInitialize)purchaseBindingSource).BeginInit();
		((ISupportInitialize)DataSet_purchase).BeginInit();
		((ISupportInitialize)purchase_detailBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		purchaseBindingSource.DataMember = "purchase";
		purchaseBindingSource.DataSource = DataSet_purchase;
		DataSet_purchase.DataSetName = "DataSet_purchase";
		DataSet_purchase.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		purchase_detailBindingSource.DataMember = "purchase_detail";
		purchase_detailBindingSource.DataSource = DataSet_purchase;
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = purchaseBindingSource;
		val2.Name = "DataSet2";
		val2.Value = purchase_detailBindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val2);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_purchase.rdlc";
		((Control)reportViewer1).Location = new Point(18, 63);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(816, 431);
		((Control)reportViewer1).TabIndex = 4;
		purchaseTableAdapter.ClearBeforeFill = true;
		purchase_detailTableAdapter.ClearBeforeFill = true;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(857, 517);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "purchase_history";
		((Control)this).Text = "Purchase History";
		((Form)this).FormClosed += new FormClosedEventHandler(purchase_history_FormClosed);
		((Form)this).Load += purchase_history_Load;
		((ISupportInitialize)purchaseBindingSource).EndInit();
		((ISupportInitialize)DataSet_purchase).EndInit();
		((ISupportInitialize)purchase_detailBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
