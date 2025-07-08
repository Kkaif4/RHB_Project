#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using TMBILL.Properties;

namespace TMBILL;

public class FlashScreen : Form
{
	private Thread t;

	private IContainer components = null;

	private MetroProgressBar metroProgressBar1;

	private PictureBox pictureBox2;

	private Label label1;

	private Label label2;

	private PictureBox pictureBox1;

	private Label label3;

	private Button button1;

	public FlashScreen()
	{
		InitializeComponent();
		t = new Thread(Load);
		t.Start();
	}

	public void Load()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		MethodInvoker val = null;
		MethodInvoker val2 = null;
		try
		{
			Label obj = label3;
			if (val == null)
			{
				val = (MethodInvoker)delegate
				{
					((Control)label3).Text = "Setting Permission";
				};
			}
			((Control)obj).BeginInvoke((Delegate)(object)val);
		}
		catch (Exception)
		{
		}
		new Permission().SetAcl();
		try
		{
			Label obj2 = label3;
			if (val2 == null)
			{
				val2 = (MethodInvoker)delegate
				{
					((Control)label3).Text = "Setting DateFormat";
				};
			}
			((Control)obj2).BeginInvoke((Delegate)(object)val2);
		}
		catch (Exception)
		{
		}
		new Permission().setDateFormat();
		ConfigureServer();
	}

	public void ConfigureServer()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between I4 and Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Invalid comparison between I4 and Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		MethodInvoker val = null;
		MethodInvoker val2 = null;
		MethodInvoker val3 = null;
		MethodInvoker val4 = null;
		MethodInvoker val5 = null;
		MethodInvoker val6 = null;
		string text = "SQLEXPRESS";
		string stat = new SQLHelper().ServerRunning(text);
		((Control)label3).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)label3).Text = "Server Status : " + stat;
		});
		switch (stat)
		{
		case "NOTFOUND":
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "SQL SERVER IS NOT INSTALLED CONTACT TO DEVELOPER", "ERROR", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				Application.Exit();
			}
			break;
		case "Running":
		{
			string text2 = "";
			string text3 = "Data Source=.\\" + text + ";AttachDbFilename=|DataDirectory|\\DBASE.mdf;Integrated Security=True;User Instance=True";
			try
			{
				SQLHelper sQLHelper = new SQLHelper(text3);
				if (sQLHelper.IsConnection)
				{
					text2 = text3;
					Label obj = label3;
					if (val == null)
					{
						val = (MethodInvoker)delegate
						{
							((Control)label3).Text = "Connection Successed";
						};
					}
					((Control)obj).BeginInvoke((Delegate)(object)val);
				}
			}
			catch (Exception)
			{
				try
				{
					string text4 = "Data Source=.\\" + text + ";AttachDbFilename=|DataDirectory|\\DBASE.mdf;Integrated Security=True;User Instance=False";
					SQLHelper sQLHelper2 = new SQLHelper(text4);
					if (sQLHelper2.IsConnection)
					{
						text2 = text4;
						Label obj2 = label3;
						if (val2 == null)
						{
							val2 = (MethodInvoker)delegate
							{
								((Control)label3).Text = "Connection Successed";
							};
						}
						((Control)obj2).BeginInvoke((Delegate)(object)val2);
					}
				}
				catch (Exception ex2)
				{
					Exception ex3 = ex2;
					((Control)label3).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						((Control)label3).Text = "ERROR :" + ex3.Message;
					});
				}
			}
			if (text2 != "")
			{
				Debug.WriteLine("final string " + text2);
				new AppSettings().SetConnectionString(text2);
				string connectionString = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
				if (text2 == connectionString)
				{
					Label obj3 = label3;
					if (val3 == null)
					{
						val3 = (MethodInvoker)delegate
						{
							((Control)label3).Text = "Database Configured";
						};
					}
					((Control)obj3).BeginInvoke((Delegate)(object)val3);
					if (val4 == null)
					{
						val4 = (MethodInvoker)delegate
						{
							((Control)this).Hide();
						};
					}
					((Control)this).BeginInvoke((Delegate)(object)val4);
					((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						((Control)new Login()).Show();
					});
				}
				else
				{
					((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
					{
						Application.Exit();
					});
				}
				break;
			}
			Label obj4 = label3;
			if (val5 == null)
			{
				val5 = (MethodInvoker)delegate
				{
					((Control)label3).Text = "Unable to Configure Database";
				};
			}
			((Control)obj4).BeginInvoke((Delegate)(object)val5);
			if (1 != (int)MetroMessageBox.Show((IWin32Window)(object)this, "Error in Configuring Database", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				break;
			}
			if (val6 == null)
			{
				val6 = (MethodInvoker)delegate
				{
					((Control)this).Hide();
				};
			}
			((Control)this).BeginInvoke((Delegate)(object)val6);
			Application.Run((Form)(object)new SQL_SETUP());
			break;
		}
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)new SQL_SETUP()).Show();
	}

	private void FlashScreen_FormClosed(object sender, FormClosedEventArgs e)
	{
		Debug.WriteLine("Form Closed");
		t.Abort();
	}

	private void FlashScreen_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)this).Hide();
		});
		((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)new Login()).Show();
		});
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FlashScreen));
		metroProgressBar1 = new MetroProgressBar();
		pictureBox2 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		label3 = new Label();
		button1 = new Button();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)metroProgressBar1).Location = new Point(-1, 313);
		((ProgressBar)metroProgressBar1).MarqueeAnimationSpeed = 5000;
		((Control)metroProgressBar1).Name = "metroProgressBar1";
		metroProgressBar1.ProgressBarStyle = (ProgressBarStyle)2;
		((Control)metroProgressBar1).Size = new Size(601, 23);
		((ProgressBar)metroProgressBar1).Step = 30;
		metroProgressBar1.Style = (MetroColorStyle)11;
		((Control)metroProgressBar1).TabIndex = 0;
		metroProgressBar1.Theme = (MetroThemeStyle)2;
		pictureBox2.Image = (Image)(object)Resources.RHinfinity;
		((Control)pictureBox2).Location = new Point(140, 185);
		((Control)pictureBox2).Name = "pictureBox2";
		((Control)pictureBox2).Size = new Size(85, 85);
		pictureBox2.SizeMode = (PictureBoxSizeMode)1;
		pictureBox2.TabIndex = 2;
		pictureBox2.TabStop = false;
		((Control)label1).AutoSize = true;
		((Control)label1).BackColor = Color.Transparent;
		((Control)label1).Font = new Font("Bodoni MT", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = Color.Magenta;
		((Control)label1).Location = new Point(258, 192);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(125, 56);
		((Control)label1).TabIndex = 3;
		((Control)label1).Text = "RHB";
		((Control)label2).AutoSize = true;
		((Control)label2).BackColor = Color.Transparent;
		((Control)label2).Font = new Font("Arial Rounded MT Bold", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)label2).ForeColor = Color.DeepPink;
		((Control)label2).Location = new Point(3, 293);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(312, 17);
		((Control)label2).TabIndex = 4;
		((Control)label2).Text = "©RH Infinity Softwares Pvt Ltd. 2019-2020";
		((Control)pictureBox1).BackColor = Color.White;
		pictureBox1.Image = (Image)(object)Resources.icon;
		((Control)pictureBox1).Location = new Point(550, 263);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(50, 50);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 5;
		pictureBox1.TabStop = false;
		((Control)pictureBox1).Click += pictureBox1_Click;
		((Control)label3).AutoSize = true;
		((Control)label3).BackColor = Color.Transparent;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label3).ForeColor = Color.White;
		((Control)label3).Location = new Point(12, 9);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(45, 16);
		((Control)label3).TabIndex = 6;
		((Control)label3).Text = "label3";
		((Control)button1).BackColor = Color.White;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.Fuchsia;
		((Control)button1).Location = new Point(465, 12);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(122, 31);
		((Control)button1).TabIndex = 7;
		((Control)button1).Text = "Skip to Login";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackColor = Color.WhiteSmoke;
		((Control)this).BackgroundImage = (Image)(object)Resources.back;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		((Form)this).ClientSize = new Size(599, 336);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)pictureBox2);
		((Control)this).Controls.Add((Control)(object)metroProgressBar1);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "FlashScreen";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "FlashScreen";
		((Form)this).FormClosed += new FormClosedEventHandler(FlashScreen_FormClosed);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
