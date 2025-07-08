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
[DesignerCategory("code")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("DataSet_SaleREPORT")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class DataSet_SaleREPORT : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable11RowChangeEventHandler(object sender, DataTable11RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable12RowChangeEventHandler(object sender, DataTable12RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable1DataTable : DataTable, IEnumerable
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

		private DataColumn columnitemname;

		private DataColumn columnqty;

		private DataColumn columnprice;

		private DataColumn columntotalofitem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn waiternameColumn => columnwaitername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn customernameColumn => columncustomername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalColumn => columntotal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn selectedtaxColumn => columnselectedtax;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn isigstColumn => columnisigst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn igstColumn => columnigst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn cgstColumn => columncgst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn sgstColumn => columnsgst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalwithtaxColumn => columntotalwithtax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn discounttypeColumn => columndiscounttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn discountamtColumn => columndiscountamt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn grandtotalColumn => columngrandtotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paymenttypeColumn => columnpaymenttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tablenameColumn => columntablename;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mydateColumn => columnmydate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn inwordsColumn => columninwords;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn paidamtColumn => columnpaidamt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn remainingamtColumn => columnremainingamt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn itemnameColumn => columnitemname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn qtyColumn => columnqty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn priceColumn => columnprice;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalofitemColumn => columntotalofitem;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row this[int index] => (DataTable1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable1RowChangeEventHandler DataTable1RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1DataTable()
		{
			base.TableName = "DataTable1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable1DataTable(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddDataTable1Row(DataTable1Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1Row AddDataTable1Row(string id, string waitername, string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string tablename, string mydate, string inwords, string paidamt, string remainingamt, string itemname, string qty, string price, string totalofitem)
		{
			DataTable1Row dataTable1Row = (DataTable1Row)NewRow();
			object[] itemArray = new object[23]
			{
				id, waitername, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax,
				discounttype, discountamt, grandtotal, paymenttype, tablename, mydate, inwords, paidamt, remainingamt, itemname,
				qty, price, totalofitem
			};
			dataTable1Row.ItemArray = itemArray;
			base.Rows.Add(dataTable1Row);
			return dataTable1Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public virtual IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable1DataTable dataTable1DataTable = (DataTable1DataTable)base.Clone();
			dataTable1DataTable.InitVars();
			return dataTable1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable1DataTable();
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
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columntotalofitem = base.Columns["totalofitem"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(string), null, MappingType.Element);
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
			columnitemname = new DataColumn("itemname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnitemname);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprice);
			columntotalofitem = new DataColumn("totalofitem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotalofitem);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row NewDataTable1Row()
		{
			return (DataTable1Row)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable1Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable1RowChanged != null)
			{
				this.DataTable1RowChanged(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable1RowChanging != null)
			{
				this.DataTable1RowChanging(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable1RowDeleted != null)
			{
				this.DataTable1RowDeleted(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable1RowDeleting != null)
			{
				this.DataTable1RowDeleting(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveDataTable1Row(DataTable1Row row)
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
			DataSet_SaleREPORT dataSet_SaleREPORT = new DataSet_SaleREPORT();
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
			val5.FixedValue = dataSet_SaleREPORT.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "DataTable1DataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_SaleREPORT.GetSchemaSerializable();
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
	public class DataTable11DataTable : DataTable, IEnumerable
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

		private DataColumn columnitemname;

		private DataColumn columnqty;

		private DataColumn columnprice;

		private DataColumn columntotalofitem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn waiternameColumn => columnwaitername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn customernameColumn => columncustomername;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalColumn => columntotal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn selectedtaxColumn => columnselectedtax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn isigstColumn => columnisigst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn igstColumn => columnigst;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn cgstColumn => columncgst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn sgstColumn => columnsgst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalwithtaxColumn => columntotalwithtax;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn discounttypeColumn => columndiscounttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn discountamtColumn => columndiscountamt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn grandtotalColumn => columngrandtotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paymenttypeColumn => columnpaymenttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tablenameColumn => columntablename;

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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn itemnameColumn => columnitemname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn qtyColumn => columnqty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn priceColumn => columnprice;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalofitemColumn => columntotalofitem;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable11Row this[int index] => (DataTable11Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable11RowChangeEventHandler DataTable11RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable11RowChangeEventHandler DataTable11RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable11RowChangeEventHandler DataTable11RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable11RowChangeEventHandler DataTable11RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable11DataTable()
		{
			base.TableName = "DataTable11";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable11DataTable(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable11DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddDataTable11Row(DataTable11Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable11Row AddDataTable11Row(string id, string waitername, string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string tablename, string mydate, string inwords, string paidamt, string remainingamt, string itemname, string qty, string price, string totalofitem)
		{
			DataTable11Row dataTable11Row = (DataTable11Row)NewRow();
			object[] itemArray = new object[23]
			{
				id, waitername, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax,
				discounttype, discountamt, grandtotal, paymenttype, tablename, mydate, inwords, paidamt, remainingamt, itemname,
				qty, price, totalofitem
			};
			dataTable11Row.ItemArray = itemArray;
			base.Rows.Add(dataTable11Row);
			return dataTable11Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public virtual IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			DataTable11DataTable dataTable11DataTable = (DataTable11DataTable)base.Clone();
			dataTable11DataTable.InitVars();
			return dataTable11DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DataTable11DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columntotalofitem = base.Columns["totalofitem"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(string), null, MappingType.Element);
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
			columnitemname = new DataColumn("itemname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnitemname);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprice);
			columntotalofitem = new DataColumn("totalofitem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotalofitem);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable11Row NewDataTable11Row()
		{
			return (DataTable11Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable11Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable11Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable11RowChanged != null)
			{
				this.DataTable11RowChanged(this, new DataTable11RowChangeEvent((DataTable11Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable11RowChanging != null)
			{
				this.DataTable11RowChanging(this, new DataTable11RowChangeEvent((DataTable11Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable11RowDeleted != null)
			{
				this.DataTable11RowDeleted(this, new DataTable11RowChangeEvent((DataTable11Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable11RowDeleting != null)
			{
				this.DataTable11RowDeleting(this, new DataTable11RowChangeEvent((DataTable11Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable11Row(DataTable11Row row)
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
			DataSet_SaleREPORT dataSet_SaleREPORT = new DataSet_SaleREPORT();
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
			val5.FixedValue = dataSet_SaleREPORT.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "DataTable11DataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_SaleREPORT.GetSchemaSerializable();
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
	public class DataTable12DataTable : DataTable, IEnumerable
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

		private DataColumn columnitemname;

		private DataColumn columnqty;

		private DataColumn columnprice;

		private DataColumn columntotalofitem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn waiternameColumn => columnwaitername;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn customernameColumn => columncustomername;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn totalColumn => columntotal;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn totalwithtaxColumn => columntotalwithtax;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn discounttypeColumn => columndiscounttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn discountamtColumn => columndiscountamt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn grandtotalColumn => columngrandtotal;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn paymenttypeColumn => columnpaymenttype;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn tablenameColumn => columntablename;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public DataColumn totalofitemColumn => columntotalofitem;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable12Row this[int index] => (DataTable12Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable12RowChangeEventHandler DataTable12RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable12RowChangeEventHandler DataTable12RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable12RowChangeEventHandler DataTable12RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event DataTable12RowChangeEventHandler DataTable12RowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable12DataTable()
		{
			base.TableName = "DataTable12";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable12DataTable(DataTable table)
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataTable12DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddDataTable12Row(DataTable12Row row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable12Row AddDataTable12Row(string id, string waitername, string customername, string total, string selectedtax, string isigst, string igst, string cgst, string sgst, string totalwithtax, string discounttype, string discountamt, string grandtotal, string paymenttype, string tablename, string mydate, string inwords, string paidamt, string remainingamt, string itemname, string qty, string price, string totalofitem)
		{
			DataTable12Row dataTable12Row = (DataTable12Row)NewRow();
			object[] itemArray = new object[23]
			{
				id, waitername, customername, total, selectedtax, isigst, igst, cgst, sgst, totalwithtax,
				discounttype, discountamt, grandtotal, paymenttype, tablename, mydate, inwords, paidamt, remainingamt, itemname,
				qty, price, totalofitem
			};
			dataTable12Row.ItemArray = itemArray;
			base.Rows.Add(dataTable12Row);
			return dataTable12Row;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public virtual IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			DataTable12DataTable dataTable12DataTable = (DataTable12DataTable)base.Clone();
			dataTable12DataTable.InitVars();
			return dataTable12DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable12DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columntotalofitem = base.Columns["totalofitem"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(string), null, MappingType.Element);
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
			columnitemname = new DataColumn("itemname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnitemname);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprice);
			columntotalofitem = new DataColumn("totalofitem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotalofitem);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable12Row NewDataTable12Row()
		{
			return (DataTable12Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DataTable12Row(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DataTable12Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable12RowChanged != null)
			{
				this.DataTable12RowChanged(this, new DataTable12RowChangeEvent((DataTable12Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable12RowChanging != null)
			{
				this.DataTable12RowChanging(this, new DataTable12RowChangeEvent((DataTable12Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable12RowDeleted != null)
			{
				this.DataTable12RowDeleted(this, new DataTable12RowChangeEvent((DataTable12Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable12RowDeleting != null)
			{
				this.DataTable12RowDeleting(this, new DataTable12RowChangeEvent((DataTable12Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveDataTable12Row(DataTable12Row row)
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
			DataSet_SaleREPORT dataSet_SaleREPORT = new DataSet_SaleREPORT();
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
			val5.FixedValue = dataSet_SaleREPORT.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "DataTable12DataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_SaleREPORT.GetSchemaSerializable();
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

	public class DataTable1Row : DataRow
	{
		private DataTable1DataTable tableDataTable1;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string id
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.idColumn] = value;
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
					return (string)base[tableDataTable1.waiternameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'waitername' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.waiternameColumn] = value;
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
					return (string)base[tableDataTable1.customernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'customername' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.customernameColumn] = value;
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
					return (string)base[tableDataTable1.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.totalColumn] = value;
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
					return (string)base[tableDataTable1.selectedtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'selectedtax' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.selectedtaxColumn] = value;
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
					return (string)base[tableDataTable1.isigstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isigst' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.isigstColumn] = value;
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
					return (string)base[tableDataTable1.igstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'igst' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.igstColumn] = value;
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
					return (string)base[tableDataTable1.cgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cgst' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.cgstColumn] = value;
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
					return (string)base[tableDataTable1.sgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sgst' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.sgstColumn] = value;
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
					return (string)base[tableDataTable1.totalwithtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalwithtax' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.totalwithtaxColumn] = value;
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
					return (string)base[tableDataTable1.discounttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discounttype' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.discounttypeColumn] = value;
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
					return (string)base[tableDataTable1.discountamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discountamt' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.discountamtColumn] = value;
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
					return (string)base[tableDataTable1.grandtotalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grandtotal' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.grandtotalColumn] = value;
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
					return (string)base[tableDataTable1.paymenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paymenttype' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.paymenttypeColumn] = value;
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
					return (string)base[tableDataTable1.tablenameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tablename' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.tablenameColumn] = value;
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
					return (string)base[tableDataTable1.mydateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mydate' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.mydateColumn] = value;
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
					return (string)base[tableDataTable1.inwordsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'inwords' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.inwordsColumn] = value;
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
					return (string)base[tableDataTable1.paidamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paidamt' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.paidamtColumn] = value;
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
					return (string)base[tableDataTable1.remainingamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remainingamt' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.remainingamtColumn] = value;
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
					return (string)base[tableDataTable1.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.itemnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string qty
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.qtyColumn] = value;
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
					return (string)base[tableDataTable1.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.priceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string totalofitem
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.totalofitemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalofitem' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.totalofitemColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal DataTable1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable1 = (DataTable1DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsidNull()
		{
			return IsNull(tableDataTable1.idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetidNull()
		{
			base[tableDataTable1.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IswaiternameNull()
		{
			return IsNull(tableDataTable1.waiternameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetwaiternameNull()
		{
			base[tableDataTable1.waiternameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscustomernameNull()
		{
			return IsNull(tableDataTable1.customernameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcustomernameNull()
		{
			base[tableDataTable1.customernameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalNull()
		{
			return IsNull(tableDataTable1.totalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalNull()
		{
			base[tableDataTable1.totalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsselectedtaxNull()
		{
			return IsNull(tableDataTable1.selectedtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetselectedtaxNull()
		{
			base[tableDataTable1.selectedtaxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsisigstNull()
		{
			return IsNull(tableDataTable1.isigstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetisigstNull()
		{
			base[tableDataTable1.isigstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsigstNull()
		{
			return IsNull(tableDataTable1.igstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetigstNull()
		{
			base[tableDataTable1.igstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscgstNull()
		{
			return IsNull(tableDataTable1.cgstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcgstNull()
		{
			base[tableDataTable1.cgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IssgstNull()
		{
			return IsNull(tableDataTable1.sgstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetsgstNull()
		{
			base[tableDataTable1.sgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalwithtaxNull()
		{
			return IsNull(tableDataTable1.totalwithtaxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalwithtaxNull()
		{
			base[tableDataTable1.totalwithtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdiscounttypeNull()
		{
			return IsNull(tableDataTable1.discounttypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscounttypeNull()
		{
			base[tableDataTable1.discounttypeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdiscountamtNull()
		{
			return IsNull(tableDataTable1.discountamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiscountamtNull()
		{
			base[tableDataTable1.discountamtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsgrandtotalNull()
		{
			return IsNull(tableDataTable1.grandtotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetgrandtotalNull()
		{
			base[tableDataTable1.grandtotalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspaymenttypeNull()
		{
			return IsNull(tableDataTable1.paymenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaymenttypeNull()
		{
			base[tableDataTable1.paymenttypeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstablenameNull()
		{
			return IsNull(tableDataTable1.tablenameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettablenameNull()
		{
			base[tableDataTable1.tablenameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmydateNull()
		{
			return IsNull(tableDataTable1.mydateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetmydateNull()
		{
			base[tableDataTable1.mydateColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsinwordsNull()
		{
			return IsNull(tableDataTable1.inwordsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetinwordsNull()
		{
			base[tableDataTable1.inwordsColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspaidamtNull()
		{
			return IsNull(tableDataTable1.paidamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaidamtNull()
		{
			base[tableDataTable1.paidamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsremainingamtNull()
		{
			return IsNull(tableDataTable1.remainingamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetremainingamtNull()
		{
			base[tableDataTable1.remainingamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsitemnameNull()
		{
			return IsNull(tableDataTable1.itemnameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetitemnameNull()
		{
			base[tableDataTable1.itemnameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsqtyNull()
		{
			return IsNull(tableDataTable1.qtyColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetqtyNull()
		{
			base[tableDataTable1.qtyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspriceNull()
		{
			return IsNull(tableDataTable1.priceColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpriceNull()
		{
			base[tableDataTable1.priceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalofitemNull()
		{
			return IsNull(tableDataTable1.totalofitemColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalofitemNull()
		{
			base[tableDataTable1.totalofitemColumn] = Convert.DBNull;
		}
	}

	public class DataTable11Row : DataRow
	{
		private DataTable11DataTable tableDataTable11;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string id
		{
			get
			{
				try
				{
					return (string)base[tableDataTable11.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.idColumn] = value;
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
					return (string)base[tableDataTable11.waiternameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'waitername' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.waiternameColumn] = value;
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
					return (string)base[tableDataTable11.customernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'customername' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.customernameColumn] = value;
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
					return (string)base[tableDataTable11.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.totalColumn] = value;
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
					return (string)base[tableDataTable11.selectedtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'selectedtax' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.selectedtaxColumn] = value;
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
					return (string)base[tableDataTable11.isigstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isigst' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.isigstColumn] = value;
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
					return (string)base[tableDataTable11.igstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'igst' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.igstColumn] = value;
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
					return (string)base[tableDataTable11.cgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cgst' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.cgstColumn] = value;
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
					return (string)base[tableDataTable11.sgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sgst' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.sgstColumn] = value;
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
					return (string)base[tableDataTable11.totalwithtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalwithtax' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.totalwithtaxColumn] = value;
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
					return (string)base[tableDataTable11.discounttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discounttype' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.discounttypeColumn] = value;
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
					return (string)base[tableDataTable11.discountamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discountamt' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.discountamtColumn] = value;
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
					return (string)base[tableDataTable11.grandtotalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grandtotal' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.grandtotalColumn] = value;
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
					return (string)base[tableDataTable11.paymenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paymenttype' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.paymenttypeColumn] = value;
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
					return (string)base[tableDataTable11.tablenameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tablename' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.tablenameColumn] = value;
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
					return (string)base[tableDataTable11.mydateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mydate' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.mydateColumn] = value;
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
					return (string)base[tableDataTable11.inwordsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'inwords' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.inwordsColumn] = value;
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
					return (string)base[tableDataTable11.paidamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paidamt' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.paidamtColumn] = value;
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
					return (string)base[tableDataTable11.remainingamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remainingamt' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.remainingamtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string itemname
		{
			get
			{
				try
				{
					return (string)base[tableDataTable11.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.itemnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string qty
		{
			get
			{
				try
				{
					return (string)base[tableDataTable11.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.qtyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string price
		{
			get
			{
				try
				{
					return (string)base[tableDataTable11.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.priceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string totalofitem
		{
			get
			{
				try
				{
					return (string)base[tableDataTable11.totalofitemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalofitem' in table 'DataTable11' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable11.totalofitemColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable11Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable11 = (DataTable11DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsidNull()
		{
			return IsNull(tableDataTable11.idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetidNull()
		{
			base[tableDataTable11.idColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IswaiternameNull()
		{
			return IsNull(tableDataTable11.waiternameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetwaiternameNull()
		{
			base[tableDataTable11.waiternameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscustomernameNull()
		{
			return IsNull(tableDataTable11.customernameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcustomernameNull()
		{
			base[tableDataTable11.customernameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalNull()
		{
			return IsNull(tableDataTable11.totalColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalNull()
		{
			base[tableDataTable11.totalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsselectedtaxNull()
		{
			return IsNull(tableDataTable11.selectedtaxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetselectedtaxNull()
		{
			base[tableDataTable11.selectedtaxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsisigstNull()
		{
			return IsNull(tableDataTable11.isigstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetisigstNull()
		{
			base[tableDataTable11.isigstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsigstNull()
		{
			return IsNull(tableDataTable11.igstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetigstNull()
		{
			base[tableDataTable11.igstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscgstNull()
		{
			return IsNull(tableDataTable11.cgstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcgstNull()
		{
			base[tableDataTable11.cgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IssgstNull()
		{
			return IsNull(tableDataTable11.sgstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetsgstNull()
		{
			base[tableDataTable11.sgstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstotalwithtaxNull()
		{
			return IsNull(tableDataTable11.totalwithtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalwithtaxNull()
		{
			base[tableDataTable11.totalwithtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdiscounttypeNull()
		{
			return IsNull(tableDataTable11.discounttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiscounttypeNull()
		{
			base[tableDataTable11.discounttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscountamtNull()
		{
			return IsNull(tableDataTable11.discountamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiscountamtNull()
		{
			base[tableDataTable11.discountamtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsgrandtotalNull()
		{
			return IsNull(tableDataTable11.grandtotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetgrandtotalNull()
		{
			base[tableDataTable11.grandtotalColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaymenttypeNull()
		{
			return IsNull(tableDataTable11.paymenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaymenttypeNull()
		{
			base[tableDataTable11.paymenttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstablenameNull()
		{
			return IsNull(tableDataTable11.tablenameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettablenameNull()
		{
			base[tableDataTable11.tablenameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmydateNull()
		{
			return IsNull(tableDataTable11.mydateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetmydateNull()
		{
			base[tableDataTable11.mydateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsinwordsNull()
		{
			return IsNull(tableDataTable11.inwordsColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetinwordsNull()
		{
			base[tableDataTable11.inwordsColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspaidamtNull()
		{
			return IsNull(tableDataTable11.paidamtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpaidamtNull()
		{
			base[tableDataTable11.paidamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsremainingamtNull()
		{
			return IsNull(tableDataTable11.remainingamtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetremainingamtNull()
		{
			base[tableDataTable11.remainingamtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsitemnameNull()
		{
			return IsNull(tableDataTable11.itemnameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetitemnameNull()
		{
			base[tableDataTable11.itemnameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsqtyNull()
		{
			return IsNull(tableDataTable11.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tableDataTable11.qtyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspriceNull()
		{
			return IsNull(tableDataTable11.priceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpriceNull()
		{
			base[tableDataTable11.priceColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstotalofitemNull()
		{
			return IsNull(tableDataTable11.totalofitemColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalofitemNull()
		{
			base[tableDataTable11.totalofitemColumn] = Convert.DBNull;
		}
	}

	public class DataTable12Row : DataRow
	{
		private DataTable12DataTable tableDataTable12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string id
		{
			get
			{
				try
				{
					return (string)base[tableDataTable12.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.idColumn] = value;
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
					return (string)base[tableDataTable12.waiternameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'waitername' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.waiternameColumn] = value;
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
					return (string)base[tableDataTable12.customernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'customername' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.customernameColumn] = value;
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
					return (string)base[tableDataTable12.totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.totalColumn] = value;
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
					return (string)base[tableDataTable12.selectedtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'selectedtax' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.selectedtaxColumn] = value;
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
					return (string)base[tableDataTable12.isigstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isigst' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.isigstColumn] = value;
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
					return (string)base[tableDataTable12.igstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'igst' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.igstColumn] = value;
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
					return (string)base[tableDataTable12.cgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cgst' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.cgstColumn] = value;
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
					return (string)base[tableDataTable12.sgstColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sgst' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.sgstColumn] = value;
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
					return (string)base[tableDataTable12.totalwithtaxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalwithtax' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.totalwithtaxColumn] = value;
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
					return (string)base[tableDataTable12.discounttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discounttype' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.discounttypeColumn] = value;
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
					return (string)base[tableDataTable12.discountamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discountamt' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.discountamtColumn] = value;
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
					return (string)base[tableDataTable12.grandtotalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grandtotal' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.grandtotalColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string paymenttype
		{
			get
			{
				try
				{
					return (string)base[tableDataTable12.paymenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paymenttype' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.paymenttypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string tablename
		{
			get
			{
				try
				{
					return (string)base[tableDataTable12.tablenameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tablename' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.tablenameColumn] = value;
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
					return (string)base[tableDataTable12.mydateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mydate' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.mydateColumn] = value;
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
					return (string)base[tableDataTable12.inwordsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'inwords' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.inwordsColumn] = value;
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
					return (string)base[tableDataTable12.paidamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paidamt' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.paidamtColumn] = value;
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
					return (string)base[tableDataTable12.remainingamtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remainingamt' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.remainingamtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string itemname
		{
			get
			{
				try
				{
					return (string)base[tableDataTable12.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.itemnameColumn] = value;
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
					return (string)base[tableDataTable12.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.qtyColumn] = value;
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
					return (string)base[tableDataTable12.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.priceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string totalofitem
		{
			get
			{
				try
				{
					return (string)base[tableDataTable12.totalofitemColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'totalofitem' in table 'DataTable12' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable12.totalofitemColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable12Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable12 = (DataTable12DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsidNull()
		{
			return IsNull(tableDataTable12.idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetidNull()
		{
			base[tableDataTable12.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IswaiternameNull()
		{
			return IsNull(tableDataTable12.waiternameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetwaiternameNull()
		{
			base[tableDataTable12.waiternameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IscustomernameNull()
		{
			return IsNull(tableDataTable12.customernameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcustomernameNull()
		{
			base[tableDataTable12.customernameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstotalNull()
		{
			return IsNull(tableDataTable12.totalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalNull()
		{
			base[tableDataTable12.totalColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsselectedtaxNull()
		{
			return IsNull(tableDataTable12.selectedtaxColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetselectedtaxNull()
		{
			base[tableDataTable12.selectedtaxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsisigstNull()
		{
			return IsNull(tableDataTable12.isigstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetisigstNull()
		{
			base[tableDataTable12.isigstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsigstNull()
		{
			return IsNull(tableDataTable12.igstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetigstNull()
		{
			base[tableDataTable12.igstColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscgstNull()
		{
			return IsNull(tableDataTable12.cgstColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetcgstNull()
		{
			base[tableDataTable12.cgstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IssgstNull()
		{
			return IsNull(tableDataTable12.sgstColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetsgstNull()
		{
			base[tableDataTable12.sgstColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstotalwithtaxNull()
		{
			return IsNull(tableDataTable12.totalwithtaxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettotalwithtaxNull()
		{
			base[tableDataTable12.totalwithtaxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscounttypeNull()
		{
			return IsNull(tableDataTable12.discounttypeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscounttypeNull()
		{
			base[tableDataTable12.discounttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscountamtNull()
		{
			return IsNull(tableDataTable12.discountamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdiscountamtNull()
		{
			base[tableDataTable12.discountamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsgrandtotalNull()
		{
			return IsNull(tableDataTable12.grandtotalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetgrandtotalNull()
		{
			base[tableDataTable12.grandtotalColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IspaymenttypeNull()
		{
			return IsNull(tableDataTable12.paymenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaymenttypeNull()
		{
			base[tableDataTable12.paymenttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstablenameNull()
		{
			return IsNull(tableDataTable12.tablenameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettablenameNull()
		{
			base[tableDataTable12.tablenameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsmydateNull()
		{
			return IsNull(tableDataTable12.mydateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetmydateNull()
		{
			base[tableDataTable12.mydateColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsinwordsNull()
		{
			return IsNull(tableDataTable12.inwordsColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetinwordsNull()
		{
			base[tableDataTable12.inwordsColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspaidamtNull()
		{
			return IsNull(tableDataTable12.paidamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetpaidamtNull()
		{
			base[tableDataTable12.paidamtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsremainingamtNull()
		{
			return IsNull(tableDataTable12.remainingamtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetremainingamtNull()
		{
			base[tableDataTable12.remainingamtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsitemnameNull()
		{
			return IsNull(tableDataTable12.itemnameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetitemnameNull()
		{
			base[tableDataTable12.itemnameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsqtyNull()
		{
			return IsNull(tableDataTable12.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tableDataTable12.qtyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspriceNull()
		{
			return IsNull(tableDataTable12.priceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpriceNull()
		{
			base[tableDataTable12.priceColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstotalofitemNull()
		{
			return IsNull(tableDataTable12.totalofitemColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SettotalofitemNull()
		{
			base[tableDataTable12.totalofitemColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable1RowChangeEvent : EventArgs
	{
		private DataTable1Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1RowChangeEvent(DataTable1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable11RowChangeEvent : EventArgs
	{
		private DataTable11Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable11Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable11RowChangeEvent(DataTable11Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable12RowChangeEvent : EventArgs
	{
		private DataTable12Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable12Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable12RowChangeEvent(DataTable12Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private DataTable1DataTable tableDataTable1;

	private DataTable11DataTable tableDataTable11;

	private DataTable12DataTable tableDataTable12;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public DataTable1DataTable DataTable1 => tableDataTable1;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	public DataTable11DataTable DataTable11 => tableDataTable11;

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DataTable12DataTable DataTable12 => tableDataTable12;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
	public DataSet_SaleREPORT()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected DataSet_SaleREPORT(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
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
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
			}
			if (dataSet.Tables["DataTable11"] != null)
			{
				base.Tables.Add(new DataTable11DataTable(dataSet.Tables["DataTable11"]));
			}
			if (dataSet.Tables["DataTable12"] != null)
			{
				base.Tables.Add(new DataTable12DataTable(dataSet.Tables["DataTable12"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		DataSet_SaleREPORT dataSet_SaleREPORT = (DataSet_SaleREPORT)base.Clone();
		dataSet_SaleREPORT.InitVars();
		dataSet_SaleREPORT.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet_SaleREPORT;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
			}
			if (dataSet.Tables["DataTable11"] != null)
			{
				base.Tables.Add(new DataTable11DataTable(dataSet.Tables["DataTable11"]));
			}
			if (dataSet.Tables["DataTable12"] != null)
			{
				base.Tables.Add(new DataTable12DataTable(dataSet.Tables["DataTable12"]));
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableDataTable1 = (DataTable1DataTable)base.Tables["DataTable1"];
		if (initTable && tableDataTable1 != null)
		{
			tableDataTable1.InitVars();
		}
		tableDataTable11 = (DataTable11DataTable)base.Tables["DataTable11"];
		if (initTable && tableDataTable11 != null)
		{
			tableDataTable11.InitVars();
		}
		tableDataTable12 = (DataTable12DataTable)base.Tables["DataTable12"];
		if (initTable && tableDataTable12 != null)
		{
			tableDataTable12.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "DataSet_SaleREPORT";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet_SaleREPORT.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableDataTable1 = new DataTable1DataTable();
		base.Tables.Add(tableDataTable1);
		tableDataTable11 = new DataTable11DataTable();
		base.Tables.Add(tableDataTable11);
		tableDataTable12 = new DataTable12DataTable();
		base.Tables.Add(tableDataTable12);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeDataTable1()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable11()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeDataTable12()
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
		DataSet_SaleREPORT dataSet_SaleREPORT = new DataSet_SaleREPORT();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSet_SaleREPORT.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSet_SaleREPORT.GetSchemaSerializable();
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
