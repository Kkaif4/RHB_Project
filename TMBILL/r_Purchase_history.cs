using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class r_Purchase_history : MetroForm
{
	public static r_Purchase_history ph;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private MetroDateTime metroDateTime1;

	private MetroDateTime metroDateTime2;

	private MetroGrid metroGrid1;

	private DataGridViewTextBoxColumn Column4;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private DataGridViewTextBoxColumn Column3;

	public r_Purchase_history()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		ph = this;
		bindGrid();
	}

	private void bindGrid()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		((DataGridView)metroGrid1).Rows.Clear();
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from purchase where convert(date,mydate,103) between convert(date,'" + ((Control)metroDateTime1).Text + "',103) and convert(date,'" + ((Control)metroDateTime2).Text + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[4]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString(),
							((DbDataReader)(object)val3)[2].ToString(),
							((DbDataReader)(object)val3)[3].ToString()
						});
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
			((Control)Functions.static_mainform).Focus();
			((Form)Functions.static_mainform).Activate();
			((Form)this).Close();
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void r_Purchase_history_Load(object sender, EventArgs e)
	{
		bindGrid();
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		bindGrid();
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		bindGrid();
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)new purchase_history(((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString())).Show();
	}

	private void r_Purchase_history_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_Purchase_history));
		label1 = new Label();
		label2 = new Label();
		metroDateTime1 = new MetroDateTime();
		metroDateTime2 = new MetroDateTime();
		metroGrid1 = new MetroGrid();
		Column4 = new DataGridViewTextBoxColumn();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(164, 59);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(44, 18);
		((Control)label1).TabIndex = 0;
		((Control)label1).Text = "From";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(461, 59);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(26, 18);
		((Control)label2).TabIndex = 1;
		((Control)label2).Text = "To";
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(230, 53);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 2;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(506, 53);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 3;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((DataGridView)metroGrid1).AllowUserToAddRows = false;
		((DataGridView)metroGrid1).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid1).AllowUserToResizeRows = false;
		((DataGridView)metroGrid1).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = Color.FromArgb(0, 174, 219);
		val.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = Color.FromArgb(255, 255, 255);
		val.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)metroGrid1).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3
		});
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.BackColor = Color.FromArgb(255, 255, 255);
		val2.Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = Color.FromArgb(136, 136, 136);
		val2.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val2.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid1).DefaultCellStyle = val2;
		((DataGridView)metroGrid1).EnableHeadersVisualStyles = false;
		((Control)metroGrid1).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid1).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid1).Location = new Point(23, 88);
		((Control)metroGrid1).Name = "metroGrid1";
		((DataGridView)metroGrid1).ReadOnly = true;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = Color.FromArgb(0, 174, 219);
		val3.Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		val3.ForeColor = Color.FromArgb(255, 255, 255);
		val3.SelectionBackColor = Color.FromArgb(0, 198, 247);
		val3.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).RowHeadersDefaultCellStyle = val3;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(774, 470);
		((Control)metroGrid1).TabIndex = 4;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewColumn)Column4).HeaderText = "id";
		((DataGridViewColumn)Column4).Name = "Column4";
		((DataGridViewBand)Column4).ReadOnly = true;
		((DataGridViewBand)Column4).Visible = false;
		((DataGridViewColumn)Column1).HeaderText = "Vendor Name";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewColumn)Column1).Width = 400;
		((DataGridViewColumn)Column2).HeaderText = "Date";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 150;
		((DataGridViewColumn)Column3).HeaderText = "Total";
		((DataGridViewColumn)Column3).Name = "Column3";
		((DataGridViewBand)Column3).ReadOnly = true;
		((DataGridViewColumn)Column3).Width = 150;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(820, 574);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)metroDateTime2);
		((Control)this).Controls.Add((Control)(object)metroDateTime1);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_Purchase_history";
		((MetroForm)this).Resizable = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Control)this).Text = "Purchase History";
		((Form)this).FormClosed += new FormClosedEventHandler(r_Purchase_history_FormClosed);
		((Form)this).Load += r_Purchase_history_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
