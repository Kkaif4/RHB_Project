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

namespace TMBILL;

public class r_user_control : MetroForm
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private Label label6;

	private Label label5;

	private Label label10;

	private Label label9;

	private Label label8;

	private Label label7;

	private Label label14;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label17;

	private Label label16;

	private Label label15;

	private Label label19;

	private Label label18;

	private Label label20;

	private Label label21;

	private Label label22;

	private Label label25;

	private Label label24;

	private Label label28;

	private Label label27;

	private Label label26;

	private MetroCheckBox metroCheckBox2;

	private MetroCheckBox metroCheckBox1;

	private MetroCheckBox metroCheckBox3;

	private Label label1;

	private MetroCheckBox metroCheckBox43;

	private MetroCheckBox metroCheckBox44;

	private MetroCheckBox metroCheckBox45;

	private MetroCheckBox metroCheckBox40;

	private MetroCheckBox metroCheckBox41;

	private MetroCheckBox metroCheckBox42;

	private MetroCheckBox metroCheckBox37;

	private MetroCheckBox metroCheckBox38;

	private MetroCheckBox metroCheckBox39;

	private MetroCheckBox metroCheckBox34;

	private MetroCheckBox metroCheckBox35;

	private MetroCheckBox metroCheckBox36;

	private MetroCheckBox metroCheckBox31;

	private MetroCheckBox metroCheckBox32;

	private MetroCheckBox metroCheckBox33;

	private MetroCheckBox metroCheckBox30;

	private MetroCheckBox metroCheckBox25;

	private MetroCheckBox metroCheckBox26;

	private MetroCheckBox metroCheckBox27;

	private MetroCheckBox metroCheckBox22;

	private MetroCheckBox metroCheckBox23;

	private MetroCheckBox metroCheckBox24;

	private MetroCheckBox metroCheckBox19;

	private MetroCheckBox metroCheckBox20;

	private MetroCheckBox metroCheckBox21;

	private MetroCheckBox metroCheckBox16;

	private MetroCheckBox metroCheckBox17;

	private MetroCheckBox metroCheckBox18;

	private MetroCheckBox metroCheckBox13;

	private MetroCheckBox metroCheckBox14;

	private MetroCheckBox metroCheckBox15;

	private MetroCheckBox metroCheckBox10;

	private MetroCheckBox metroCheckBox11;

	private MetroCheckBox metroCheckBox12;

	private MetroCheckBox metroCheckBox7;

	private MetroCheckBox metroCheckBox8;

	private MetroCheckBox metroCheckBox9;

	private MetroCheckBox metroCheckBox4;

	private MetroCheckBox metroCheckBox5;

	private MetroCheckBox metroCheckBox6;

	private MetroCheckBox metroCheckBox72;

	private MetroCheckBox metroCheckBox69;

	private MetroCheckBox metroCheckBox63;

	private MetroCheckBox metroCheckBox60;

	private MetroCheckBox metroCheckBox52;

	private MetroCheckBox metroCheckBox53;

	private MetroCheckBox metroCheckBox54;

	private MetroCheckBox metroCheckBox49;

	private MetroCheckBox metroCheckBox50;

	private MetroCheckBox metroCheckBox51;

	private MetroCheckBox metroCheckBox46;

	private MetroCheckBox metroCheckBox47;

	private MetroCheckBox metroCheckBox48;

	private MetroComboBox metroComboBox1;

	private Label label3;

	private Panel panel1;

	private Label label2;

	private Panel panel2;

	private Panel panel4;

	private MetroCheckBox metroCheckBox57;

	private MetroCheckBox metroCheckBox87;

	private MetroCheckBox metroCheckBox86;

	private MetroCheckBox metroCheckBox85;

	private MetroCheckBox metroCheckBox84;

	private MetroCheckBox metroCheckBox83;

	private MetroCheckBox metroCheckBox81;

	private MetroCheckBox metroCheckBox80;

	private MetroCheckBox metroCheckBox79;

	private MetroCheckBox metroCheckBox78;

	private MetroCheckBox metroCheckBox77;

	private MetroCheckBox metroCheckBox76;

	private MetroCheckBox metroCheckBox75;

	private MetroCheckBox metroCheckBox74;

	private MetroCheckBox metroCheckBox73;

	private MetroCheckBox metroCheckBox94;

	private MetroCheckBox metroCheckBox95;

	private MetroCheckBox metroCheckBox96;

	private Button button1;

	public r_user_control()
	{
		InitializeComponent();
		bindcombo();
		((ListControl)metroComboBox1).SelectedIndex = 0;
	}

	private void bindcombo()
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
				((DbCommand)(object)val2).CommandText = "select * from r_users";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((ComboBox)metroComboBox1).Items.Add((object)((DbDataReader)(object)val3)[1].ToString());
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

	private void SelectUSERS()
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
				string commandText = "select id," + ((Control)metroComboBox1).Text + " from DB_Permission";
				((DbCommand)(object)val2).CommandText = commandText;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string text = ((DbDataReader)(object)val3)[0].ToString();
						string text2 = ((DbDataReader)(object)val3)[1].ToString();
						string[] array = text2.Split(new char[1] { '*' });
						switch (text)
						{
						case "1":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox73).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox73).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox1).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox1).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox2).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox2).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox3).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox3).Checked = false;
							}
							break;
						case "2":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox74).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox74).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox6).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox6).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox5).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox5).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox4).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox4).Checked = false;
							}
							break;
						case "3":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox75).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox75).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox9).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox9).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox8).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox8).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox7).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox7).Checked = false;
							}
							break;
						case "4":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox76).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox76).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox12).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox12).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox11).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox11).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox10).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox10).Checked = false;
							}
							break;
						case "5":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox77).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox77).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox15).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox15).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox14).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox14).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox13).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox13).Checked = false;
							}
							break;
						case "6":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox78).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox78).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox18).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox18).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox17).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox17).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox16).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox16).Checked = false;
							}
							break;
						case "7":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox79).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox79).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox21).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox21).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox20).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox20).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox19).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox19).Checked = false;
							}
							break;
						case "8":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox80).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox80).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox24).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox24).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox23).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox23).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox22).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox22).Checked = false;
							}
							break;
						case "9":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox81).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox81).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox27).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox27).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox26).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox26).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox25).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox25).Checked = false;
							}
							break;
						case "10":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox30).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox30).Checked = false;
							}
							break;
						case "11":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox83).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox83).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox33).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox33).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox32).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox32).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox31).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox31).Checked = false;
							}
							break;
						case "12":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox84).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox84).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox36).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox36).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox35).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox35).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox34).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox34).Checked = false;
							}
							break;
						case "13":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox85).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox85).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox39).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox39).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox38).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox38).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox37).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox37).Checked = false;
							}
							break;
						case "14":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox86).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox86).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox42).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox42).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox41).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox41).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox40).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox40).Checked = false;
							}
							break;
						case "15":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox87).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox87).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox45).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox45).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox44).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox44).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox43).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox43).Checked = false;
							}
							break;
						case "16":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox96).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox96).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox48).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox48).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox47).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox47).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox46).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox46).Checked = false;
							}
							break;
						case "17":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox95).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox95).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox51).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox51).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox50).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox50).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox49).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox49).Checked = false;
							}
							break;
						case "18":
							if (array[0] != "" && array[1] != "" && array[2] != "")
							{
								((CheckBox)metroCheckBox94).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox94).Checked = false;
							}
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox54).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox54).Checked = false;
							}
							if (array[1] != "")
							{
								((CheckBox)metroCheckBox53).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox53).Checked = false;
							}
							if (array[2] != "")
							{
								((CheckBox)metroCheckBox52).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox52).Checked = false;
							}
							break;
						case "19":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox57).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox57).Checked = false;
							}
							break;
						case "20":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox60).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox60).Checked = false;
							}
							break;
						case "21":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox63).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox63).Checked = false;
							}
							break;
						case "23":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox69).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox69).Checked = false;
							}
							break;
						case "24":
							if (array[0] != "")
							{
								((CheckBox)metroCheckBox72).Checked = true;
							}
							else
							{
								((CheckBox)metroCheckBox72).Checked = false;
							}
							break;
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

	private void r_user_control_Load(object sender, EventArgs e)
	{
	}

	private void metroCheckBox73_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox73).Checked)
		{
			MetroCheckBox obj = metroCheckBox1;
			MetroCheckBox obj2 = metroCheckBox2;
			bool flag = (((CheckBox)metroCheckBox3).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox1;
			MetroCheckBox obj4 = metroCheckBox2;
			bool flag = (((CheckBox)metroCheckBox3).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox74_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox74).Checked)
		{
			MetroCheckBox obj = metroCheckBox4;
			MetroCheckBox obj2 = metroCheckBox5;
			bool flag = (((CheckBox)metroCheckBox6).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox4;
			MetroCheckBox obj4 = metroCheckBox5;
			bool flag = (((CheckBox)metroCheckBox6).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox75_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox75).Checked)
		{
			MetroCheckBox obj = metroCheckBox7;
			MetroCheckBox obj2 = metroCheckBox8;
			bool flag = (((CheckBox)metroCheckBox9).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox7;
			MetroCheckBox obj4 = metroCheckBox8;
			bool flag = (((CheckBox)metroCheckBox9).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox76_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox76).Checked)
		{
			MetroCheckBox obj = metroCheckBox10;
			MetroCheckBox obj2 = metroCheckBox11;
			bool flag = (((CheckBox)metroCheckBox12).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox10;
			MetroCheckBox obj4 = metroCheckBox11;
			bool flag = (((CheckBox)metroCheckBox12).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox77_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox77).Checked)
		{
			MetroCheckBox obj = metroCheckBox13;
			MetroCheckBox obj2 = metroCheckBox14;
			bool flag = (((CheckBox)metroCheckBox15).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox13;
			MetroCheckBox obj4 = metroCheckBox14;
			bool flag = (((CheckBox)metroCheckBox15).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox78_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox78).Checked)
		{
			MetroCheckBox obj = metroCheckBox16;
			MetroCheckBox obj2 = metroCheckBox17;
			bool flag = (((CheckBox)metroCheckBox18).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox16;
			MetroCheckBox obj4 = metroCheckBox17;
			bool flag = (((CheckBox)metroCheckBox18).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox79_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox79).Checked)
		{
			MetroCheckBox obj = metroCheckBox19;
			MetroCheckBox obj2 = metroCheckBox20;
			bool flag = (((CheckBox)metroCheckBox21).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox19;
			MetroCheckBox obj4 = metroCheckBox20;
			bool flag = (((CheckBox)metroCheckBox21).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox80_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox80).Checked)
		{
			MetroCheckBox obj = metroCheckBox22;
			MetroCheckBox obj2 = metroCheckBox23;
			bool flag = (((CheckBox)metroCheckBox24).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox22;
			MetroCheckBox obj4 = metroCheckBox23;
			bool flag = (((CheckBox)metroCheckBox24).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox81_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox81).Checked)
		{
			MetroCheckBox obj = metroCheckBox25;
			MetroCheckBox obj2 = metroCheckBox26;
			bool flag = (((CheckBox)metroCheckBox27).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox25;
			MetroCheckBox obj4 = metroCheckBox26;
			bool flag = (((CheckBox)metroCheckBox27).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox83_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox83).Checked)
		{
			MetroCheckBox obj = metroCheckBox31;
			MetroCheckBox obj2 = metroCheckBox32;
			bool flag = (((CheckBox)metroCheckBox33).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox31;
			MetroCheckBox obj4 = metroCheckBox32;
			bool flag = (((CheckBox)metroCheckBox33).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox84_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox84).Checked)
		{
			MetroCheckBox obj = metroCheckBox34;
			MetroCheckBox obj2 = metroCheckBox35;
			bool flag = (((CheckBox)metroCheckBox36).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox34;
			MetroCheckBox obj4 = metroCheckBox35;
			bool flag = (((CheckBox)metroCheckBox36).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox85_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox85).Checked)
		{
			MetroCheckBox obj = metroCheckBox37;
			MetroCheckBox obj2 = metroCheckBox38;
			bool flag = (((CheckBox)metroCheckBox39).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox37;
			MetroCheckBox obj4 = metroCheckBox38;
			bool flag = (((CheckBox)metroCheckBox39).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox86_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox86).Checked)
		{
			MetroCheckBox obj = metroCheckBox40;
			MetroCheckBox obj2 = metroCheckBox41;
			bool flag = (((CheckBox)metroCheckBox42).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox40;
			MetroCheckBox obj4 = metroCheckBox41;
			bool flag = (((CheckBox)metroCheckBox42).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox87_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox87).Checked)
		{
			MetroCheckBox obj = metroCheckBox43;
			MetroCheckBox obj2 = metroCheckBox44;
			bool flag = (((CheckBox)metroCheckBox45).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox43;
			MetroCheckBox obj4 = metroCheckBox44;
			bool flag = (((CheckBox)metroCheckBox45).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox96_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox96).Checked)
		{
			MetroCheckBox obj = metroCheckBox46;
			MetroCheckBox obj2 = metroCheckBox47;
			bool flag = (((CheckBox)metroCheckBox48).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox46;
			MetroCheckBox obj4 = metroCheckBox47;
			bool flag = (((CheckBox)metroCheckBox48).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox95_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox95).Checked)
		{
			MetroCheckBox obj = metroCheckBox49;
			MetroCheckBox obj2 = metroCheckBox50;
			bool flag = (((CheckBox)metroCheckBox51).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox49;
			MetroCheckBox obj4 = metroCheckBox50;
			bool flag = (((CheckBox)metroCheckBox51).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void metroCheckBox94_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)metroCheckBox94).Checked)
		{
			MetroCheckBox obj = metroCheckBox52;
			MetroCheckBox obj2 = metroCheckBox53;
			bool flag = (((CheckBox)metroCheckBox54).Checked = true);
			flag = (((CheckBox)obj2).Checked = flag);
			((CheckBox)obj).Checked = flag;
		}
		else
		{
			MetroCheckBox obj3 = metroCheckBox52;
			MetroCheckBox obj4 = metroCheckBox53;
			bool flag = (((CheckBox)metroCheckBox54).Checked = false);
			flag = (((CheckBox)obj4).Checked = flag);
			((CheckBox)obj3).Checked = flag;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		UserLogin();
	}

	public void UserLogin()
	{
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		string customer_Management = Customer_management();
		SET_DB(customer_Management, "1");
		string customer_Management2 = Employee_management();
		SET_DB(customer_Management2, "2");
		string customer_Management3 = Vendor_management();
		SET_DB(customer_Management3, "3");
		string customer_Management4 = Tax_management();
		SET_DB(customer_Management4, "4");
		string customer_Management5 = Discount_management();
		SET_DB(customer_Management5, "5");
		string customer_Management6 = Delivery_Boy_management();
		SET_DB(customer_Management6, "6");
		string customer_Management7 = Order_Type_management();
		SET_DB(customer_Management7, "7");
		string customer_Management8 = Payment_management();
		SET_DB(customer_Management8, "8");
		string customer_Management9 = Bank_management();
		SET_DB(customer_Management9, "9");
		string customer_Management10 = Printer_management();
		SET_DB(customer_Management10, "10");
		string customer_Management11 = FoodCategory_management();
		SET_DB(customer_Management11, "11");
		string customer_Management12 = FoodSubcategory_management();
		SET_DB(customer_Management12, "12");
		string customer_Management13 = FoodDetails_management();
		SET_DB(customer_Management13, "13");
		string customer_Management14 = Table_management();
		SET_DB(customer_Management14, "14");
		string customer_Management15 = RMCategory_management();
		SET_DB(customer_Management15, "15");
		string customer_Management16 = RawMatrial();
		SET_DB(customer_Management16, "16");
		string customer_Management17 = Unit_Management();
		SET_DB(customer_Management17, "17");
		string customer_Management18 = Recipe_Management();
		SET_DB(customer_Management18, "18");
		string customer_Management19 = Stock_report();
		SET_DB(customer_Management19, "19");
		string customer_Management20 = Bill_report();
		SET_DB(customer_Management20, "20");
		string customer_Management21 = Sell_report();
		SET_DB(customer_Management21, "21");
		string customer_Management22 = Db_Backup();
		SET_DB(customer_Management22, "23");
		string customer_Management23 = Db_Restore();
		SET_DB(customer_Management23, "24");
		MetroMessageBox.Show((IWin32Window)(object)this, "Permission Set", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void SET_DB(string Customer_Management, string id)
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
				((DbCommand)(object)val2).CommandText = "update DB_Permission set " + ((Control)metroComboBox1).Text + "='" + Customer_Management + "' where id='" + id + "'";
				((DbCommand)(object)val2).ExecuteNonQuery();
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

	public string Customer_management()
	{
		string text = (((CheckBox)metroCheckBox1).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox2).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox3).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Employee_management()
	{
		string text = (((CheckBox)metroCheckBox6).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox5).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox4).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Vendor_management()
	{
		string text = (((CheckBox)metroCheckBox9).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox8).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox7).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Tax_management()
	{
		string text = (((CheckBox)metroCheckBox12).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox11).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox10).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Discount_management()
	{
		string text = (((CheckBox)metroCheckBox15).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox14).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox13).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Delivery_Boy_management()
	{
		string text = (((CheckBox)metroCheckBox18).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox17).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox16).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Order_Type_management()
	{
		string text = (((CheckBox)metroCheckBox21).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox20).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox19).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Payment_management()
	{
		string text = (((CheckBox)metroCheckBox24).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox23).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox22).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Bank_management()
	{
		string text = (((CheckBox)metroCheckBox27).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox26).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox25).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Printer_management()
	{
		string text = (((CheckBox)metroCheckBox30).Checked ? "View" : "");
		return text + "*";
	}

	public string FoodCategory_management()
	{
		string text = (((CheckBox)metroCheckBox33).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox32).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox31).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string FoodSubcategory_management()
	{
		string text = (((CheckBox)metroCheckBox36).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox35).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox34).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string FoodDetails_management()
	{
		string text = (((CheckBox)metroCheckBox39).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox38).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox37).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Table_management()
	{
		string text = (((CheckBox)metroCheckBox42).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox41).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox40).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string RMCategory_management()
	{
		string text = (((CheckBox)metroCheckBox45).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox44).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox43).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string RawMatrial()
	{
		string text = (((CheckBox)metroCheckBox48).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox47).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox46).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Unit_Management()
	{
		string text = (((CheckBox)metroCheckBox51).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox50).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox49).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Recipe_Management()
	{
		string text = (((CheckBox)metroCheckBox54).Checked ? "Insert" : "");
		string text2 = (((CheckBox)metroCheckBox53).Checked ? "Update" : "");
		string text3 = (((CheckBox)metroCheckBox52).Checked ? "Delete" : "");
		return text + "*" + text2 + "*" + text3;
	}

	public string Stock_report()
	{
		string text = (((CheckBox)metroCheckBox57).Checked ? "View" : "");
		return text + "*";
	}

	public string Bill_report()
	{
		string text = (((CheckBox)metroCheckBox60).Checked ? "View" : "");
		return text + "*";
	}

	public string Sell_report()
	{
		string text = (((CheckBox)metroCheckBox63).Checked ? "View" : "");
		return text + "*";
	}

	public string Db_Backup()
	{
		string text = (((CheckBox)metroCheckBox69).Checked ? "View" : "");
		return text + "*";
	}

	public string Db_Restore()
	{
		string text = (((CheckBox)metroCheckBox72).Checked ? "View" : "");
		return text + "*";
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		SelectUSERS();
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
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_3661: Unknown result type (might be due to invalid IL or missing references)
		//IL_366b: Expected O, but got Unknown
		//IL_36fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3707: Expected O, but got Unknown
		//IL_4443: Unknown result type (might be due to invalid IL or missing references)
		//IL_444d: Expected O, but got Unknown
		//IL_4932: Unknown result type (might be due to invalid IL or missing references)
		//IL_493c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_user_control));
		groupBox1 = new GroupBox();
		label3 = new Label();
		metroComboBox1 = new MetroComboBox();
		metroCheckBox63 = new MetroCheckBox();
		metroCheckBox60 = new MetroCheckBox();
		metroCheckBox57 = new MetroCheckBox();
		metroCheckBox52 = new MetroCheckBox();
		metroCheckBox53 = new MetroCheckBox();
		metroCheckBox54 = new MetroCheckBox();
		metroCheckBox49 = new MetroCheckBox();
		metroCheckBox50 = new MetroCheckBox();
		metroCheckBox51 = new MetroCheckBox();
		metroCheckBox46 = new MetroCheckBox();
		metroCheckBox47 = new MetroCheckBox();
		metroCheckBox48 = new MetroCheckBox();
		metroCheckBox43 = new MetroCheckBox();
		metroCheckBox44 = new MetroCheckBox();
		metroCheckBox45 = new MetroCheckBox();
		metroCheckBox40 = new MetroCheckBox();
		metroCheckBox41 = new MetroCheckBox();
		metroCheckBox42 = new MetroCheckBox();
		metroCheckBox37 = new MetroCheckBox();
		metroCheckBox38 = new MetroCheckBox();
		metroCheckBox39 = new MetroCheckBox();
		metroCheckBox34 = new MetroCheckBox();
		metroCheckBox35 = new MetroCheckBox();
		metroCheckBox36 = new MetroCheckBox();
		metroCheckBox31 = new MetroCheckBox();
		metroCheckBox32 = new MetroCheckBox();
		metroCheckBox33 = new MetroCheckBox();
		metroCheckBox30 = new MetroCheckBox();
		metroCheckBox25 = new MetroCheckBox();
		metroCheckBox26 = new MetroCheckBox();
		metroCheckBox27 = new MetroCheckBox();
		metroCheckBox22 = new MetroCheckBox();
		metroCheckBox23 = new MetroCheckBox();
		metroCheckBox24 = new MetroCheckBox();
		metroCheckBox19 = new MetroCheckBox();
		metroCheckBox20 = new MetroCheckBox();
		metroCheckBox21 = new MetroCheckBox();
		metroCheckBox16 = new MetroCheckBox();
		metroCheckBox17 = new MetroCheckBox();
		metroCheckBox18 = new MetroCheckBox();
		metroCheckBox13 = new MetroCheckBox();
		metroCheckBox14 = new MetroCheckBox();
		metroCheckBox15 = new MetroCheckBox();
		metroCheckBox10 = new MetroCheckBox();
		metroCheckBox11 = new MetroCheckBox();
		metroCheckBox12 = new MetroCheckBox();
		metroCheckBox7 = new MetroCheckBox();
		metroCheckBox8 = new MetroCheckBox();
		metroCheckBox9 = new MetroCheckBox();
		metroCheckBox4 = new MetroCheckBox();
		metroCheckBox5 = new MetroCheckBox();
		metroCheckBox6 = new MetroCheckBox();
		metroCheckBox3 = new MetroCheckBox();
		metroCheckBox2 = new MetroCheckBox();
		metroCheckBox1 = new MetroCheckBox();
		label28 = new Label();
		label27 = new Label();
		label26 = new Label();
		label22 = new Label();
		label21 = new Label();
		label19 = new Label();
		label18 = new Label();
		label17 = new Label();
		label16 = new Label();
		label15 = new Label();
		label14 = new Label();
		label13 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		panel1 = new Panel();
		label2 = new Label();
		label1 = new Label();
		panel2 = new Panel();
		metroCheckBox87 = new MetroCheckBox();
		metroCheckBox86 = new MetroCheckBox();
		metroCheckBox85 = new MetroCheckBox();
		metroCheckBox84 = new MetroCheckBox();
		metroCheckBox83 = new MetroCheckBox();
		metroCheckBox81 = new MetroCheckBox();
		metroCheckBox80 = new MetroCheckBox();
		metroCheckBox79 = new MetroCheckBox();
		metroCheckBox78 = new MetroCheckBox();
		metroCheckBox77 = new MetroCheckBox();
		metroCheckBox76 = new MetroCheckBox();
		metroCheckBox75 = new MetroCheckBox();
		metroCheckBox74 = new MetroCheckBox();
		metroCheckBox73 = new MetroCheckBox();
		label20 = new Label();
		panel4 = new Panel();
		button1 = new Button();
		metroCheckBox94 = new MetroCheckBox();
		metroCheckBox72 = new MetroCheckBox();
		metroCheckBox95 = new MetroCheckBox();
		metroCheckBox69 = new MetroCheckBox();
		metroCheckBox96 = new MetroCheckBox();
		label24 = new Label();
		label25 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Anchor = (AnchorStyles)15;
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)metroComboBox1);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox63);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox60);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox57);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox52);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox53);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox54);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox49);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox50);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox51);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox46);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox47);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox48);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox43);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox44);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox45);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox40);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox41);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox42);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox37);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox38);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox39);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox34);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox35);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox36);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox31);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox32);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox33);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox30);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox25);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox26);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox27);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox22);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox23);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox24);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox19);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox20);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox21);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox16);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox17);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox18);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox13);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox14);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox15);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox10);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox11);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox12);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox7);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox8);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox9);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox4);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox5);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox6);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox3);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox2);
		((Control)groupBox1).Controls.Add((Control)(object)metroCheckBox1);
		((Control)groupBox1).Controls.Add((Control)(object)label28);
		((Control)groupBox1).Controls.Add((Control)(object)label27);
		((Control)groupBox1).Controls.Add((Control)(object)label26);
		((Control)groupBox1).Controls.Add((Control)(object)label22);
		((Control)groupBox1).Controls.Add((Control)(object)label21);
		((Control)groupBox1).Controls.Add((Control)(object)label19);
		((Control)groupBox1).Controls.Add((Control)(object)label18);
		((Control)groupBox1).Controls.Add((Control)(object)label17);
		((Control)groupBox1).Controls.Add((Control)(object)label16);
		((Control)groupBox1).Controls.Add((Control)(object)label15);
		((Control)groupBox1).Controls.Add((Control)(object)label14);
		((Control)groupBox1).Controls.Add((Control)(object)label13);
		((Control)groupBox1).Controls.Add((Control)(object)label12);
		((Control)groupBox1).Controls.Add((Control)(object)label11);
		((Control)groupBox1).Controls.Add((Control)(object)label10);
		((Control)groupBox1).Controls.Add((Control)(object)label9);
		((Control)groupBox1).Controls.Add((Control)(object)label8);
		((Control)groupBox1).Controls.Add((Control)(object)label7);
		((Control)groupBox1).Controls.Add((Control)(object)label6);
		((Control)groupBox1).Controls.Add((Control)(object)label5);
		((Control)groupBox1).Controls.Add((Control)(object)panel1);
		((Control)groupBox1).Controls.Add((Control)(object)panel2);
		((Control)groupBox1).Controls.Add((Control)(object)panel4);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(23, 63);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(1053, 523);
		((Control)groupBox1).TabIndex = 0;
		groupBox1.TabStop = false;
		((Control)label3).AutoSize = true;
		((Control)label3).Location = new Point(144, 26);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(85, 18);
		((Control)label3).TabIndex = 102;
		((Control)label3).Text = "Select User";
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(306, 23);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select User";
		((Control)metroComboBox1).Size = new Size(237, 29);
		((Control)metroComboBox1).TabIndex = 101;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((Control)metroCheckBox63).AutoSize = true;
		metroCheckBox63.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox63).Location = new Point(722, 236);
		((Control)metroCheckBox63).Name = "metroCheckBox63";
		((Control)metroCheckBox63).Size = new Size(54, 19);
		metroCheckBox63.Style = (MetroColorStyle)8;
		((Control)metroCheckBox63).TabIndex = 88;
		((Control)metroCheckBox63).Text = "View";
		metroCheckBox63.UseSelectable = true;
		((Control)metroCheckBox60).AutoSize = true;
		metroCheckBox60.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox60).Location = new Point(722, 210);
		((Control)metroCheckBox60).Name = "metroCheckBox60";
		((Control)metroCheckBox60).Size = new Size(54, 19);
		metroCheckBox60.Style = (MetroColorStyle)8;
		((Control)metroCheckBox60).TabIndex = 85;
		((Control)metroCheckBox60).Text = "View";
		metroCheckBox60.UseSelectable = true;
		((Control)metroCheckBox57).AutoSize = true;
		metroCheckBox57.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox57).Location = new Point(722, 184);
		((Control)metroCheckBox57).Name = "metroCheckBox57";
		((Control)metroCheckBox57).Size = new Size(54, 19);
		metroCheckBox57.Style = (MetroColorStyle)8;
		((Control)metroCheckBox57).TabIndex = 82;
		((Control)metroCheckBox57).Text = "View";
		metroCheckBox57.UseSelectable = true;
		((Control)metroCheckBox52).AutoSize = true;
		metroCheckBox52.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox52).Location = new Point(889, 158);
		((Control)metroCheckBox52).Name = "metroCheckBox52";
		((Control)metroCheckBox52).Size = new Size(64, 19);
		metroCheckBox52.Style = (MetroColorStyle)8;
		((Control)metroCheckBox52).TabIndex = 81;
		((Control)metroCheckBox52).Text = "Delete";
		metroCheckBox52.UseSelectable = true;
		((Control)metroCheckBox53).AutoSize = true;
		metroCheckBox53.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox53).Location = new Point(803, 158);
		((Control)metroCheckBox53).Name = "metroCheckBox53";
		((Control)metroCheckBox53).Size = new Size(70, 19);
		metroCheckBox53.Style = (MetroColorStyle)8;
		((Control)metroCheckBox53).TabIndex = 80;
		((Control)metroCheckBox53).Text = "Update";
		metroCheckBox53.UseSelectable = true;
		((Control)metroCheckBox54).AutoSize = true;
		metroCheckBox54.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox54).Location = new Point(722, 158);
		((Control)metroCheckBox54).Name = "metroCheckBox54";
		((Control)metroCheckBox54).Size = new Size(60, 19);
		metroCheckBox54.Style = (MetroColorStyle)8;
		((Control)metroCheckBox54).TabIndex = 79;
		((Control)metroCheckBox54).Text = "Insert";
		metroCheckBox54.UseSelectable = true;
		((Control)metroCheckBox49).AutoSize = true;
		metroCheckBox49.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox49).Location = new Point(889, 132);
		((Control)metroCheckBox49).Name = "metroCheckBox49";
		((Control)metroCheckBox49).Size = new Size(64, 19);
		metroCheckBox49.Style = (MetroColorStyle)8;
		((Control)metroCheckBox49).TabIndex = 78;
		((Control)metroCheckBox49).Text = "Delete";
		metroCheckBox49.UseSelectable = true;
		((Control)metroCheckBox50).AutoSize = true;
		metroCheckBox50.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox50).Location = new Point(803, 132);
		((Control)metroCheckBox50).Name = "metroCheckBox50";
		((Control)metroCheckBox50).Size = new Size(70, 19);
		metroCheckBox50.Style = (MetroColorStyle)8;
		((Control)metroCheckBox50).TabIndex = 77;
		((Control)metroCheckBox50).Text = "Update";
		metroCheckBox50.UseSelectable = true;
		((Control)metroCheckBox51).AutoSize = true;
		metroCheckBox51.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox51).Location = new Point(722, 132);
		((Control)metroCheckBox51).Name = "metroCheckBox51";
		((Control)metroCheckBox51).Size = new Size(60, 19);
		metroCheckBox51.Style = (MetroColorStyle)8;
		((Control)metroCheckBox51).TabIndex = 76;
		((Control)metroCheckBox51).Text = "Insert";
		metroCheckBox51.UseSelectable = true;
		((Control)metroCheckBox46).AutoSize = true;
		metroCheckBox46.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox46).Location = new Point(889, 105);
		((Control)metroCheckBox46).Name = "metroCheckBox46";
		((Control)metroCheckBox46).Size = new Size(64, 19);
		metroCheckBox46.Style = (MetroColorStyle)8;
		((Control)metroCheckBox46).TabIndex = 75;
		((Control)metroCheckBox46).Text = "Delete";
		metroCheckBox46.UseSelectable = true;
		((Control)metroCheckBox47).AutoSize = true;
		metroCheckBox47.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox47).Location = new Point(803, 105);
		((Control)metroCheckBox47).Name = "metroCheckBox47";
		((Control)metroCheckBox47).Size = new Size(70, 19);
		metroCheckBox47.Style = (MetroColorStyle)8;
		((Control)metroCheckBox47).TabIndex = 74;
		((Control)metroCheckBox47).Text = "Update";
		metroCheckBox47.UseSelectable = true;
		((Control)metroCheckBox48).AutoSize = true;
		metroCheckBox48.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox48).Location = new Point(722, 105);
		((Control)metroCheckBox48).Name = "metroCheckBox48";
		((Control)metroCheckBox48).Size = new Size(60, 19);
		metroCheckBox48.Style = (MetroColorStyle)8;
		((Control)metroCheckBox48).TabIndex = 73;
		((Control)metroCheckBox48).Text = "Insert";
		metroCheckBox48.UseSelectable = true;
		((Control)metroCheckBox43).AutoSize = true;
		metroCheckBox43.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox43).Location = new Point(392, 470);
		((Control)metroCheckBox43).Name = "metroCheckBox43";
		((Control)metroCheckBox43).Size = new Size(64, 19);
		metroCheckBox43.Style = (MetroColorStyle)5;
		((Control)metroCheckBox43).TabIndex = 72;
		((Control)metroCheckBox43).Text = "Delete";
		metroCheckBox43.UseSelectable = true;
		((Control)metroCheckBox44).AutoSize = true;
		metroCheckBox44.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox44).Location = new Point(306, 470);
		((Control)metroCheckBox44).Name = "metroCheckBox44";
		((Control)metroCheckBox44).Size = new Size(70, 19);
		metroCheckBox44.Style = (MetroColorStyle)5;
		((Control)metroCheckBox44).TabIndex = 71;
		((Control)metroCheckBox44).Text = "Update";
		metroCheckBox44.UseSelectable = true;
		((Control)metroCheckBox45).AutoSize = true;
		metroCheckBox45.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox45).Location = new Point(225, 470);
		((Control)metroCheckBox45).Name = "metroCheckBox45";
		((Control)metroCheckBox45).Size = new Size(60, 19);
		metroCheckBox45.Style = (MetroColorStyle)5;
		((Control)metroCheckBox45).TabIndex = 70;
		((Control)metroCheckBox45).Text = "Insert";
		metroCheckBox45.UseSelectable = true;
		((Control)metroCheckBox40).AutoSize = true;
		metroCheckBox40.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox40).Location = new Point(392, 444);
		((Control)metroCheckBox40).Name = "metroCheckBox40";
		((Control)metroCheckBox40).Size = new Size(64, 19);
		metroCheckBox40.Style = (MetroColorStyle)5;
		((Control)metroCheckBox40).TabIndex = 69;
		((Control)metroCheckBox40).Text = "Delete";
		metroCheckBox40.UseSelectable = true;
		((Control)metroCheckBox41).AutoSize = true;
		metroCheckBox41.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox41).Location = new Point(306, 444);
		((Control)metroCheckBox41).Name = "metroCheckBox41";
		((Control)metroCheckBox41).Size = new Size(70, 19);
		metroCheckBox41.Style = (MetroColorStyle)5;
		((Control)metroCheckBox41).TabIndex = 68;
		((Control)metroCheckBox41).Text = "Update";
		metroCheckBox41.UseSelectable = true;
		((Control)metroCheckBox42).AutoSize = true;
		metroCheckBox42.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox42).Location = new Point(225, 444);
		((Control)metroCheckBox42).Name = "metroCheckBox42";
		((Control)metroCheckBox42).Size = new Size(60, 19);
		metroCheckBox42.Style = (MetroColorStyle)5;
		((Control)metroCheckBox42).TabIndex = 67;
		((Control)metroCheckBox42).Text = "Insert";
		metroCheckBox42.UseSelectable = true;
		((Control)metroCheckBox37).AutoSize = true;
		metroCheckBox37.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox37).Location = new Point(392, 418);
		((Control)metroCheckBox37).Name = "metroCheckBox37";
		((Control)metroCheckBox37).Size = new Size(64, 19);
		metroCheckBox37.Style = (MetroColorStyle)5;
		((Control)metroCheckBox37).TabIndex = 66;
		((Control)metroCheckBox37).Text = "Delete";
		metroCheckBox37.UseSelectable = true;
		((Control)metroCheckBox38).AutoSize = true;
		metroCheckBox38.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox38).Location = new Point(306, 418);
		((Control)metroCheckBox38).Name = "metroCheckBox38";
		((Control)metroCheckBox38).Size = new Size(70, 19);
		metroCheckBox38.Style = (MetroColorStyle)5;
		((Control)metroCheckBox38).TabIndex = 65;
		((Control)metroCheckBox38).Text = "Update";
		metroCheckBox38.UseSelectable = true;
		((Control)metroCheckBox39).AutoSize = true;
		metroCheckBox39.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox39).Location = new Point(225, 418);
		((Control)metroCheckBox39).Name = "metroCheckBox39";
		((Control)metroCheckBox39).Size = new Size(60, 19);
		metroCheckBox39.Style = (MetroColorStyle)5;
		((Control)metroCheckBox39).TabIndex = 64;
		((Control)metroCheckBox39).Text = "Insert";
		metroCheckBox39.UseSelectable = true;
		((Control)metroCheckBox34).AutoSize = true;
		metroCheckBox34.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox34).Location = new Point(392, 392);
		((Control)metroCheckBox34).Name = "metroCheckBox34";
		((Control)metroCheckBox34).Size = new Size(64, 19);
		metroCheckBox34.Style = (MetroColorStyle)5;
		((Control)metroCheckBox34).TabIndex = 63;
		((Control)metroCheckBox34).Text = "Delete";
		metroCheckBox34.UseSelectable = true;
		((Control)metroCheckBox35).AutoSize = true;
		metroCheckBox35.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox35).Location = new Point(306, 392);
		((Control)metroCheckBox35).Name = "metroCheckBox35";
		((Control)metroCheckBox35).Size = new Size(70, 19);
		metroCheckBox35.Style = (MetroColorStyle)5;
		((Control)metroCheckBox35).TabIndex = 62;
		((Control)metroCheckBox35).Text = "Update";
		metroCheckBox35.UseSelectable = true;
		((Control)metroCheckBox36).AutoSize = true;
		metroCheckBox36.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox36).Location = new Point(225, 392);
		((Control)metroCheckBox36).Name = "metroCheckBox36";
		((Control)metroCheckBox36).Size = new Size(60, 19);
		metroCheckBox36.Style = (MetroColorStyle)5;
		((Control)metroCheckBox36).TabIndex = 61;
		((Control)metroCheckBox36).Text = "Insert";
		metroCheckBox36.UseSelectable = true;
		((Control)metroCheckBox31).AutoSize = true;
		metroCheckBox31.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox31).Location = new Point(392, 366);
		((Control)metroCheckBox31).Name = "metroCheckBox31";
		((Control)metroCheckBox31).Size = new Size(64, 19);
		metroCheckBox31.Style = (MetroColorStyle)5;
		((Control)metroCheckBox31).TabIndex = 60;
		((Control)metroCheckBox31).Text = "Delete";
		metroCheckBox31.UseSelectable = true;
		((Control)metroCheckBox32).AutoSize = true;
		metroCheckBox32.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox32).Location = new Point(306, 366);
		((Control)metroCheckBox32).Name = "metroCheckBox32";
		((Control)metroCheckBox32).Size = new Size(70, 19);
		metroCheckBox32.Style = (MetroColorStyle)5;
		((Control)metroCheckBox32).TabIndex = 59;
		((Control)metroCheckBox32).Text = "Update";
		metroCheckBox32.UseSelectable = true;
		((Control)metroCheckBox33).AutoSize = true;
		metroCheckBox33.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox33).Location = new Point(225, 366);
		((Control)metroCheckBox33).Name = "metroCheckBox33";
		((Control)metroCheckBox33).Size = new Size(60, 19);
		metroCheckBox33.Style = (MetroColorStyle)5;
		((Control)metroCheckBox33).TabIndex = 58;
		((Control)metroCheckBox33).Text = "Insert";
		metroCheckBox33.UseSelectable = true;
		((Control)metroCheckBox30).AutoSize = true;
		metroCheckBox30.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox30).Location = new Point(225, 340);
		((Control)metroCheckBox30).Name = "metroCheckBox30";
		((Control)metroCheckBox30).Size = new Size(44, 19);
		metroCheckBox30.Style = (MetroColorStyle)5;
		((Control)metroCheckBox30).TabIndex = 55;
		((Control)metroCheckBox30).Text = "Set";
		metroCheckBox30.UseSelectable = true;
		((Control)metroCheckBox25).AutoSize = true;
		metroCheckBox25.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox25).Location = new Point(392, 314);
		((Control)metroCheckBox25).Name = "metroCheckBox25";
		((Control)metroCheckBox25).Size = new Size(64, 19);
		metroCheckBox25.Style = (MetroColorStyle)5;
		((Control)metroCheckBox25).TabIndex = 54;
		((Control)metroCheckBox25).Text = "Delete";
		metroCheckBox25.UseSelectable = true;
		((Control)metroCheckBox26).AutoSize = true;
		metroCheckBox26.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox26).Location = new Point(306, 314);
		((Control)metroCheckBox26).Name = "metroCheckBox26";
		((Control)metroCheckBox26).Size = new Size(70, 19);
		metroCheckBox26.Style = (MetroColorStyle)5;
		((Control)metroCheckBox26).TabIndex = 53;
		((Control)metroCheckBox26).Text = "Update";
		metroCheckBox26.UseSelectable = true;
		((Control)metroCheckBox27).AutoSize = true;
		metroCheckBox27.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox27).Location = new Point(225, 314);
		((Control)metroCheckBox27).Name = "metroCheckBox27";
		((Control)metroCheckBox27).Size = new Size(60, 19);
		metroCheckBox27.Style = (MetroColorStyle)5;
		((Control)metroCheckBox27).TabIndex = 52;
		((Control)metroCheckBox27).Text = "Insert";
		metroCheckBox27.UseSelectable = true;
		((Control)metroCheckBox22).AutoSize = true;
		metroCheckBox22.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox22).Location = new Point(392, 288);
		((Control)metroCheckBox22).Name = "metroCheckBox22";
		((Control)metroCheckBox22).Size = new Size(64, 19);
		metroCheckBox22.Style = (MetroColorStyle)5;
		((Control)metroCheckBox22).TabIndex = 51;
		((Control)metroCheckBox22).Text = "Delete";
		metroCheckBox22.UseSelectable = true;
		((Control)metroCheckBox23).AutoSize = true;
		metroCheckBox23.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox23).Location = new Point(306, 288);
		((Control)metroCheckBox23).Name = "metroCheckBox23";
		((Control)metroCheckBox23).Size = new Size(70, 19);
		metroCheckBox23.Style = (MetroColorStyle)5;
		((Control)metroCheckBox23).TabIndex = 50;
		((Control)metroCheckBox23).Text = "Update";
		metroCheckBox23.UseSelectable = true;
		((Control)metroCheckBox24).AutoSize = true;
		metroCheckBox24.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox24).Location = new Point(225, 288);
		((Control)metroCheckBox24).Name = "metroCheckBox24";
		((Control)metroCheckBox24).Size = new Size(60, 19);
		metroCheckBox24.Style = (MetroColorStyle)5;
		((Control)metroCheckBox24).TabIndex = 49;
		((Control)metroCheckBox24).Text = "Insert";
		metroCheckBox24.UseSelectable = true;
		((Control)metroCheckBox19).AutoSize = true;
		metroCheckBox19.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox19).Location = new Point(392, 262);
		((Control)metroCheckBox19).Name = "metroCheckBox19";
		((Control)metroCheckBox19).Size = new Size(64, 19);
		metroCheckBox19.Style = (MetroColorStyle)5;
		((Control)metroCheckBox19).TabIndex = 48;
		((Control)metroCheckBox19).Text = "Delete";
		metroCheckBox19.UseSelectable = true;
		((Control)metroCheckBox20).AutoSize = true;
		metroCheckBox20.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox20).Location = new Point(306, 262);
		((Control)metroCheckBox20).Name = "metroCheckBox20";
		((Control)metroCheckBox20).Size = new Size(70, 19);
		metroCheckBox20.Style = (MetroColorStyle)5;
		((Control)metroCheckBox20).TabIndex = 47;
		((Control)metroCheckBox20).Text = "Update";
		metroCheckBox20.UseSelectable = true;
		((Control)metroCheckBox21).AutoSize = true;
		metroCheckBox21.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox21).Location = new Point(225, 262);
		((Control)metroCheckBox21).Name = "metroCheckBox21";
		((Control)metroCheckBox21).Size = new Size(60, 19);
		metroCheckBox21.Style = (MetroColorStyle)5;
		((Control)metroCheckBox21).TabIndex = 46;
		((Control)metroCheckBox21).Text = "Insert";
		metroCheckBox21.UseSelectable = true;
		((Control)metroCheckBox16).AutoSize = true;
		metroCheckBox16.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox16).Location = new Point(392, 236);
		((Control)metroCheckBox16).Name = "metroCheckBox16";
		((Control)metroCheckBox16).Size = new Size(64, 19);
		metroCheckBox16.Style = (MetroColorStyle)5;
		((Control)metroCheckBox16).TabIndex = 45;
		((Control)metroCheckBox16).Text = "Delete";
		metroCheckBox16.UseSelectable = true;
		((Control)metroCheckBox17).AutoSize = true;
		metroCheckBox17.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox17).Location = new Point(306, 236);
		((Control)metroCheckBox17).Name = "metroCheckBox17";
		((Control)metroCheckBox17).Size = new Size(70, 19);
		metroCheckBox17.Style = (MetroColorStyle)5;
		((Control)metroCheckBox17).TabIndex = 44;
		((Control)metroCheckBox17).Text = "Update";
		metroCheckBox17.UseSelectable = true;
		((Control)metroCheckBox18).AutoSize = true;
		metroCheckBox18.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox18).Location = new Point(225, 236);
		((Control)metroCheckBox18).Name = "metroCheckBox18";
		((Control)metroCheckBox18).Size = new Size(60, 19);
		metroCheckBox18.Style = (MetroColorStyle)5;
		((Control)metroCheckBox18).TabIndex = 43;
		((Control)metroCheckBox18).Text = "Insert";
		metroCheckBox18.UseSelectable = true;
		((Control)metroCheckBox13).AutoSize = true;
		metroCheckBox13.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox13).Location = new Point(392, 210);
		((Control)metroCheckBox13).Name = "metroCheckBox13";
		((Control)metroCheckBox13).Size = new Size(64, 19);
		metroCheckBox13.Style = (MetroColorStyle)5;
		((Control)metroCheckBox13).TabIndex = 42;
		((Control)metroCheckBox13).Text = "Delete";
		metroCheckBox13.UseSelectable = true;
		((Control)metroCheckBox14).AutoSize = true;
		metroCheckBox14.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox14).Location = new Point(306, 210);
		((Control)metroCheckBox14).Name = "metroCheckBox14";
		((Control)metroCheckBox14).Size = new Size(70, 19);
		metroCheckBox14.Style = (MetroColorStyle)5;
		((Control)metroCheckBox14).TabIndex = 41;
		((Control)metroCheckBox14).Text = "Update";
		metroCheckBox14.UseSelectable = true;
		((Control)metroCheckBox15).AutoSize = true;
		metroCheckBox15.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox15).Location = new Point(225, 210);
		((Control)metroCheckBox15).Name = "metroCheckBox15";
		((Control)metroCheckBox15).Size = new Size(60, 19);
		metroCheckBox15.Style = (MetroColorStyle)5;
		((Control)metroCheckBox15).TabIndex = 40;
		((Control)metroCheckBox15).Text = "Insert";
		metroCheckBox15.UseSelectable = true;
		((Control)metroCheckBox10).AutoSize = true;
		metroCheckBox10.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox10).Location = new Point(392, 183);
		((Control)metroCheckBox10).Name = "metroCheckBox10";
		((Control)metroCheckBox10).Size = new Size(64, 19);
		metroCheckBox10.Style = (MetroColorStyle)5;
		((Control)metroCheckBox10).TabIndex = 39;
		((Control)metroCheckBox10).Text = "Delete";
		metroCheckBox10.UseSelectable = true;
		((Control)metroCheckBox11).AutoSize = true;
		metroCheckBox11.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox11).Location = new Point(306, 183);
		((Control)metroCheckBox11).Name = "metroCheckBox11";
		((Control)metroCheckBox11).Size = new Size(70, 19);
		metroCheckBox11.Style = (MetroColorStyle)5;
		((Control)metroCheckBox11).TabIndex = 38;
		((Control)metroCheckBox11).Text = "Update";
		metroCheckBox11.UseSelectable = true;
		((Control)metroCheckBox12).AutoSize = true;
		metroCheckBox12.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox12).Location = new Point(225, 183);
		((Control)metroCheckBox12).Name = "metroCheckBox12";
		((Control)metroCheckBox12).Size = new Size(60, 19);
		metroCheckBox12.Style = (MetroColorStyle)5;
		((Control)metroCheckBox12).TabIndex = 37;
		((Control)metroCheckBox12).Text = "Insert";
		metroCheckBox12.UseSelectable = true;
		((Control)metroCheckBox7).AutoSize = true;
		metroCheckBox7.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox7).Location = new Point(392, 158);
		((Control)metroCheckBox7).Name = "metroCheckBox7";
		((Control)metroCheckBox7).Size = new Size(64, 19);
		metroCheckBox7.Style = (MetroColorStyle)5;
		((Control)metroCheckBox7).TabIndex = 36;
		((Control)metroCheckBox7).Text = "Delete";
		metroCheckBox7.UseSelectable = true;
		((Control)metroCheckBox8).AutoSize = true;
		metroCheckBox8.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox8).Location = new Point(306, 158);
		((Control)metroCheckBox8).Name = "metroCheckBox8";
		((Control)metroCheckBox8).Size = new Size(70, 19);
		metroCheckBox8.Style = (MetroColorStyle)5;
		((Control)metroCheckBox8).TabIndex = 35;
		((Control)metroCheckBox8).Text = "Update";
		metroCheckBox8.UseSelectable = true;
		((Control)metroCheckBox9).AutoSize = true;
		metroCheckBox9.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox9).Location = new Point(225, 158);
		((Control)metroCheckBox9).Name = "metroCheckBox9";
		((Control)metroCheckBox9).Size = new Size(60, 19);
		metroCheckBox9.Style = (MetroColorStyle)5;
		((Control)metroCheckBox9).TabIndex = 34;
		((Control)metroCheckBox9).Text = "Insert";
		metroCheckBox9.UseSelectable = true;
		((Control)metroCheckBox4).AutoSize = true;
		metroCheckBox4.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox4).Location = new Point(392, 132);
		((Control)metroCheckBox4).Name = "metroCheckBox4";
		((Control)metroCheckBox4).Size = new Size(64, 19);
		metroCheckBox4.Style = (MetroColorStyle)5;
		((Control)metroCheckBox4).TabIndex = 33;
		((Control)metroCheckBox4).Text = "Delete";
		metroCheckBox4.UseSelectable = true;
		((Control)metroCheckBox5).AutoSize = true;
		metroCheckBox5.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox5).Location = new Point(306, 132);
		((Control)metroCheckBox5).Name = "metroCheckBox5";
		((Control)metroCheckBox5).Size = new Size(70, 19);
		metroCheckBox5.Style = (MetroColorStyle)5;
		((Control)metroCheckBox5).TabIndex = 32;
		((Control)metroCheckBox5).Text = "Update";
		metroCheckBox5.UseSelectable = true;
		((Control)metroCheckBox6).AutoSize = true;
		metroCheckBox6.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox6).Location = new Point(225, 132);
		((Control)metroCheckBox6).Name = "metroCheckBox6";
		((Control)metroCheckBox6).Size = new Size(60, 19);
		metroCheckBox6.Style = (MetroColorStyle)5;
		((Control)metroCheckBox6).TabIndex = 31;
		((Control)metroCheckBox6).Text = "Insert";
		metroCheckBox6.UseSelectable = true;
		((Control)metroCheckBox3).AutoSize = true;
		metroCheckBox3.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox3).Location = new Point(392, 105);
		((Control)metroCheckBox3).Name = "metroCheckBox3";
		((Control)metroCheckBox3).Size = new Size(64, 19);
		metroCheckBox3.Style = (MetroColorStyle)5;
		((Control)metroCheckBox3).TabIndex = 28;
		((Control)metroCheckBox3).Text = "Delete";
		metroCheckBox3.UseSelectable = true;
		((Control)metroCheckBox2).AutoSize = true;
		metroCheckBox2.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox2).Location = new Point(306, 105);
		((Control)metroCheckBox2).Name = "metroCheckBox2";
		((Control)metroCheckBox2).Size = new Size(70, 19);
		metroCheckBox2.Style = (MetroColorStyle)5;
		((Control)metroCheckBox2).TabIndex = 27;
		((Control)metroCheckBox2).Text = "Update";
		metroCheckBox2.UseSelectable = true;
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(225, 105);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(60, 19);
		metroCheckBox1.Style = (MetroColorStyle)5;
		((Control)metroCheckBox1).TabIndex = 26;
		((Control)metroCheckBox1).Text = "Insert";
		metroCheckBox1.UseSelectable = true;
		((Control)label28).AutoSize = true;
		((Control)label28).Location = new Point(613, 236);
		((Control)label28).Name = "label28";
		((Control)label28).Size = new Size(81, 18);
		((Control)label28).TabIndex = 25;
		((Control)label28).Text = "Sell Report";
		((Control)label27).AutoSize = true;
		((Control)label27).Location = new Point(598, 184);
		((Control)label27).Name = "label27";
		((Control)label27).Size = new Size(96, 18);
		((Control)label27).TabIndex = 24;
		((Control)label27).Text = "Stock Report";
		((Control)label26).AutoSize = true;
		((Control)label26).Location = new Point(618, 210);
		((Control)label26).Name = "label26";
		((Control)label26).Size = new Size(76, 18);
		((Control)label26).TabIndex = 23;
		((Control)label26).Text = "Bill Report";
		((Control)label22).AutoSize = true;
		((Control)label22).Location = new Point(640, 158);
		((Control)label22).Name = "label22";
		((Control)label22).Size = new Size(54, 18);
		((Control)label22).TabIndex = 19;
		((Control)label22).Text = "Recipe";
		((Control)label21).AutoSize = true;
		((Control)label21).Location = new Point(570, 132);
		((Control)label21).Name = "label21";
		((Control)label21).Size = new Size(124, 18);
		((Control)label21).TabIndex = 18;
		((Control)label21).Text = "Unit Management";
		((Control)label19).AutoSize = true;
		((Control)label19).Location = new Point(600, 106);
		((Control)label19).Name = "label19";
		((Control)label19).Size = new Size(94, 18);
		((Control)label19).TabIndex = 16;
		((Control)label19).Text = "Raw Material";
		((Control)label18).AutoSize = true;
		((Control)label18).Location = new Point(85, 470);
		((Control)label18).Name = "label18";
		((Control)label18).Size = new Size(125, 18);
		((Control)label18).TabIndex = 15;
		((Control)label18).Text = "Raw Material Cat.";
		((Control)label17).AutoSize = true;
		((Control)label17).Location = new Point(118, 418);
		((Control)label17).Name = "label17";
		((Control)label17).Size = new Size(92, 18);
		((Control)label17).TabIndex = 14;
		((Control)label17).Text = "Food Details";
		((Control)label16).AutoSize = true;
		((Control)label16).Location = new Point(80, 392);
		((Control)label16).Name = "label16";
		((Control)label16).Size = new Size(130, 18);
		((Control)label16).TabIndex = 13;
		((Control)label16).Text = "Food Subcategory";
		((Control)label15).AutoSize = true;
		((Control)label15).Location = new Point(103, 366);
		((Control)label15).Name = "label15";
		((Control)label15).Size = new Size(107, 18);
		((Control)label15).TabIndex = 12;
		((Control)label15).Text = "Food Category";
		((Control)label14).AutoSize = true;
		((Control)label14).Location = new Point(69, 340);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(141, 18);
		((Control)label14).TabIndex = 11;
		((Control)label14).Text = "Printer Management";
		((Control)label13).AutoSize = true;
		((Control)label13).Location = new Point(119, 314);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(91, 18);
		((Control)label13).TabIndex = 10;
		((Control)label13).Text = "Bank Details";
		((Control)label12).AutoSize = true;
		((Control)label12).Location = new Point(102, 288);
		((Control)label12).Name = "label12";
		((Control)label12).Size = new Size(108, 18);
		((Control)label12).TabIndex = 9;
		((Control)label12).Text = "Payment Mode";
		((Control)label11).AutoSize = true;
		((Control)label11).Location = new Point(128, 262);
		((Control)label11).Name = "label11";
		((Control)label11).Size = new Size(82, 18);
		((Control)label11).TabIndex = 8;
		((Control)label11).Text = "Order Type";
		((Control)label10).AutoSize = true;
		((Control)label10).Location = new Point(26, 236);
		((Control)label10).Name = "label10";
		((Control)label10).Size = new Size(184, 18);
		((Control)label10).TabIndex = 7;
		((Control)label10).Text = "Delivery Boy  Management";
		((Control)label9).AutoSize = true;
		((Control)label9).Location = new Point(53, 210);
		((Control)label9).Name = "label9";
		((Control)label9).Size = new Size(157, 18);
		((Control)label9).TabIndex = 6;
		((Control)label9).Text = "Discount Management";
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(88, 184);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(122, 18);
		((Control)label8).TabIndex = 5;
		((Control)label8).Text = "Tax Management";
		((Control)label7).AutoSize = true;
		((Control)label7).Location = new Point(65, 158);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(145, 18);
		((Control)label7).TabIndex = 4;
		((Control)label7).Text = "Vendor Management";
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(46, 132);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(164, 18);
		((Control)label6).TabIndex = 3;
		((Control)label6).Text = "Employee Management";
		((Control)label5).AutoSize = true;
		((Control)label5).Location = new Point(46, 106);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(164, 18);
		((Control)label5).TabIndex = 2;
		((Control)label5).Text = "Customer Management";
		((Control)panel1).BackColor = Color.SeaGreen;
		((Control)panel1).Controls.Add((Control)(object)label2);
		((Control)panel1).Controls.Add((Control)(object)label1);
		((Control)panel1).Location = new Point(22, 63);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(507, 40);
		((Control)panel1).TabIndex = 105;
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label2).ForeColor = Color.White;
		((Control)label2).Location = new Point(199, 10);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(143, 20);
		((Control)label2).TabIndex = 30;
		((Control)label2).Text = "Database Action";
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = Color.White;
		((Control)label1).Location = new Point(13, 10);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(168, 20);
		((Control)label1).TabIndex = 29;
		((Control)label1).Text = "Opeational Window ";
		panel2.BorderStyle = (BorderStyle)1;
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox87);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox86);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox85);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox84);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox83);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox81);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox80);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox79);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox78);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox77);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox76);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox75);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox74);
		((Control)panel2).Controls.Add((Control)(object)metroCheckBox73);
		((Control)panel2).Controls.Add((Control)(object)label20);
		((Control)panel2).Location = new Point(22, 101);
		((Control)panel2).Name = "panel2";
		((Control)panel2).Size = new Size(507, 402);
		((Control)panel2).TabIndex = 106;
		((Control)metroCheckBox87).AutoSize = true;
		metroCheckBox87.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox87).Location = new Point(442, 368);
		((Control)metroCheckBox87).Name = "metroCheckBox87";
		((Control)metroCheckBox87).Size = new Size(48, 19);
		metroCheckBox87.Style = (MetroColorStyle)5;
		((Control)metroCheckBox87).TabIndex = 122;
		((Control)metroCheckBox87).Text = "ALL";
		metroCheckBox87.UseSelectable = true;
		((CheckBox)metroCheckBox87).CheckedChanged += metroCheckBox87_CheckedChanged;
		((Control)metroCheckBox86).AutoSize = true;
		metroCheckBox86.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox86).Location = new Point(442, 342);
		((Control)metroCheckBox86).Name = "metroCheckBox86";
		((Control)metroCheckBox86).Size = new Size(48, 19);
		metroCheckBox86.Style = (MetroColorStyle)5;
		((Control)metroCheckBox86).TabIndex = 121;
		((Control)metroCheckBox86).Text = "ALL";
		metroCheckBox86.UseSelectable = true;
		((CheckBox)metroCheckBox86).CheckedChanged += metroCheckBox86_CheckedChanged;
		((Control)metroCheckBox85).AutoSize = true;
		metroCheckBox85.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox85).Location = new Point(442, 316);
		((Control)metroCheckBox85).Name = "metroCheckBox85";
		((Control)metroCheckBox85).Size = new Size(48, 19);
		metroCheckBox85.Style = (MetroColorStyle)5;
		((Control)metroCheckBox85).TabIndex = 120;
		((Control)metroCheckBox85).Text = "ALL";
		metroCheckBox85.UseSelectable = true;
		((CheckBox)metroCheckBox85).CheckedChanged += metroCheckBox85_CheckedChanged;
		((Control)metroCheckBox84).AutoSize = true;
		metroCheckBox84.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox84).Location = new Point(442, 290);
		((Control)metroCheckBox84).Name = "metroCheckBox84";
		((Control)metroCheckBox84).Size = new Size(48, 19);
		metroCheckBox84.Style = (MetroColorStyle)5;
		((Control)metroCheckBox84).TabIndex = 119;
		((Control)metroCheckBox84).Text = "ALL";
		metroCheckBox84.UseSelectable = true;
		((CheckBox)metroCheckBox84).CheckedChanged += metroCheckBox84_CheckedChanged;
		((Control)metroCheckBox83).AutoSize = true;
		metroCheckBox83.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox83).Location = new Point(442, 264);
		((Control)metroCheckBox83).Name = "metroCheckBox83";
		((Control)metroCheckBox83).Size = new Size(48, 19);
		metroCheckBox83.Style = (MetroColorStyle)5;
		((Control)metroCheckBox83).TabIndex = 118;
		((Control)metroCheckBox83).Text = "ALL";
		metroCheckBox83.UseSelectable = true;
		((CheckBox)metroCheckBox83).CheckedChanged += metroCheckBox83_CheckedChanged;
		((Control)metroCheckBox81).AutoSize = true;
		metroCheckBox81.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox81).Location = new Point(442, 212);
		((Control)metroCheckBox81).Name = "metroCheckBox81";
		((Control)metroCheckBox81).Size = new Size(48, 19);
		metroCheckBox81.Style = (MetroColorStyle)5;
		((Control)metroCheckBox81).TabIndex = 116;
		((Control)metroCheckBox81).Text = "ALL";
		metroCheckBox81.UseSelectable = true;
		((CheckBox)metroCheckBox81).CheckedChanged += metroCheckBox81_CheckedChanged;
		((Control)metroCheckBox80).AutoSize = true;
		metroCheckBox80.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox80).Location = new Point(442, 186);
		((Control)metroCheckBox80).Name = "metroCheckBox80";
		((Control)metroCheckBox80).Size = new Size(48, 19);
		metroCheckBox80.Style = (MetroColorStyle)5;
		((Control)metroCheckBox80).TabIndex = 115;
		((Control)metroCheckBox80).Text = "ALL";
		metroCheckBox80.UseSelectable = true;
		((CheckBox)metroCheckBox80).CheckedChanged += metroCheckBox80_CheckedChanged;
		((Control)metroCheckBox79).AutoSize = true;
		metroCheckBox79.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox79).Location = new Point(442, 160);
		((Control)metroCheckBox79).Name = "metroCheckBox79";
		((Control)metroCheckBox79).Size = new Size(48, 19);
		metroCheckBox79.Style = (MetroColorStyle)5;
		((Control)metroCheckBox79).TabIndex = 114;
		((Control)metroCheckBox79).Text = "ALL";
		metroCheckBox79.UseSelectable = true;
		((CheckBox)metroCheckBox79).CheckedChanged += metroCheckBox79_CheckedChanged;
		((Control)metroCheckBox78).AutoSize = true;
		metroCheckBox78.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox78).Location = new Point(442, 134);
		((Control)metroCheckBox78).Name = "metroCheckBox78";
		((Control)metroCheckBox78).Size = new Size(48, 19);
		metroCheckBox78.Style = (MetroColorStyle)5;
		((Control)metroCheckBox78).TabIndex = 113;
		((Control)metroCheckBox78).Text = "ALL";
		metroCheckBox78.UseSelectable = true;
		((CheckBox)metroCheckBox78).CheckedChanged += metroCheckBox78_CheckedChanged;
		((Control)metroCheckBox77).AutoSize = true;
		metroCheckBox77.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox77).Location = new Point(442, 108);
		((Control)metroCheckBox77).Name = "metroCheckBox77";
		((Control)metroCheckBox77).Size = new Size(48, 19);
		metroCheckBox77.Style = (MetroColorStyle)5;
		((Control)metroCheckBox77).TabIndex = 112;
		((Control)metroCheckBox77).Text = "ALL";
		metroCheckBox77.UseSelectable = true;
		((CheckBox)metroCheckBox77).CheckedChanged += metroCheckBox77_CheckedChanged;
		((Control)metroCheckBox76).AutoSize = true;
		metroCheckBox76.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox76).Location = new Point(442, 82);
		((Control)metroCheckBox76).Name = "metroCheckBox76";
		((Control)metroCheckBox76).Size = new Size(48, 19);
		metroCheckBox76.Style = (MetroColorStyle)5;
		((Control)metroCheckBox76).TabIndex = 111;
		((Control)metroCheckBox76).Text = "ALL";
		metroCheckBox76.UseSelectable = true;
		((CheckBox)metroCheckBox76).CheckedChanged += metroCheckBox76_CheckedChanged;
		((Control)metroCheckBox75).AutoSize = true;
		metroCheckBox75.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox75).Location = new Point(442, 56);
		((Control)metroCheckBox75).Name = "metroCheckBox75";
		((Control)metroCheckBox75).Size = new Size(48, 19);
		metroCheckBox75.Style = (MetroColorStyle)5;
		((Control)metroCheckBox75).TabIndex = 110;
		((Control)metroCheckBox75).Text = "ALL";
		metroCheckBox75.UseSelectable = true;
		((CheckBox)metroCheckBox75).CheckedChanged += metroCheckBox75_CheckedChanged;
		((Control)metroCheckBox74).AutoSize = true;
		metroCheckBox74.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox74).Location = new Point(442, 30);
		((Control)metroCheckBox74).Name = "metroCheckBox74";
		((Control)metroCheckBox74).Size = new Size(48, 19);
		metroCheckBox74.Style = (MetroColorStyle)5;
		((Control)metroCheckBox74).TabIndex = 109;
		((Control)metroCheckBox74).Text = "ALL";
		metroCheckBox74.UseSelectable = true;
		((CheckBox)metroCheckBox74).CheckedChanged += metroCheckBox74_CheckedChanged;
		((Control)metroCheckBox73).AutoSize = true;
		metroCheckBox73.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox73).Location = new Point(442, 4);
		((Control)metroCheckBox73).Name = "metroCheckBox73";
		((Control)metroCheckBox73).Size = new Size(48, 19);
		metroCheckBox73.Style = (MetroColorStyle)5;
		((Control)metroCheckBox73).TabIndex = 108;
		((Control)metroCheckBox73).Text = "ALL";
		metroCheckBox73.UseSelectable = true;
		((CheckBox)metroCheckBox73).CheckedChanged += metroCheckBox73_CheckedChanged;
		((Control)label20).AutoSize = true;
		((Control)label20).Location = new Point(45, 343);
		((Control)label20).Name = "label20";
		((Control)label20).Size = new Size(142, 18);
		((Control)label20).TabIndex = 17;
		((Control)label20).Text = "Table Managemenet";
		panel4.BorderStyle = (BorderStyle)1;
		((Control)panel4).Controls.Add((Control)(object)button1);
		((Control)panel4).Controls.Add((Control)(object)metroCheckBox94);
		((Control)panel4).Controls.Add((Control)(object)metroCheckBox72);
		((Control)panel4).Controls.Add((Control)(object)metroCheckBox95);
		((Control)panel4).Controls.Add((Control)(object)metroCheckBox69);
		((Control)panel4).Controls.Add((Control)(object)metroCheckBox96);
		((Control)panel4).Controls.Add((Control)(object)label24);
		((Control)panel4).Controls.Add((Control)(object)label25);
		((Control)panel4).Location = new Point(550, 101);
		((Control)panel4).Name = "panel4";
		((Control)panel4).Size = new Size(490, 402);
		((Control)panel4).TabIndex = 107;
		((Control)button1).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(171, 226);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(179, 42);
		((Control)button1).TabIndex = 126;
		((Control)button1).Text = "Update";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)metroCheckBox94).AutoSize = true;
		metroCheckBox94.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox94).Location = new Point(423, 56);
		((Control)metroCheckBox94).Name = "metroCheckBox94";
		((Control)metroCheckBox94).Size = new Size(48, 19);
		metroCheckBox94.Style = (MetroColorStyle)8;
		((Control)metroCheckBox94).TabIndex = 119;
		((Control)metroCheckBox94).Text = "ALL";
		metroCheckBox94.UseSelectable = true;
		((CheckBox)metroCheckBox94).CheckedChanged += metroCheckBox94_CheckedChanged;
		((Control)metroCheckBox72).AutoSize = true;
		metroCheckBox72.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox72).Location = new Point(171, 186);
		((Control)metroCheckBox72).Name = "metroCheckBox72";
		((Control)metroCheckBox72).Size = new Size(71, 19);
		metroCheckBox72.Style = (MetroColorStyle)8;
		((Control)metroCheckBox72).TabIndex = 97;
		((Control)metroCheckBox72).Text = "Restore";
		metroCheckBox72.UseSelectable = true;
		((Control)metroCheckBox95).AutoSize = true;
		metroCheckBox95.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox95).Location = new Point(423, 30);
		((Control)metroCheckBox95).Name = "metroCheckBox95";
		((Control)metroCheckBox95).Size = new Size(48, 19);
		metroCheckBox95.Style = (MetroColorStyle)8;
		((Control)metroCheckBox95).TabIndex = 118;
		((Control)metroCheckBox95).Text = "ALL";
		metroCheckBox95.UseSelectable = true;
		((CheckBox)metroCheckBox95).CheckedChanged += metroCheckBox95_CheckedChanged;
		((Control)metroCheckBox69).AutoSize = true;
		metroCheckBox69.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox69).Location = new Point(171, 161);
		((Control)metroCheckBox69).Name = "metroCheckBox69";
		((Control)metroCheckBox69).Size = new Size(69, 19);
		metroCheckBox69.Style = (MetroColorStyle)8;
		((Control)metroCheckBox69).TabIndex = 94;
		((Control)metroCheckBox69).Text = "Backup";
		metroCheckBox69.UseSelectable = true;
		((Control)metroCheckBox96).AutoSize = true;
		metroCheckBox96.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox96).Location = new Point(423, 4);
		((Control)metroCheckBox96).Name = "metroCheckBox96";
		((Control)metroCheckBox96).Size = new Size(48, 19);
		metroCheckBox96.Style = (MetroColorStyle)8;
		((Control)metroCheckBox96).TabIndex = 117;
		((Control)metroCheckBox96).Text = "ALL";
		metroCheckBox96.UseSelectable = true;
		((CheckBox)metroCheckBox96).CheckedChanged += metroCheckBox96_CheckedChanged;
		((Control)label24).AutoSize = true;
		((Control)label24).Location = new Point(18, 161);
		((Control)label24).Name = "label24";
		((Control)label24).Size = new Size(125, 18);
		((Control)label24).TabIndex = 21;
		((Control)label24).Text = "Backup Database";
		((Control)label25).AutoSize = true;
		((Control)label25).Location = new Point(15, 187);
		((Control)label25).Name = "label25";
		((Control)label25).Size = new Size(128, 18);
		((Control)label25).TabIndex = 22;
		((Control)label25).Text = "Restore Database";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1099, 609);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "r_user_control";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "User Operation Permissions";
		((Form)this).Load += r_user_control_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
