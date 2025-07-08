using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using TMBILL.Properties;

namespace TMBILL;

public class h_room_type : MetroForm
{
	private IContainer components = null;

	private Button button5;

	private Button button4;

	private Button button3;

	private Button button2;

	private MetroTextBox metroTextBox2;

	private MetroGrid metroGrid1;

	private Button button1;

	private MetroTextBox metroTextBox1;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn Column2;

	private OpenFileDialog openFileDialog1;

	private ErrorProvider errorProvider1;

	private string gid = "";

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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		metroTextBox2 = new MetroTextBox();
		metroGrid1 = new MetroGrid();
		button1 = new Button();
		metroTextBox1 = new MetroTextBox();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		openFileDialog1 = new OpenFileDialog();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)metroGrid1).BeginInit();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button5).Location = new Point(345, 515);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(101, 38);
		((Control)button5).TabIndex = 15;
		((Control)button5).Text = "Reset (R)";
		((ButtonBase)button5).UseVisualStyleBackColor = true;
		((Control)button5).Click += button5_Click;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button4).Location = new Point(229, 515);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(110, 38);
		((Control)button4).TabIndex = 14;
		((Control)button4).Text = "Delete (D)";
		((ButtonBase)button4).UseVisualStyleBackColor = true;
		((Control)button4).Click += button4_Click;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button3).Location = new Point(120, 515);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(103, 38);
		((Control)button3).TabIndex = 13;
		((Control)button3).Text = "Update (U)";
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button2).Location = new Point(23, 515);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(91, 38);
		((Control)button2).TabIndex = 12;
		((Control)button2).Text = "Add (S)";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(397, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(25, 25);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(23, 482);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Room Type";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(423, 27);
		((Control)metroTextBox2).TabIndex = 11;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Room Type";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
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
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2
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
		((Control)metroGrid1).Location = new Point(23, 111);
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
		((Control)metroGrid1).Size = new Size(423, 365);
		((Control)metroGrid1).TabIndex = 10;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).Location = new Point(292, 57);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(130, 48);
		((Control)button1).TabIndex = 9;
		((Control)button1).Text = "Import From Excel (I)";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		metroTextBox1.CustomButton.Image = (Image)(object)Resources.search_34;
		((Control)metroTextBox1.CustomButton).Location = new Point(237, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(25, 25);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(23, 63);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Search Room Type Here";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		metroTextBox1.ShowButton = true;
		metroTextBox1.ShowClearButton = true;
		((Control)metroTextBox1).Size = new Size(263, 27);
		((Control)metroTextBox1).TabIndex = 8;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Search Room Type Here";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
		((DataGridViewColumn)Column1).HeaderText = "id";
		((DataGridViewColumn)Column1).Name = "Column1";
		((DataGridViewBand)Column1).ReadOnly = true;
		((DataGridViewBand)Column1).Visible = false;
		((DataGridViewColumn)Column2).HeaderText = "Room Type";
		((DataGridViewColumn)Column2).Name = "Column2";
		((DataGridViewBand)Column2).ReadOnly = true;
		((DataGridViewColumn)Column2).Width = 350;
		((FileDialog)openFileDialog1).FileName = "openFileDialog1";
		((FileDialog)openFileDialog1).Filter = "Excel Files|*.xlsx;*.xls";
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(472, 571);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)metroTextBox2);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "h_room_type";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Room";
		((Form)this).FormClosed += new FormClosedEventHandler(r_category_FormClosed);
		((ISupportInitialize)metroGrid1).EndInit();
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public h_room_type()
	{
		InitializeComponent();
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)2;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)1;
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)2;
		bindall();
		Button obj = button3;
		bool enabled = (((Control)button4).Enabled = false);
		((Control)obj).Enabled = enabled;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		ImportMethod();
	}

	private void loading()
	{
		Application.Run((Form)(object)new Loading());
	}

	private void ImportMethod()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Invalid comparison between I4 and Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		DialogResult val = ((CommonDialog)openFileDialog1).ShowDialog();
		if ((int)val != 1)
		{
			return;
		}
		string fileName = ((FileDialog)openFileDialog1).FileName;
		try
		{
			Thread thread = new Thread(loading);
			thread.Start();
			Application application = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			Workbook workbook = application.Workbooks.Open(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			_Worksheet worksheet = (dynamic)workbook.Sheets[1];
			Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
			int count = usedRange.Rows.Count;
			int count2 = usedRange.Columns.Count;
			for (int i = 1; i <= count; i++)
			{
				try
				{
					string text = ((dynamic)usedRange.Cells[i, 1]).Value2.ToString();
					SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val3 = new SqlCommand();
						try
						{
							val3.Connection = val2;
							((DbConnection)(object)val2).Open();
							((DbCommand)(object)val3).CommandText = "insert into h_room_type(room_type) values('" + text + "')";
							((DbCommand)(object)val3).ExecuteNonQuery();
							((DbConnection)(object)val2).Close();
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				catch (Exception)
				{
				}
			}
			thread.Abort();
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Type Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
			bindall();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Marshal.ReleaseComObject(usedRange);
			Marshal.ReleaseComObject(worksheet);
			workbook.Close(Missing.Value, Missing.Value, Missing.Value);
			Marshal.ReleaseComObject(workbook);
			application.Quit();
			Marshal.ReleaseComObject(application);
		}
		catch (IOException)
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	public void bindall()
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
				((DbCommand)(object)val2).CommandText = "select * from h_room_type where room_type like '" + ((Control)metroTextBox1).Text + "%'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((DataGridView)metroGrid1).Rows.Add(new object[2]
						{
							((DbDataReader)(object)val3)[0].ToString(),
							((DbDataReader)(object)val3)[1].ToString()
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

	private void r_category_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
	{
		bindall();
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox2, "Enter room type");
			e.Cancel = true;
		}
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		SaveFunction();
	}

	private void SaveFunction()
	{
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Invalid comparison between I4 and Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Invalid comparison between I4 and Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between I4 and Unknown
		if (((ContainerControl)this).ValidateChildren())
		{
			try
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "insert into h_room_type(room_type) values('" + ((Control)metroTextBox2).Text + "')";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						((Control)metroTextBox2).Text = "";
						bindall();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Type Added Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
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
			catch (Exception)
			{
				if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room type Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
				{
					((Control)this).Focus();
					((Form)this).Activate();
				}
				return;
			}
		}
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		((Control)button2).Enabled = false;
		Button obj = button3;
		bool enabled = (((Control)button4).Enabled = true);
		((Control)obj).Enabled = enabled;
		gid = ((DataGridView)metroGrid1).SelectedRows[0].Cells[0].Value.ToString();
		((Control)metroTextBox2).Text = ((DataGridView)metroGrid1).SelectedRows[0].Cells[1].Value.ToString();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	private void updateFunction()
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between I4 and Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between I4 and Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between I4 and Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between I4 and Unknown
		if (gid != "")
		{
			if (((ContainerControl)this).ValidateChildren())
			{
				try
				{
					SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val2 = new SqlCommand();
						try
						{
							val2.Connection = val;
							((DbConnection)(object)val).Open();
							((DbCommand)(object)val2).CommandText = "update h_room_type set room_type='" + ((Control)metroTextBox2).Text + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							bindall();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Type Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)metroTextBox2).Text = "";
								((Control)this).Focus();
								((Form)this).Activate();
							}
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
				catch (Exception)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room type Already Avaliable", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				ResetMethod();
				((Control)metroTextBox2).Text = "";
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill All the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		ResetMethod();
	}

	private void ResetMethod()
	{
		gid = "";
		((Control)button2).Enabled = true;
		Button obj = button3;
		bool enabled = (((Control)button4).Enabled = false);
		((Control)obj).Enabled = enabled;
		((Control)metroTextBox2).Text = "";
	}

	private void button4_Click(object sender, EventArgs e)
	{
		DeleteMethod();
	}

	private void DeleteMethod()
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between I4 and Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between I4 and Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between I4 and Unknown
		if (gid != "")
		{
			if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete record", "Confirm?", (MessageBoxButtons)4, (MessageBoxIcon)32))
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "delete from h_room_type where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						((Control)metroTextBox2).Text = "";
						gid = "";
						ResetMethod();
						bindall();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Room Type deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
						return;
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
			((Control)this).Focus();
			((Form)this).Activate();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Item From Table", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData <= 131145)
		{
			if ((int)keyData == 131140)
			{
				DeleteMethod();
				return true;
			}
			if ((int)keyData == 131145)
			{
				ImportMethod();
				return true;
			}
		}
		else
		{
			switch (keyData - 131154)
			{
			default:
				if ((int)keyData != 262232)
				{
					break;
				}
				((Control)Functions.static_mainform).Focus();
				((Form)Functions.static_mainform).Activate();
				((Form)this).Close();
				return true;
			case 1:
				SaveFunction();
				return true;
			case 3:
				updateFunction();
				return true;
			case 0:
				ResetMethod();
				return true;
			case 2:
				break;
			}
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void r_category_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}
}
