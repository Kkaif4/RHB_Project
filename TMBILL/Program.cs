using System;
using System.Threading;
using System.Windows.Forms;

namespace TMBILL;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		bool createdNew = false;
		using (new Mutex(initiallyOwned: true, "RunningApp", out createdNew))
		{
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new FlashScreen());
			}
			else
			{
				MessageBox.Show("Application is Already Running");
			}
		}
	}
}
