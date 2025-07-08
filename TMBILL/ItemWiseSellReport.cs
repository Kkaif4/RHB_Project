using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace TMBILL;

public class ItemWiseSellReport : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private Label label1;

	private MetroTextBox metroTextBox1;

	private MetroDateTime metroDateTime2;

	private Label label3;

	private MetroDateTime metroDateTime1;

	private Label label2;

	private ReportViewer reportViewer1;

	private BindingSource DataTable1BindingSource;

	private DataSetITEMWISEREPORT DataSetITEMWISEREPORT;

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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		components = new Container();
		ReportDataSource val = new ReportDataSource();
		groupBox1 = new GroupBox();
		metroDateTime2 = new MetroDateTime();
		label3 = new Label();
		metroDateTime1 = new MetroDateTime();
		label2 = new Label();
		metroTextBox1 = new MetroTextBox();
		label1 = new Label();
		reportViewer1 = new ReportViewer();
		DataSetITEMWISEREPORT = new DataSetITEMWISEREPORT();
		DataTable1BindingSource = new BindingSource(components);
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)DataSetITEMWISEREPORT).BeginInit();
		((ISupportInitialize)DataTable1BindingSource).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Anchor = (AnchorStyles)13;
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime2);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(958, 72);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Filter";
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(682, 23);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 6;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime1_ValueChanged;
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(631, 23);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(26, 18);
		((Control)label3).TabIndex = 5;
		((Control)label3).Text = "To";
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(402, 23);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 4;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(338, 23);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(44, 18);
		((Control)label2).TabIndex = 3;
		((Control)label2).Text = "From";
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(180, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(107, 23);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Count";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(208, 29);
		((Control)metroTextBox1).TabIndex = 2;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Count";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
		((Control)metroTextBox1).KeyPress += new KeyPressEventHandler(metroTextBox1_KeyPress);
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(26, 23);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(75, 18);
		((Control)label1).TabIndex = 1;
		((Control)label1).Text = "Top Menu";
		((Control)reportViewer1).Anchor = (AnchorStyles)15;
		val.Name = "DataSet1";
		val.Value = DataTable1BindingSource;
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(val);
		reportViewer1.LocalReport.ReportEmbeddedResource = "TMBILL.Report_Itemwise.rdlc";
		((Control)reportViewer1).Location = new Point(23, 141);
		((Control)reportViewer1).Name = "reportViewer1";
		((Control)reportViewer1).Size = new Size(958, 315);
		((Control)reportViewer1).TabIndex = 1;
		DataSetITEMWISEREPORT.DataSetName = "DataSetITEMWISEREPORT";
		DataSetITEMWISEREPORT.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		DataTable1BindingSource.DataMember = "DataTable1";
		DataTable1BindingSource.DataSource = DataSetITEMWISEREPORT;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1004, 479);
		((Control)this).Controls.Add((Control)(object)reportViewer1);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Name = "ItemWiseSellReport";
		((Control)this).Text = "Menu Wise Sell Report";
		((Form)this).FormClosed += new FormClosedEventHandler(ItemWiseSellReport_FormClosed);
		((Form)this).Load += ItemWiseSellReport_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)DataSetITEMWISEREPORT).EndInit();
		((ISupportInitialize)DataTable1BindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public ItemWiseSellReport()
	{
		InitializeComponent();
	}

	public void BindReport()
	{
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		string text = "";
		string text2 = ((Control)metroTextBox1).Text;
		text = ((!(text2 == "")) ? ("TOP (" + ((Control)metroTextBox1).Text + ")") : "");
		string commandText = "SELECT " + text + " itemname,SUM(total) AS total FROM (SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_invoice_home_detail WHERE (invoice_id IN (SELECT id FROM r_invoice_home WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname UNION SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_invoice_detail WHERE (invoice_id IN (SELECT id FROM r_invoice WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname UNION SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_takeaway_detail WHERE (invoice_id IN (SELECT id FROM r_invoice_takeaway WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname) AS derivedtbl_1 GROUP BY itemname ORDER BY total DESC";
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("itemname");
		dataTable.Columns.Add("total");
		dataTable.Columns.Add("Date");
		string text3 = ((Control)metroDateTime1).Text + " - " + ((Control)metroDateTime2).Text;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = commandText;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						dataTable.Rows.Add(((DbDataReader)(object)val3)[0].ToString(), ((DbDataReader)(object)val3)[1].ToString(), text3);
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
		ReportDataSource item = new ReportDataSource("DataSet1", dataTable);
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Clear();
		((Collection<ReportDataSource>)(object)reportViewer1.LocalReport.DataSources).Add(item);
		reportViewer1.RefreshReport();
	}

	private void ItemWiseSellReport_Load(object sender, EventArgs e)
	{
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).Focus();
		((Form)this).Activate();
		BindReport();
		reportViewer1.RefreshReport();
	}

	private void ItemWiseSellReport_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}

	private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar((object)(Keys)8);
	}

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
	{
		BindReport();
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		BindReport();
	}
}
