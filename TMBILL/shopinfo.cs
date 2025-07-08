using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class shopinfo : MetroForm
{
	private long m_lImageFileLength = 0L;

	private byte[] m_barrImg;

	private int myflag = 1;

	private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

	private SqlCommand cmd = new SqlCommand();

	private RegualarExpress reg = new RegualarExpress();

	private IContainer components = null;

	private MetroGrid metroGrid1;

	private GroupBox groupBox1;

	private Label label7;

	private MetroTextBox metroTextBox6;

	private Label label6;

	private Button button5;

	private PictureBox pictureBox1;

	private MetroTextBox metroTextBox5;

	private MetroTextBox metroTextBox4;

	private MetroTextBox metroTextBox3;

	private MetroTextBox metroTextBox2;

	private MetroTextBox metroTextBox1;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private GroupBox groupBox2;

	private ErrorProvider errorProvider1;

	private OpenFileDialog openFileDialog1;

	private Button button1;

	private MetroTextBox metroTextBox7;

	private Label label8;

	private DataGridViewTextBoxColumn shopname;

	private DataGridViewTextBoxColumn propritorname;

	private DataGridViewTextBoxColumn address;

	private DataGridViewTextBoxColumn contactno;

	private DataGridViewTextBoxColumn emailid;

	private DataGridViewTextBoxColumn gstinno;

	private DataGridViewImageColumn logo;

	public shopinfo()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		InitializeComponent();
		cmd.Connection = cn;
		myflag = 1;
		gridload();
	}

	private void gridload()
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Invalid comparison between I4 and Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((DataGridView)metroGrid1).Rows.Clear();
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
					((DbCommand)(object)val2).CommandText = "select * from shop where id=1";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						while (((DbDataReader)(object)val3).Read())
						{
							((DataGridView)metroGrid1).Rows.Add(new object[7]
							{
								((DbDataReader)(object)val3)["shop_name"].ToString(),
								((DbDataReader)(object)val3)["prop_name"].ToString(),
								((DbDataReader)(object)val3)["address"].ToString(),
								((DbDataReader)(object)val3)["contact"].ToString(),
								((DbDataReader)(object)val3)["email"].ToString(),
								((DbDataReader)(object)val3)["phoneno"].ToString(),
								((DbDataReader)(object)val3)["shop_image"]
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
			((DataGridView)metroGrid1).ClearSelection();
		}
		catch (Exception ex)
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message.ToString(), "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)2;
	}

	private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Invalid comparison between I4 and Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Invalid comparison between I4 and Unknown
		try
		{
			((DbConnection)(object)cn).Open();
			((DbCommand)(object)cmd).CommandText = "select * from shop where id=1";
			SqlDataReader val = cmd.ExecuteReader();
			if (((DbDataReader)(object)val).HasRows)
			{
				while (((DbDataReader)(object)val).Read())
				{
					try
					{
						((Control)metroTextBox1).Text = ((DbDataReader)(object)val)["shop_name"].ToString();
						((Control)metroTextBox6).Text = ((DbDataReader)(object)val)["prop_name"].ToString();
						((Control)metroTextBox2).Text = ((DbDataReader)(object)val)["address"].ToString();
						((Control)metroTextBox3).Text = ((DbDataReader)(object)val)["contact"].ToString();
						((Control)metroTextBox4).Text = ((DbDataReader)(object)val)["email"].ToString();
						((Control)metroTextBox5).Text = ((DbDataReader)(object)val)["gstno"].ToString();
						((Control)metroTextBox7).Text = ((DbDataReader)(object)val)["phoneno"].ToString();
						try
						{
							byte[] array = (byte[])((DbDataReader)(object)val)["shop_image"];
							string text = Convert.ToString(DateTime.Now.ToFileTime());
							FileStream fileStream = new FileStream(text, FileMode.CreateNew, FileAccess.Write);
							fileStream.Write(array, 0, array.Length);
							fileStream.Flush();
							fileStream.Close();
							pictureBox1.Image = Image.FromFile(text);
						}
						catch (Exception)
						{
						}
					}
					catch (Exception ex)
					{
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message, "error", (MessageBoxButtons)0, (MessageBoxIcon)16))
						{
							((Control)this).Focus();
							((Form)this).Activate();
						}
					}
				}
			}
			((DbConnection)(object)cn).Close();
		}
		catch (Exception ex)
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message.ToString(), "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			e.Cancel = true;
			errorProvider1.SetError((Control)(object)metroTextBox1, "Shop Name Required");
		}
	}

	private void bunifuFlatButton1_Click(object sender, EventArgs e)
	{
		button1click();
	}

	private void button1click()
	{
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Invalid comparison between I4 and Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Invalid comparison between I4 and Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Invalid comparison between I4 and Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Invalid comparison between I4 and Unknown
		try
		{
			if (((ContainerControl)this).ValidateChildren())
			{
				if (myflag == 0)
				{
					((DbConnection)(object)cn).Open();
					if (((DbParameterCollection)(object)cmd.Parameters).Count == 0)
					{
						((DbCommand)(object)cmd).CommandText = "update shop set shop_name=@shop_name , prop_name=@prop_name , address=@address , contact=@contact , email=@email , gstno=@gstno ,phoneno=@phoneno, shop_image=@shopimg where id=1 ";
						cmd.Parameters.Add("@shop_name", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@prop_name", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@address", SqlDbType.NVarChar, 100);
						cmd.Parameters.Add("@contact", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@gstno", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@phoneno", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@shopimg", SqlDbType.Image);
					}
					((DbParameter)(object)cmd.Parameters["@shop_name"]).Value = ((Control)metroTextBox1).Text;
					((DbParameter)(object)cmd.Parameters["@prop_name"]).Value = ((Control)metroTextBox6).Text;
					((DbParameter)(object)cmd.Parameters["@address"]).Value = ((Control)metroTextBox2).Text;
					((DbParameter)(object)cmd.Parameters["@contact"]).Value = ((Control)metroTextBox3).Text;
					((DbParameter)(object)cmd.Parameters["@email"]).Value = ((Control)metroTextBox4).Text;
					((DbParameter)(object)cmd.Parameters["@gstno"]).Value = ((Control)metroTextBox5).Text;
					((DbParameter)(object)cmd.Parameters["@phoneno"]).Value = ((Control)metroTextBox7).Text;
					((DbParameter)(object)cmd.Parameters["@shopimg"]).Value = m_barrImg;
					((DbCommand)(object)cmd).ExecuteNonQuery();
					((DbConnection)(object)cn).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Shop Information Successfully Updated ", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
				else
				{
					((DbConnection)(object)cn).Open();
					if (((DbParameterCollection)(object)cmd.Parameters).Count == 0)
					{
						((DbCommand)(object)cmd).CommandText = "update shop set shop_name=@shop_name , prop_name=@prop_name , address=@address , contact=@contact , email=@email ,phoneno=@phoneno, gstno=@gstno where id=1 ";
						cmd.Parameters.Add("@shop_name", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@prop_name", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@address", SqlDbType.NVarChar, 100);
						cmd.Parameters.Add("@contact", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@phoneno", SqlDbType.NVarChar, 50);
						cmd.Parameters.Add("@gstno", SqlDbType.NVarChar, 50);
					}
					((DbParameter)(object)cmd.Parameters["@shop_name"]).Value = ((Control)metroTextBox1).Text;
					((DbParameter)(object)cmd.Parameters["@prop_name"]).Value = ((Control)metroTextBox6).Text;
					((DbParameter)(object)cmd.Parameters["@address"]).Value = ((Control)metroTextBox2).Text;
					((DbParameter)(object)cmd.Parameters["@contact"]).Value = ((Control)metroTextBox3).Text;
					((DbParameter)(object)cmd.Parameters["@email"]).Value = ((Control)metroTextBox4).Text;
					((DbParameter)(object)cmd.Parameters["@gstno"]).Value = ((Control)metroTextBox5).Text;
					((DbParameter)(object)cmd.Parameters["@phoneno"]).Value = ((Control)metroTextBox7).Text;
					((DbCommand)(object)cmd).ExecuteNonQuery();
					((DbConnection)(object)cn).Close();
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Shop Information Successfully Updated ", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
				}
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Enter Valid Information", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		catch (Exception ex)
		{
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message.ToString(), "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
	}

	private void metroTextBox6_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox6, "");
	}

	private void metroTextBox6_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox6).Text == "")
		{
			e.Cancel = true;
			errorProvider1.SetError((Control)(object)metroTextBox6, "Proprietor Name Required");
		}
	}

	private void metroTextBox2_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox2, "");
	}

	private void metroTextBox2_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox2).Text == "")
		{
			e.Cancel = true;
			errorProvider1.SetError((Control)(object)metroTextBox2, "");
		}
	}

	private void metroTextBox3_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox3, "");
	}

	private void metroTextBox3_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox3).Text == "" || !reg.mobilenofield(((Control)metroTextBox3).Text))
		{
			e.Cancel = true;
			errorProvider1.SetError((Control)(object)metroTextBox3, "Incorrect Mobile No");
		}
	}

	private void metroTextBox4_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox4, "");
	}

	private void metroTextBox4_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox4).Text == "" || !reg.emailfield(((Control)metroTextBox4).Text))
		{
			errorProvider1.SetError((Control)(object)metroTextBox4, "Incorrect Email id");
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		button2click();
	}

	private void button2click()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)openFileDialog1).ShowDialog((IWin32Window)(object)this);
		string fileName = ((FileDialog)openFileDialog1).FileName;
		pictureBox1.Image = Image.FromFile(fileName);
		FileInfo fileInfo = new FileInfo(fileName);
		m_lImageFileLength = fileInfo.Length;
		FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
		int num = fileStream.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
		fileStream.Close();
		myflag = 0;
	}

	private void shopinfo_Activated(object sender, EventArgs e)
	{
		gridload();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131138)
		{
			if ((int)keyData != 131157)
			{
				if ((int)keyData == 262232)
				{
					((Control)metroTextBox1).Text = "a";
					((Form)this).Close();
					return true;
				}
				return ((Form)this).ProcessCmdKey(ref msg, keyData);
			}
			button1click();
			return true;
		}
		button2click();
		return true;
	}

	private void shopinfo_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}

	private void shopinfo_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
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
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
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
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6f: Expected O, but got Unknown
		//IL_0f4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected O, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected O, but got Unknown
		//IL_1442: Unknown result type (might be due to invalid IL or missing references)
		//IL_144c: Expected O, but got Unknown
		//IL_166e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1678: Expected O, but got Unknown
		//IL_1897: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a1: Expected O, but got Unknown
		//IL_1ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aca: Expected O, but got Unknown
		//IL_1d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d44: Expected O, but got Unknown
		//IL_1df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfd: Expected O, but got Unknown
		//IL_1f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f36: Expected O, but got Unknown
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8c: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(shopinfo));
		metroGrid1 = new MetroGrid();
		shopname = new DataGridViewTextBoxColumn();
		propritorname = new DataGridViewTextBoxColumn();
		address = new DataGridViewTextBoxColumn();
		contactno = new DataGridViewTextBoxColumn();
		emailid = new DataGridViewTextBoxColumn();
		gstinno = new DataGridViewTextBoxColumn();
		logo = new DataGridViewImageColumn();
		groupBox1 = new GroupBox();
		metroTextBox7 = new MetroTextBox();
		label8 = new Label();
		label7 = new Label();
		metroTextBox6 = new MetroTextBox();
		label6 = new Label();
		button5 = new Button();
		pictureBox1 = new PictureBox();
		metroTextBox5 = new MetroTextBox();
		metroTextBox4 = new MetroTextBox();
		metroTextBox3 = new MetroTextBox();
		metroTextBox2 = new MetroTextBox();
		metroTextBox1 = new MetroTextBox();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		groupBox2 = new GroupBox();
		button1 = new Button();
		errorProvider1 = new ErrorProvider(components);
		openFileDialog1 = new OpenFileDialog();
		((ISupportInitialize)metroGrid1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((DataGridView)metroGrid1).AllowUserToAddRows = false;
		((DataGridView)metroGrid1).AllowUserToDeleteRows = false;
		((DataGridView)metroGrid1).AllowUserToResizeRows = false;
		((DataGridView)metroGrid1).BackgroundColor = Color.FromArgb(255, 255, 255);
		((DataGridView)metroGrid1).BorderStyle = (BorderStyle)0;
		((DataGridView)metroGrid1).CellBorderStyle = (DataGridViewCellBorderStyle)4;
		((DataGridView)metroGrid1).ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val.Alignment = (DataGridViewContentAlignment)32;
		val.BackColor = Color.FromArgb(0, 170, 173);
		val.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val.ForeColor = Color.FromArgb(255, 255, 255);
		val.SelectionBackColor = Color.FromArgb(0, 201, 206);
		val.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).ColumnHeadersDefaultCellStyle = val;
		((DataGridView)metroGrid1).ColumnHeadersHeightSizeMode = (DataGridViewColumnHeadersHeightSizeMode)2;
		((DataGridView)metroGrid1).Columns.AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)shopname,
			(DataGridViewColumn)propritorname,
			(DataGridViewColumn)address,
			(DataGridViewColumn)contactno,
			(DataGridViewColumn)emailid,
			(DataGridViewColumn)gstinno,
			(DataGridViewColumn)logo
		});
		val2.Alignment = (DataGridViewContentAlignment)32;
		val2.BackColor = Color.FromArgb(255, 255, 255);
		val2.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val2.ForeColor = Color.FromArgb(136, 136, 136);
		val2.SelectionBackColor = Color.FromArgb(0, 201, 206);
		val2.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val2.WrapMode = (DataGridViewTriState)2;
		((DataGridView)metroGrid1).DefaultCellStyle = val2;
		((DataGridView)metroGrid1).EnableHeadersVisualStyles = false;
		((Control)metroGrid1).Font = new Font("Segoe UI", 11f, (FontStyle)0, (GraphicsUnit)2);
		((DataGridView)metroGrid1).GridColor = Color.FromArgb(255, 255, 255);
		((Control)metroGrid1).Location = new Point(23, 63);
		((Control)metroGrid1).Name = "metroGrid1";
		((DataGridView)metroGrid1).ReadOnly = true;
		((DataGridView)metroGrid1).RowHeadersBorderStyle = (DataGridViewHeaderBorderStyle)4;
		val3.Alignment = (DataGridViewContentAlignment)16;
		val3.BackColor = Color.FromArgb(0, 170, 173);
		val3.Font = new Font("Segoe UI", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		val3.ForeColor = Color.FromArgb(255, 255, 255);
		val3.SelectionBackColor = Color.FromArgb(0, 201, 206);
		val3.SelectionForeColor = Color.FromArgb(17, 17, 17);
		val3.WrapMode = (DataGridViewTriState)1;
		((DataGridView)metroGrid1).RowHeadersDefaultCellStyle = val3;
		((DataGridView)metroGrid1).RowHeadersWidthSizeMode = (DataGridViewRowHeadersWidthSizeMode)1;
		((DataGridView)metroGrid1).RowTemplate.Height = 50;
		((DataGridView)metroGrid1).SelectionMode = (DataGridViewSelectionMode)1;
		((Control)metroGrid1).Size = new Size(1162, 120);
		metroGrid1.Style = (MetroColorStyle)7;
		((Control)metroGrid1).TabIndex = 1;
		((DataGridView)metroGrid1).CellClick += new DataGridViewCellEventHandler(metroGrid1_CellClick);
		((DataGridViewBand)shopname).Frozen = true;
		((DataGridViewColumn)shopname).HeaderText = "Shop Name";
		((DataGridViewColumn)shopname).Name = "shopname";
		((DataGridViewBand)shopname).ReadOnly = true;
		((DataGridViewColumn)shopname).Width = 200;
		((DataGridViewBand)propritorname).Frozen = true;
		((DataGridViewColumn)propritorname).HeaderText = "Propriter Name";
		((DataGridViewColumn)propritorname).Name = "propritorname";
		((DataGridViewBand)propritorname).ReadOnly = true;
		((DataGridViewColumn)propritorname).Width = 130;
		((DataGridViewBand)address).Frozen = true;
		((DataGridViewColumn)address).HeaderText = "Address";
		((DataGridViewColumn)address).Name = "address";
		((DataGridViewBand)address).ReadOnly = true;
		((DataGridViewColumn)address).Width = 230;
		((DataGridViewBand)contactno).Frozen = true;
		((DataGridViewColumn)contactno).HeaderText = "Mobile No";
		((DataGridViewColumn)contactno).Name = "contactno";
		((DataGridViewBand)contactno).ReadOnly = true;
		((DataGridViewColumn)contactno).Width = 125;
		((DataGridViewBand)emailid).Frozen = true;
		((DataGridViewColumn)emailid).HeaderText = "Email ID";
		((DataGridViewColumn)emailid).Name = "emailid";
		((DataGridViewBand)emailid).ReadOnly = true;
		((DataGridViewColumn)emailid).Width = 200;
		((DataGridViewBand)gstinno).Frozen = true;
		((DataGridViewColumn)gstinno).HeaderText = "Phone No";
		((DataGridViewColumn)gstinno).Name = "gstinno";
		((DataGridViewBand)gstinno).ReadOnly = true;
		((DataGridViewColumn)gstinno).Width = 125;
		((DataGridViewColumn)logo).AutoSizeMode = (DataGridViewAutoSizeColumnMode)1;
		((DataGridViewColumn)logo).DataPropertyName = "shop_image";
		((DataGridViewBand)logo).Frozen = true;
		((DataGridViewColumn)logo).HeaderText = "Logo";
		logo.ImageLayout = (DataGridViewImageCellLayout)3;
		((DataGridViewColumn)logo).Name = "logo";
		((DataGridViewBand)logo).ReadOnly = true;
		((Control)groupBox1).Anchor = (AnchorStyles)13;
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox7);
		((Control)groupBox1).Controls.Add((Control)(object)label8);
		((Control)groupBox1).Controls.Add((Control)(object)label7);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox6);
		((Control)groupBox1).Controls.Add((Control)(object)label6);
		((Control)groupBox1).Controls.Add((Control)(object)button5);
		((Control)groupBox1).Controls.Add((Control)(object)pictureBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox5);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox4);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)label5);
		((Control)groupBox1).Controls.Add((Control)(object)label4);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 189);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(787, 323);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Fill Information";
		metroTextBox7.CustomButton.Image = null;
		((Control)metroTextBox7.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox7.CustomButton).Name = "";
		((Control)metroTextBox7.CustomButton).Size = new Size(25, 25);
		metroTextBox7.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox7.CustomButton).TabIndex = 1;
		metroTextBox7.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox7.CustomButton.UseSelectable = true;
		((Control)metroTextBox7.CustomButton).Visible = false;
		metroTextBox7.FontSize = (MetroTextBoxSize)2;
		metroTextBox7.Lines = new string[0];
		((Control)metroTextBox7).Location = new Point(164, 263);
		metroTextBox7.MaxLength = 32767;
		((Control)metroTextBox7).Name = "metroTextBox7";
		metroTextBox7.PasswordChar = '\0';
		metroTextBox7.PromptText = "Enter Phone NO";
		metroTextBox7.ScrollBars = (ScrollBars)0;
		metroTextBox7.SelectedText = "";
		metroTextBox7.SelectionLength = 0;
		metroTextBox7.SelectionStart = 0;
		metroTextBox7.ShortcutsEnabled = true;
		((Control)metroTextBox7).Size = new Size(315, 30);
		metroTextBox7.Style = (MetroColorStyle)7;
		((Control)metroTextBox7).TabIndex = 48;
		metroTextBox7.UseSelectable = true;
		metroTextBox7.WaterMark = "Enter Phone NO";
		metroTextBox7.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox7.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(53, 275);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(75, 18);
		((Control)label8).TabIndex = 47;
		((Control)label8).Text = "Phone No";
		((Control)label7).AutoSize = true;
		((Control)label7).Location = new Point(40, 80);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(88, 18);
		((Control)label7).TabIndex = 46;
		((Control)label7).Text = "Prop. Name";
		metroTextBox6.CustomButton.Image = null;
		((Control)metroTextBox6.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox6.CustomButton).Name = "";
		((Control)metroTextBox6.CustomButton).Size = new Size(25, 25);
		metroTextBox6.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox6.CustomButton).TabIndex = 1;
		metroTextBox6.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox6.CustomButton.UseSelectable = true;
		((Control)metroTextBox6.CustomButton).Visible = false;
		metroTextBox6.FontSize = (MetroTextBoxSize)2;
		metroTextBox6.Lines = new string[0];
		((Control)metroTextBox6).Location = new Point(164, 73);
		metroTextBox6.MaxLength = 32767;
		((Control)metroTextBox6).Name = "metroTextBox6";
		metroTextBox6.PasswordChar = '\0';
		metroTextBox6.PromptText = "Enter Proprietor Name";
		metroTextBox6.ScrollBars = (ScrollBars)0;
		metroTextBox6.SelectedText = "";
		metroTextBox6.SelectionLength = 0;
		metroTextBox6.SelectionStart = 0;
		metroTextBox6.ShortcutsEnabled = true;
		((Control)metroTextBox6).Size = new Size(315, 30);
		metroTextBox6.Style = (MetroColorStyle)7;
		((Control)metroTextBox6).TabIndex = 1;
		metroTextBox6.UseSelectable = true;
		metroTextBox6.WaterMark = "Enter Proprietor Name";
		metroTextBox6.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox6.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox6).Validating += metroTextBox6_Validating;
		((Control)metroTextBox6).Validated += metroTextBox6_Validated;
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(531, 207);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(210, 36);
		((Control)label6).TabIndex = 44;
		((Control)label6).Text = "Choose 100x100 Image size it \r\ndisplay Corrretly";
		((Control)button5).BackColor = Color.FromArgb(0, 170, 170);
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((Control)button5).Location = new Point(553, 170);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(153, 34);
		((Control)button5).TabIndex = 6;
		((Control)button5).Text = "Browse(Ctrl+B)";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)pictureBox1).Location = new Point(576, 47);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(100, 100);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 10;
		pictureBox1.TabStop = false;
		metroTextBox5.CustomButton.Image = null;
		((Control)metroTextBox5.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox5.CustomButton).Name = "";
		((Control)metroTextBox5.CustomButton).Size = new Size(25, 25);
		metroTextBox5.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox5.CustomButton).TabIndex = 1;
		metroTextBox5.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox5.CustomButton.UseSelectable = true;
		((Control)metroTextBox5.CustomButton).Visible = false;
		metroTextBox5.FontSize = (MetroTextBoxSize)2;
		metroTextBox5.Lines = new string[0];
		((Control)metroTextBox5).Location = new Point(164, 225);
		metroTextBox5.MaxLength = 32767;
		((Control)metroTextBox5).Name = "metroTextBox5";
		metroTextBox5.PasswordChar = '\0';
		metroTextBox5.PromptText = "Enter GSTIN NO";
		metroTextBox5.ScrollBars = (ScrollBars)0;
		metroTextBox5.SelectedText = "";
		metroTextBox5.SelectionLength = 0;
		metroTextBox5.SelectionStart = 0;
		metroTextBox5.ShortcutsEnabled = true;
		((Control)metroTextBox5).Size = new Size(315, 30);
		metroTextBox5.Style = (MetroColorStyle)7;
		((Control)metroTextBox5).TabIndex = 5;
		metroTextBox5.UseSelectable = true;
		metroTextBox5.WaterMark = "Enter GSTIN NO";
		metroTextBox5.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox5.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		metroTextBox4.CustomButton.Image = null;
		((Control)metroTextBox4.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox4.CustomButton).Name = "";
		((Control)metroTextBox4.CustomButton).Size = new Size(25, 25);
		metroTextBox4.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox4.CustomButton).TabIndex = 1;
		metroTextBox4.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox4.CustomButton.UseSelectable = true;
		((Control)metroTextBox4.CustomButton).Visible = false;
		metroTextBox4.FontSize = (MetroTextBoxSize)2;
		metroTextBox4.Lines = new string[0];
		((Control)metroTextBox4).Location = new Point(164, 187);
		metroTextBox4.MaxLength = 32767;
		((Control)metroTextBox4).Name = "metroTextBox4";
		metroTextBox4.PasswordChar = '\0';
		metroTextBox4.PromptText = "Enter Email ID";
		metroTextBox4.ScrollBars = (ScrollBars)0;
		metroTextBox4.SelectedText = "";
		metroTextBox4.SelectionLength = 0;
		metroTextBox4.SelectionStart = 0;
		metroTextBox4.ShortcutsEnabled = true;
		((Control)metroTextBox4).Size = new Size(315, 30);
		metroTextBox4.Style = (MetroColorStyle)7;
		((Control)metroTextBox4).TabIndex = 4;
		metroTextBox4.UseSelectable = true;
		metroTextBox4.WaterMark = "Enter Email ID";
		metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox4.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox4).Validating += metroTextBox4_Validating;
		((Control)metroTextBox4).Validated += metroTextBox4_Validated;
		metroTextBox3.CustomButton.Image = null;
		((Control)metroTextBox3.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox3.CustomButton).Name = "";
		((Control)metroTextBox3.CustomButton).Size = new Size(25, 25);
		metroTextBox3.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox3.CustomButton).TabIndex = 1;
		metroTextBox3.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox3.CustomButton.UseSelectable = true;
		((Control)metroTextBox3.CustomButton).Visible = false;
		metroTextBox3.FontSize = (MetroTextBoxSize)2;
		metroTextBox3.Lines = new string[0];
		((Control)metroTextBox3).Location = new Point(164, 149);
		metroTextBox3.MaxLength = 32767;
		((Control)metroTextBox3).Name = "metroTextBox3";
		metroTextBox3.PasswordChar = '\0';
		metroTextBox3.PromptText = "Enter Mobile No";
		metroTextBox3.ScrollBars = (ScrollBars)0;
		metroTextBox3.SelectedText = "";
		metroTextBox3.SelectionLength = 0;
		metroTextBox3.SelectionStart = 0;
		metroTextBox3.ShortcutsEnabled = true;
		((Control)metroTextBox3).Size = new Size(315, 30);
		metroTextBox3.Style = (MetroColorStyle)7;
		((Control)metroTextBox3).TabIndex = 3;
		metroTextBox3.UseSelectable = true;
		metroTextBox3.WaterMark = "Enter Mobile No";
		metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox3.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox3).Validating += metroTextBox3_Validating;
		((Control)metroTextBox3).Validated += metroTextBox3_Validated;
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(25, 25);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)2;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(164, 111);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Enter Shop Address";
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(315, 30);
		metroTextBox2.Style = (MetroColorStyle)7;
		((Control)metroTextBox2).TabIndex = 2;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Enter Shop Address";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox2).Validating += metroTextBox2_Validating;
		((Control)metroTextBox2).Validated += metroTextBox2_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(287, 2);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(25, 25);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)2;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(164, 35);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Shop Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(315, 30);
		metroTextBox1.Style = (MetroColorStyle)7;
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Shop Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)label5).AutoSize = true;
		((Control)label5).Location = new Point(51, 237);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(77, 18);
		((Control)label5).TabIndex = 4;
		((Control)label5).Text = "GSTIN No";
		((Control)label4).AutoSize = true;
		((Control)label4).Location = new Point(65, 199);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(63, 18);
		((Control)label4).TabIndex = 3;
		((Control)label4).Text = "Email ID";
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(52, 161);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(76, 18);
		((Control)label3).TabIndex = 2;
		((Control)label3).Text = "Mobile No";
		((Control)label2).AutoSize = true;
		((Control)label2).Location = new Point(66, 123);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(62, 18);
		((Control)label2).TabIndex = 1;
		((Control)label2).Text = "Address";
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(41, 35);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(87, 18);
		((Control)label1).TabIndex = 0;
		((Control)label1).Text = "Shop Name";
		((Control)groupBox2).Anchor = (AnchorStyles)9;
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(816, 189);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(369, 323);
		((Control)groupBox2).TabIndex = 3;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Actions";
		((Control)button1).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(98, 61);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(169, 57);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = "Update";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += bunifuFlatButton1_Click;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((FileDialog)openFileDialog1).FileName = "openFileDialog1";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(1208, 535);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Controls.Add((Control)(object)metroGrid1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "shopinfo";
		((MetroForm)this).Resizable = false;
		((MetroForm)this).Style = (MetroColorStyle)7;
		((Control)this).Text = "Shop Information";
		((Form)this).Activated += shopinfo_Activated;
		((Form)this).FormClosed += new FormClosedEventHandler(shopinfo_FormClosed);
		((Form)this).Load += shopinfo_Load;
		((ISupportInitialize)metroGrid1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)groupBox2).ResumeLayout(false);
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
