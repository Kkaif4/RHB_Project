using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace TMBILL;

public class Loading : MetroForm
{
	private IContainer components = null;

	private MetroProgressSpinner metroProgressSpinner1;

	private Label label1;

	public Loading()
	{
		InitializeComponent();
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		metroProgressSpinner1 = new MetroProgressSpinner();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)metroProgressSpinner1).Location = new Point(38, 32);
		metroProgressSpinner1.Maximum = 100;
		((Control)metroProgressSpinner1).Name = "metroProgressSpinner1";
		((Control)metroProgressSpinner1).Size = new Size(124, 124);
		metroProgressSpinner1.Style = (MetroColorStyle)5;
		((Control)metroProgressSpinner1).TabIndex = 0;
		metroProgressSpinner1.UseSelectable = true;
		((Control)label1).AutoSize = true;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(45, 159);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(117, 20);
		((Control)label1).TabIndex = 1;
		((Control)label1).Text = "Please Wait . . .";
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(203, 203);
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)metroProgressSpinner1);
		((MetroForm)this).DisplayHeader = false;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((MetroForm)this).Movable = false;
		((Control)this).Name = "Loading";
		((MetroForm)this).Padding = new Padding(20, 30, 20, 20);
		((MetroForm)this).Resizable = false;
		((Form)this).ShowInTaskbar = false;
		((MetroForm)this).Style = (MetroColorStyle)5;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
