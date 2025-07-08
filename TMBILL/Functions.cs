using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class Functions : MetroForm
{
	public static Functions static_mainform;

	private IContainer components = null;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button1;

	private Button button13;

	private Button button14;

	private Button button15;

	private Button button17;

	private Button button18;

	private Button button19;

	private Button button20;

	private Button button21;

	private Button button22;

	private Button button23;

	private Button button24;

	private Button button25;

	private Button button26;

	private Button button27;

	private Button button28;

	private Button button29;

	private Button button30;

	private Button button31;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private GroupBox groupBox3;

	private GroupBox groupBox5;

	private GroupBox groupBox4;

	public Functions()
	{
		InitializeComponent();
		static_mainform = this;
	}

	private void Functions_Load(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_customer") == "false")
		{
			((Control)new r_customer()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_customer");
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_empolyee") == "false")
		{
			((Control)new r_empolyee()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_empolyee");
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_vendor") == "false")
		{
			((Control)new r_vendor()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_vendor");
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_tax") == "false")
		{
			((Control)new r_tax()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_tax");
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_discount") == "false")
		{
			((Control)new r_discount()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_discount");
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_delieveryboy") == "false")
		{
			((Control)new r_delieveryboy()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_delieveryboy");
		}
	}

	private void button8_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_customer_transaction") == "false")
		{
			((Control)new r_customer_transaction()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_customer_transaction");
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_order_type") == "false")
		{
			((Control)new r_order_type()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_order_type");
		}
	}

	private void button10_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_payment_type") == "false")
		{
			((Control)new r_payment_type()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_payment_type");
		}
	}

	private void button11_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_Bank_management") == "false")
		{
			((Control)new r_Bank_management()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_Bank_management");
		}
	}

	private void button12_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_color_management") == "false")
		{
			((Control)new r_color_management()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_color_management");
		}
	}

	private void button15_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("Add_table") == "false")
		{
			((Control)new Add_table()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("Add_table");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_category") == "false")
		{
			((Control)new r_category()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_category");
		}
	}

	private void button13_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_subcategory") == "false")
		{
			((Control)new r_subcategory()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_subcategory");
		}
	}

	private void button14_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_product_item") == "false")
		{
			((Control)new r_product_item()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_product_item");
		}
	}

	private void button25_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_Purchase_history") == "false")
		{
			((Control)new r_Purchase_history()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_Purchase_history");
		}
	}

	private void button17_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("BillReport") == "false")
		{
			((Control)new BillReport()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("BillReport");
		}
	}

	private void button18_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("SaleReport") == "false")
		{
			((Control)new SaleReport()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("SaleReport");
		}
	}

	private void button19_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("PRINT_STOCK") == "false")
		{
			((Control)new PRINT_STOCK()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("PRINT_STOCK");
		}
	}

	private void button20_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("ItemWiseSellReport") == "false")
		{
			((Control)new ItemWiseSellReport()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("ItemWiseSellReport");
		}
	}

	private void button21_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_raw_category") == "false")
		{
			((Control)new r_raw_category()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_raw_category");
		}
	}

	private void button22_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_raw_material") == "false")
		{
			((Control)new r_raw_material()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_raw_material");
		}
	}

	private void button23_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("r_unit") == "false")
		{
			((Control)new r_unit()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("r_unit");
		}
	}

	private void button24_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("Recipe") == "false")
		{
			((Control)new Recipe()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("Recipe");
		}
	}

	private void button26_Click(object sender, EventArgs e)
	{
		if (new Permission().IsFormAlreadyOpen("DataBase_backup") == "false")
		{
			((Control)new DataBase_backup()).Show();
		}
		else
		{
			new Permission().IsFormFocusOpen("DataBase_backup");
		}
	}

	private void button27_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("10", "View"))
		{
			if (new Permission().IsFormAlreadyOpen("Printer_Management") == "false")
			{
				((Control)new Printer_Management()).Show();
			}
			else
			{
				new Permission().IsFormFocusOpen("Printer_Management");
			}
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button28_Click(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between I4 and Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between I4 and Unknown
		if (new Permission().IsFormAlreadyOpen("r_Users") == "false")
		{
			if (Settings.Default.Setting == "admin")
			{
				((Control)new r_Users()).Show();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else if (Settings.Default.Setting == "admin")
		{
			new Permission().IsFormFocusOpen("r_Users");
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void button29_Click(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between I4 and Unknown
		if (new Permission().IsFormAlreadyOpen("r_user_control") == "false")
		{
			if (Settings.Default.Setting == "admin")
			{
				((Control)new r_user_control()).Show();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else
		{
			new Permission().IsFormFocusOpen("r_user_control");
		}
	}

	private void button30_Click(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between I4 and Unknown
		if (new Permission().IsFormAlreadyOpen("r_header") == "false")
		{
			if (Settings.Default.Setting == "admin")
			{
				((Control)new r_header()).Show();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else
		{
			new Permission().IsFormFocusOpen("r_header");
		}
	}

	private void button31_Click(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between I4 and Unknown
		if (new Permission().IsFormAlreadyOpen("shopinfo") == "false")
		{
			if (Settings.Default.Setting == "admin")
			{
				((Control)new shopinfo()).Show();
			}
			else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
			{
				((Control)this).Focus();
				((Form)this).Activate();
			}
		}
		else
		{
			new Permission().IsFormFocusOpen("shopinfo");
		}
	}

	private void Functions_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)MainFrom.static_mainform).Focus();
		((Form)MainFrom.static_mainform).Activate();
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
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected O, but got Unknown
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected O, but got Unknown
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Expected O, but got Unknown
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected O, but got Unknown
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected O, but got Unknown
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected O, but got Unknown
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected O, but got Unknown
		//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Expected O, but got Unknown
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected O, but got Unknown
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e6: Expected O, but got Unknown
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected O, but got Unknown
		//IL_16b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c2: Expected O, but got Unknown
		//IL_17a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b3: Expected O, but got Unknown
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18af: Expected O, but got Unknown
		//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19aa: Expected O, but got Unknown
		//IL_1a9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa5: Expected O, but got Unknown
		//IL_1b96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba0: Expected O, but got Unknown
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9b: Expected O, but got Unknown
		//IL_1d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d93: Expected O, but got Unknown
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8b: Expected O, but got Unknown
		//IL_1f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8a: Expected O, but got Unknown
		//IL_207b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected O, but got Unknown
		//IL_2176: Unknown result type (might be due to invalid IL or missing references)
		//IL_2180: Expected O, but got Unknown
		//IL_2275: Unknown result type (might be due to invalid IL or missing references)
		//IL_227f: Expected O, but got Unknown
		//IL_2374: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Expected O, but got Unknown
		//IL_2555: Unknown result type (might be due to invalid IL or missing references)
		//IL_255f: Expected O, but got Unknown
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		groupBox3 = new GroupBox();
		groupBox5 = new GroupBox();
		groupBox4 = new GroupBox();
		button21 = new Button();
		button22 = new Button();
		button23 = new Button();
		button24 = new Button();
		button26 = new Button();
		button27 = new Button();
		button28 = new Button();
		button31 = new Button();
		button29 = new Button();
		button30 = new Button();
		button17 = new Button();
		button18 = new Button();
		button19 = new Button();
		button20 = new Button();
		button1 = new Button();
		button13 = new Button();
		button14 = new Button();
		button25 = new Button();
		button7 = new Button();
		button6 = new Button();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button15 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)button15);
		((Control)groupBox1).Controls.Add((Control)(object)button8);
		((Control)groupBox1).Controls.Add((Control)(object)button9);
		((Control)groupBox1).Controls.Add((Control)(object)button10);
		((Control)groupBox1).Controls.Add((Control)(object)button11);
		((Control)groupBox1).Controls.Add((Control)(object)button12);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).ForeColor = Color.FromArgb(0, 174, 219);
		((Control)groupBox1).Location = new Point(23, 40);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(613, 381);
		((Control)groupBox1).TabIndex = 38;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Functions";
		((Control)groupBox2).Controls.Add((Control)(object)button1);
		((Control)groupBox2).Controls.Add((Control)(object)button13);
		((Control)groupBox2).Controls.Add((Control)(object)button14);
		((Control)groupBox2).Controls.Add((Control)(object)button25);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).ForeColor = Color.Red;
		((Control)groupBox2).Location = new Point(23, 431);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(302, 258);
		((Control)groupBox2).TabIndex = 39;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Menu Card";
		((Control)groupBox3).Controls.Add((Control)(object)button17);
		((Control)groupBox3).Controls.Add((Control)(object)button18);
		((Control)groupBox3).Controls.Add((Control)(object)button19);
		((Control)groupBox3).Controls.Add((Control)(object)button20);
		((Control)groupBox3).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).ForeColor = Color.Purple;
		((Control)groupBox3).Location = new Point(331, 427);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(305, 262);
		((Control)groupBox3).TabIndex = 40;
		groupBox3.TabStop = false;
		((Control)groupBox3).Text = "Report";
		((Control)groupBox5).Controls.Add((Control)(object)button26);
		((Control)groupBox5).Controls.Add((Control)(object)button27);
		((Control)groupBox5).Controls.Add((Control)(object)button28);
		((Control)groupBox5).Controls.Add((Control)(object)button31);
		((Control)groupBox5).Controls.Add((Control)(object)button29);
		((Control)groupBox5).Controls.Add((Control)(object)button30);
		((Control)groupBox5).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)groupBox5).ForeColor = Color.FromArgb(255, 128, 0);
		((Control)groupBox5).Location = new Point(642, 40);
		((Control)groupBox5).Name = "groupBox5";
		((Control)groupBox5).Size = new Size(311, 381);
		((Control)groupBox5).TabIndex = 42;
		groupBox5.TabStop = false;
		((Control)groupBox5).Text = "Settings";
		((Control)groupBox4).Controls.Add((Control)(object)button21);
		((Control)groupBox4).Controls.Add((Control)(object)button22);
		((Control)groupBox4).Controls.Add((Control)(object)button23);
		((Control)groupBox4).Controls.Add((Control)(object)button24);
		((Control)groupBox4).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)groupBox4).ForeColor = Color.DarkOliveGreen;
		((Control)groupBox4).Location = new Point(642, 431);
		((Control)groupBox4).Name = "groupBox4";
		((Control)groupBox4).Size = new Size(311, 262);
		((Control)groupBox4).TabIndex = 43;
		groupBox4.TabStop = false;
		((Control)groupBox4).Text = "Raw Material Management";
		((Control)button21).BackColor = Color.DarkOliveGreen;
		((ButtonBase)button21).FlatStyle = (FlatStyle)0;
		((Control)button21).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button21).ForeColor = Color.White;
		((ButtonBase)button21).Image = (Image)(object)Resources.w_raw_material_cat;
		((ButtonBase)button21).ImageAlign = (ContentAlignment)16;
		((Control)button21).Location = new Point(13, 25);
		((Control)button21).Name = "button21";
		((Control)button21).Size = new Size(284, 50);
		((Control)button21).TabIndex = 26;
		((Control)button21).Text = "Raw Material Category";
		((ButtonBase)button21).UseVisualStyleBackColor = false;
		((Control)button21).Click += button21_Click;
		((Control)button22).BackColor = Color.DarkOliveGreen;
		((ButtonBase)button22).FlatStyle = (FlatStyle)0;
		((Control)button22).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button22).ForeColor = Color.White;
		((ButtonBase)button22).Image = (Image)(object)Resources.w_raw_material_cat;
		((ButtonBase)button22).ImageAlign = (ContentAlignment)16;
		((Control)button22).Location = new Point(13, 83);
		((Control)button22).Name = "button22";
		((Control)button22).Size = new Size(284, 50);
		((Control)button22).TabIndex = 27;
		((Control)button22).Text = "Raw Material";
		((ButtonBase)button22).UseVisualStyleBackColor = false;
		((Control)button22).Click += button22_Click;
		((Control)button23).BackColor = Color.DarkOliveGreen;
		((ButtonBase)button23).FlatStyle = (FlatStyle)0;
		((Control)button23).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button23).ForeColor = Color.White;
		((ButtonBase)button23).Image = (Image)(object)Resources.unit_management;
		((ButtonBase)button23).ImageAlign = (ContentAlignment)16;
		((Control)button23).Location = new Point(13, 141);
		((Control)button23).Name = "button23";
		((Control)button23).Size = new Size(284, 50);
		((Control)button23).TabIndex = 28;
		((Control)button23).Text = "Unit Management";
		((ButtonBase)button23).UseVisualStyleBackColor = false;
		((Control)button23).Click += button23_Click;
		((Control)button24).BackColor = Color.DarkOliveGreen;
		((ButtonBase)button24).FlatStyle = (FlatStyle)0;
		((Control)button24).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button24).ForeColor = Color.White;
		((ButtonBase)button24).Image = (Image)(object)Resources.w_recipe;
		((ButtonBase)button24).ImageAlign = (ContentAlignment)16;
		((Control)button24).Location = new Point(13, 199);
		((Control)button24).Name = "button24";
		((Control)button24).Size = new Size(284, 52);
		((Control)button24).TabIndex = 29;
		((Control)button24).Text = "Recipe";
		((ButtonBase)button24).UseVisualStyleBackColor = false;
		((Control)button24).Click += button24_Click;
		((Control)button26).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button26).FlatStyle = (FlatStyle)0;
		((Control)button26).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button26).ForeColor = Color.White;
		((ButtonBase)button26).Image = (Image)(object)Resources.w_database;
		((ButtonBase)button26).ImageAlign = (ContentAlignment)16;
		((Control)button26).Location = new Point(9, 25);
		((Control)button26).Name = "button26";
		((Control)button26).Size = new Size(284, 52);
		((Control)button26).TabIndex = 32;
		((Control)button26).Text = "DB Backup && Restore";
		((ButtonBase)button26).UseVisualStyleBackColor = false;
		((Control)button26).Click += button26_Click;
		((Control)button27).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button27).FlatStyle = (FlatStyle)0;
		((Control)button27).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button27).ForeColor = Color.White;
		((ButtonBase)button27).Image = (Image)(object)Resources.w_printer;
		((ButtonBase)button27).ImageAlign = (ContentAlignment)16;
		((Control)button27).Location = new Point(9, 83);
		((Control)button27).Name = "button27";
		((Control)button27).Size = new Size(284, 52);
		((Control)button27).TabIndex = 33;
		((Control)button27).Text = "Printer Management";
		((ButtonBase)button27).UseVisualStyleBackColor = false;
		((Control)button27).Click += button27_Click;
		((Control)button28).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button28).FlatStyle = (FlatStyle)0;
		((Control)button28).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button28).ForeColor = Color.White;
		((ButtonBase)button28).Image = (Image)(object)Resources.user_management;
		((ButtonBase)button28).ImageAlign = (ContentAlignment)16;
		((Control)button28).Location = new Point(9, 141);
		((Control)button28).Name = "button28";
		((Control)button28).Size = new Size(284, 52);
		((Control)button28).TabIndex = 34;
		((Control)button28).Text = "User Management";
		((ButtonBase)button28).UseVisualStyleBackColor = false;
		((Control)button28).Click += button28_Click;
		((Control)button31).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button31).FlatStyle = (FlatStyle)0;
		((Control)button31).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button31).ForeColor = Color.White;
		((ButtonBase)button31).Image = (Image)(object)Resources.wshopinfo;
		((ButtonBase)button31).ImageAlign = (ContentAlignment)16;
		((Control)button31).Location = new Point(9, 315);
		((Control)button31).Name = "button31";
		((Control)button31).Size = new Size(284, 52);
		((Control)button31).TabIndex = 37;
		((Control)button31).Text = "Hotel Information";
		((ButtonBase)button31).UseVisualStyleBackColor = false;
		((Control)button31).Click += button31_Click;
		((Control)button29).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button29).FlatStyle = (FlatStyle)0;
		((Control)button29).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button29).ForeColor = Color.White;
		((ButtonBase)button29).Image = (Image)(object)Resources.user_permission;
		((ButtonBase)button29).ImageAlign = (ContentAlignment)16;
		((Control)button29).Location = new Point(9, 199);
		((Control)button29).Name = "button29";
		((Control)button29).Size = new Size(284, 52);
		((Control)button29).TabIndex = 35;
		((Control)button29).Text = "User Permission";
		((ButtonBase)button29).UseVisualStyleBackColor = false;
		((Control)button29).Click += button29_Click;
		((Control)button30).BackColor = Color.FromArgb(255, 128, 0);
		((ButtonBase)button30).FlatStyle = (FlatStyle)0;
		((Control)button30).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button30).ForeColor = Color.White;
		((ButtonBase)button30).Image = (Image)(object)Resources.w_priner_header;
		((ButtonBase)button30).ImageAlign = (ContentAlignment)16;
		((Control)button30).Location = new Point(9, 257);
		((Control)button30).Name = "button30";
		((Control)button30).Size = new Size(284, 52);
		((Control)button30).TabIndex = 36;
		((Control)button30).Text = "Printer Header && Footer";
		((ButtonBase)button30).UseVisualStyleBackColor = false;
		((Control)button30).Click += button30_Click;
		((Control)button17).BackColor = Color.FromArgb(192, 0, 192);
		((ButtonBase)button17).FlatStyle = (FlatStyle)0;
		((Control)button17).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button17).ForeColor = Color.White;
		((ButtonBase)button17).Image = (Image)(object)Resources.w_Report;
		((ButtonBase)button17).ImageAlign = (ContentAlignment)16;
		((Control)button17).Location = new Point(10, 25);
		((Control)button17).Name = "button17";
		((Control)button17).Size = new Size(284, 52);
		((Control)button17).TabIndex = 21;
		((Control)button17).Text = "Bill Report";
		((ButtonBase)button17).UseVisualStyleBackColor = false;
		((Control)button17).Click += button17_Click;
		((Control)button18).BackColor = Color.FromArgb(192, 0, 192);
		((ButtonBase)button18).FlatStyle = (FlatStyle)0;
		((Control)button18).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button18).ForeColor = Color.White;
		((ButtonBase)button18).Image = (Image)(object)Resources.w_Report;
		((ButtonBase)button18).ImageAlign = (ContentAlignment)16;
		((Control)button18).Location = new Point(10, 83);
		((Control)button18).Name = "button18";
		((Control)button18).Size = new Size(284, 52);
		((Control)button18).TabIndex = 22;
		((Control)button18).Text = "Sale Report";
		((ButtonBase)button18).UseVisualStyleBackColor = false;
		((Control)button18).Click += button18_Click;
		((Control)button19).BackColor = Color.FromArgb(192, 0, 192);
		((ButtonBase)button19).FlatStyle = (FlatStyle)0;
		((Control)button19).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button19).ForeColor = Color.White;
		((ButtonBase)button19).Image = (Image)(object)Resources.w_Report;
		((ButtonBase)button19).ImageAlign = (ContentAlignment)16;
		((Control)button19).Location = new Point(10, 141);
		((Control)button19).Name = "button19";
		((Control)button19).Size = new Size(284, 52);
		((Control)button19).TabIndex = 23;
		((Control)button19).Text = "Stock Report";
		((ButtonBase)button19).UseVisualStyleBackColor = false;
		((Control)button19).Click += button19_Click;
		((Control)button20).BackColor = Color.FromArgb(192, 0, 192);
		((ButtonBase)button20).FlatStyle = (FlatStyle)0;
		((Control)button20).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button20).ForeColor = Color.White;
		((ButtonBase)button20).Image = (Image)(object)Resources.w_Report;
		((ButtonBase)button20).ImageAlign = (ContentAlignment)16;
		((Control)button20).Location = new Point(10, 199);
		((Control)button20).Name = "button20";
		((Control)button20).Size = new Size(284, 52);
		((Control)button20).TabIndex = 24;
		((Control)button20).Text = "Menu Wise Sell Report";
		((ButtonBase)button20).UseVisualStyleBackColor = false;
		((Control)button20).Click += button20_Click;
		((Control)button1).BackColor = Color.Red;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button1).ForeColor = Color.White;
		((ButtonBase)button1).Image = (Image)(object)Resources.w_menu_card;
		((ButtonBase)button1).ImageAlign = (ContentAlignment)16;
		((Control)button1).Location = new Point(9, 24);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(284, 52);
		((Control)button1).TabIndex = 14;
		((Control)button1).Text = "Food Category";
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button13).BackColor = Color.Red;
		((ButtonBase)button13).FlatStyle = (FlatStyle)0;
		((Control)button13).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button13).ForeColor = Color.White;
		((ButtonBase)button13).Image = (Image)(object)Resources.w_menu_card;
		((ButtonBase)button13).ImageAlign = (ContentAlignment)16;
		((Control)button13).Location = new Point(9, 82);
		((Control)button13).Name = "button13";
		((Control)button13).Size = new Size(284, 52);
		((Control)button13).TabIndex = 15;
		((Control)button13).Text = "Food Subcategory";
		((ButtonBase)button13).UseVisualStyleBackColor = false;
		((Control)button13).Click += button13_Click;
		((Control)button14).BackColor = Color.Red;
		((ButtonBase)button14).FlatStyle = (FlatStyle)0;
		((Control)button14).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button14).ForeColor = Color.White;
		((ButtonBase)button14).Image = (Image)(object)Resources.w_menu_card;
		((ButtonBase)button14).ImageAlign = (ContentAlignment)16;
		((Control)button14).Location = new Point(9, 140);
		((Control)button14).Name = "button14";
		((Control)button14).Size = new Size(284, 52);
		((Control)button14).TabIndex = 16;
		((Control)button14).Text = "Menu Card";
		((ButtonBase)button14).UseVisualStyleBackColor = false;
		((Control)button14).Click += button14_Click;
		((Control)button25).BackColor = Color.Red;
		((ButtonBase)button25).FlatStyle = (FlatStyle)0;
		((Control)button25).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button25).ForeColor = Color.White;
		((ButtonBase)button25).Image = (Image)(object)Resources.w_purchase_histort;
		((ButtonBase)button25).ImageAlign = (ContentAlignment)16;
		((Control)button25).Location = new Point(9, 195);
		((Control)button25).Name = "button25";
		((Control)button25).Size = new Size(284, 52);
		((Control)button25).TabIndex = 30;
		((Control)button25).Text = "Purchase History";
		((ButtonBase)button25).UseVisualStyleBackColor = false;
		((Control)button25).Click += button25_Click;
		((Control)button7).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button7).FlatStyle = (FlatStyle)0;
		((Control)button7).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button7).ForeColor = Color.White;
		((ButtonBase)button7).Image = (Image)(object)Resources.w_deliveryboy;
		((ButtonBase)button7).ImageAlign = (ContentAlignment)16;
		((Control)button7).Location = new Point(41, 355);
		((Control)button7).Name = "button7";
		((Control)button7).Size = new Size(284, 52);
		((Control)button7).TabIndex = 6;
		((Control)button7).Text = "        Delivery Boy Management";
		((ButtonBase)button7).UseVisualStyleBackColor = false;
		((Control)button7).Click += button7_Click;
		((Control)button6).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button6).ForeColor = Color.White;
		((ButtonBase)button6).Image = (Image)(object)Resources.w_discount;
		((ButtonBase)button6).ImageAlign = (ContentAlignment)16;
		((Control)button6).Location = new Point(41, 297);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(284, 52);
		((Control)button6).TabIndex = 5;
		((Control)button6).Text = "Discount Management";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		((Control)button5).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button5).ForeColor = Color.White;
		((ButtonBase)button5).Image = (Image)(object)Resources.wtax;
		((ButtonBase)button5).ImageAlign = (ContentAlignment)16;
		((Control)button5).Location = new Point(41, 239);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(284, 52);
		((Control)button5).TabIndex = 4;
		((Control)button5).Text = "Tax Management";
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button4).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button4).ForeColor = Color.White;
		((ButtonBase)button4).Image = (Image)(object)Resources.w_vendor;
		((ButtonBase)button4).ImageAlign = (ContentAlignment)16;
		((Control)button4).Location = new Point(41, 181);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(284, 52);
		((Control)button4).TabIndex = 3;
		((Control)button4).Text = "Vendor Management";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Click += button4_Click;
		((Control)button3).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button3).ForeColor = Color.White;
		((ButtonBase)button3).Image = (Image)(object)Resources.w_employee;
		((ButtonBase)button3).ImageAlign = (ContentAlignment)16;
		((Control)button3).Location = new Point(41, 123);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(284, 52);
		((Control)button3).TabIndex = 2;
		((Control)button3).Text = "Employee Management";
		((ButtonBase)button3).UseVisualStyleBackColor = false;
		((Control)button3).Click += button3_Click;
		((Control)button2).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button2).ForeColor = Color.White;
		((ButtonBase)button2).Image = (Image)(object)Resources.avtar;
		((ButtonBase)button2).ImageAlign = (ContentAlignment)16;
		((Control)button2).Location = new Point(41, 65);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(284, 52);
		((Control)button2).TabIndex = 1;
		((Control)button2).Text = "Customer Management";
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button15).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button15).FlatStyle = (FlatStyle)0;
		((Control)button15).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button15).ForeColor = Color.White;
		((ButtonBase)button15).Image = (Image)(object)Resources.table_management;
		((ButtonBase)button15).ImageAlign = (ContentAlignment)16;
		((Control)button15).Location = new Point(308, 315);
		((Control)button15).Name = "button15";
		((Control)button15).Size = new Size(284, 52);
		((Control)button15).TabIndex = 18;
		((Control)button15).Text = "Table Management";
		((ButtonBase)button15).UseVisualStyleBackColor = false;
		((Control)button15).Click += button15_Click;
		((Control)button8).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button8).FlatStyle = (FlatStyle)0;
		((Control)button8).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button8).ForeColor = Color.White;
		((ButtonBase)button8).Image = (Image)(object)Resources.w_customer_transaction;
		((ButtonBase)button8).ImageAlign = (ContentAlignment)16;
		((Control)button8).Location = new Point(308, 25);
		((Control)button8).Name = "button8";
		((Control)button8).Size = new Size(284, 52);
		((Control)button8).TabIndex = 7;
		((Control)button8).Text = "Customer Transaction";
		((ButtonBase)button8).UseVisualStyleBackColor = false;
		((Control)button8).Click += button8_Click;
		((Control)button9).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button9).FlatStyle = (FlatStyle)0;
		((Control)button9).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button9).ForeColor = Color.White;
		((ButtonBase)button9).Image = (Image)(object)Resources.w_ordertype;
		((ButtonBase)button9).ImageAlign = (ContentAlignment)16;
		((Control)button9).Location = new Point(308, 83);
		((Control)button9).Name = "button9";
		((Control)button9).Size = new Size(284, 52);
		((Control)button9).TabIndex = 8;
		((Control)button9).Text = "    Order Type Mangement";
		((ButtonBase)button9).UseVisualStyleBackColor = false;
		((Control)button9).Click += button9_Click;
		((Control)button10).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button10).FlatStyle = (FlatStyle)0;
		((Control)button10).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button10).ForeColor = Color.White;
		((ButtonBase)button10).Image = (Image)(object)Resources.w_payment_mode;
		((ButtonBase)button10).ImageAlign = (ContentAlignment)16;
		((Control)button10).Location = new Point(308, 141);
		((Control)button10).Name = "button10";
		((Control)button10).Size = new Size(284, 52);
		((Control)button10).TabIndex = 9;
		((Control)button10).Text = "Payment Mode";
		((ButtonBase)button10).UseVisualStyleBackColor = false;
		((Control)button10).Click += button10_Click;
		((Control)button11).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button11).FlatStyle = (FlatStyle)0;
		((Control)button11).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button11).ForeColor = Color.White;
		((ButtonBase)button11).Image = (Image)(object)Resources.w_bank;
		((ButtonBase)button11).ImageAlign = (ContentAlignment)16;
		((Control)button11).Location = new Point(308, 199);
		((Control)button11).Name = "button11";
		((Control)button11).Size = new Size(284, 52);
		((Control)button11).TabIndex = 10;
		((Control)button11).Text = "Bank Management";
		((ButtonBase)button11).UseVisualStyleBackColor = false;
		((Control)button11).Click += button11_Click;
		((Control)button12).BackColor = Color.FromArgb(0, 174, 219);
		((ButtonBase)button12).FlatStyle = (FlatStyle)0;
		((Control)button12).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)button12).ForeColor = Color.White;
		((ButtonBase)button12).Image = (Image)(object)Resources.w_outofstock;
		((ButtonBase)button12).ImageAlign = (ContentAlignment)16;
		((Control)button12).Location = new Point(308, 257);
		((Control)button12).Name = "button12";
		((Control)button12).Size = new Size(284, 52);
		((Control)button12).TabIndex = 11;
		((Control)button12).Text = "Out Of Stock Color";
		((ButtonBase)button12).UseVisualStyleBackColor = false;
		((Control)button12).Click += button12_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(972, 705);
		((Control)this).Controls.Add((Control)(object)groupBox4);
		((Control)this).Controls.Add((Control)(object)groupBox5);
		((Control)this).Controls.Add((Control)(object)groupBox3);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)button7);
		((Control)this).Controls.Add((Control)(object)button6);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)button3);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).MaximizeBox = false;
		((Control)this).Name = "Functions";
		((MetroForm)this).Resizable = false;
		((Form)this).FormClosed += new FormClosedEventHandler(Functions_FormClosed);
		((Form)this).Load += Functions_Load;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
