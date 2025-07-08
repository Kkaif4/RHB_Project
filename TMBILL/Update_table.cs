#define DEBUG
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class Update_table : MetroForm
{
	public static Update_table s_update_table;

	public string gid;

	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private MetroCheckBox metroCheckBox1;

	private Button button1;

	private Button button2;

	private ErrorProvider errorProvider1;

	public Update_table(string id)
	{
		InitializeComponent();
		s_update_table = this;
		gid = id;
		Debug.WriteLine(id);
		Bindall();
	}

	private void Bindall()
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
				((DbCommand)(object)val2).CommandText = "select * from tbl where id='" + gid + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroTextBox1).Text = ((DbDataReader)(object)val3)[1].ToString();
						string text = ((DbDataReader)(object)val3)[2].ToString();
						if (text == "Yes")
						{
							((CheckBox)metroCheckBox1).Checked = true;
						}
						else
						{
							((CheckBox)metroCheckBox1).Checked = false;
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

	public void updateFunction()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Invalid comparison between I4 and Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between I4 and Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between I4 and Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("14", "Update"))
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
							((DbCommand)(object)val2).CommandText = "update tbl set table_name='" + ((Control)metroTextBox1).Text + "',isactive='" + (((CheckBox)metroCheckBox1).Checked ? "Yes" : "No") + "' where id='" + gid + "'";
							((DbCommand)(object)val2).ExecuteNonQuery();
							((DbConnection)(object)val).Close();
							if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
							{
								((Control)s_update_table).Focus();
								((Form)s_update_table).Activate();
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
					if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Table Name Already Taken", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
					{
						((Control)s_update_table).Focus();
						((Form)s_update_table).Activate();
					}
					return;
				}
			}
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill ALL the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)s_update_table).Focus();
				((Form)s_update_table).Activate();
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	public void DeleteFunction()
	{
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Invalid comparison between I4 and Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between I4 and Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("14", "Delete"))
		{
			if (6 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Are you sure want to delete?", "Confirm", (MessageBoxButtons)4, (MessageBoxIcon)32))
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "delete from tbl where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Deleted Successfully", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)Add_table.s_add_table).Focus();
							((Form)Add_table.s_add_table).Activate();
							((Form)this).Close();
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
			((Control)s_update_table).Focus();
			((Form)s_update_table).Activate();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void Update_table_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Add_table.s_add_table).Focus();
		((Form)Add_table.s_add_table).Activate();
	}

	private void Update_table_FormClosing(object sender, FormClosingEventArgs e)
	{
		((Control)Add_table.s_add_table).Focus();
		((Form)Add_table.s_add_table).Activate();
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
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 131140)
		{
			if ((int)keyData != 131157)
			{
				if ((int)keyData == 262232)
				{
					((Control)Add_table.s_add_table).Focus();
					((Form)Add_table.s_add_table).Activate();
					((Form)this).Close();
					return true;
				}
				return ((Form)this).ProcessCmdKey(ref msg, keyData);
			}
			updateFunction();
			return true;
		}
		DeleteFunction();
		return true;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		DeleteFunction();
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Table Name");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void Update_table_Load(object sender, EventArgs e)
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Update_table));
		metroTextBox1 = new MetroTextBox();
		metroCheckBox1 = new MetroCheckBox();
		button1 = new Button();
		button2 = new Button();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(340, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(25, 25);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(27, 65);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Table Name";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		metroTextBox1.ShowClearButton = true;
		((Control)metroTextBox1).Size = new Size(366, 27);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Table Name";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)metroCheckBox1).AutoSize = true;
		metroCheckBox1.FontSize = (MetroCheckBoxSize)1;
		((Control)metroCheckBox1).Location = new Point(33, 106);
		((Control)metroCheckBox1).Name = "metroCheckBox1";
		((Control)metroCheckBox1).Size = new Size(76, 19);
		((Control)metroCheckBox1).TabIndex = 1;
		((Control)metroCheckBox1).Text = "Is Active";
		metroCheckBox1.UseSelectable = true;
		((Control)button1).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(28, 142);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(129, 39);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "&Update (D)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button2).BackColor = Color.Red;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(264, 142);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(129, 39);
		((Control)button2).TabIndex = 3;
		((Control)button2).Text = "&Delete (D)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(416, 191);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroCheckBox1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Update_table";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Updates";
		((Form)this).FormClosing += new FormClosingEventHandler(Update_table_FormClosing);
		((Form)this).FormClosed += new FormClosedEventHandler(Update_table_FormClosed);
		((Form)this).Load += Update_table_Load;
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
