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
[XmlRoot("DataSet_ALLREPORT")]
public class DataSet_ALLREPORT : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DataTable1DataTable : DataTable, IEnumerable
	{
		private DataColumn columnbillno;

		private DataColumn columnmydate;

		private DataColumn columnamount;

		private DataColumn columntax;

		private DataColumn columndiscount;

		private DataColumn columnordertype;

		private DataColumn columnorderfrom;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn billnoColumn => columnbillno;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mydateColumn => columnmydate;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn amountColumn => columnamount;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn taxColumn => columntax;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn discountColumn => columndiscount;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ordertypeColumn => columnordertype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn orderfromColumn => columnorderfrom;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1DataTable()
		{
			base.TableName = "DataTable1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row AddDataTable1Row(string billno, string mydate, string amount, string tax, string discount, string ordertype, string orderfrom)
		{
			DataTable1Row dataTable1Row = (DataTable1Row)NewRow();
			object[] itemArray = new object[7] { billno, mydate, amount, tax, discount, ordertype, orderfrom };
			dataTable1Row.ItemArray = itemArray;
			base.Rows.Add(dataTable1Row);
			return dataTable1Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new DataTable1DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnbillno = base.Columns["billno"];
			columnmydate = base.Columns["mydate"];
			columnamount = base.Columns["amount"];
			columntax = base.Columns["tax"];
			columndiscount = base.Columns["discount"];
			columnordertype = base.Columns["ordertype"];
			columnorderfrom = base.Columns["orderfrom"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			columnbillno = new DataColumn("billno", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnbillno);
			columnmydate = new DataColumn("mydate", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnmydate);
			columnamount = new DataColumn("amount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnamount);
			columntax = new DataColumn("tax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntax);
			columndiscount = new DataColumn("discount", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndiscount);
			columnordertype = new DataColumn("ordertype", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnordertype);
			columnorderfrom = new DataColumn("orderfrom", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnorderfrom);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataTable1Row NewDataTable1Row()
		{
			return (DataTable1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DataTable1RowChanged != null)
			{
				this.DataTable1RowChanged(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DataTable1RowChanging != null)
			{
				this.DataTable1RowChanging(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DataTable1RowDeleted != null)
			{
				this.DataTable1RowDeleted(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DataTable1RowDeleting != null)
			{
				this.DataTable1RowDeleting(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
			DataSet_ALLREPORT dataSet_ALLREPORT = new DataSet_ALLREPORT();
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
			val5.FixedValue = dataSet_ALLREPORT.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "DataTable1DataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSet_ALLREPORT.GetSchemaSerializable();
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
		public string billno
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.billnoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'billno' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.billnoColumn] = value;
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
		public string amount
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.amountColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'amount' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.amountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string tax
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.taxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tax' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.taxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string discount
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.discountColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'discount' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.discountColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ordertype
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.ordertypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ordertype' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.ordertypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string orderfrom
		{
			get
			{
				try
				{
					return (string)base[tableDataTable1.orderfromColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'orderfrom' in table 'DataTable1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDataTable1.orderfromColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal DataTable1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableDataTable1 = (DataTable1DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsbillnoNull()
		{
			return IsNull(tableDataTable1.billnoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetbillnoNull()
		{
			base[tableDataTable1.billnoColumn] = Convert.DBNull;
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsamountNull()
		{
			return IsNull(tableDataTable1.amountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetamountNull()
		{
			base[tableDataTable1.amountColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IstaxNull()
		{
			return IsNull(tableDataTable1.taxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SettaxNull()
		{
			base[tableDataTable1.taxColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdiscountNull()
		{
			return IsNull(tableDataTable1.discountColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdiscountNull()
		{
			base[tableDataTable1.discountColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsordertypeNull()
		{
			return IsNull(tableDataTable1.ordertypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetordertypeNull()
		{
			base[tableDataTable1.ordertypeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsorderfromNull()
		{
			return IsNull(tableDataTable1.orderfromColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetorderfromNull()
		{
			base[tableDataTable1.orderfromColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class DataTable1RowChangeEvent : EventArgs
	{
		private DataTable1Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataTable1RowChangeEvent(DataTable1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private DataTable1DataTable tableDataTable1;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public DataTable1DataTable DataTable1 => tableDataTable1;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(true)]
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
	public DataSet_ALLREPORT()
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
	protected DataSet_ALLREPORT(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
		DataSet_ALLREPORT dataSet_ALLREPORT = (DataSet_ALLREPORT)base.Clone();
		dataSet_ALLREPORT.InitVars();
		dataSet_ALLREPORT.SchemaSerializationMode = SchemaSerializationMode;
		return dataSet_ALLREPORT;
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
			if (dataSet.Tables["DataTable1"] != null)
			{
				base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars(bool initTable)
	{
		tableDataTable1 = (DataTable1DataTable)base.Tables["DataTable1"];
		if (initTable && tableDataTable1 != null)
		{
			tableDataTable1.InitVars();
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitClass()
	{
		base.DataSetName = "DataSet_ALLREPORT";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSet_ALLREPORT.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableDataTable1 = new DataTable1DataTable();
		base.Tables.Add(tableDataTable1);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeDataTable1()
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
		DataSet_ALLREPORT dataSet_ALLREPORT = new DataSet_ALLREPORT();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSet_ALLREPORT.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSet_ALLREPORT.GetSchemaSerializable();
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
