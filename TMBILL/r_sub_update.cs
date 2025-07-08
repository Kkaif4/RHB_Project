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

public class r_sub_update : MetroForm
{
	private IContainer components = null;

	private MetroComboBox metroComboBox1;

	private MetroTextBox metroTextBox1;

	private Button button1;

	private Button button2;

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
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(r_sub_update));
		metroComboBox1 = new MetroComboBox();
		metroTextBox1 = new MetroTextBox();
		button1 = new Button();
		button2 = new Button();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		((ListControl)metroComboBox1).FormattingEnabled = true;
		((ComboBox)metroComboBox1).ItemHeight = 23;
		((Control)metroComboBox1).Location = new Point(62, 68);
		((Control)metroComboBox1).Name = "metroComboBox1";
		metroComboBox1.PromptText = "Select Category";
		((Control)metroComboBox1).Size = new Size(376, 29);
		((Control)metroComboBox1).TabIndex = 0;
		metroComboBox1.UseSelectable = true;
		((ComboBox)metroComboBox1).SelectedIndexChanged += metroComboBox1_SelectedIndexChanged;
		((Control)metroComboBox1).Validating += metroComboBox1_Validating;
		((Control)metroComboBox1).Validated += metroComboBox1_Validated;
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(348, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(62, 103);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Subcategory";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(376, 29);
		((Control)metroTextBox1).TabIndex = 1;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Subcategory";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).Validating += metroTextBox1_Validating;
		((Control)metroTextBox1).Validated += metroTextBox1_Validated;
		((Control)button1).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.refresh;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(66, 149);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(161, 47);
		((Control)button1).TabIndex = 2;
		((Control)button1).Text = "Update (U)";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button2).BackColor = Color.Red;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.delete;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(277, 147);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(161, 47);
		((Control)button2).TabIndex = 3;
		((Control)button2).Text = "Delete (D)";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((Form)this).ClientSize = new Size(499, 217);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Control)this).Controls.Add((Control)(object)metroComboBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "r_sub_update";
		((MetroForm)this).Resizable = false;
		((Control)this).Text = "Update";
		((Form)this).FormClosing += new FormClosingEventHandler(r_sub_update_FormClosing);
		((Form)this).Load += r_sub_update_Load;
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public r_sub_update(string id)
	{
		InitializeComponent();
		bindcomb();
		gid = id;
		bindall();
	}

	private void bindall()
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
				((DbCommand)(object)val2).CommandText = "select * from r_subcategory where id='" + gid + "'";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)metroComboBox1).Text = ((DbDataReader)(object)val3)[1].ToString();
						((Control)metroTextBox1).Text = ((DbDataReader)(object)val3)[2].ToString();
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

	public void bindcomb()
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
				((DbCommand)(object)val2).CommandText = "select * from r_category";
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

	private void button1_Click(object sender, EventArgs e)
	{
		updateFunction();
	}

	private void deleteFunction()
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between I4 and Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between I4 and Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("12", "Delete"))
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
						((DbCommand)(object)val2).CommandText = "delete from r_subcategory where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "subcategory Deleted", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
						{
							((Control)r_subcategory.s_r_sub).Focus();
							((Form)r_subcategory.s_r_sub).Activate();
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
			((Control)this).Focus();
			((Form)this).Activate();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "You are not allowed to perform this operation", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void updateFunction()
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between I4 and Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Invalid comparison between I4 and Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("12", "Update"))
		{
			if (((ContainerControl)this).ValidateChildren())
			{
				SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
				try
				{
					SqlCommand val2 = new SqlCommand();
					try
					{
						val2.Connection = val;
						((DbConnection)(object)val).Open();
						((DbCommand)(object)val2).CommandText = "update r_subcategory set category='" + ((Control)metroComboBox1).Text + "',subcategory='" + ((Control)metroTextBox1).Text + "' where id='" + gid + "'";
						((DbCommand)(object)val2).ExecuteNonQuery();
						((DbConnection)(object)val).Close();
						if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Information Updated", "Done", (MessageBoxButtons)0, (MessageBoxIcon)64))
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
			if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Fill all the fields", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
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

	private void r_sub_update_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
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
					((Control)r_subcategory.s_r_sub).Focus();
					((Form)r_subcategory.s_r_sub).Activate();
					((Form)this).Close();
					return true;
				}
				return ((Form)this).ProcessCmdKey(ref msg, keyData);
			}
			updateFunction();
			return true;
		}
		deleteFunction();
		return true;
	}

	private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void metroComboBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroComboBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroComboBox1, "select category");
			e.Cancel = true;
		}
	}

	private void metroTextBox1_Validating(object sender, CancelEventArgs e)
	{
		if (((Control)metroTextBox1).Text == "")
		{
			errorProvider1.SetError((Control)(object)metroTextBox1, "Enter Subcategory");
			e.Cancel = true;
		}
	}

	private void metroComboBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroComboBox1, "");
	}

	private void metroTextBox1_Validated(object sender, EventArgs e)
	{
		errorProvider1.SetError((Control)(object)metroTextBox1, "");
	}

	private void r_sub_update_FormClosing(object sender, FormClosingEventArgs e)
	{
		((Control)r_subcategory.s_r_sub).Focus();
		((Form)r_subcategory.s_r_sub).Activate();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		deleteFunction();
	}
}
