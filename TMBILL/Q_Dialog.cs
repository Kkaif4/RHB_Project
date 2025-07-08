using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class Q_Dialog : MetroForm
{
	private IContainer components = null;

	private MetroTextBox metroTextBox1;

	private Button button1;

	private ErrorProvider errorProvider1;

	public string seletedText { get; set; }

	public Q_Dialog()
	{
		InitializeComponent();
		((Control)metroTextBox1).Focus();
	}

	public Q_Dialog(string s)
	{
		InitializeComponent();
		((Control)metroTextBox1).Text = s;
		((Control)metroTextBox1).Focus();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).DialogResult = (DialogResult)1;
	}

	private void metroTextBox1_TextChanged(object sender, EventArgs e)
	{
		seletedText = ((Control)metroTextBox1).Text;
	}

	private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
		{
			e.Handled = true;
		}
	}

	private void Q_Dialog_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
	}

	private void metroTextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		if ((int)e.KeyData == 13)
		{
			((Form)this).DialogResult = (DialogResult)1;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Q_Dialog));
		metroTextBox1 = new MetroTextBox();
		button1 = new Button();
		errorProvider1 = new ErrorProvider(components);
		((ISupportInitialize)errorProvider1).BeginInit();
		((Control)this).SuspendLayout();
		metroTextBox1.CustomButton.Image = null;
		((Control)metroTextBox1.CustomButton).Location = new Point(291, 1);
		((Control)metroTextBox1.CustomButton).Name = "";
		((Control)metroTextBox1.CustomButton).Size = new Size(27, 27);
		metroTextBox1.CustomButton.Style = (MetroColorStyle)4;
		((Control)metroTextBox1.CustomButton).TabIndex = 1;
		metroTextBox1.CustomButton.Theme = (MetroThemeStyle)1;
		metroTextBox1.CustomButton.UseSelectable = true;
		((Control)metroTextBox1.CustomButton).Visible = false;
		metroTextBox1.FontSize = (MetroTextBoxSize)1;
		metroTextBox1.Lines = new string[0];
		((Control)metroTextBox1).Location = new Point(31, 65);
		metroTextBox1.MaxLength = 32767;
		((Control)metroTextBox1).Name = "metroTextBox1";
		metroTextBox1.PasswordChar = '\0';
		metroTextBox1.PromptText = "Enter Quantity Here";
		metroTextBox1.ScrollBars = (ScrollBars)0;
		metroTextBox1.SelectedText = "";
		metroTextBox1.SelectionLength = 0;
		metroTextBox1.SelectionStart = 0;
		metroTextBox1.ShortcutsEnabled = true;
		((Control)metroTextBox1).Size = new Size(319, 29);
		((Control)metroTextBox1).TabIndex = 0;
		metroTextBox1.UseSelectable = true;
		metroTextBox1.WaterMark = "Enter Quantity Here";
		metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
		metroTextBox1.WaterMarkFont = new Font("Segoe UI", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)metroTextBox1).TextChanged += metroTextBox1_TextChanged;
		((Control)metroTextBox1).KeyDown += new KeyEventHandler(metroTextBox1_KeyDown);
		((Control)metroTextBox1).KeyPress += new KeyPressEventHandler(metroTextBox1_KeyPress);
		((Control)button1).BackColor = Color.FromArgb(0, 174, 219);
		button1.DialogResult = (DialogResult)1;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((Control)button1).Location = new Point(238, 110);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(111, 35);
		((Control)button1).TabIndex = 1;
		((Control)button1).Text = "OK";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		errorProvider1.BlinkStyle = (ErrorBlinkStyle)2;
		errorProvider1.ContainerControl = (ContainerControl)(object)this;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((ContainerControl)this).AutoValidate = (AutoValidate)2;
		((MetroForm)this).BorderStyle = (MetroFormBorderStyle)1;
		((Form)this).ClientSize = new Size(391, 158);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)metroTextBox1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "Q_Dialog";
		((MetroForm)this).Resizable = false;
		((MetroForm)this).ShadowType = (MetroFormShadowType)2;
		((Control)this).Text = "Enter Quantity";
		((Form)this).Load += Q_Dialog_Load;
		((ISupportInitialize)errorProvider1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
