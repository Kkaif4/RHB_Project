using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;

namespace TMBILL;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).Location = new Point(62, 52);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(75, 23);
		((Control)button1).TabIndex = 0;
		((Control)button1).Text = "button1";
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(284, 261);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Name = "Form1";
		((Control)this).Text = "Form1";
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between I4 and Unknown
		if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "SERVICE ERROR? Visit www.rhinfinity.com for solution", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}
}
