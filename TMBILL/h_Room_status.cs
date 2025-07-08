using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class h_Room_status : MetroForm
{
	private string ButtonGlobalId = "";

	private IContainer components = null;

	private FlowLayoutPanel flowLayoutPanel1;

	private MetroDateTime metroDateTime1;

	private FlowLayoutPanel flowLayoutPanel2;

	private Panel panel1;

	private Panel panel6;

	private Label label6;

	private Panel panel2;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem checkInToolStripMenuItem;

	private ToolStripMenuItem checkOutToolStripMenuItem;

	private ToolStripMenuItem foodToolStripMenuItem;

	private ToolStripMenuItem billPrintToolStripMenuItem;

	private Label label1;

	private Label label2;

	public h_Room_status()
	{
		InitializeComponent();
		BindAllColors();
		LoadAllColors();
	}

	private void LoadAllColors()
	{
	}

	private void BindAllColors()
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
				((DbCommand)(object)val2).CommandText = "select * from h_room_color";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						string text = ((DbDataReader)(object)val3)[2].ToString();
						string[] array = text.Split(new char[1] { '*' });
						if (array.Length > 1)
						{
							switch (((DbDataReader)(object)val3)[1].ToString())
							{
							case "Avaliable":
								((Control)panel1).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
								break;
							case "Occupied":
								((Control)panel2).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
								break;
							case "Online Booked":
								((Control)panel6).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
								break;
							}
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

	private string SetButtoncolor(string status)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string result = "";
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select * from h_room_color where status='" + status + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						result = ((DbDataReader)(object)val3)[2].ToString();
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
		return result;
	}

	private void h_CheckIn_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
		BindRooms();
	}

	private void SetColor(string roomid, string status)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)flowLayoutPanel1).Controls)
		{
			Control val = item;
			Button val2 = (Button)val;
			if (((Control)val2).Name == roomid)
			{
				string text = SetButtoncolor(status);
				string[] array = text.Split(new char[1] { '*' });
				if (array.Length > 1)
				{
					((Control)val2).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
				}
			}
		}
	}

	private void BindRooms()
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
				((DbCommand)(object)val2).CommandText = "select * from room";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						Button val4 = AddButton(((DbDataReader)(object)val3)[0].ToString(), ((DbDataReader)(object)val3)[1].ToString(), ((DbDataReader)(object)val3)[2].ToString(), ((DbDataReader)(object)val3)[3].ToString(), ((DbDataReader)(object)val3)[4].ToString());
						((Control)val4).Click += buttonclick;
						((Control)flowLayoutPanel1).Controls.Add((Control)(object)val4);
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

	private void buttonclick(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		Button val = (Button)sender;
		ButtonGlobalId = ((Control)val).Name;
		Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
		((ToolStripDropDown)contextMenuStrip1).Show(point);
	}

	private Button AddButton(string i, string name, string type, string description, string status)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		Button val = new Button();
		SqlConnection val2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val3 = new SqlCommand();
			try
			{
				val3.Connection = val2;
				((DbConnection)(object)val2).Open();
				((DbCommand)(object)val3).CommandText = "select * from h_room_color where Status='Avaliable'";
				SqlDataReader val4 = val3.ExecuteReader();
				if (((DbDataReader)(object)val4).HasRows)
				{
					while (((DbDataReader)(object)val4).Read())
					{
						string text = ((DbDataReader)(object)val4)[2].ToString();
						string[] array = text.Split(new char[1] { '*' });
						if (array.Length > 1)
						{
							((Control)val).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
						}
						else
						{
							((Control)val).BackColor = Color.FromArgb(0, 174, 219);
						}
					}
				}
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
		((ButtonBase)val).FlatStyle = (FlatStyle)0;
		((Control)val).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)val).ForeColor = Color.White;
		((Control)val).Name = i.ToString();
		((Control)val).Size = new Size(190, 70);
		((Control)val).Text = name + "\n" + type;
		ToolTip val5 = new ToolTip();
		val5.AutoPopDelay = 2000;
		val5.InitialDelay = 0;
		val5.ReshowDelay = 500;
		val5.ShowAlways = true;
		val5.SetToolTip((Control)(object)val, description);
		((ButtonBase)val).UseVisualStyleBackColor = false;
		return val;
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
	}

	private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new room_checkin_(ButtonGlobalId, ((Control)metroDateTime1).Text)).Show();
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		components = new Container();
		flowLayoutPanel1 = new FlowLayoutPanel();
		metroDateTime1 = new MetroDateTime();
		flowLayoutPanel2 = new FlowLayoutPanel();
		panel1 = new Panel();
		panel6 = new Panel();
		label6 = new Label();
		panel2 = new Panel();
		contextMenuStrip1 = new ContextMenuStrip(components);
		checkInToolStripMenuItem = new ToolStripMenuItem();
		checkOutToolStripMenuItem = new ToolStripMenuItem();
		foodToolStripMenuItem = new ToolStripMenuItem();
		billPrintToolStripMenuItem = new ToolStripMenuItem();
		label2 = new Label();
		label1 = new Label();
		((Control)flowLayoutPanel2).SuspendLayout();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)flowLayoutPanel1).Anchor = (AnchorStyles)15;
		((Control)flowLayoutPanel1).Location = new Point(23, 92);
		((Control)flowLayoutPanel1).Name = "flowLayoutPanel1";
		((Control)flowLayoutPanel1).Size = new Size(763, 422);
		((Control)flowLayoutPanel1).TabIndex = 0;
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(23, 57);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 1;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((Control)flowLayoutPanel2).Anchor = (AnchorStyles)13;
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)panel1);
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)label1);
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)panel6);
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)label6);
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)panel2);
		((Control)flowLayoutPanel2).Controls.Add((Control)(object)label2);
		((Control)flowLayoutPanel2).Location = new Point(533, 27);
		((Control)flowLayoutPanel2).Name = "flowLayoutPanel2";
		((Control)flowLayoutPanel2).Size = new Size(253, 59);
		((Control)flowLayoutPanel2).TabIndex = 2;
		((Control)panel1).Location = new Point(3, 3);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(39, 31);
		((Control)panel1).TabIndex = 22;
		((Control)panel6).Location = new Point(119, 3);
		((Control)panel6).Name = "panel6";
		((Control)panel6).Size = new Size(39, 31);
		((Control)panel6).TabIndex = 23;
		((Control)label6).AutoSize = true;
		((Control)label6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label6).Location = new Point(3, 37);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(106, 18);
		((Control)label6).TabIndex = 21;
		((Control)label6).Text = "Online Booked";
		((Control)panel2).Location = new Point(115, 40);
		((Control)panel2).Name = "panel2";
		((Control)panel2).Size = new Size(39, 31);
		((Control)panel2).TabIndex = 23;
		((Control)contextMenuStrip1).Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStrip)contextMenuStrip1).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)checkInToolStripMenuItem,
			(ToolStripItem)checkOutToolStripMenuItem,
			(ToolStripItem)foodToolStripMenuItem,
			(ToolStripItem)billPrintToolStripMenuItem
		});
		((Control)contextMenuStrip1).Name = "contextMenuStrip1";
		((Control)contextMenuStrip1).Size = new Size(153, 122);
		((ToolStripItem)checkInToolStripMenuItem).Name = "checkInToolStripMenuItem";
		((ToolStripItem)checkInToolStripMenuItem).Size = new Size(192, 24);
		((ToolStripItem)checkInToolStripMenuItem).Text = "Check In";
		((ToolStripItem)checkInToolStripMenuItem).Click += checkInToolStripMenuItem_Click;
		((ToolStripItem)checkOutToolStripMenuItem).Name = "checkOutToolStripMenuItem";
		((ToolStripItem)checkOutToolStripMenuItem).Size = new Size(192, 24);
		((ToolStripItem)checkOutToolStripMenuItem).Text = "Check Out";
		((ToolStripItem)foodToolStripMenuItem).Name = "foodToolStripMenuItem";
		((ToolStripItem)foodToolStripMenuItem).Size = new Size(192, 24);
		((ToolStripItem)foodToolStripMenuItem).Text = "Serve Food";
		((ToolStripItem)billPrintToolStripMenuItem).Name = "billPrintToolStripMenuItem";
		((ToolStripItem)billPrintToolStripMenuItem).Size = new Size(192, 24);
		((ToolStripItem)billPrintToolStripMenuItem).Text = "Bill Print";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(160, 37);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(71, 18);
		((Control)label2).TabIndex = 17;
		((Control)label2).Text = "Occupied";
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(48, 0);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(65, 18);
		((Control)label1).TabIndex = 16;
		((Control)label1).Text = "Avaliable";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(809, 537);
		((Control)this).Controls.Add((Control)(object)flowLayoutPanel2);
		((Control)this).Controls.Add((Control)(object)metroDateTime1);
		((Control)this).Controls.Add((Control)(object)flowLayoutPanel1);
		((Control)this).Name = "h_Room_status";
		((Control)this).Text = "Room Status";
		((Form)this).Load += h_CheckIn_Load;
		((Control)flowLayoutPanel2).ResumeLayout(false);
		((Control)flowLayoutPanel2).PerformLayout();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
