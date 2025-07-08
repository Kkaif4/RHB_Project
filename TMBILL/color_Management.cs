using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace TMBILL;

public class color_Management : MetroForm
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Label label1;

	private Label label2;

	private Button button6;

	private Button button7;

	private Button button11;

	private Button button12;

	private Label label6;

	public color_Management()
	{
		InitializeComponent();
		BindAllColors();
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
								((Control)button1).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
								break;
							case "Occupied":
								((Control)button2).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
								break;
							case "Online Booked":
								((Control)button12).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
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

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		ColorDialog val = new ColorDialog();
		val.AllowFullOpen = false;
		val.AnyColor = true;
		val.SolidColorOnly = true;
		val.Color = Color.Red;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string text = val.Color.R + "*" + val.Color.G + "*" + val.Color.B;
			string[] array = text.Split(new char[1] { '*' });
			((Control)button1).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		ColorDialog val = new ColorDialog();
		val.AllowFullOpen = false;
		val.AnyColor = true;
		val.SolidColorOnly = true;
		val.Color = Color.Red;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string text = val.Color.R + "*" + val.Color.G + "*" + val.Color.B;
			string[] array = text.Split(new char[1] { '*' });
			((Control)button2).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Color backColor = ((Control)button1).BackColor;
		string code = backColor.R + "*" + backColor.G + "*" + backColor.B;
		UpdateColor(code, "1");
	}

	private void UpdateColor(string code, string id)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between I4 and Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "update h_room_color set code='" + code + "' where id='" + id + "'";
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
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Color Code Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		Color backColor = ((Control)button2).BackColor;
		string code = backColor.R + "*" + backColor.G + "*" + backColor.B;
		UpdateColor(code, "2");
	}

	private void button11_Click(object sender, EventArgs e)
	{
		Color backColor = ((Control)button12).BackColor;
		string code = backColor.R + "*" + backColor.G + "*" + backColor.B;
		UpdateColor(code, "3");
	}

	private void button12_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		ColorDialog val = new ColorDialog();
		val.AllowFullOpen = false;
		val.AnyColor = true;
		val.SolidColorOnly = true;
		val.Color = Color.Red;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string text = val.Color.R + "*" + val.Color.G + "*" + val.Color.B;
			string[] array = text.Split(new char[1] { '*' });
			((Control)button12).BackColor = Color.FromArgb(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
		}
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(color_Management));
		button1 = new Button();
		button2 = new Button();
		label1 = new Label();
		label2 = new Label();
		button6 = new Button();
		button7 = new Button();
		button11 = new Button();
		button12 = new Button();
		label6 = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).Location = new Point(21, 58);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(41, 37);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = " ";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button2).Location = new Point(21, 99);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(41, 37);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = " ";
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)button2).Click += button2_Click;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(91, 66);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(65, 18);
		((Control)label1).TabIndex = 4;
		((Control)label1).Text = "Avaliable";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(91, 107);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(71, 18);
		((Control)label2).TabIndex = 5;
		((Control)label2).Text = "Occupied";
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button6).Location = new Point(212, 58);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(71, 37);
		((Control)button6).TabIndex = 10;
		((Control)button6).Text = "Set";
		((ButtonBase)button6).UseVisualStyleBackColor = true;
		((Control)button6).Click += button6_Click;
		((Control)button7).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button7).Location = new Point(212, 99);
		((Control)button7).Name = "button7";
		((Control)button7).Size = new Size(71, 37);
		((Control)button7).TabIndex = 11;
		((Control)button7).Text = "Set";
		((ButtonBase)button7).UseVisualStyleBackColor = true;
		((Control)button7).Click += button7_Click;
		((Control)button11).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button11).Location = new Point(212, 142);
		((Control)button11).Name = "button11";
		((Control)button11).Size = new Size(71, 37);
		((Control)button11).TabIndex = 17;
		((Control)button11).Text = "Set";
		((ButtonBase)button11).UseVisualStyleBackColor = true;
		((Control)button11).Click += button11_Click;
		((ButtonBase)button12).FlatStyle = (FlatStyle)0;
		((Control)button12).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button12).Location = new Point(21, 142);
		((Control)button12).Name = "button12";
		((Control)button12).Size = new Size(41, 37);
		((Control)button12).TabIndex = 16;
		((Control)button12).Text = " ";
		((ButtonBase)button12).UseVisualStyleBackColor = true;
		((Control)button12).Click += button12_Click;
		((Control)label6).AutoSize = true;
		((Control)label6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label6).Location = new Point(91, 151);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(106, 18);
		((Control)label6).TabIndex = 15;
		((Control)label6).Text = "Online Booked";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(314, 200);
		((Control)this).Controls.Add((Control)(object)button11);
		((Control)this).Controls.Add((Control)(object)button12);
		((Control)this).Controls.Add((Control)(object)label6);
		((Control)this).Controls.Add((Control)(object)button7);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((MetroForm)this).Movable = false;
		((Control)this).Name = "color_Management";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Room Color ";
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
