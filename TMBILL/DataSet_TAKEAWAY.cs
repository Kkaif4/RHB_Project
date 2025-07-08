using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TMBILL;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DataSet_TAKEAWAY")]
public class DataSet_TAKEAWAY : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void r_takeaway_detailRowChangeEventHandler(object sender, r_takeaway_detailRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void r_invoice_takeawayRowChangeEventHandler(object sender, r_invoice_takeawayRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class r_takeaway_detailDataTable : TypedTableBase<r_takeaway_detailRow>
	{
		private DataColumn columnid;

		private DataColumn columninvoice_id;

		private DataColumn columnitemname;

		private DataColumn columnqty;

		private DataColumn columnprice;

		private DataColumn columntotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn invoice_idColumn => columninvoice_id;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn itemnameColumn => columnitemname;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn qtyColumn => columnqty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn priceColumn => columnprice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalColumn => columntotal;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_takeaway_detailRow this[int index] => (r_takeaway_detailRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_takeaway_detailRowChangeEventHandler r_takeaway_detailRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_takeaway_detailRowChangeEventHandler r_takeaway_detailRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_takeaway_detailRowChangeEventHandler r_takeaway_detailRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_takeaway_detailRowChangeEventHandler r_takeaway_detailRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_takeaway_detailDataTable()
		{
			base.TableName = "r_takeaway_detail";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_takeaway_detailDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected r_takeaway_detailDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addr_takeaway_detailRow(r_takeaway_detailRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_takeaway_detailRow Addr_takeaway_detailRow(string invoice_id, string itemname, string qty, string price, string total)
		{
			r_takeaway_detailRow r_takeaway_detailRow = (r_takeaway_detailRow)NewRow();
			object[] itemArray = new object[6] { null, invoice_id, itemname, qty, price, total };
			r_takeaway_detailRow.ItemArray = itemArray;
			base.Rows.Add(r_takeaway_detailRow);
			return r_takeaway_detailRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			r_takeaway_detailDataTable r_takeaway_detailDataTable = (r_takeaway_detailDataTable)base.Clone();
			r_takeaway_detailDataTable.InitVars();
			return r_takeaway_detailDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new r_takeaway_detailDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columninvoice_id = base.Columns["invoice_id"];
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columntotal = base.Columns["total"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columninvoice_id = new DataColumn("invoice_id", typeof(string), null, MappingType.Element);
			base.Columns.Add(columninvoice_id);
			columnitemname = new DataColumn("itemname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnitemname);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprice);
			columntotal = new DataColumn("total", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotal);
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columninvoice_id.MaxLength = 50;
			columnitemname.MaxLength = 200;
			columnqty.MaxLength = 50;
			columnprice.MaxLength = 50;
			columntotal.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_takeaway_detailRow Newr_takeaway_detailRow()
		{
			return (r_takeaway_detailRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new r_takeaway_detailRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(r_takeaway_detailRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.r_takeaway_detailRowChanged != null)
			{
				this.r_takeaway_detailRowChanged(this, new r_takeaway_detailRowChangeEvent((r_takeaway_detailRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.r_takeaway_detailRowChanging != null)
			{
				this.r_takeaway_detailRowChanging(this, new r_takeaway_detailRowChangeEvent((r_takeaway_detailRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.r_takeaway_detailRowDeleted != null)
			{
				this.r_takeaway_detailRowDeleted(this, new r_takeaway_detailRowChangeEvent((r_takeaway_detailRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.r_takeaway_detailRowDeleting != null)
			{
				this.r_takeaway_detailRowDeleting(this, new r_takeaway_detailRowChangeEvent((r_takeaway_detailRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Remover_takeaway_detailRow(r_takeaway_detailRow row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			XmlSchemaComplexType val = new XmlSchemaComplexType();
			XmlSchemaSequence val2 = new XmlSchemaSequence();
			DataSet_TAKEAWAY dataSet_TAKEAWAY = new DataSet_TAKEAWAY();
			XmlSchemaAny val3 = new XmlSchemaAny();
			val3.Namespace = "http://www.w3.org/2001/XMLSchema";
			((XmlSchemaParticle)val3).MinOccurs = 0m;
			((XmlSchemaParticle)val3).MaxOccurs = decimal.MaxValue;
			val3.ProcessContents = (XmlSchemaContentProcessing)2;
			((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
			XmlSchemaAny val4 = new XmlSchemaAny();
			val4.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			((XmlSchemaParticle)val4).MinOccurs = 1m;
			val4.ProcessContents = (XmlSchemaContentProcessing)2;
			((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val4);
			XmlSchemaAttribute val5 = new XmlSchemaAttribute();
			val5.Name = "namespace";
			val5.FixedValue = dataSet_TAKEAWAY.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "r_takeaway_detailDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_TAKEAWAY.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema val7 = null;
					schemaSerializable.Write((Stream)memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						val7 = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						val7.Write((Stream)memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return val;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return val;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class r_invoice_takeawayDataTable : TypedTableBase<r_invoice_takeawayRow>
	{
		private DataColumn columnid;

		private DataColumn columncustomername;

		private DataColumn columntotal;

		private DataColumn columnselectedtax;

		private DataColumn columnisigst;

		private DataColumn columnigst;

		private DataColumn columncgst;

		private DataColumn columnsgst;

		private DataColumn columntotalwithtax;

		private DataColumn columndiscounttype;

		private DataColumn columndiscountamt;

		private DataColumn columngrandtotal;

		private DataColumn columnpaymenttype;

		private DataColumn columnmydate;

		private DataColumn columninwords;

		private DataColumn columnpaidamt;

		private DataColumn columnremainingamt;

		private DataColumn columnextra_tax_s;

		private DataColumn columnextra_tax_amt;

		private DataColumn columnextra_tax_tot;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idColumn => columnid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn customernameColumn => columncustomername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalColumn => columntotal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn selectedtaxColumn => columnselectedtax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn isigstColumn => columnisigst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn igstColumn => columnigst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn cgstColumn => columncgst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn sgstColumn => columnsgst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalwithtaxColumn => columntotalwithtax;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn discounttypeColumn => columndiscounttype;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn discountamtColumn => columndiscountamt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn grandtotalColumn => columngrandtotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paymenttypeColumn => columnpaymenttype;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mydateColumn => columnmydate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn inwordsColumn => columninwords;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paidamtColumn => columnpaidamt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn remainingamtColumn => columnremainingamt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn extra_tax_sColumn => columnextra_tax_s;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn extra_tax_amtColumn => columnextra_tax_amt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn extra_tax_totColumn => columnextra_tax_tot;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_takeawayRow this[int index] => (r_invoice_takeawayRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_takeawayRowChangeEventHandler r_invoice_takeawayRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_takeawayRowChangeEventHandler r_invoice_takeawayRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_takeawayRowChangeEventHandler r_invoice_takeawayRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_takeawayRowChangeEventHandler r_invoice_takeawayRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_takeawayDataTable()
		{
			base.TableName = "r_invoice_takeaway";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoice_takeawayDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected r_invoice_takeawayDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addr_invoice_takeawayRow(r_invoice_takeawayRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_takeawayRow Addr_invoice_takeawayRow(string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string mydate, string inwords, string paidamt, string remainingamt, string extra_tax_s, string extra_tax_amt, string extra_tax_tot)
		{
			r_invoice_takeawayRow r_invoice_takeawayRow = (r_invoice_takeawayRow)NewRow();
			object[] itemArray = new object[20]
			{
				null, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax, discounttype,
				discountamt, grandtotal, paymenttype, mydate, inwords, paidamt, remainingamt, extra_tax_s, extra_tax_amt, extra_tax_tot
			};
			r_invoice_takeawayRow.ItemArray = itemArray;
			base.Rows.Add(r_invoice_takeawayRow);
			return r_invoice_takeawayRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			r_invoice_takeawayDataTable r_invoice_takeawayDataTable = (r_invoice_takeawayDataTable)base.Clone();
			r_invoice_takeawayDataTable.InitVars();
			return r_invoice_takeawayDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new r_invoice_takeawayDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columncustomername = base.Columns["customername"];
			columntotal = base.Columns["total"];
			columnselectedtax = base.Columns["selectedtax"];
			columnisigst = base.Columns["isigst"];
			columnigst = base.Columns["igst"];
			columncgst = base.Columns["cgst"];
			columnsgst = base.Columns["sgst"];
			columntotalwithtax = base.Columns["totalwithtax"];
			columndiscounttype = base.Columns["discounttype"];
			columndiscountamt = base.Columns["discountamt"];
			columngrandtotal = base.Columns["grandtotal"];
			columnpaymenttype = base.Columns["paymenttype"];
			columnmydate = base.Columns["mydate"];
			columninwords = base.Columns["inwords"];
			columnpaidamt = base.Columns["paidamt"];
			columnremainingamt = base.Columns["remainingamt"];
			columnextra_tax_s = base.Columns["extra_tax_s"];
			columnextra_tax_amt = base.Columns["extra_tax_amt"];
			columnextra_tax_tot = base.Columns["extra_tax_tot"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columncustomername = new DataColumn("customername", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncustomername);
			columntotal = new DataColumn("total", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotal);
			columnselectedtax = new DataColumn("selectedtax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnselectedtax);
			columnisigst = new DataColumn("isigst", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnisigst);
			columnigst = new DataColumn("igst", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnigst);
			columncgst = new DataColumn("cgst", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncgst);
			columnsgst = new DataColumn("sgst", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnsgst);
			columntotalwithtax = new DataColumn("totalwithtax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotalwithtax);
			columndiscounttype = new DataColumn("discounttype", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndiscounttype);
			columndiscountamt = new DataColumn("discountamt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndiscountamt);
			columngrandtotal = new DataColumn("grandtotal", typeof(string), null, MappingType.Element);
			base.Columns.Add(columngrandtotal);
			columnpaymenttype = new DataColumn("paymenttype", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpaymenttype);
			columnmydate = new DataColumn("mydate", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnmydate);
			columninwords = new DataColumn("inwords", typeof(string), null, MappingType.Element);
			base.Columns.Add(columninwords);
			columnpaidamt = new DataColumn("paidamt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpaidamt);
			columnremainingamt = new DataColumn("remainingamt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnremainingamt);
			columnextra_tax_s = new DataColumn("extra_tax_s", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnextra_tax_s);
			columnextra_tax_amt = new DataColumn("extra_tax_amt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnextra_tax_amt);
			columnextra_tax_tot = new DataColumn("extra_tax_tot", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnextra_tax_tot);
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columncustomername.MaxLength = 100;
			columntotal.MaxLength = 50;
			columnselectedtax.MaxLength = 50;
			columnisigst.MaxLength = 50;
			columnigst.MaxLength = 50;
			columncgst.MaxLength = 50;
			columnsgst.MaxLength = 50;
			columntotalwithtax.MaxLength = 50;
			columndiscounttype.MaxLength = 50;
			columndiscountamt.MaxLength = 50;
			columngrandtotal.MaxLength = 50;
			columnpaymenttype.MaxLength = 50;
			columnmydate.MaxLength = 50;
			columninwords.MaxLength = 400;
			columnpaidamt.MaxLength = 50;
			columnremainingamt.MaxLength = 50;
			columnextra_tax_s.MaxLength = 50;
			columnextra_tax_amt.MaxLength = 50;
			columnextra_tax_tot.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_takeawayRow Newr_invoice_takeawayRow()
		{
			return (r_invoice_takeawayRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new r_invoice_takeawayRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(r_invoice_takeawayRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.r_invoice_takeawayRowChanged != null)
			{
				this.r_invoice_takeawayRowChanged(this, new r_invoice_takeawayRowChangeEvent((r_invoice_takeawayRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.r_invoice_takeawayRowChanging != null)
			{
				this.r_invoice_takeawayRowChanging(this, new r_invoice_takeawayRowChangeEvent((r_invoice_takeawayRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.r_invoice_takeawayRowDeleted != null)
			{
				this.r_invoice_takeawayRowDeleted(this, new r_invoice_takeawayRowChangeEvent((r_invoice_takeawayRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.r_invoice_takeawayRowDeleting != null)
			{
				this.r_invoice_takeawayRowDeleting(this, new r_invoice_takeawayRowChangeEvent((r_invoice_takeawayRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Remover_invoice_takeawayRow(r_invoice_takeawayRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			XmlSchemaComplexType val = new XmlSchemaComplexType();
			XmlSchemaSequence val2 = new XmlSchemaSequence();
			DataSet_TAKEAWAY dataSet_TAKEAWAY = new DataSet_TAKEAWAY();
			XmlSchemaAny val3 = new XmlSchemaAny();
			val3.Namespace = "http://www.w3.org/2001/XMLSchema";
			((XmlSchemaParticle)val3).MinOccurs = 0m;
			((XmlSchemaParticle)val3).MaxOccurs = decimal.MaxValue;
			val3.ProcessContents = (XmlSchemaContentProcessing)2;
			((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
			XmlSchemaAny val4 = new XmlSchemaAny();
			val4.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			((XmlSchemaParticle)val4).MinOccurs = 1m;
			val4.ProcessContents = (XmlSchemaContentProcessing)2;
			((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val4);
			XmlSchemaAttribute val5 = new XmlSchemaAttribute();
			val5.Name = "namespace";
			val5.FixedValue = dataSet_TAKEAWAY.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "r_invoice_takeawayDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_TAKEAWAY.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema val7 = null;
					schemaSerializable.Write((Stream)memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						val7 = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						val7.Write((Stream)memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return val;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return val;
		}
	}

	public class r_takeaway_detailRow : DataRow
	{
		private r_takeaway_detailDataTable tabler_takeaway_detail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[tabler_takeaway_detail.idColumn];
			}
			set
			{
				base[tabler_takeaway_detail.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string invoice_id
		{
			get
			{
				try
				{
					return (string)base[tabler_takeaway_detail.invoice_idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'invoice_id' in table 'r_takeaway_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_takeaway_detail.invoice_idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string itemname
		{
			get
			{
				try
				{
					return (string)base[tabler_takeaway_detail.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'r_takeaway_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_takeaway_detail.itemnameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string qty
		{
			get
			{
				try
				{
					return (string)base[tabler_takeaway_detail.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'r_takeaway_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_takeaway_detail.qtyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string price
		{
			get
			{
				try
				{
					return (string)base[tabler_takeaway_detail.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'r_takeaway_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_takeaway_detail.priceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string total
		{
			get
			{
				try
				{
					return (string)base[tabler_takeaway_detail.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'r_takeaway_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_takeaway_detail.totalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_takeaway_detailRow(DataRowBuilder rb)
			: base(rb)
		{
			tabler_takeaway_detail = (r_takeaway_detailDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isinvoice_idNull()
		{
			return IsNull(tabler_takeaway_detail.invoice_idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setinvoice_idNull()
		{
			base[tabler_takeaway_detail.invoice_idColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsitemnameNull()
		{
			return IsNull(tabler_takeaway_detail.itemnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetitemnameNull()
		{
			base[tabler_takeaway_detail.itemnameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsqtyNull()
		{
			return IsNull(tabler_takeaway_detail.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tabler_takeaway_detail.qtyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspriceNull()
		{
			return IsNull(tabler_takeaway_detail.priceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpriceNull()
		{
			base[tabler_takeaway_detail.priceColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstotalNull()
		{
			return IsNull(tabler_takeaway_detail.totalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalNull()
		{
			base[tabler_takeaway_detail.totalColumn] = Convert.DBNull;
		}
	}

	public class r_invoice_takeawayRow : DataRow
	{
		private r_invoice_takeawayDataTable tabler_invoice_takeaway;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[tabler_invoice_takeaway.idColumn];
			}
			set
			{
				base[tabler_invoice_takeaway.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string customername
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.customernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'customername' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.customernameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string total
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.totalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string selectedtax
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.selectedtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'selectedtax' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.selectedtaxColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string isigst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.isigstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isigst' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.isigstColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string igst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.igstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'igst' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.igstColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string cgst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.cgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cgst' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.cgstColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string sgst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.sgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sgst' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.sgstColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string totalwithtax
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.totalwithtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalwithtax' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.totalwithtaxColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string discounttype
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.discounttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discounttype' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.discounttypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string discountamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.discountamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discountamt' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.discountamtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string grandtotal
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.grandtotalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grandtotal' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.grandtotalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string paymenttype
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.paymenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paymenttype' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.paymenttypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mydate
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.mydateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mydate' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.mydateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string inwords
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.inwordsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'inwords' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.inwordsColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string paidamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.paidamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paidamt' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.paidamtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string remainingamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.remainingamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remainingamt' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.remainingamtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string extra_tax_s
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.extra_tax_sColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_s' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.extra_tax_sColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string extra_tax_amt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.extra_tax_amtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_amt' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.extra_tax_amtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string extra_tax_tot
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice_takeaway.extra_tax_totColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_tot' in table 'r_invoice_takeaway' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_takeaway.extra_tax_totColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoice_takeawayRow(DataRowBuilder rb)
			: base(rb)
		{
			tabler_invoice_takeaway = (r_invoice_takeawayDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscustomernameNull()
		{
			return IsNull(tabler_invoice_takeaway.customernameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcustomernameNull()
		{
			base[tabler_invoice_takeaway.customernameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalNull()
		{
			return IsNull(tabler_invoice_takeaway.totalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalNull()
		{
			base[tabler_invoice_takeaway.totalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsselectedtaxNull()
		{
			return IsNull(tabler_invoice_takeaway.selectedtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetselectedtaxNull()
		{
			base[tabler_invoice_takeaway.selectedtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsisigstNull()
		{
			return IsNull(tabler_invoice_takeaway.isigstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetisigstNull()
		{
			base[tabler_invoice_takeaway.isigstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsigstNull()
		{
			return IsNull(tabler_invoice_takeaway.igstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetigstNull()
		{
			base[tabler_invoice_takeaway.igstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscgstNull()
		{
			return IsNull(tabler_invoice_takeaway.cgstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcgstNull()
		{
			base[tabler_invoice_takeaway.cgstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IssgstNull()
		{
			return IsNull(tabler_invoice_takeaway.sgstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetsgstNull()
		{
			base[tabler_invoice_takeaway.sgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalwithtaxNull()
		{
			return IsNull(tabler_invoice_takeaway.totalwithtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalwithtaxNull()
		{
			base[tabler_invoice_takeaway.totalwithtaxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscounttypeNull()
		{
			return IsNull(tabler_invoice_takeaway.discounttypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscounttypeNull()
		{
			base[tabler_invoice_takeaway.discounttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscountamtNull()
		{
			return IsNull(tabler_invoice_takeaway.discountamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiscountamtNull()
		{
			base[tabler_invoice_takeaway.discountamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsgrandtotalNull()
		{
			return IsNull(tabler_invoice_takeaway.grandtotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetgrandtotalNull()
		{
			base[tabler_invoice_takeaway.grandtotalColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaymenttypeNull()
		{
			return IsNull(tabler_invoice_takeaway.paymenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaymenttypeNull()
		{
			base[tabler_invoice_takeaway.paymenttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmydateNull()
		{
			return IsNull(tabler_invoice_takeaway.mydateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetmydateNull()
		{
			base[tabler_invoice_takeaway.mydateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsinwordsNull()
		{
			return IsNull(tabler_invoice_takeaway.inwordsColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetinwordsNull()
		{
			base[tabler_invoice_takeaway.inwordsColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaidamtNull()
		{
			return IsNull(tabler_invoice_takeaway.paidamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaidamtNull()
		{
			base[tabler_invoice_takeaway.paidamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsremainingamtNull()
		{
			return IsNull(tabler_invoice_takeaway.remainingamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetremainingamtNull()
		{
			base[tabler_invoice_takeaway.remainingamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isextra_tax_sNull()
		{
			return IsNull(tabler_invoice_takeaway.extra_tax_sColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setextra_tax_sNull()
		{
			base[tabler_invoice_takeaway.extra_tax_sColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isextra_tax_amtNull()
		{
			return IsNull(tabler_invoice_takeaway.extra_tax_amtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setextra_tax_amtNull()
		{
			base[tabler_invoice_takeaway.extra_tax_amtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isextra_tax_totNull()
		{
			return IsNull(tabler_invoice_takeaway.extra_tax_totColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setextra_tax_totNull()
		{
			base[tabler_invoice_takeaway.extra_tax_totColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class r_takeaway_detailRowChangeEvent : EventArgs
	{
		private r_takeaway_detailRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_takeaway_detailRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_takeaway_detailRowChangeEvent(r_takeaway_detailRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class r_invoice_takeawayRowChangeEvent : EventArgs
	{
		private r_invoice_takeawayRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_takeawayRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_takeawayRowChangeEvent(r_invoice_takeawayRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private r_takeaway_detailDataTable tabler_takeaway_detail;

	private r_invoice_takeawayDataTable tabler_invoice_takeaway;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public r_takeaway_detailDataTable r_takeaway_detail => tabler_takeaway_detail;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public r_invoice_takeawayDataTable r_invoice_takeaway => tabler_invoice_takeaway;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(true)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public DataSet_TAKEAWAY()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected DataSet_TAKEAWAY(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema((XmlReader?)new XmlTextReader((TextReader)new StringReader(s)));
			if (dataSet.Tables["r_takeaway_detail"] != null)
			{
				base.Tables.Add(new r_takeaway_detailDataTable(dataSet.Tables["r_takeaway_detail"]));
			}
			if (dataSet.Tables["r_invoice_takeaway"] != null)
			{
				base.Tables.Add(new r_invoice_takeawayDataTable(dataSet.Tables["r_invoice_takeaway"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema((XmlReader?)new XmlTextReader((TextReader)new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public override DataSet Clone()
	{
		DataSet_TAKEAWAY dataSet_TAKEAWAY = (DataSet_TAKEAWAY)base.Clone();
		dataSet_TAKEAWAY.InitVars();
		dataSet_TAKEAWAY.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet_TAKEAWAY;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["r_takeaway_detail"] != null)
			{
				base.Tables.Add(new r_takeaway_detailDataTable(dataSet.Tables["r_takeaway_detail"]));
			}
			if (dataSet.Tables["r_invoice_takeaway"] != null)
			{
				base.Tables.Add(new r_invoice_takeawayDataTable(dataSet.Tables["r_invoice_takeaway"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override XmlSchema GetSchemaSerializable()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema((XmlWriter?)new XmlTextWriter((Stream)memoryStream, (Encoding)null));
		memoryStream.Position = 0L;
		return XmlSchema.Read((XmlReader)new XmlTextReader((Stream)memoryStream), (ValidationEventHandler)null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tabler_takeaway_detail = (r_takeaway_detailDataTable)base.Tables["r_takeaway_detail"];
		if (initTable && tabler_takeaway_detail != null)
		{
			tabler_takeaway_detail.InitVars();
		}
		tabler_invoice_takeaway = (r_invoice_takeawayDataTable)base.Tables["r_invoice_takeaway"];
		if (initTable && tabler_invoice_takeaway != null)
		{
			tabler_invoice_takeaway.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "DataSet_TAKEAWAY";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet_TAKEAWAY.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tabler_takeaway_detail = new r_takeaway_detailDataTable();
		base.Tables.Add(tabler_takeaway_detail);
		tabler_invoice_takeaway = new r_invoice_takeawayDataTable();
		base.Tables.Add(tabler_invoice_takeaway);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializer_takeaway_detail()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializer_invoice_takeaway()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		DataSet_TAKEAWAY dataSet_TAKEAWAY = new DataSet_TAKEAWAY();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSet_TAKEAWAY.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSet_TAKEAWAY.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema val4 = null;
				schemaSerializable.Write((Stream)memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					val4 = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					val4.Write((Stream)memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return val;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return val;
	}
}
