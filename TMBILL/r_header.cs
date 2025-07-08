using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class r_header : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox2;

	private MetroComboBox metroComboBox1;

	private MetroCheckBox metroCheckBox1;

	private MetroCheckBox metroCheckBox2;

	private MetroCheckBox metroCheckBox3;

	private MetroCheckBox metroCheckBox4;

	private MetroCheckBox metroCheckBox5;

	private MetroCheckBox metroCheckBox6;

	private MetroCheckBox metroCheckBox7;

	private MetroCheckBox metroCheckBox8;

	private MetroCheckBox metroCheckBox9;

	private MetroCheckBox metroCheckBox10;

	private MetroCheckBox metroCheckBox12;

	private MetroCheckBox metroCheckBox11;

	private Button button1;

	public r_header()
	{
		InitializeComponent();
		((ListControl)metroComboBox1).SelectedIndex = 0;
	}

	public void BindCheckBox()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from r_header where form_name='" + ((Control)metroComboBox1).Text + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string text = ((DbDataReader)(object)val3)[2].ToString();
						if (text != "")
						{
							string[] array = text.Split(new char[1] { '*' });
							if (array.Length > 0)
							{
								if (array[0] == "True")
								{
									((CheckBox)metroCheckBox3).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox3).Checked = false;
								}
								if (array[1] == "True")
								{
									((CheckBox)metroCheckBox4).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox4).Checked = false;
								}
								if (array[2] == "True")
								{
									((CheckBox)metroCheckBox5).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox5).Checked = false;
								}
								if (array[3] != "")
								{
									((CheckBox)metroCheckBox6).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox6).Checked = false;
								}
								if (array[4] != "")
								{
									((CheckBox)metroCheckBox7).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox7).Checked = false;
								}
								if (array[5] != "")
								{
									((CheckBox)metroCheckBox8).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox8).Checked = false;
								}
								if (array[6] != "")
								{
									((CheckBox)metroCheckBox9).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox9).Checked = false;
								}
								if (array[7] != "")
								{
									((CheckBox)metroCheckBox10).Checked = true;
								}
								else
								{
									((CheckBox)metroCheckBox10).Checked = false;
								}
							}
						}
						string text2 = ((DbDataReader)(object)val3)[3].ToString();
						if (text2 != "")
						{
							string[] array = text2.Split(new char[1] { '*' });
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox11).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox11).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox12).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox12).Checked = false;
							}
						}
						string text3 = ((DbDataReader)(object)val3)[4].ToString();
						string text4 = ((DbDataReader)(object)val3)[5].ToString();
						if (text3 == "True")
						{
							((CheckBox)metroCheckBox1).Checked = true;
						}
						else
						{
							((CheckBox)metroCheckBox1).Checked = false;
						}
						if (text4 == "True")
						{
							((CheckBox)metroCheckBox2).Checked = true;
						}
						else
						{
							((CheckBox)metroCheckBox2).Checked = false;
						}
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

	private void r_header_Load(object sender, EventArgs e)
	{
		BindCheckBox();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		setall();
	}

	private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox1).Checked)
		{
			MetroCheckBox obj = metroCheckBox3;
			MetroCheckBox obj2 = metroCheckBox4;
			MetroCheckBox obj3 = metroCheckBox5;
			MetroCheckBox obj4 = metroCheckBox6;
			MetroCheckBox obj5 = metroCheckBox7;
			MetroCheckBox obj6 = metroCheckBox8;
			MetroCheckBox obj7 = metroCheckBox9;
			bool flag = (((Control)metroCheckBox10).Enabled = true);
			flag = (((Control)obj7).Enabled = flag);
			flag = (((Control)obj6).Enabled = flag);
			flag = (((Control)obj5).Enabled = flag);
			flag = (((Control)obj4).Enabled = flag);
			flag = (((Control)obj3).Enabled = flag);
			flag = (((Control)obj2).Enabled = flag);
			((Control)obj).Enabled = flag;
		}
		else
		{
			MetroCheckBox obj8 = metroCheckBox3;
			MetroCheckBox obj9 = metroCheckBox4;
			MetroCheckBox obj10 = metroCheckBox5;
			MetroCheckBox obj11 = metroCheckBox6;
			MetroCheckBox obj12 = metroCheckBox7;
			MetroCheckBox obj13 = metroCheckBox8;
			MetroCheckBox obj14 = metroCheckBox9;
			bool flag = (((Control)metroCheckBox10).Enabled = false);
			flag = (((Control)obj14).Enabled = flag);
			flag = (((Control)obj13).Enabled = flag);
			flag = (((Control)obj12).Enabled = flag);
			flag = (((Control)obj11).Enabled = flag);
			flag = (((Control)obj10).Enabled = flag);
			flag = (((Control)obj9).Enabled = flag);
			((Control)obj8).Enabled = flag;
		}
	}

	private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox2).Checked)
		{
			MetroCheckBox obj = metroCheckBox11;
			bool enabled = (((Control)metroCheckBox12).Enabled = true);
			((Control)obj).Enabled = enabled;
		}
		else
		{
			MetroCheckBox obj2 = metroCheckBox11;
			bool enabled = (((Control)metroCheckBox12).Enabled = false);
			((Control)obj2).Enabled = enabled;
		}
	}

	public void setall()
	{
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between I4 and Unknown
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		if (!((CheckBox)metroCheckBox1).Checked)
		{
			text = "False";
			text2 = "********";
		}
		else
		{
			text = "True";
			text2 += (((CheckBox)metroCheckBox3).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox4).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox5).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox6).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox7).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox8).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox9).Checked ? "True*" : "*");
			text2 += (((CheckBox)metroCheckBox10).Checked ? "True*" : "*");
		}
		if (!((CheckBox)metroCheckBox2).Checked)
		{
			text4 = "False";
			text3 = "**";
		}
		else
		{
			text4 = "True";
			text3 += (((CheckBox)metroCheckBox11).Checked ? "True*" : "*");
			text3 += (((CheckBox)metroCheckBox12).Checked ? "True*" : "*");
		}
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "update r_header set header='" + text2 + "',footer='" + text3 + "',print_header='" + text + "',print_footer='" + text4 + "' where form_name='" + ((Control)metroComboBox1).Text + "'";
				((DbCommand)(object)val2).ExecuteNonQuery();
				((DbConnection)(object)val).Close();
				if (1 != (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
				{
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
		BindCheckBox();
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		BindCheckBox();
	}

	private void r_header_FormClosed(object sender, FormClosedEventArgs e)
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Expected O, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_header));
		groupBox2 = new GroupBox();
		button1 = new Button();
		metroCheckBox12 = new MetroCheckBox();
		metroCheckBox11 = new MetroCheckBox();
		metroCheckBox10 = new MetroCheckBox();
		metroCheckBox9 = new MetroCheckBox();
		metroCheckBox8 = new MetroCheckBox();
		metroCheckBox7 = new MetroCheckBox();
		metroCheckBox6 = new MetroCheckBox();
		metroCheckBox5 = new MetroCheckBox();
		metroCheckBox4 = new MetroCheckBox();
		metroCheckBox3 = new MetroCheckBox();
		metroCheckBox2 = new MetroCheckBox();
		metroCheckBox1 = new MetroCheckBox();
		metroComboBox1 = new MetroComboBox();
		((Control)groupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox12);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox11);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox10);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox9);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox8);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox7);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox6);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox5);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox4);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox3);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox2);
		((Control)groupBox2).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox2).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(23, 63);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(282, 447);
		((Control)groupBox2).TabIndex = 1;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Print Paper Header && Footer";
		((Control)button1).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(22, 382);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(239, 51);
		((Control)button1).TabIndex = 14;
		((Control)button1).Text = "Update";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)metroCheckBox12).AutoSize = true;
		metroCheckBox12.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox12).Location = new Point(46, 354);
		((Control)metroCheckBox12).Name = "metroCheckBox12";
		((Control)metroCheckBox12).Size = new Size(117, 19);
		metroCheckBox12.Style = (MetroColorStyle)8;
		((Control)metroCheckBox12).TabIndex = 12;
		((Control)metroCheckBox12).Text = "Proprietor Sign";
		metroCheckBox12.UseSelectable = true;
		((Control)metroCheckBox11).AutoSize = true;
		metroCheckBox11.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox11).Location = new Point(46, 329);
		((Control)metroCheckBox11).Name = "metroCheckBox11";
		((Control)metroCheckBox11).Size = new Size(115, 19);
		metroCheckBox11.Style = (MetroColorStyle)8;
		((Control)metroCheckBox11).TabIndex = 11;
		((Control)metroCheckBox11).Text = "Customer Sign";
		metroCheckBox11.UseSelectable = true;
		((Control)metroCheckBox10).AutoSize = true;
		metroCheckBox10.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox10).Location = new Point(46, 279);
		((Control)metroCheckBox10).Name = "metroCheckBox10";
		((Control)metroCheckBox10).Size = new Size(56, 19);
		metroCheckBox10.Style = (MetroColorStyle)8;
		((Control)metroCheckBox10).TabIndex = 10;
		((Control)metroCheckBox10).Text = "Logo";
		metroCheckBox10.UseSelectable = true;
		((Control)metroCheckBox9).AutoSize = true;
		metroCheckBox9.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox9).Location = new Point(46, 254);
		((Control)metroCheckBox9).Name = "metroCheckBox9";
		((Control)metroCheckBox9).Size = new Size(98, 19);
		metroCheckBox9.Style = (MetroColorStyle)8;
		((Control)metroCheckBox9).TabIndex = 9;
		((Control)metroCheckBox9).Text = "Landline No";
		metroCheckBox9.UseSelectable = true;
		((Control)metroCheckBox8).AutoSize = true;
		metroCheckBox8.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox8).Location = new Point(46, 229);
		((Control)metroCheckBox8).Name = "metroCheckBox8";
		((Control)metroCheckBox8).Size = new Size(71, 19);
		metroCheckBox8.Style = (MetroColorStyle)8;
		((Control)metroCheckBox8).TabIndex = 8;
		((Control)metroCheckBox8).Text = "GST No";
		metroCheckBox8.UseSelectable = true;
		((Control)metroCheckBox7).AutoSize = true;
		metroCheckBox7.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox7).Location = new Point(46, 204);
		((Control)metroCheckBox7).Name = "metroCheckBox7";
		((Control)metroCheckBox7).Size = new Size(97, 19);
		metroCheckBox7.Style = (MetroColorStyle)8;
		((Control)metroCheckBox7).TabIndex = 7;
		((Control)metroCheckBox7).Text = "Email Name";
		metroCheckBox7.UseSelectable = true;
		((Control)metroCheckBox6).AutoSize = true;
		metroCheckBox6.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox6).Location = new Point(46, 179);
		((Control)metroCheckBox6).Name = "metroCheckBox6";
		((Control)metroCheckBox6).Size = new Size(89, 19);
		metroCheckBox6.Style = (MetroColorStyle)8;
		((Control)metroCheckBox6).TabIndex = 6;
		((Control)metroCheckBox6).Text = "Mobile No";
		metroCheckBox6.UseSelectable = true;
		((Control)metroCheckBox5).AutoSize = true;
		metroCheckBox5.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox5).Location = new Point(46, 154);
		((Control)metroCheckBox5).Name = "metroCheckBox5";
		((Control)metroCheckBox5).Size = new Size(114, 19);
		metroCheckBox5.Style = (MetroColorStyle)8;
		((Control)metroCheckBox5).TabIndex = 5;
		((Control)metroCheckBox5).Text = "Address Name";
		metroCheckBox5.UseSelectable = true;
		((Control)metroCheckBox4).AutoSize = true;
		metroCheckBox4.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox4).Location = new Point(46, 129);
		((Control)metroCheckBox4).Name = "metroCheckBox4";
		((Control)metroCheckBox4).Size = new Size(127, 19);
		metroCheckBox4.Style = (MetroColorStyle)8;
		((Control)metroCheckBox4).TabIndex = 4;
		((Control)metroCheckBox4).Text = "Proprietor Name";
		metroCheckBox4.UseSelectable = true;
		((Control)metroCheckBox3).AutoSize = true;
		metroCheckBox3.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox3).Location = new Point(46, 104);
		((Control)metroCheckBox3).Name = "metroCheckBox3";
		((Control)metroCheckBox3).Size = new Size(98, 19);
		metroCheckBox3.Style = (MetroColorStyle)8;
		((Control)metroCheckBox3).TabIndex = 3;
		((Control)metroCheckBox3).Text = "Hotel Name";
		metroCheckBox3.UseSelectable = true;
		((Control)metroCheckBox2).AutoSize = true;
		metroCheckBox2.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox2).Location = new Point(22, 304);
		((Control)metroCheckBox2).Name = "metroCheckBox2";
		((Control)metroCheckBox2).Size = new Size(98, 19);
		metroCheckBox2.Style = (MetroColorStyle)5;
		((Control)metroCheckBox2).TabIndex = 2;
		((Control)metroCheckBox2).Text = "Print Footer";
		metroCheckBox2.UseSelectable = true;
		((CheckBox)metroCheckBox2).CheckedChanged += metroCheckBox2_CheckedChanged;
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(22, 79);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(102, 19);
		metroCheckBox1.Style = (MetroColorStyle)5;
		((Control)metroCheckBox1).TabIndex = 1;
		((Control)metroCheckBox1).Text = "Print Header";
		metroCheckBox1.UseSelectable = true;
		((CheckBox)metroCheckBox1).CheckedChanged += metroCheckBox1_CheckedChanged;
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((ComboBox)metroComboBox1).Items.AddRange(new object[8] { "Bill Report", "Sale Report", "Stock Report", "KOT Print", "Dine In Print", "Takeaway Print", "Home Delivery Print", "Purchase History Print" });
		((Control)metroComboBox1).Location = new Point(22, 38);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Form";
		((Control)metroComboBox1).Size = new Size(239, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(330, 519);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_header";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Printer Header && Footer";
		((Form)this).FormClosed += new FormClosedEventHandler(r_header_FormClosed);
		((Form)this).Load += r_header_Load;
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
