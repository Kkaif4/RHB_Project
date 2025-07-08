using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Helpers;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using TMBILL.Properties;

namespace TMBILL;

public class MainFrom : MetroForm
{
	public class bindsecond
	{
		public string text;

		public double value;

		public bindsecond(string text, double valu)
		{
			this.text = text;
			value = valu;
		}
	}

	private IContainer components = null;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem mastersToolStripMenuItem;

	private ToolStripMenuItem inventoryManagementToolStripMenuItem;

	private ToolStripMenuItem tableToolStripMenuItem;

	private ToolStripMenuItem stockManagementToolStripMenuItem;

	private ToolStripMenuItem reportToolStripMenuItem;

	private ToolStripMenuItem helpToolStripMenuItem;

	private ToolStripMenuItem customerManagementToolStripMenuItem;

	private ToolStripMenuItem employeeManagementToolStripMenuItem;

	private ToolStripMenuItem vendorManagementToolStripMenuItem;

	private ToolStripMenuItem taxManagementToolStripMenuItem;

	private ToolStripMenuItem discountManagementToolStripMenuItem;

	private ToolStripMenuItem deliveryBoyManagementToolStripMenuItem;

	private ToolStripMenuItem customerTransactionDetailsToolStripMenuItem;

	private ToolStripMenuItem orderTypeManagementToolStripMenuItem;

	private ToolStripMenuItem paymentModeManagementToolStripMenuItem;

	private ToolStripMenuItem bankManagementToolStripMenuItem;

	private ToolStripMenuItem manageCategoryToolStripMenuItem;

	private ToolStripMenuItem manageSubCategoryToolStripMenuItem;

	private ToolStripMenuItem manageItemsToolStripMenuItem;

	private ToolStripMenuItem tableToolStripMenuItem1;

	private ToolStripMenuItem runningTableToolStripMenuItem;

	private ToolStripMenuItem rawMaterialCategoryToolStripMenuItem;

	private ToolStripMenuItem rawMaterialToolStripMenuItem;

	private ToolStripMenuItem unitManagementToolStripMenuItem;

	private ToolStripMenuItem recipeToolStripMenuItem;

	private ToolStripMenuItem purchaseHistoryToolStripMenuItem;

	private FlowLayoutPanel flowLayoutPanel1;

	private MetroTile metroTile1;

	private MetroTile metroTile2;

	private MetroTile metroTile3;

	private GroupBox groupBox1;

	private Label label1;

	private Label label3;

	private Label label4;

	private Label label2;

	private MetroPanel metroPanel1;

	private Label label8;

	private Label label6;

	private Label label5;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private MetroPanel metroPanel2;

	private Label label15;

	private Label label14;

	private Label label13;

	private Label label7;

	private MetroProgressBar metroProgressBar3;

	private MetroProgressBar metroProgressBar2;

	private MetroProgressBar metroProgressBar1;

	private GroupBox groupBox2;

	private ToolStripMenuItem salesReportToolStripMenuItem;

	private ToolStripMenuItem saleReportToolStripMenuItem;

	private ToolStripMenuItem stockReportToolStripMenuItem;

	private ToolStripMenuItem databaseBackupToolStripMenuItem;

	private ToolStripMenuItem outOfStockColorToolStripMenuItem;

	private ToolStripMenuItem printerManagementToolStripMenuItem;

	private ToolStripMenuItem userManagementToolStripMenuItem;

	private ToolStripMenuItem userPermissionToolStripMenuItem;

	private ToolStripMenuItem printerHeaderToolStripMenuItem;

	private ToolStripMenuItem hotelInformationToolStripMenuItem;

	private PieChart pieChart1;

	private GroupBox groupBox3;

	private ToolStripMenuItem menuWiseSellReportToolStripMenuItem;

	private PieChart pieChart2;

	private Label label16;

	private MetroDateTime metroDateTime2;

	private MetroDateTime metroDateTime1;

	private Label label17;

	private ListBox listBox1;

	private MetroTile metroTile4;

	public static MainFrom static_mainform;

	private List<bindsecond> arr = new List<bindsecond>();

	private string bo = "false";

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
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected O, but got Unknown
		//IL_1e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1c: Expected O, but got Unknown
		//IL_1f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f28: Expected O, but got Unknown
		//IL_203b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2045: Expected O, but got Unknown
		//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cb: Expected O, but got Unknown
		//IL_2686: Unknown result type (might be due to invalid IL or missing references)
		//IL_2690: Expected O, but got Unknown
		//IL_26d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26db: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainFrom));
		menuStrip1 = new MenuStrip();
		mastersToolStripMenuItem = new ToolStripMenuItem();
		customerManagementToolStripMenuItem = new ToolStripMenuItem();
		employeeManagementToolStripMenuItem = new ToolStripMenuItem();
		vendorManagementToolStripMenuItem = new ToolStripMenuItem();
		taxManagementToolStripMenuItem = new ToolStripMenuItem();
		discountManagementToolStripMenuItem = new ToolStripMenuItem();
		deliveryBoyManagementToolStripMenuItem = new ToolStripMenuItem();
		customerTransactionDetailsToolStripMenuItem = new ToolStripMenuItem();
		orderTypeManagementToolStripMenuItem = new ToolStripMenuItem();
		paymentModeManagementToolStripMenuItem = new ToolStripMenuItem();
		bankManagementToolStripMenuItem = new ToolStripMenuItem();
		outOfStockColorToolStripMenuItem = new ToolStripMenuItem();
		inventoryManagementToolStripMenuItem = new ToolStripMenuItem();
		manageCategoryToolStripMenuItem = new ToolStripMenuItem();
		manageSubCategoryToolStripMenuItem = new ToolStripMenuItem();
		manageItemsToolStripMenuItem = new ToolStripMenuItem();
		tableToolStripMenuItem = new ToolStripMenuItem();
		tableToolStripMenuItem1 = new ToolStripMenuItem();
		runningTableToolStripMenuItem = new ToolStripMenuItem();
		stockManagementToolStripMenuItem = new ToolStripMenuItem();
		rawMaterialCategoryToolStripMenuItem = new ToolStripMenuItem();
		rawMaterialToolStripMenuItem = new ToolStripMenuItem();
		unitManagementToolStripMenuItem = new ToolStripMenuItem();
		recipeToolStripMenuItem = new ToolStripMenuItem();
		purchaseHistoryToolStripMenuItem = new ToolStripMenuItem();
		reportToolStripMenuItem = new ToolStripMenuItem();
		salesReportToolStripMenuItem = new ToolStripMenuItem();
		saleReportToolStripMenuItem = new ToolStripMenuItem();
		stockReportToolStripMenuItem = new ToolStripMenuItem();
		menuWiseSellReportToolStripMenuItem = new ToolStripMenuItem();
		helpToolStripMenuItem = new ToolStripMenuItem();
		databaseBackupToolStripMenuItem = new ToolStripMenuItem();
		printerManagementToolStripMenuItem = new ToolStripMenuItem();
		userManagementToolStripMenuItem = new ToolStripMenuItem();
		userPermissionToolStripMenuItem = new ToolStripMenuItem();
		printerHeaderToolStripMenuItem = new ToolStripMenuItem();
		hotelInformationToolStripMenuItem = new ToolStripMenuItem();
		flowLayoutPanel1 = new FlowLayoutPanel();
		metroTile1 = new MetroTile();
		metroTile2 = new MetroTile();
		metroTile3 = new MetroTile();
		groupBox1 = new GroupBox();
		metroPanel2 = new MetroPanel();
		metroProgressBar3 = new MetroProgressBar();
		metroProgressBar2 = new MetroProgressBar();
		metroProgressBar1 = new MetroProgressBar();
		label15 = new Label();
		label14 = new Label();
		label13 = new Label();
		metroPanel1 = new MetroPanel();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label3 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		groupBox2 = new GroupBox();
		pieChart1 = new PieChart();
		groupBox3 = new GroupBox();
		listBox1 = new ListBox();
		label17 = new Label();
		label16 = new Label();
		metroDateTime2 = new MetroDateTime();
		metroDateTime1 = new MetroDateTime();
		pieChart2 = new PieChart();
		metroTile4 = new MetroTile();
		((Control)menuStrip1).SuspendLayout();
		((Control)flowLayoutPanel1).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)metroPanel2).SuspendLayout();
		((Control)metroPanel1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).BackColor = Color.FromArgb(0, 174, 219);
		((Control)menuStrip1).Font = new Font("Segoe UI", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((ToolStrip)menuStrip1).Items.AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)mastersToolStripMenuItem,
			(ToolStripItem)inventoryManagementToolStripMenuItem,
			(ToolStripItem)tableToolStripMenuItem,
			(ToolStripItem)stockManagementToolStripMenuItem,
			(ToolStripItem)reportToolStripMenuItem,
			(ToolStripItem)helpToolStripMenuItem
		});
		((Control)menuStrip1).Location = new Point(20, 60);
		((Control)menuStrip1).Name = "menuStrip1";
		((Control)menuStrip1).Size = new Size(1218, 28);
		((Control)menuStrip1).TabIndex = 0;
		((Control)menuStrip1).Text = "menuStrip1";
		((ToolStripDropDownItem)mastersToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)customerManagementToolStripMenuItem,
			(ToolStripItem)employeeManagementToolStripMenuItem,
			(ToolStripItem)vendorManagementToolStripMenuItem,
			(ToolStripItem)taxManagementToolStripMenuItem,
			(ToolStripItem)discountManagementToolStripMenuItem,
			(ToolStripItem)deliveryBoyManagementToolStripMenuItem,
			(ToolStripItem)customerTransactionDetailsToolStripMenuItem,
			(ToolStripItem)orderTypeManagementToolStripMenuItem,
			(ToolStripItem)paymentModeManagementToolStripMenuItem,
			(ToolStripItem)bankManagementToolStripMenuItem,
			(ToolStripItem)outOfStockColorToolStripMenuItem
		});
		((ToolStripItem)mastersToolStripMenuItem).Name = "mastersToolStripMenuItem";
		((ToolStripItem)mastersToolStripMenuItem).Size = new Size(83, 24);
		((ToolStripItem)mastersToolStripMenuItem).Text = "Functions";
		((ToolStripItem)customerManagementToolStripMenuItem).Name = "customerManagementToolStripMenuItem";
		((ToolStripItem)customerManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)customerManagementToolStripMenuItem).Text = "Customer Management";
		((ToolStripItem)customerManagementToolStripMenuItem).Click += customerManagementToolStripMenuItem_Click;
		((ToolStripItem)employeeManagementToolStripMenuItem).Name = "employeeManagementToolStripMenuItem";
		((ToolStripItem)employeeManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)employeeManagementToolStripMenuItem).Text = "Employee Management";
		((ToolStripItem)employeeManagementToolStripMenuItem).Click += employeeManagementToolStripMenuItem_Click;
		((ToolStripItem)vendorManagementToolStripMenuItem).Name = "vendorManagementToolStripMenuItem";
		((ToolStripItem)vendorManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)vendorManagementToolStripMenuItem).Text = "Vendor Management";
		((ToolStripItem)vendorManagementToolStripMenuItem).Click += vendorManagementToolStripMenuItem_Click;
		((ToolStripItem)taxManagementToolStripMenuItem).Name = "taxManagementToolStripMenuItem";
		((ToolStripItem)taxManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)taxManagementToolStripMenuItem).Text = "Tax Management";
		((ToolStripItem)taxManagementToolStripMenuItem).Click += taxManagementToolStripMenuItem_Click;
		((ToolStripItem)discountManagementToolStripMenuItem).Name = "discountManagementToolStripMenuItem";
		((ToolStripItem)discountManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)discountManagementToolStripMenuItem).Text = "Discount Management";
		((ToolStripItem)discountManagementToolStripMenuItem).Click += discountManagementToolStripMenuItem_Click;
		((ToolStripItem)deliveryBoyManagementToolStripMenuItem).Name = "deliveryBoyManagementToolStripMenuItem";
		((ToolStripItem)deliveryBoyManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)deliveryBoyManagementToolStripMenuItem).Text = "Delivery Boy Management";
		((ToolStripItem)deliveryBoyManagementToolStripMenuItem).Click += deliveryBoyManagementToolStripMenuItem_Click;
		((ToolStripItem)customerTransactionDetailsToolStripMenuItem).Name = "customerTransactionDetailsToolStripMenuItem";
		((ToolStripItem)customerTransactionDetailsToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)customerTransactionDetailsToolStripMenuItem).Text = "Customer Transaction Details";
		((ToolStripItem)customerTransactionDetailsToolStripMenuItem).Click += customerTransactionDetailsToolStripMenuItem_Click;
		((ToolStripItem)orderTypeManagementToolStripMenuItem).Name = "orderTypeManagementToolStripMenuItem";
		((ToolStripItem)orderTypeManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)orderTypeManagementToolStripMenuItem).Text = "Order Type Management";
		((ToolStripItem)orderTypeManagementToolStripMenuItem).Click += orderTypeManagementToolStripMenuItem_Click;
		((ToolStripItem)paymentModeManagementToolStripMenuItem).Name = "paymentModeManagementToolStripMenuItem";
		((ToolStripItem)paymentModeManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)paymentModeManagementToolStripMenuItem).Text = "Payment Mode Management";
		((ToolStripItem)paymentModeManagementToolStripMenuItem).Click += paymentModeManagementToolStripMenuItem_Click;
		((ToolStripItem)bankManagementToolStripMenuItem).Name = "bankManagementToolStripMenuItem";
		((ToolStripItem)bankManagementToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)bankManagementToolStripMenuItem).Text = "Bank Management";
		((ToolStripItem)bankManagementToolStripMenuItem).Click += bankManagementToolStripMenuItem_Click;
		((ToolStripItem)outOfStockColorToolStripMenuItem).Name = "outOfStockColorToolStripMenuItem";
		((ToolStripItem)outOfStockColorToolStripMenuItem).Size = new Size(294, 24);
		((ToolStripItem)outOfStockColorToolStripMenuItem).Text = "Out Of Stock Color Management";
		((ToolStripItem)outOfStockColorToolStripMenuItem).Click += outOfStockColorToolStripMenuItem_Click;
		((ToolStripDropDownItem)inventoryManagementToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)manageCategoryToolStripMenuItem,
			(ToolStripItem)manageSubCategoryToolStripMenuItem,
			(ToolStripItem)manageItemsToolStripMenuItem
		});
		((ToolStripItem)inventoryManagementToolStripMenuItem).Name = "inventoryManagementToolStripMenuItem";
		((ToolStripItem)inventoryManagementToolStripMenuItem).Size = new Size(93, 24);
		((ToolStripItem)inventoryManagementToolStripMenuItem).Text = "Menu Card";
		((ToolStripItem)manageCategoryToolStripMenuItem).Name = "manageCategoryToolStripMenuItem";
		((ToolStripItem)manageCategoryToolStripMenuItem).Size = new Size(207, 24);
		((ToolStripItem)manageCategoryToolStripMenuItem).Text = "Food Category";
		((ToolStripItem)manageCategoryToolStripMenuItem).Click += manageCategoryToolStripMenuItem_Click;
		((ToolStripItem)manageSubCategoryToolStripMenuItem).Name = "manageSubCategoryToolStripMenuItem";
		((ToolStripItem)manageSubCategoryToolStripMenuItem).Size = new Size(207, 24);
		((ToolStripItem)manageSubCategoryToolStripMenuItem).Text = "Food Sub-Category";
		((ToolStripItem)manageSubCategoryToolStripMenuItem).Click += manageSubCategoryToolStripMenuItem_Click;
		((ToolStripItem)manageItemsToolStripMenuItem).Name = "manageItemsToolStripMenuItem";
		((ToolStripItem)manageItemsToolStripMenuItem).Size = new Size(207, 24);
		((ToolStripItem)manageItemsToolStripMenuItem).Text = "Menu Card";
		((ToolStripItem)manageItemsToolStripMenuItem).Click += manageItemsToolStripMenuItem_Click;
		((ToolStripDropDownItem)tableToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)tableToolStripMenuItem1,
			(ToolStripItem)runningTableToolStripMenuItem
		});
		((ToolStripItem)tableToolStripMenuItem).Name = "tableToolStripMenuItem";
		((ToolStripItem)tableToolStripMenuItem).Size = new Size(56, 24);
		((ToolStripItem)tableToolStripMenuItem).Text = "Table";
		((ToolStripItem)tableToolStripMenuItem1).Name = "tableToolStripMenuItem1";
		((ToolStripItem)tableToolStripMenuItem1).Size = new Size(205, 24);
		((ToolStripItem)tableToolStripMenuItem1).Text = "Table Management";
		((ToolStripItem)tableToolStripMenuItem1).Click += tableToolStripMenuItem1_Click;
		((ToolStripItem)runningTableToolStripMenuItem).Name = "runningTableToolStripMenuItem";
		((ToolStripItem)runningTableToolStripMenuItem).Size = new Size(205, 24);
		((ToolStripItem)runningTableToolStripMenuItem).Text = "Running Table";
		((ToolStripItem)runningTableToolStripMenuItem).Click += runningTableToolStripMenuItem_Click;
		((ToolStripDropDownItem)stockManagementToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)rawMaterialCategoryToolStripMenuItem,
			(ToolStripItem)rawMaterialToolStripMenuItem,
			(ToolStripItem)unitManagementToolStripMenuItem,
			(ToolStripItem)recipeToolStripMenuItem,
			(ToolStripItem)purchaseHistoryToolStripMenuItem
		});
		((ToolStripItem)stockManagementToolStripMenuItem).Name = "stockManagementToolStripMenuItem";
		((ToolStripItem)stockManagementToolStripMenuItem).Size = new Size(200, 24);
		((ToolStripItem)stockManagementToolStripMenuItem).Text = "Raw Material Management";
		((ToolStripItem)rawMaterialCategoryToolStripMenuItem).Name = "rawMaterialCategoryToolStripMenuItem";
		((ToolStripItem)rawMaterialCategoryToolStripMenuItem).Size = new Size(229, 24);
		((ToolStripItem)rawMaterialCategoryToolStripMenuItem).Text = "Raw Material Category";
		((ToolStripItem)rawMaterialCategoryToolStripMenuItem).Click += rawMaterialCategoryToolStripMenuItem_Click;
		((ToolStripItem)rawMaterialToolStripMenuItem).Name = "rawMaterialToolStripMenuItem";
		((ToolStripItem)rawMaterialToolStripMenuItem).Size = new Size(229, 24);
		((ToolStripItem)rawMaterialToolStripMenuItem).Text = "Raw Material";
		((ToolStripItem)rawMaterialToolStripMenuItem).Click += rawMaterialToolStripMenuItem_Click;
		((ToolStripItem)unitManagementToolStripMenuItem).Name = "unitManagementToolStripMenuItem";
		((ToolStripItem)unitManagementToolStripMenuItem).Size = new Size(229, 24);
		((ToolStripItem)unitManagementToolStripMenuItem).Text = "Unit Management";
		((ToolStripItem)unitManagementToolStripMenuItem).Click += unitManagementToolStripMenuItem_Click;
		((ToolStripItem)recipeToolStripMenuItem).Name = "recipeToolStripMenuItem";
		((ToolStripItem)recipeToolStripMenuItem).Size = new Size(229, 24);
		((ToolStripItem)recipeToolStripMenuItem).Text = "Recipe";
		((ToolStripItem)recipeToolStripMenuItem).Click += recipeToolStripMenuItem_Click;
		((ToolStripItem)purchaseHistoryToolStripMenuItem).Name = "purchaseHistoryToolStripMenuItem";
		((ToolStripItem)purchaseHistoryToolStripMenuItem).Size = new Size(229, 24);
		((ToolStripItem)purchaseHistoryToolStripMenuItem).Text = "Purchase History";
		((ToolStripItem)purchaseHistoryToolStripMenuItem).Click += purchaseHistoryToolStripMenuItem_Click;
		((ToolStripDropDownItem)reportToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)salesReportToolStripMenuItem,
			(ToolStripItem)saleReportToolStripMenuItem,
			(ToolStripItem)stockReportToolStripMenuItem,
			(ToolStripItem)menuWiseSellReportToolStripMenuItem
		});
		((ToolStripItem)reportToolStripMenuItem).Name = "reportToolStripMenuItem";
		((ToolStripItem)reportToolStripMenuItem).Size = new Size(66, 24);
		((ToolStripItem)reportToolStripMenuItem).Text = "Report";
		((ToolStripItem)salesReportToolStripMenuItem).Name = "salesReportToolStripMenuItem";
		((ToolStripItem)salesReportToolStripMenuItem).Size = new Size(228, 24);
		((ToolStripItem)salesReportToolStripMenuItem).Text = "Bill Report";
		((ToolStripItem)salesReportToolStripMenuItem).Click += salesReportToolStripMenuItem_Click;
		((ToolStripItem)saleReportToolStripMenuItem).Name = "saleReportToolStripMenuItem";
		((ToolStripItem)saleReportToolStripMenuItem).Size = new Size(228, 24);
		((ToolStripItem)saleReportToolStripMenuItem).Text = "Sale Report";
		((ToolStripItem)saleReportToolStripMenuItem).Click += saleReportToolStripMenuItem_Click;
		((ToolStripItem)stockReportToolStripMenuItem).Name = "stockReportToolStripMenuItem";
		((ToolStripItem)stockReportToolStripMenuItem).Size = new Size(228, 24);
		((ToolStripItem)stockReportToolStripMenuItem).Text = "Stock Report";
		((ToolStripItem)stockReportToolStripMenuItem).Click += stockReportToolStripMenuItem_Click;
		((ToolStripItem)menuWiseSellReportToolStripMenuItem).Name = "menuWiseSellReportToolStripMenuItem";
		((ToolStripItem)menuWiseSellReportToolStripMenuItem).Size = new Size(228, 24);
		((ToolStripItem)menuWiseSellReportToolStripMenuItem).Text = "Menu Wise Sell Report";
		((ToolStripItem)menuWiseSellReportToolStripMenuItem).Click += menuWiseSellReportToolStripMenuItem_Click;
		((ToolStripDropDownItem)helpToolStripMenuItem).DropDownItems.AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)databaseBackupToolStripMenuItem,
			(ToolStripItem)printerManagementToolStripMenuItem,
			(ToolStripItem)userManagementToolStripMenuItem,
			(ToolStripItem)userPermissionToolStripMenuItem,
			(ToolStripItem)printerHeaderToolStripMenuItem,
			(ToolStripItem)hotelInformationToolStripMenuItem
		});
		((ToolStripItem)helpToolStripMenuItem).Name = "helpToolStripMenuItem";
		((ToolStripItem)helpToolStripMenuItem).Size = new Size(74, 24);
		((ToolStripItem)helpToolStripMenuItem).Text = "Settings";
		((ToolStripItem)databaseBackupToolStripMenuItem).Name = "databaseBackupToolStripMenuItem";
		((ToolStripItem)databaseBackupToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)databaseBackupToolStripMenuItem).Text = "Database Backup && Restore";
		((ToolStripItem)databaseBackupToolStripMenuItem).Click += databaseBackupToolStripMenuItem_Click;
		((ToolStripItem)printerManagementToolStripMenuItem).Name = "printerManagementToolStripMenuItem";
		((ToolStripItem)printerManagementToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)printerManagementToolStripMenuItem).Text = "Printer Management";
		((ToolStripItem)printerManagementToolStripMenuItem).Click += printerManagementToolStripMenuItem_Click_1;
		((ToolStripItem)userManagementToolStripMenuItem).Name = "userManagementToolStripMenuItem";
		((ToolStripItem)userManagementToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)userManagementToolStripMenuItem).Text = "User Management";
		((ToolStripItem)userManagementToolStripMenuItem).Click += userManagementToolStripMenuItem_Click;
		((ToolStripItem)userPermissionToolStripMenuItem).Name = "userPermissionToolStripMenuItem";
		((ToolStripItem)userPermissionToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)userPermissionToolStripMenuItem).Text = "User Permission";
		((ToolStripItem)userPermissionToolStripMenuItem).Click += userPermissionToolStripMenuItem_Click;
		((ToolStripItem)printerHeaderToolStripMenuItem).Name = "printerHeaderToolStripMenuItem";
		((ToolStripItem)printerHeaderToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)printerHeaderToolStripMenuItem).Text = "Printer Header && Footer";
		((ToolStripItem)printerHeaderToolStripMenuItem).Click += printerHeaderToolStripMenuItem_Click;
		((ToolStripItem)hotelInformationToolStripMenuItem).Name = "hotelInformationToolStripMenuItem";
		((ToolStripItem)hotelInformationToolStripMenuItem).Size = new Size(263, 24);
		((ToolStripItem)hotelInformationToolStripMenuItem).Text = "Hotel Information";
		((ToolStripItem)hotelInformationToolStripMenuItem).Click += hotelInformationToolStripMenuItem_Click;
		((Control)flowLayoutPanel1).Anchor = (AnchorStyles)7;
		((Control)flowLayoutPanel1).Controls.Add((Control)(object)metroTile1);
		((Control)flowLayoutPanel1).Controls.Add((Control)(object)metroTile2);
		((Control)flowLayoutPanel1).Controls.Add((Control)(object)metroTile3);
		((Control)flowLayoutPanel1).Controls.Add((Control)(object)metroTile4);
		((Control)flowLayoutPanel1).Location = new Point(20, 91);
		((Control)flowLayoutPanel1).Name = "flowLayoutPanel1";
		((Control)flowLayoutPanel1).Size = new Size(135, 623);
		((Control)flowLayoutPanel1).TabIndex = 1;
		metroTile1.ActiveControl = null;
		((Control)metroTile1).Location = new Point(3, 3);
		((Control)metroTile1).Name = "metroTile1";
		((Control)metroTile1).Size = new Size(123, 123);
		metroTile1.Style = (MetroColorStyle)5;
		((Control)metroTile1).TabIndex = 0;
		((Control)metroTile1).Text = "Order";
		metroTile1.TileTextFontSize = (MetroTileTextSize)2;
		metroTile1.TileTextFontWeight = (MetroTileTextWeight)2;
		metroTile1.UseSelectable = true;
		((Control)metroTile1).Click += metroTile1_Click;
		metroTile2.ActiveControl = null;
		((Control)metroTile2).Location = new Point(3, 132);
		((Control)metroTile2).Name = "metroTile2";
		((Control)metroTile2).Size = new Size(123, 123);
		metroTile2.Style = (MetroColorStyle)13;
		((Control)metroTile2).TabIndex = 1;
		((Control)metroTile2).Text = "Receipts";
		metroTile2.TileTextFontSize = (MetroTileTextSize)2;
		metroTile2.TileTextFontWeight = (MetroTileTextWeight)2;
		metroTile2.UseSelectable = true;
		((Control)metroTile2).Click += metroTile2_Click;
		metroTile3.ActiveControl = null;
		((Control)metroTile3).Location = new Point(3, 261);
		((Control)metroTile3).Name = "metroTile3";
		((Control)metroTile3).Size = new Size(123, 123);
		metroTile3.Style = (MetroColorStyle)8;
		((Control)metroTile3).TabIndex = 2;
		((Control)metroTile3).Text = "Purchase";
		metroTile3.TileTextFontSize = (MetroTileTextSize)2;
		metroTile3.TileTextFontWeight = (MetroTileTextWeight)2;
		metroTile3.UseSelectable = true;
		((Control)metroTile3).Click += metroTile3_Click;
		((Control)groupBox1).Anchor = (AnchorStyles)13;
		((Control)groupBox1).Controls.Add((Control)(object)metroPanel2);
		((Control)groupBox1).Controls.Add((Control)(object)metroPanel1);
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)label4);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox1).Location = new Point(161, 94);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(1077, 123);
		((Control)groupBox1).TabIndex = 2;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Sell Satat";
		((Control)metroPanel2).Anchor = (AnchorStyles)13;
		((Panel)metroPanel2).BorderStyle = (BorderStyle)1;
		((Control)metroPanel2).Controls.Add((Control)(object)metroProgressBar3);
		((Control)metroPanel2).Controls.Add((Control)(object)metroProgressBar2);
		((Control)metroPanel2).Controls.Add((Control)(object)metroProgressBar1);
		((Control)metroPanel2).Controls.Add((Control)(object)label15);
		((Control)metroPanel2).Controls.Add((Control)(object)label14);
		((Control)metroPanel2).Controls.Add((Control)(object)label13);
		metroPanel2.HorizontalScrollbarBarColor = true;
		metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
		metroPanel2.HorizontalScrollbarSize = 10;
		((Control)metroPanel2).Location = new Point(777, 13);
		((Control)metroPanel2).Name = "metroPanel2";
		((Control)metroPanel2).Size = new Size(294, 104);
		((Control)metroPanel2).TabIndex = 5;
		metroPanel2.VerticalScrollbarBarColor = true;
		metroPanel2.VerticalScrollbarHighlightOnWheel = false;
		metroPanel2.VerticalScrollbarSize = 10;
		((Control)metroProgressBar3).Anchor = (AnchorStyles)13;
		metroProgressBar3.FontWeight = (MetroProgressBarWeight)1;
		metroProgressBar3.HideProgressText = false;
		((Control)metroProgressBar3).Location = new Point(114, 71);
		((Control)metroProgressBar3).Name = "metroProgressBar3";
		((Control)metroProgressBar3).Size = new Size(164, 23);
		metroProgressBar3.Style = (MetroColorStyle)10;
		((Control)metroProgressBar3).TabIndex = 14;
		((Control)metroProgressBar2).Anchor = (AnchorStyles)13;
		metroProgressBar2.FontWeight = (MetroProgressBarWeight)1;
		metroProgressBar2.HideProgressText = false;
		((Control)metroProgressBar2).Location = new Point(114, 40);
		((Control)metroProgressBar2).Name = "metroProgressBar2";
		((Control)metroProgressBar2).Size = new Size(164, 23);
		metroProgressBar2.Style = (MetroColorStyle)6;
		((Control)metroProgressBar2).TabIndex = 13;
		((Control)metroProgressBar1).Anchor = (AnchorStyles)13;
		metroProgressBar1.FontWeight = (MetroProgressBarWeight)1;
		metroProgressBar1.HideProgressText = false;
		((Control)metroProgressBar1).Location = new Point(114, 9);
		((Control)metroProgressBar1).Name = "metroProgressBar1";
		((Control)metroProgressBar1).Size = new Size(164, 23);
		metroProgressBar1.Style = (MetroColorStyle)11;
		((Control)metroProgressBar1).TabIndex = 12;
		((Control)label15).AutoSize = true;
		((Control)label15).Location = new Point(3, 71);
		((Control)label15).Name = "label15";
		((Control)label15).Size = new Size(105, 18);
		((Control)label15).TabIndex = 11;
		((Control)label15).Text = "Home Delivery";
		((Control)label14).AutoSize = true;
		((Control)label14).Location = new Point(28, 40);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(80, 18);
		((Control)label14).TabIndex = 6;
		((Control)label14).Text = "Take Away";
		((Control)label13).AutoSize = true;
		((Control)label13).Location = new Point(55, 9);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(53, 18);
		((Control)label13).TabIndex = 5;
		((Control)label13).Text = "Dine In";
		((Panel)metroPanel1).BorderStyle = (BorderStyle)1;
		((Control)metroPanel1).Controls.Add((Control)(object)label12);
		((Control)metroPanel1).Controls.Add((Control)(object)label11);
		((Control)metroPanel1).Controls.Add((Control)(object)label10);
		((Control)metroPanel1).Controls.Add((Control)(object)label9);
		((Control)metroPanel1).Controls.Add((Control)(object)label8);
		((Control)metroPanel1).Controls.Add((Control)(object)label7);
		((Control)metroPanel1).Controls.Add((Control)(object)label6);
		((Control)metroPanel1).Controls.Add((Control)(object)label5);
		metroPanel1.HorizontalScrollbarBarColor = true;
		metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
		metroPanel1.HorizontalScrollbarSize = 10;
		((Control)metroPanel1).Location = new Point(268, 13);
		((Control)metroPanel1).Name = "metroPanel1";
		((Control)metroPanel1).Size = new Size(503, 104);
		((Control)metroPanel1).TabIndex = 4;
		metroPanel1.VerticalScrollbarBarColor = true;
		metroPanel1.VerticalScrollbarHighlightOnWheel = false;
		metroPanel1.VerticalScrollbarSize = 10;
		((Control)label12).AutoSize = true;
		((Control)label12).Location = new Point(417, 69);
		((Control)label12).Name = "label12";
		((Control)label12).Size = new Size(32, 18);
		((Control)label12).TabIndex = 10;
		((Control)label12).Text = "800";
		((Control)label11).AutoSize = true;
		((Control)label11).Location = new Point(291, 69);
		((Control)label11).Name = "label11";
		((Control)label11).Size = new Size(32, 18);
		((Control)label11).TabIndex = 9;
		((Control)label11).Text = "800";
		((Control)label10).AutoSize = true;
		((Control)label10).Location = new Point(162, 69);
		((Control)label10).Name = "label10";
		((Control)label10).Size = new Size(32, 18);
		((Control)label10).TabIndex = 8;
		((Control)label10).Text = "800";
		((Control)label9).AutoSize = true;
		((Control)label9).Location = new Point(48, 69);
		((Control)label9).Name = "label9";
		((Control)label9).Size = new Size(32, 18);
		((Control)label9).TabIndex = 7;
		((Control)label9).Text = "700";
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(381, 22);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(105, 18);
		((Control)label8).TabIndex = 6;
		((Control)label8).Text = "Home Delivery";
		((Control)label7).AutoSize = true;
		((Control)label7).Location = new Point(267, 22);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(80, 18);
		((Control)label7).TabIndex = 5;
		((Control)label7).Text = "Take Away";
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(152, 22);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(53, 18);
		((Control)label6).TabIndex = 4;
		((Control)label6).Text = "Dine In";
		((Control)label5).AutoSize = true;
		((Control)label5).Location = new Point(19, 22);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(91, 18);
		((Control)label5).TabIndex = 3;
		((Control)label5).Text = "Total Orders";
		((Control)label3).AutoSize = true;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label3).ForeColor = Color.FromArgb(0, 174, 219);
		((Control)label3).Location = new Point(155, 78);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(84, 18);
		((Control)label3).TabIndex = 3;
		((Control)label3).Text = "Rs. 00000";
		((Control)label4).AutoSize = true;
		((Control)label4).Location = new Point(155, 37);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(88, 18);
		((Control)label4).TabIndex = 2;
		((Control)label4).Text = "Monthly Sell";
		((Control)label2).AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label2).ForeColor = Color.FromArgb(0, 174, 219);
		((Control)label2).Location = new Point(25, 78);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(84, 18);
		((Control)label2).TabIndex = 1;
		((Control)label2).Text = "Rs. 00000";
		((Control)label1).AutoSize = true;
		((Control)label1).Location = new Point(21, 37);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(88, 18);
		((Control)label1).TabIndex = 0;
		((Control)label1).Text = "Today's Sell";
		((Control)groupBox2).Anchor = (AnchorStyles)7;
		((Control)groupBox2).Controls.Add((Control)(object)pieChart1);
		((Control)groupBox2).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox2).Location = new Point(161, 223);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(463, 482);
		((Control)groupBox2).TabIndex = 3;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Last 7 Days Sell Report";
		((Control)pieChart1).Location = new Point(6, 23);
		((Control)pieChart1).Name = "pieChart1";
		((Control)pieChart1).Size = new Size(441, 439);
		((Control)pieChart1).TabIndex = 0;
		((Control)pieChart1).Text = "pieChart1";
		((Control)groupBox3).Anchor = (AnchorStyles)15;
		((Control)groupBox3).Controls.Add((Control)(object)listBox1);
		((Control)groupBox3).Controls.Add((Control)(object)label17);
		((Control)groupBox3).Controls.Add((Control)(object)label16);
		((Control)groupBox3).Controls.Add((Control)(object)metroDateTime2);
		((Control)groupBox3).Controls.Add((Control)(object)metroDateTime1);
		((Control)groupBox3).Controls.Add((Control)(object)pieChart2);
		((Control)groupBox3).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)groupBox3).Location = new Point(630, 223);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(608, 482);
		((Control)groupBox3).TabIndex = 4;
		groupBox3.TabStop = false;
		((Control)groupBox3).Text = "Top Sell Items";
		((Control)listBox1).Anchor = (AnchorStyles)15;
		((ListControl)listBox1).FormattingEnabled = true;
		listBox1.ItemHeight = 18;
		((Control)listBox1).Location = new Point(420, 74);
		((Control)listBox1).Name = "listBox1";
		listBox1.SelectionMode = (SelectionMode)2;
		((Control)listBox1).Size = new Size(167, 382);
		((Control)listBox1).TabIndex = 6;
		listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
		((Control)label17).AutoSize = true;
		((Control)label17).Location = new Point(308, 30);
		((Control)label17).Name = "label17";
		((Control)label17).Size = new Size(26, 18);
		((Control)label17).TabIndex = 5;
		((Control)label17).Text = "To";
		((Control)label16).AutoSize = true;
		((Control)label16).Location = new Point(23, 28);
		((Control)label16).Name = "label16";
		((Control)label16).Size = new Size(44, 18);
		((Control)label16).TabIndex = 4;
		((Control)label16).Text = "From";
		((DateTimePicker)metroDateTime2).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime2).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime2).Location = new Point(340, 23);
		((Control)metroDateTime2).MinimumSize = new Size(0, 29);
		((Control)metroDateTime2).Name = "metroDateTime2";
		((Control)metroDateTime2).Size = new Size(200, 29);
		((Control)metroDateTime2).TabIndex = 3;
		((DateTimePicker)metroDateTime2).ValueChanged += metroDateTime2_ValueChanged;
		((DateTimePicker)metroDateTime1).CustomFormat = "dd/MM/yyyy";
		((DateTimePicker)metroDateTime1).Format = (DateTimePickerFormat)8;
		((Control)metroDateTime1).Location = new Point(86, 23);
		((Control)metroDateTime1).MinimumSize = new Size(0, 29);
		((Control)metroDateTime1).Name = "metroDateTime1";
		((Control)metroDateTime1).Size = new Size(200, 29);
		((Control)metroDateTime1).TabIndex = 2;
		((DateTimePicker)metroDateTime1).ValueChanged += metroDateTime1_ValueChanged;
		((Control)pieChart2).Anchor = (AnchorStyles)7;
		((Control)pieChart2).Location = new Point(25, 74);
		((Control)pieChart2).Name = "pieChart2";
		((Control)pieChart2).Size = new Size(392, 385);
		((Control)pieChart2).TabIndex = 0;
		((Control)pieChart2).Text = "pieChart2";
		metroTile4.ActiveControl = null;
		((Control)metroTile4).Location = new Point(3, 390);
		((Control)metroTile4).Name = "metroTile4";
		((Control)metroTile4).Size = new Size(123, 123);
		((Control)metroTile4).TabIndex = 3;
		((Control)metroTile4).Text = "Functions";
		metroTile4.TileTextFontSize = (MetroTileTextSize)2;
		metroTile4.TileTextFontWeight = (MetroTileTextWeight)2;
		metroTile4.UseSelectable = true;
		((Control)metroTile4).Click += metroTile4_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).ClientSize = new Size(1258, 728);
		((Control)this).Controls.Add((Control)(object)groupBox3);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Controls.Add((Control)(object)flowLayoutPanel1);
		((Control)this).Controls.Add((Control)(object)menuStrip1);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MainMenuStrip = menuStrip1;
		((Control)this).Name = "MainFrom";
		((Control)this).Text = "Dashboard";
		((Form)this).Activated += MainFrom_Activated;
		((Form)this).FormClosed += new FormClosedEventHandler(MainFrom_FormClosed);
		((Form)this).Load += MainFrom_Load;
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)flowLayoutPanel1).ResumeLayout(false);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)metroPanel2).ResumeLayout(false);
		((Control)metroPanel2).PerformLayout();
		((Control)metroPanel1).ResumeLayout(false);
		((Control)metroPanel1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public MainFrom()
	{
		InitializeComponent();
		static_mainform = this;
		((Control)menuStrip1).Visible = false;
	}

	private void Bindchekc()
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		listBox1.Items.Clear();
		arr.Clear();
		string commandText = "SELECT itemname,SUM(total) AS total FROM (SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_invoice_home_detail WHERE (invoice_id IN (SELECT id FROM r_invoice_home WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname UNION SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_invoice_detail WHERE (invoice_id IN (SELECT id FROM r_invoice WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname UNION SELECT itemname, SUM(CAST(qty AS int)) AS total FROM r_takeaway_detail WHERE (invoice_id IN (SELECT id FROM r_invoice_takeaway WHERE (CONVERT(date, mydate, 103) BETWEEN CONVERT(date, '" + ((Control)metroDateTime1).Text + "', 103) AND CONVERT(date, '" + ((Control)metroDateTime2).Text + "', 103)))) GROUP BY itemname) AS derivedtbl_1 GROUP BY itemname ORDER BY total DESC";
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = commandText;
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					int num = 0;
					while (((DbDataReader)(object)val3).Read())
					{
						string text = ((DbDataReader)(object)val3)[0].ToString();
						listBox1.Items.Add((object)text);
						double valu = double.Parse(((DbDataReader)(object)val3)[1].ToString());
						arr.Add(new bindsecond(text, valu));
						if (num < 7)
						{
							listBox1.SetSelected(num, true);
						}
						num++;
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
		BindPiechart();
	}

	private void SetForm()
	{
		BindTodaysSell();
		BindMonthlySell();
		Bindcount();
		bindgraph();
	}

	private void BindPiechart()
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		((NoisyCollection<ISeriesView>)(object)pieChart2.Series).Clear();
		Func<ChartPoint, string> labelPoint = (ChartPoint chartPoint) => $"{chartPoint.Y} ({chartPoint.Participation:P})";
		foreach (object selectedItem in listBox1.SelectedItems)
		{
			string text = selectedItem.ToString();
			for (int num = 0; num < arr.Count; num++)
			{
				if (text == arr[num].text)
				{
					SeriesCollection series = pieChart2.Series;
					PieSeries val = new PieSeries();
					((Series)val).Title = arr[num].text;
					ChartValues<double> val2 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val2).Add(arr[num].value);
					((Series)val).Values = (IChartValues)(object)val2;
					val.PushOut = 0.0;
					((Series)val).DataLabels = true;
					((Series)val).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)series).Add((ISeriesView)(object)val);
				}
			}
		}
		pieChart1.LegendLocation = (LegendLocation)2;
		bo = "true";
	}

	private void bindLineGraph()
	{
	}

	private void bindgraph()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected O, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				DataTable dataTable = new DataTable();
				string[] array = new string[7];
				string[] array2 = new string[7];
				string[] array3 = new string[7];
				string[] array4 = new string[7];
				try
				{
					array2[0] = "0";
					array2[1] = "0";
					array2[2] = "0";
					array2[3] = "0";
					array2[4] = "0";
					array2[5] = "0";
					array2[6] = "0";
					array[0] = DateTime.Now.ToString().Substring(0, 10);
					array[1] = DateTime.Parse(array[0]).AddDays(-1.0).ToString()
						.Substring(0, 10);
					array[2] = DateTime.Parse(array[0]).AddDays(-2.0).ToString()
						.Substring(0, 10);
					array[3] = DateTime.Parse(array[0]).AddDays(-3.0).ToString()
						.Substring(0, 10);
					array[4] = DateTime.Parse(array[0]).AddDays(-4.0).ToString()
						.Substring(0, 10);
					array[5] = DateTime.Parse(array[0]).AddDays(-5.0).ToString()
						.Substring(0, 10);
					array[6] = DateTime.Parse(array[0]).AddDays(-6.0).ToString()
						.Substring(0, 10);
					((DbConnection)(object)val).Open();
					dataTable.Columns.Add("Value");
					dataTable.Columns.Add("Date");
					((DbCommand)(object)val2).CommandText = "SELECT (sum(cast(grandtotal AS Float))) AS Value,CONVERT(date, mydate, 103) AS Date FROM r_invoice WHERE (CONVERT(date, mydate, 103) IN (CONVERT(date,'" + array[0] + "',103),CONVERT(date,'" + array[1] + "', 103),CONVERT(date, '" + array[2] + "', 103),CONVERT(date, '" + array[3] + "', 103),CONVERT(date, '" + array[4] + "', 103),CONVERT(date, '" + array[5] + "', 103),CONVERT(date, '" + array[6] + "', 103))) GROUP BY CONVERT(date, mydate, 103)";
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						int num = 0;
						while (((DbDataReader)(object)val3).Read())
						{
							array4[num] = ((DbDataReader)(object)val3)[0].ToString();
							array3[num] = ((DbDataReader)(object)val3)[1].ToString();
							num++;
						}
					}
					SqlConnection val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val5 = new SqlCommand();
						try
						{
							val5.Connection = val4;
							((DbConnection)(object)val4).Open();
							((DbCommand)(object)val5).CommandText = "SELECT (sum(cast(grandtotal AS Float))) AS Value,CONVERT(date, mydate, 103) AS Date FROM r_invoice_takeaway WHERE (CONVERT(date, mydate, 103) IN (CONVERT(date,'" + array[0] + "',103),CONVERT(date,'" + array[1] + "', 103),CONVERT(date, '" + array[2] + "', 103),CONVERT(date, '" + array[3] + "', 103),CONVERT(date, '" + array[4] + "', 103),CONVERT(date, '" + array[5] + "', 103),CONVERT(date, '" + array[6] + "', 103))) GROUP BY CONVERT(date, mydate, 103)";
							SqlDataReader val6 = val5.ExecuteReader();
							if (((DbDataReader)(object)val6).HasRows)
							{
								while (((DbDataReader)(object)val6).Read())
								{
									for (int num = 0; num < array3.Length; num++)
									{
										if (((DbDataReader)(object)val6)[1].ToString() == array3[num])
										{
											double num2 = double.Parse(array4[num]);
											double num3 = double.Parse(((DbDataReader)(object)val6)[0].ToString());
											array4[num] = (num2 + num3).ToString();
										}
									}
								}
							}
							((DbConnection)(object)val4).Close();
						}
						finally
						{
							((IDisposable)val5)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
					val4 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
					try
					{
						SqlCommand val5 = new SqlCommand();
						try
						{
							val5.Connection = val4;
							((DbConnection)(object)val4).Open();
							((DbCommand)(object)val5).CommandText = "SELECT (sum(cast(grandtotal AS Float))) AS Value,CONVERT(date, mydate, 103) AS Date FROM r_invoice_home WHERE (CONVERT(date, mydate, 103) IN (CONVERT(date,'" + array[0] + "',103),CONVERT(date,'" + array[1] + "', 103),CONVERT(date, '" + array[2] + "', 103),CONVERT(date, '" + array[3] + "', 103),CONVERT(date, '" + array[4] + "', 103),CONVERT(date, '" + array[5] + "', 103),CONVERT(date, '" + array[6] + "', 103))) GROUP BY CONVERT(date, mydate, 103)";
							SqlDataReader val6 = val5.ExecuteReader();
							if (((DbDataReader)(object)val6).HasRows)
							{
								while (((DbDataReader)(object)val6).Read())
								{
									for (int num = 0; num < array3.Length; num++)
									{
										if (((DbDataReader)(object)val6)[1].ToString() == array3[num])
										{
											double num2 = double.Parse(array4[num]);
											double num3 = double.Parse(((DbDataReader)(object)val6)[0].ToString());
											array4[num] = (num2 + num3).ToString();
										}
									}
								}
							}
							((DbConnection)(object)val4).Close();
						}
						finally
						{
							((IDisposable)val5)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
					int num4 = 0;
					((DbConnection)(object)val).Close();
					try
					{
						for (int num = 0; num < array3.Length; num++)
						{
							for (int i = 0; i < 7; i++)
							{
								if (array[i] == array3[num].Substring(0, 10))
								{
									array2[i] = array4[num];
								}
							}
						}
					}
					catch
					{
					}
					Func<ChartPoint, string> labelPoint = (ChartPoint chartPoint) => $"{chartPoint.Y} ({chartPoint.Participation:P})";
					PieChart obj2 = pieChart1;
					SeriesCollection val7 = new SeriesCollection();
					PieSeries val8 = new PieSeries();
					((Series)val8).Title = array[0];
					ChartValues<double> val9 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val9).Add(double.Parse(array2[0].ToString()));
					((Series)val8).Values = (IChartValues)(object)val9;
					val8.PushOut = 0.0;
					((Series)val8).DataLabels = true;
					((Series)val8).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val8);
					PieSeries val10 = new PieSeries();
					((Series)val10).Title = array[1];
					ChartValues<double> val11 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val11).Add(double.Parse(array2[1].ToString()));
					((Series)val10).Values = (IChartValues)(object)val11;
					val10.PushOut = 0.0;
					((Series)val10).DataLabels = true;
					((Series)val10).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val10);
					PieSeries val12 = new PieSeries();
					((Series)val12).Title = array[2];
					ChartValues<double> val13 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val13).Add(double.Parse(array2[2].ToString()));
					((Series)val12).Values = (IChartValues)(object)val13;
					val12.PushOut = 0.0;
					((Series)val12).DataLabels = true;
					((Series)val12).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val12);
					PieSeries val14 = new PieSeries();
					((Series)val14).Title = array[3];
					ChartValues<double> val15 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val15).Add(double.Parse(array2[3].ToString()));
					((Series)val14).Values = (IChartValues)(object)val15;
					val14.PushOut = 0.0;
					((Series)val14).DataLabels = true;
					((Series)val14).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val14);
					PieSeries val16 = new PieSeries();
					((Series)val16).Title = array[4];
					ChartValues<double> val17 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val17).Add(double.Parse(array2[4].ToString()));
					((Series)val16).Values = (IChartValues)(object)val17;
					val16.PushOut = 0.0;
					((Series)val16).DataLabels = true;
					((Series)val16).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val16);
					PieSeries val18 = new PieSeries();
					((Series)val18).Title = array[5];
					ChartValues<double> val19 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val19).Add(double.Parse(array2[5].ToString()));
					((Series)val18).Values = (IChartValues)(object)val19;
					val18.PushOut = 0.0;
					((Series)val18).DataLabels = true;
					((Series)val18).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val18);
					PieSeries val20 = new PieSeries();
					((Series)val20).Title = array[6];
					ChartValues<double> val21 = new ChartValues<double>();
					((NoisyCollection<double>)(object)val21).Add(double.Parse(array2[6].ToString()));
					((Series)val20).Values = (IChartValues)(object)val21;
					val20.PushOut = 0.0;
					((Series)val20).DataLabels = true;
					((Series)val20).LabelPoint = labelPoint;
					((NoisyCollection<ISeriesView>)(object)val7).Add((ISeriesView)(object)val20);
					obj2.Series = val7;
					pieChart1.LegendLocation = (LegendLocation)2;
				}
				catch (Exception ex)
				{
					MetroMessageBox.Show((IWin32Window)(object)this, ex.Message.ToString(), "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
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

	private void Bindcount()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select count(*) as count from r_invoice where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)label10).Text = ((DbDataReader)(object)val3)[0].ToString();
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select count(*) as count from r_invoice_home where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)label12).Text = ((DbDataReader)(object)val3)[0].ToString();
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select count(*) as count from r_invoice_takeaway where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						((Control)label11).Text = ((DbDataReader)(object)val3)[0].ToString();
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
		double num = double.Parse(((Control)label10).Text) + double.Parse(((Control)label11).Text) + double.Parse(((Control)label12).Text);
		((Control)label9).Text = num.ToString();
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		try
		{
			num2 = double.Parse(((Control)label10).Text) * 100.0 / double.Parse(((Control)label9).Text);
			metroProgressBar1.Value = int.Parse(num2.ToString());
		}
		catch (Exception)
		{
			metroProgressBar1.Value = 0;
		}
		try
		{
			num3 = double.Parse(((Control)label11).Text) * 100.0 / double.Parse(((Control)label9).Text);
			metroProgressBar2.Value = int.Parse(num3.ToString());
		}
		catch (Exception)
		{
			metroProgressBar2.Value = 0;
		}
		try
		{
			num4 = double.Parse(((Control)label12).Text) * 100.0 / double.Parse(((Control)label9).Text);
			metroProgressBar3.Value = int.Parse(num4.ToString());
		}
		catch (Exception)
		{
			metroProgressBar3.Value = 0;
		}
	}

	private void BindMonthlySell()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		double num = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total  from r_invoice where month(convert(date,mydate,103))=month(convert(date,'" + DateTime.Now.ToString() + "',103))";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total  from r_invoice_home where month(convert(date,mydate,103))=month(convert(date,'" + DateTime.Now.ToString() + "',103))";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total  from r_invoice_takeaway where month(convert(date,mydate,103))=month(convert(date,'" + DateTime.Now.ToString() + "',103))";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		((Control)label3).Text = "Rs. " + $"{num:f2}";
	}

	private void BindTodaysSell()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		double num = 0.0;
		SqlConnection val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total from r_invoice where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total  from r_invoice_home where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		val = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
		try
		{
			SqlCommand val2 = new SqlCommand();
			try
			{
				val2.Connection = val;
				((DbConnection)(object)val).Open();
				((DbCommand)(object)val2).CommandText = "select SUM(CAST(grandtotal AS float)) as total  from r_invoice_takeaway where convert(date,mydate,103)=convert(date,'" + DateTime.Now.ToString() + "',103)";
				SqlDataReader val3 = val2.ExecuteReader();
				if (((DbDataReader)(object)val3).HasRows)
				{
					while (((DbDataReader)(object)val3).Read())
					{
						try
						{
							num += double.Parse(((DbDataReader)(object)val3)["total"].ToString());
						}
						catch (Exception)
						{
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
		((Control)label2).Text = "Rs. " + $"{num:f2}";
	}

	private void MainFrom_Load(object sender, EventArgs e)
	{
		((Control)this).Focus();
		((Form)this).Activate();
		((Form)this).WindowState = (FormWindowState)2;
		SetForm();
		Bindchekc();
	}

	private void metroTile1_Click(object sender, EventArgs e)
	{
		((Control)new Order()).Show();
	}

	private void metroTile3_Click(object sender, EventArgs e)
	{
		((Control)new r_Purchase()).Show();
	}

	private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between I4 and Unknown
		if (new Permission().IsFormAlreadyOpen("r_customer") == "false")
		{
			((Control)new r_customer()).Show();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Form is already opened", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_empolyee()).Show();
	}

	private void vendorManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_vendor()).Show();
	}

	private void taxManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_tax()).Show();
	}

	private void discountManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_discount()).Show();
	}

	private void deliveryBoyManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_delieveryboy()).Show();
	}

	private void customerTransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_customer_transaction()).Show();
	}

	private void orderTypeManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_order_type()).Show();
	}

	private void paymentModeManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_payment_type()).Show();
	}

	private void bankManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_Bank_management()).Show();
	}

	private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_category()).Show();
	}

	private void manageSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_subcategory()).Show();
	}

	private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_product_item()).Show();
	}

	private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		((Control)new Add_table()).Show();
	}

	private void runningTableToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new Order()).Show();
	}

	private void rawMaterialCategoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_raw_category()).Show();
	}

	private void rawMaterialToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_raw_material()).Show();
	}

	private void unitManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_unit()).Show();
	}

	private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new Recipe()).Show();
	}

	private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_Purchase_history()).Show();
	}

	private void MainFrom_Activated(object sender, EventArgs e)
	{
		SetForm();
	}

	private void metroTile2_Click(object sender, EventArgs e)
	{
		((Control)new view_Order()).Show();
	}

	private void printerManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new BillReport()).Show();
	}

	private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new SaleReport()).Show();
	}

	private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new PRINT_STOCK()).Show();
	}

	private void databaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new DataBase_backup()).Show();
	}

	private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_room_type()).Show();
	}

	private void roomEntryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_room_entry()).Show();
	}

	private void referedByToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_referedby()).Show();
	}

	private void referenceNamesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_reference_name()).Show();
	}

	private void documentTypeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_doctype()).Show();
	}

	private void outOfStockColorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new r_color_management()).Show();
	}

	private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_guest_entry()).Show();
	}

	private void allocateToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_Room_status()).Show();
	}

	private void roomColorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new color_Management()).Show();
	}

	private void planChargeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new h_Plan_charge()).Show();
	}

	private void printerManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
		if (new USER_PERMISSION().Permission("10", "View"))
		{
			((Control)new Printer_Management()).Show();
		}
		else if (1 == (int)MetroMessageBox.Show((IWin32Window)(object)this, "Permission Denind", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16))
		{
			((Control)this).Focus();
			((Form)this).Activate();
		}
	}

	private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
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

	private void userPermissionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
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

	private void printerHeaderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
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

	private void hotelInformationToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between I4 and Unknown
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

	private void MainFrom_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void menuWiseSellReportToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)new ItemWiseSellReport()).Show();
	}

	private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
	{
	}

	private void metroDateTime1_ValueChanged(object sender, EventArgs e)
	{
		Bindchekc();
	}

	private void metroDateTime2_ValueChanged(object sender, EventArgs e)
	{
		Bindchekc();
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bo == "true")
		{
			BindPiechart();
		}
	}

	private void metroTile4_Click(object sender, EventArgs e)
	{
		((Control)new Functions()).Show();
	}
}
