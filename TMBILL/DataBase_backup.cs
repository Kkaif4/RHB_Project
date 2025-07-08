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

public class DataBase_backup : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private Button button1;

	private Button button2;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private MetroTextBox metroTextBox2;

	private Button button3;

	private Button button4;

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
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DataBase_backup));
		metroTextBox1 = new MetroTextBox();
		groupBox1 = new GroupBox();
		button2 = new Button();
		button1 = new Button();
		groupBox2 = new GroupBox();
		metroTextBox2 = new MetroTextBox();
		button3 = new Button();
		button4 = new Button();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(333, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(30, 34);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Browse Your Backup Location";
		metroTextBox1.ReadOnly = true;
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(361, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Browse Your Backup Location";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Controls.Add((Control)(object)metroTextBox1);
		((Control)groupBox1).Controls.Add((Control)(object)button2);
		((Control)groupBox1).Controls.Add((Control)(object)button1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(24, 60);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(421, 126);
		((Control)groupBox1).TabIndex = 3;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Backup Database";
		((Control)button2).BackColor = Color.FromArgb(241, 89, 42);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.database;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(228, 67);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(163, 43);
		((Control)button2).TabIndex = 2;
		((Control)button2).Text = "Backup";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button1).BackColor = Color.FromArgb(0, 125, 121);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.folder;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(30, 69);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(163, 43);
		((Control)button1).TabIndex = 1;
		((Control)button1).Text = "Browse";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)groupBox2).Controls.Add((Control)(object)metroTextBox2);
		((Control)groupBox2).Controls.Add((Control)(object)button3);
		((Control)groupBox2).Controls.Add((Control)(object)button4);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(24, 192);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(421, 126);
		((Control)groupBox2).TabIndex = 4;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Restore Database";
		metroTextBox2.CustomButton.Image = null;
		((Control)metroTextBox2.CustomButton).Location = new Point(333, 1);
		((Control)metroTextBox2.CustomButton).Name = "";
		((Control)metroTextBox2.CustomButton).Size = new Size(27, 27);
		metroTextBox2.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox2.CustomButton).TabIndex = 1;
		metroTextBox2.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox2.CustomButton.UseSelectable = true;
		((Control)metroTextBox2.CustomButton).Visible = false;
		metroTextBox2.FontSize = (MetroTextBoxSize)1;
		metroTextBox2.Lines = new string[0];
		((Control)metroTextBox2).Location = new Point(30, 34);
		metroTextBox2.MaxLength = 32767;
		((Control)metroTextBox2).Name = "metroTextBox2";
		metroTextBox2.PasswordChar = '\0';
		metroTextBox2.PromptText = "Browse Your .bak file Location";
		metroTextBox2.ReadOnly = true;
		metroTextBox2.ScrollBars = (ScrollBars)0;
		metroTextBox2.SelectedText = "";
		metroTextBox2.SelectionLength = 0;
		metroTextBox2.SelectionStart = 0;
		metroTextBox2.ShortcutsEnabled = true;
		((Control)metroTextBox2).Size = new Size(361, 29);
		((Control)metroTextBox2).TabIndex = 0;
		metroTextBox2.UseSelectable = true;
		metroTextBox2.WaterMark = "Browse Your .bak file Location";
		metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox2.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)button3).BackColor = Color.FromArgb(241, 89, 42);
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.restore;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(228, 67);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(163, 43);
		((Control)button3).TabIndex = 2;
		((Control)button3).Text = "Restore";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button4).BackColor = Color.FromArgb(0, 125, 121);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.folder;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(30, 69);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(163, 43);
		((Control)button4).TabIndex = 1;
		((Control)button4).Text = "Browse";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(468, 341);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "DataBase_backup";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Backup && Restore Database";
		((Form)this).FormClosed += new FormClosedEventHandler(DataBase_backup_FormClosed);
		((Form)this).Load += DataBase_backup_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public DataBase_backup()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.ShowNewFolderButton = true;
		DialogResult val2 = ((CommonDialog)val).ShowDialog();
		if ((int)val2 == 1)
		{
			((Control)metroTextBox1).Text = val.SelectedPath;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between I4 and Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Invalid comparison between I4 and Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Invalid comparison between I4 and Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("23", "View"))
		{
			if (((Control)metroTextBox1).Text != "")
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
							((DbCommand)(object)val2).CommandText = "BACKUP DATABASE [" + ((DbConnection)(object)val).Database + "] TO DISK='" + ((Control)metroTextBox1).Text + "\\Backup_" + DateTime.Now.ToFileTime() + ".bak'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Backup is created Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)metroTextBox1).Text = "";
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
				catch (Exception ex)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Your backup Location", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation..", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = "Backup File(*.bak) | *.bak";
		((FileDialog)val).Title = "Select your Backup file";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			((Control)metroTextBox2).Text = ((FileDialog)val).FileName;
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Invalid comparison between I4 and Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Invalid comparison between I4 and Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between I4 and Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("24", "View"))
		{
			if (((Control)metroTextBox2).Text != "")
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
							((DbCommand)(object)val2).CommandText = "alter database [" + ((DbConnection)(object)val).Database + "] set offline with rollback immediate";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbCommand)(object)val2).Cancel();
							((DbCommand)(object)val2).CommandText = "RESTORE DATABASE [" + ((DbConnection)(object)val).Database + "] FROM DISK='" + ((Control)metroTextBox2).Text + "' with file=1";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbCommand)(object)val2).Cancel();
							((DbCommand)(object)val2).CommandText = "alter database [" + ((DbConnection)(object)val).Database + "] set online";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Database Restored Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)metroTextBox2).Text = "";
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
				catch (Exception ex)
				{
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, ex.Message, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)this).Focus();
						((Form)this).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Select Your backup Location", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void DataBase_backup_Load(object sender, EventArgs e)
	{
	}

	private void DataBase_backup_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Functions.static_mainform).Focus();
		((Form)Functions.static_mainform).Activate();
	}
}
