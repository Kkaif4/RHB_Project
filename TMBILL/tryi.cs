using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TMBILL;

public class tryi : Form
{
	private IContainer components = null;

	private Button button1;

	public tryi()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.rhinfinity.com/SOFT_FILE/trial.php");
		string text = "name=hello";
		text += "&hotelname=world";
		text += "&col=miss";
		byte[] bytes = Encoding.ASCII.GetBytes(text);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		MessageBox.Show(text2);
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).Location = new Point(54, 42);
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
		((Control)this).Name = "tryi";
		((Control)this).Text = "tryi";
		((Control)this).ResumeLayout(false);
	}
}
