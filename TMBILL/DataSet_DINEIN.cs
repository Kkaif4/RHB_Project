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
[XmlSchemaProvider("GetTypedDataSetSchema")]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlRoot("DataSet_DINEIN")]
public class DataSet_DINEIN : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void r_invoice_detailRowChangeEventHandler(object sender, r_invoice_detailRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void r_invoiceRowChangeEventHandler(object sender, r_invoiceRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class r_invoice_detailDataTable : TypedTableBase<r_invoice_detailRow>
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn invoice_idColumn => columninvoice_id;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn itemnameColumn => columnitemname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn qtyColumn => columnqty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn priceColumn => columnprice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalColumn => columntotal;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_detailRow this[int index] => (r_invoice_detailRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_detailRowChangeEventHandler r_invoice_detailRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_detailRowChangeEventHandler r_invoice_detailRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_detailRowChangeEventHandler r_invoice_detailRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoice_detailRowChangeEventHandler r_invoice_detailRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_detailDataTable()
		{
			base.TableName = "r_invoice_detail";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoice_detailDataTable(DataTable table)
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
		protected r_invoice_detailDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addr_invoice_detailRow(r_invoice_detailRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_detailRow Addr_invoice_detailRow(string invoice_id, string itemname, string qty, string price, string total)
		{
			r_invoice_detailRow r_invoice_detailRow = (r_invoice_detailRow)NewRow();
			object[] itemArray = new object[6] { null, invoice_id, itemname, qty, price, total };
			r_invoice_detailRow.ItemArray = itemArray;
			base.Rows.Add(r_invoice_detailRow);
			return r_invoice_detailRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			r_invoice_detailDataTable r_invoice_detailDataTable = (r_invoice_detailDataTable)base.Clone();
			r_invoice_detailDataTable.InitVars();
			return r_invoice_detailDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new r_invoice_detailDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columninvoice_id = base.Columns["invoice_id"];
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columntotal = base.Columns["total"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_detailRow Newr_invoice_detailRow()
		{
			return (r_invoice_detailRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new r_invoice_detailRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(r_invoice_detailRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.r_invoice_detailRowChanged != null)
			{
				this.r_invoice_detailRowChanged(this, new r_invoice_detailRowChangeEvent((r_invoice_detailRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.r_invoice_detailRowChanging != null)
			{
				this.r_invoice_detailRowChanging(this, new r_invoice_detailRowChangeEvent((r_invoice_detailRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.r_invoice_detailRowDeleted != null)
			{
				this.r_invoice_detailRowDeleted(this, new r_invoice_detailRowChangeEvent((r_invoice_detailRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.r_invoice_detailRowDeleting != null)
			{
				this.r_invoice_detailRowDeleting(this, new r_invoice_detailRowChangeEvent((r_invoice_detailRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Remover_invoice_detailRow(r_invoice_detailRow row)
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
			DataSet_DINEIN dataSet_DINEIN = new DataSet_DINEIN();
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
			val5.FixedValue = dataSet_DINEIN.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "r_invoice_detailDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_DINEIN.GetSchemaSerializable();
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
	public class r_invoiceDataTable : TypedTableBase<r_invoiceRow>
	{
		private DataColumn columnid;

		private DataColumn columnwaitername;

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

		private DataColumn columntablename;

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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn waiternameColumn => columnwaitername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn customernameColumn => columncustomername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalColumn => columntotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn selectedtaxColumn => columnselectedtax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn isigstColumn => columnisigst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn grandtotalColumn => columngrandtotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paymenttypeColumn => columnpaymenttype;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn tablenameColumn => columntablename;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mydateColumn => columnmydate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn extra_tax_totColumn => columnextra_tax_tot;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoiceRow this[int index] => (r_invoiceRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoiceRowChangeEventHandler r_invoiceRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoiceRowChangeEventHandler r_invoiceRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoiceRowChangeEventHandler r_invoiceRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event r_invoiceRowChangeEventHandler r_invoiceRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoiceDataTable()
		{
			base.TableName = "r_invoice";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoiceDataTable(DataTable table)
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
		protected r_invoiceDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Addr_invoiceRow(r_invoiceRow row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoiceRow Addr_invoiceRow(string waitername, string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string tablename, string mydate, string inwords, string paidamt, string remainingamt, string extra_tax_s, string extra_tax_amt, string extra_tax_tot)
		{
			r_invoiceRow r_invoiceRow = (r_invoiceRow)NewRow();
			object[] itemArray = new object[22]
			{
				null, waitername, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax,
				discounttype, discountamt, grandtotal, paymenttype, tablename, mydate, inwords, paidamt, remainingamt, extra_tax_s,
				extra_tax_amt, extra_tax_tot
			};
			r_invoiceRow.ItemArray = itemArray;
			base.Rows.Add(r_invoiceRow);
			return r_invoiceRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			r_invoiceDataTable r_invoiceDataTable = (r_invoiceDataTable)base.Clone();
			r_invoiceDataTable.InitVars();
			return r_invoiceDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new r_invoiceDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columnwaitername = base.Columns["waitername"];
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
			columntablename = base.Columns["tablename"];
			columnmydate = base.Columns["mydate"];
			columninwords = base.Columns["inwords"];
			columnpaidamt = base.Columns["paidamt"];
			columnremainingamt = base.Columns["remainingamt"];
			columnextra_tax_s = base.Columns["extra_tax_s"];
			columnextra_tax_amt = base.Columns["extra_tax_amt"];
			columnextra_tax_tot = base.Columns["extra_tax_tot"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columnwaitername = new DataColumn("waitername", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnwaitername);
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
			columntablename = new DataColumn("tablename", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntablename);
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
			columnwaitername.MaxLength = 100;
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
			columntablename.MaxLength = 50;
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
		public r_invoiceRow Newr_invoiceRow()
		{
			return (r_invoiceRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new r_invoiceRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(r_invoiceRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.r_invoiceRowChanged != null)
			{
				this.r_invoiceRowChanged(this, new r_invoiceRowChangeEvent((r_invoiceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.r_invoiceRowChanging != null)
			{
				this.r_invoiceRowChanging(this, new r_invoiceRowChangeEvent((r_invoiceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.r_invoiceRowDeleted != null)
			{
				this.r_invoiceRowDeleted(this, new r_invoiceRowChangeEvent((r_invoiceRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.r_invoiceRowDeleting != null)
			{
				this.r_invoiceRowDeleting(this, new r_invoiceRowChangeEvent((r_invoiceRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Remover_invoiceRow(r_invoiceRow row)
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
			DataSet_DINEIN dataSet_DINEIN = new DataSet_DINEIN();
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
			val5.FixedValue = dataSet_DINEIN.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "r_invoiceDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_DINEIN.GetSchemaSerializable();
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

	public class r_invoice_detailRow : DataRow
	{
		private r_invoice_detailDataTable tabler_invoice_detail;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[tabler_invoice_detail.idColumn];
			}
			set
			{
				base[tabler_invoice_detail.idColumn] = value;
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
					return (string)base[tabler_invoice_detail.invoice_idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'invoice_id' in table 'r_invoice_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_detail.invoice_idColumn] = value;
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
					return (string)base[tabler_invoice_detail.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'r_invoice_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_detail.itemnameColumn] = value;
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
					return (string)base[tabler_invoice_detail.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'r_invoice_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_detail.qtyColumn] = value;
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
					return (string)base[tabler_invoice_detail.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'r_invoice_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_detail.priceColumn] = value;
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
					return (string)base[tabler_invoice_detail.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'r_invoice_detail' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice_detail.totalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoice_detailRow(DataRowBuilder rb)
			: base(rb)
		{
			tabler_invoice_detail = (r_invoice_detailDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isinvoice_idNull()
		{
			return IsNull(tabler_invoice_detail.invoice_idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setinvoice_idNull()
		{
			base[tabler_invoice_detail.invoice_idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsitemnameNull()
		{
			return IsNull(tabler_invoice_detail.itemnameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetitemnameNull()
		{
			base[tabler_invoice_detail.itemnameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsqtyNull()
		{
			return IsNull(tabler_invoice_detail.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tabler_invoice_detail.qtyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspriceNull()
		{
			return IsNull(tabler_invoice_detail.priceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpriceNull()
		{
			base[tabler_invoice_detail.priceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalNull()
		{
			return IsNull(tabler_invoice_detail.totalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalNull()
		{
			base[tabler_invoice_detail.totalColumn] = Convert.DBNull;
		}
	}

	public class r_invoiceRow : DataRow
	{
		private r_invoiceDataTable tabler_invoice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[tabler_invoice.idColumn];
			}
			set
			{
				base[tabler_invoice.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string waitername
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.waiternameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'waitername' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.waiternameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string customername
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.customernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'customername' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.customernameColumn] = value;
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
					return (string)base[tabler_invoice.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.totalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string selectedtax
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.selectedtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'selectedtax' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.selectedtaxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string isigst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.isigstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isigst' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.isigstColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string igst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.igstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'igst' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.igstColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string cgst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.cgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cgst' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.cgstColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string sgst
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.sgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sgst' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.sgstColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string totalwithtax
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.totalwithtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalwithtax' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.totalwithtaxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string discounttype
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.discounttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discounttype' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.discounttypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string discountamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.discountamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discountamt' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.discountamtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string grandtotal
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.grandtotalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grandtotal' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.grandtotalColumn] = value;
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
					return (string)base[tabler_invoice.paymenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paymenttype' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.paymenttypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string tablename
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.tablenameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tablename' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.tablenameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string mydate
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.mydateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mydate' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.mydateColumn] = value;
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
					return (string)base[tabler_invoice.inwordsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'inwords' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.inwordsColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string paidamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.paidamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paidamt' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.paidamtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string remainingamt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.remainingamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remainingamt' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.remainingamtColumn] = value;
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
					return (string)base[tabler_invoice.extra_tax_sColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_s' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.extra_tax_sColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string extra_tax_amt
		{
			get
			{
				try
				{
					return (string)base[tabler_invoice.extra_tax_amtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_amt' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.extra_tax_amtColumn] = value;
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
					return (string)base[tabler_invoice.extra_tax_totColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_tax_tot' in table 'r_invoice' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabler_invoice.extra_tax_totColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal r_invoiceRow(DataRowBuilder rb)
			: base(rb)
		{
			tabler_invoice = (r_invoiceDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IswaiternameNull()
		{
			return IsNull(tabler_invoice.waiternameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetwaiternameNull()
		{
			base[tabler_invoice.waiternameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscustomernameNull()
		{
			return IsNull(tabler_invoice.customernameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcustomernameNull()
		{
			base[tabler_invoice.customernameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalNull()
		{
			return IsNull(tabler_invoice.totalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalNull()
		{
			base[tabler_invoice.totalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsselectedtaxNull()
		{
			return IsNull(tabler_invoice.selectedtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetselectedtaxNull()
		{
			base[tabler_invoice.selectedtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsisigstNull()
		{
			return IsNull(tabler_invoice.isigstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetisigstNull()
		{
			base[tabler_invoice.isigstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsigstNull()
		{
			return IsNull(tabler_invoice.igstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetigstNull()
		{
			base[tabler_invoice.igstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscgstNull()
		{
			return IsNull(tabler_invoice.cgstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcgstNull()
		{
			base[tabler_invoice.cgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IssgstNull()
		{
			return IsNull(tabler_invoice.sgstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetsgstNull()
		{
			base[tabler_invoice.sgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalwithtaxNull()
		{
			return IsNull(tabler_invoice.totalwithtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalwithtaxNull()
		{
			base[tabler_invoice.totalwithtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdiscounttypeNull()
		{
			return IsNull(tabler_invoice.discounttypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscounttypeNull()
		{
			base[tabler_invoice.discounttypeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdiscountamtNull()
		{
			return IsNull(tabler_invoice.discountamtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscountamtNull()
		{
			base[tabler_invoice.discountamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsgrandtotalNull()
		{
			return IsNull(tabler_invoice.grandtotalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetgrandtotalNull()
		{
			base[tabler_invoice.grandtotalColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaymenttypeNull()
		{
			return IsNull(tabler_invoice.paymenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaymenttypeNull()
		{
			base[tabler_invoice.paymenttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstablenameNull()
		{
			return IsNull(tabler_invoice.tablenameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettablenameNull()
		{
			base[tabler_invoice.tablenameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmydateNull()
		{
			return IsNull(tabler_invoice.mydateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetmydateNull()
		{
			base[tabler_invoice.mydateColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsinwordsNull()
		{
			return IsNull(tabler_invoice.inwordsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetinwordsNull()
		{
			base[tabler_invoice.inwordsColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaidamtNull()
		{
			return IsNull(tabler_invoice.paidamtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpaidamtNull()
		{
			base[tabler_invoice.paidamtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsremainingamtNull()
		{
			return IsNull(tabler_invoice.remainingamtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetremainingamtNull()
		{
			base[tabler_invoice.remainingamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isextra_tax_sNull()
		{
			return IsNull(tabler_invoice.extra_tax_sColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setextra_tax_sNull()
		{
			base[tabler_invoice.extra_tax_sColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isextra_tax_amtNull()
		{
			return IsNull(tabler_invoice.extra_tax_amtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setextra_tax_amtNull()
		{
			base[tabler_invoice.extra_tax_amtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isextra_tax_totNull()
		{
			return IsNull(tabler_invoice.extra_tax_totColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setextra_tax_totNull()
		{
			base[tabler_invoice.extra_tax_totColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class r_invoice_detailRowChangeEvent : EventArgs
	{
		private r_invoice_detailRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoice_detailRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoice_detailRowChangeEvent(r_invoice_detailRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class r_invoiceRowChangeEvent : EventArgs
	{
		private r_invoiceRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public r_invoiceRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public r_invoiceRowChangeEvent(r_invoiceRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private r_invoice_detailDataTable tabler_invoice_detail;

	private r_invoiceDataTable tabler_invoice;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public r_invoice_detailDataTable r_invoice_detail => tabler_invoice_detail;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public r_invoiceDataTable r_invoice => tabler_invoice;

	[Browsable(true)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public DataSet_DINEIN()
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
	protected DataSet_DINEIN(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["r_invoice_detail"] != null)
			{
				base.Tables.Add(new r_invoice_detailDataTable(dataSet.Tables["r_invoice_detail"]));
			}
			if (dataSet.Tables["r_invoice"] != null)
			{
				base.Tables.Add(new r_invoiceDataTable(dataSet.Tables["r_invoice"]));
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
		DataSet_DINEIN dataSet_DINEIN = (DataSet_DINEIN)base.Clone();
		dataSet_DINEIN.InitVars();
		dataSet_DINEIN.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet_DINEIN;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["r_invoice_detail"] != null)
			{
				base.Tables.Add(new r_invoice_detailDataTable(dataSet.Tables["r_invoice_detail"]));
			}
			if (dataSet.Tables["r_invoice"] != null)
			{
				base.Tables.Add(new r_invoiceDataTable(dataSet.Tables["r_invoice"]));
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tabler_invoice_detail = (r_invoice_detailDataTable)base.Tables["r_invoice_detail"];
		if (initTable && tabler_invoice_detail != null)
		{
			tabler_invoice_detail.InitVars();
		}
		tabler_invoice = (r_invoiceDataTable)base.Tables["r_invoice"];
		if (initTable && tabler_invoice != null)
		{
			tabler_invoice.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "DataSet_DINEIN";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet_DINEIN.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tabler_invoice_detail = new r_invoice_detailDataTable();
		base.Tables.Add(tabler_invoice_detail);
		tabler_invoice = new r_invoiceDataTable();
		base.Tables.Add(tabler_invoice);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializer_invoice_detail()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializer_invoice()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		DataSet_DINEIN dataSet_DINEIN = new DataSet_DINEIN();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSet_DINEIN.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSet_DINEIN.GetSchemaSerializable();
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
