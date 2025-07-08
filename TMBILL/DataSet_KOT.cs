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
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DataSet_KOT")]
public class DataSet_KOT : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void temp_KOTRowChangeEventHandler(object sender, temp_KOTRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class temp_KOTDataTable : DataTable, IEnumerable
	{
		private DataColumn columnid;

		private DataColumn columntablename;

		private DataColumn columnitemname;

		private DataColumn columnqty;

		private DataColumn columnprice;

		private DataColumn columnamount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tablenameColumn => columntablename;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn itemnameColumn => columnitemname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn qtyColumn => columnqty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn priceColumn => columnprice;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn amountColumn => columnamount;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public temp_KOTRow this[int index] => (temp_KOTRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event temp_KOTRowChangeEventHandler temp_KOTRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event temp_KOTRowChangeEventHandler temp_KOTRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event temp_KOTRowChangeEventHandler temp_KOTRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event temp_KOTRowChangeEventHandler temp_KOTRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public temp_KOTDataTable()
		{
			base.TableName = "temp_KOT";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal temp_KOTDataTable(DataTable table)
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
		protected temp_KOTDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addtemp_KOTRow(temp_KOTRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public temp_KOTRow Addtemp_KOTRow(string tablename, string itemname, string qty, string price, string amount)
		{
			temp_KOTRow temp_KOTRow = (temp_KOTRow)NewRow();
			object[] itemArray = new object[6] { null, tablename, itemname, qty, price, amount };
			temp_KOTRow.ItemArray = itemArray;
			base.Rows.Add(temp_KOTRow);
			return temp_KOTRow;
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
			temp_KOTDataTable temp_KOTDataTable = (temp_KOTDataTable)base.Clone();
			temp_KOTDataTable.InitVars();
			return temp_KOTDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new temp_KOTDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columntablename = base.Columns["tablename"];
			columnitemname = base.Columns["itemname"];
			columnqty = base.Columns["qty"];
			columnprice = base.Columns["price"];
			columnamount = base.Columns["amount"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columntablename = new DataColumn("tablename", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntablename);
			columnitemname = new DataColumn("itemname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnitemname);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnprice);
			columnamount = new DataColumn("amount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnamount);
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columntablename.MaxLength = 100;
			columnitemname.MaxLength = 250;
			columnqty.MaxLength = 50;
			columnprice.MaxLength = 50;
			columnamount.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public temp_KOTRow Newtemp_KOTRow()
		{
			return (temp_KOTRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new temp_KOTRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(temp_KOTRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.temp_KOTRowChanged != null)
			{
				this.temp_KOTRowChanged(this, new temp_KOTRowChangeEvent((temp_KOTRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.temp_KOTRowChanging != null)
			{
				this.temp_KOTRowChanging(this, new temp_KOTRowChangeEvent((temp_KOTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.temp_KOTRowDeleted != null)
			{
				this.temp_KOTRowDeleted(this, new temp_KOTRowChangeEvent((temp_KOTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.temp_KOTRowDeleting != null)
			{
				this.temp_KOTRowDeleting(this, new temp_KOTRowChangeEvent((temp_KOTRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Removetemp_KOTRow(temp_KOTRow row)
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
			DataSet_KOT dataSet_KOT = new DataSet_KOT();
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
			val5.FixedValue = dataSet_KOT.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "temp_KOTDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_KOT.GetSchemaSerializable();
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

	public class temp_KOTRow : DataRow
	{
		private temp_KOTDataTable tabletemp_KOT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[tabletemp_KOT.idColumn];
			}
			set
			{
				base[tabletemp_KOT.idColumn] = value;
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
					return (string)base[tabletemp_KOT.tablenameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tablename' in table 'temp_KOT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabletemp_KOT.tablenameColumn] = value;
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
					return (string)base[tabletemp_KOT.itemnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'itemname' in table 'temp_KOT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabletemp_KOT.itemnameColumn] = value;
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
					return (string)base[tabletemp_KOT.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'temp_KOT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabletemp_KOT.qtyColumn] = value;
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
					return (string)base[tabletemp_KOT.priceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'price' in table 'temp_KOT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabletemp_KOT.priceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string amount
		{
			get
			{
				try
				{
					return (string)base[tabletemp_KOT.amountColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'amount' in table 'temp_KOT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tabletemp_KOT.amountColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal temp_KOTRow(DataRowBuilder rb)
			: base(rb)
		{
			tabletemp_KOT = (temp_KOTDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IstablenameNull()
		{
			return IsNull(tabletemp_KOT.tablenameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettablenameNull()
		{
			base[tabletemp_KOT.tablenameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsitemnameNull()
		{
			return IsNull(tabletemp_KOT.itemnameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetitemnameNull()
		{
			base[tabletemp_KOT.itemnameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsqtyNull()
		{
			return IsNull(tabletemp_KOT.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tabletemp_KOT.qtyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IspriceNull()
		{
			return IsNull(tabletemp_KOT.priceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetpriceNull()
		{
			base[tabletemp_KOT.priceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsamountNull()
		{
			return IsNull(tabletemp_KOT.amountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetamountNull()
		{
			base[tabletemp_KOT.amountColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class temp_KOTRowChangeEvent : EventArgs
	{
		private temp_KOTRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public temp_KOTRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public temp_KOTRowChangeEvent(temp_KOTRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private temp_KOTDataTable tabletemp_KOT;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public temp_KOTDataTable temp_KOT => tabletemp_KOT;

	[Browsable(true)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public DataSet_KOT()
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
	protected DataSet_KOT(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
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
			if (dataSet.Tables["temp_KOT"] != null)
			{
				base.Tables.Add(new temp_KOTDataTable(dataSet.Tables["temp_KOT"]));
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		DataSet_KOT dataSet_KOT = (DataSet_KOT)base.Clone();
		dataSet_KOT.InitVars();
		dataSet_KOT.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet_KOT;
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["temp_KOT"] != null)
			{
				base.Tables.Add(new temp_KOTDataTable(dataSet.Tables["temp_KOT"]));
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
		tabletemp_KOT = (temp_KOTDataTable)base.Tables["temp_KOT"];
		if (initTable && tabletemp_KOT != null)
		{
			tabletemp_KOT.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "DataSet_KOT";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet_KOT.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tabletemp_KOT = new temp_KOTDataTable();
		base.Tables.Add(tabletemp_KOT);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializetemp_KOT()
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
		DataSet_KOT dataSet_KOT = new DataSet_KOT();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSet_KOT.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSet_KOT.GetSchemaSerializable();
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
