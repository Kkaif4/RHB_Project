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
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DataSetCheckIn")]
[HelpKeyword("vs.data.DataSet")]
[ToolboxItem(true)]
public class DataSetCheckIn : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void h_guest_entryRowChangeEventHandler(object sender, h_guest_entryRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void roomRowChangeEventHandler(object sender, roomRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void h_checkinRowChangeEventHandler(object sender, h_checkinRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void h_checkin_planRowChangeEventHandler(object sender, h_checkin_planRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class h_guest_entryDataTable : DataTable, IEnumerable
	{
		private DataColumn columnid;

		private DataColumn columnguest_name;

		private DataColumn columngender;

		private DataColumn columncompany_name;

		private DataColumn columnaddress;

		private DataColumn columncity;

		private DataColumn columnmobile_no;

		private DataColumn columnemailid;

		private DataColumn columndocumenttype;

		private DataColumn columndocument_no;

		private DataColumn columnremark;

		private DataColumn columnphoto;

		private DataColumn columndocument_photo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn guest_nameColumn => columnguest_name;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn genderColumn => columngender;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn company_nameColumn => columncompany_name;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn addressColumn => columnaddress;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn cityColumn => columncity;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn mobile_noColumn => columnmobile_no;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn emailidColumn => columnemailid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn documenttypeColumn => columndocumenttype;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn document_noColumn => columndocument_no;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn remarkColumn => columnremark;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn photoColumn => columnphoto;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn document_photoColumn => columndocument_photo;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_guest_entryRow this[int index] => (h_guest_entryRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_guest_entryRowChangeEventHandler h_guest_entryRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_guest_entryRowChangeEventHandler h_guest_entryRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_guest_entryRowChangeEventHandler h_guest_entryRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_guest_entryRowChangeEventHandler h_guest_entryRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_guest_entryDataTable()
		{
			base.TableName = "h_guest_entry";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_guest_entryDataTable(DataTable table)
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
		protected h_guest_entryDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Addh_guest_entryRow(h_guest_entryRow row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_guest_entryRow Addh_guest_entryRow(string guest_name, string gender, string company_name, string address, string city, string mobile_no, string emailid, string documenttype, string document_no, string remark, byte[] photo, byte[] document_photo)
		{
			h_guest_entryRow h_guest_entryRow = (h_guest_entryRow)NewRow();
			object[] itemArray = new object[13]
			{
				null, guest_name, gender, company_name, address, city, mobile_no, emailid, documenttype, document_no,
				remark, photo, document_photo
			};
			h_guest_entryRow.ItemArray = itemArray;
			base.Rows.Add(h_guest_entryRow);
			return h_guest_entryRow;
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
			h_guest_entryDataTable h_guest_entryDataTable = (h_guest_entryDataTable)base.Clone();
			h_guest_entryDataTable.InitVars();
			return h_guest_entryDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new h_guest_entryDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columnguest_name = base.Columns["guest_name"];
			columngender = base.Columns["gender"];
			columncompany_name = base.Columns["company_name"];
			columnaddress = base.Columns["address"];
			columncity = base.Columns["city"];
			columnmobile_no = base.Columns["mobile_no"];
			columnemailid = base.Columns["emailid"];
			columndocumenttype = base.Columns["documenttype"];
			columndocument_no = base.Columns["document_no"];
			columnremark = base.Columns["remark"];
			columnphoto = base.Columns["photo"];
			columndocument_photo = base.Columns["document_photo"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columnguest_name = new DataColumn("guest_name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnguest_name);
			columngender = new DataColumn("gender", typeof(string), null, MappingType.Element);
			base.Columns.Add(columngender);
			columncompany_name = new DataColumn("company_name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncompany_name);
			columnaddress = new DataColumn("address", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnaddress);
			columncity = new DataColumn("city", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncity);
			columnmobile_no = new DataColumn("mobile_no", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnmobile_no);
			columnemailid = new DataColumn("emailid", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnemailid);
			columndocumenttype = new DataColumn("documenttype", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndocumenttype);
			columndocument_no = new DataColumn("document_no", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndocument_no);
			columnremark = new DataColumn("remark", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnremark);
			columnphoto = new DataColumn("photo", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnphoto);
			columndocument_photo = new DataColumn("document_photo", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columndocument_photo);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnmobile_no }, isPrimaryKey: false));
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnguest_name.MaxLength = 100;
			columngender.MaxLength = 50;
			columncompany_name.MaxLength = 50;
			columnaddress.MaxLength = 100;
			columncity.MaxLength = 100;
			columnmobile_no.Unique = true;
			columnmobile_no.MaxLength = 50;
			columnemailid.MaxLength = 50;
			columndocumenttype.MaxLength = 50;
			columndocument_no.MaxLength = 500;
			columnremark.MaxLength = 500;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_guest_entryRow Newh_guest_entryRow()
		{
			return (h_guest_entryRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new h_guest_entryRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(h_guest_entryRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.h_guest_entryRowChanged != null)
			{
				this.h_guest_entryRowChanged(this, new h_guest_entryRowChangeEvent((h_guest_entryRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.h_guest_entryRowChanging != null)
			{
				this.h_guest_entryRowChanging(this, new h_guest_entryRowChangeEvent((h_guest_entryRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.h_guest_entryRowDeleted != null)
			{
				this.h_guest_entryRowDeleted(this, new h_guest_entryRowChangeEvent((h_guest_entryRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.h_guest_entryRowDeleting != null)
			{
				this.h_guest_entryRowDeleting(this, new h_guest_entryRowChangeEvent((h_guest_entryRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Removeh_guest_entryRow(h_guest_entryRow row)
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
			DataSetCheckIn dataSetCheckIn = new DataSetCheckIn();
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
			val5.FixedValue = dataSetCheckIn.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "h_guest_entryDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSetCheckIn.GetSchemaSerializable();
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
	public class roomDataTable : DataTable, IEnumerable
	{
		private DataColumn columnid;

		private DataColumn columnroomname;

		private DataColumn columnroomtype;

		private DataColumn columndescription;

		private DataColumn columnstatus;

		private DataColumn columncharges;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn roomnameColumn => columnroomname;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn roomtypeColumn => columnroomtype;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn descriptionColumn => columndescription;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn statusColumn => columnstatus;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn chargesColumn => columncharges;

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public roomRow this[int index] => (roomRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event roomRowChangeEventHandler roomRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event roomRowChangeEventHandler roomRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event roomRowChangeEventHandler roomRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event roomRowChangeEventHandler roomRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public roomDataTable()
		{
			base.TableName = "room";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal roomDataTable(DataTable table)
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
		protected roomDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddroomRow(roomRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public roomRow AddroomRow(string roomname, string roomtype, string description, string status, string charges)
		{
			roomRow roomRow = (roomRow)NewRow();
			object[] itemArray = new object[6] { null, roomname, roomtype, description, status, charges };
			roomRow.ItemArray = itemArray;
			base.Rows.Add(roomRow);
			return roomRow;
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
			roomDataTable roomDataTable = (roomDataTable)base.Clone();
			roomDataTable.InitVars();
			return roomDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new roomDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columnroomname = base.Columns["roomname"];
			columnroomtype = base.Columns["roomtype"];
			columndescription = base.Columns["description"];
			columnstatus = base.Columns["status"];
			columncharges = base.Columns["charges"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columnroomname = new DataColumn("roomname", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnroomname);
			columnroomtype = new DataColumn("roomtype", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnroomtype);
			columndescription = new DataColumn("description", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndescription);
			columnstatus = new DataColumn("status", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnstatus);
			columncharges = new DataColumn("charges", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncharges);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnroomname }, isPrimaryKey: false));
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnroomname.Unique = true;
			columnroomname.MaxLength = 50;
			columnroomtype.MaxLength = 50;
			columndescription.MaxLength = 200;
			columnstatus.MaxLength = 50;
			columncharges.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public roomRow NewroomRow()
		{
			return (roomRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new roomRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(roomRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.roomRowChanged != null)
			{
				this.roomRowChanged(this, new roomRowChangeEvent((roomRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.roomRowChanging != null)
			{
				this.roomRowChanging(this, new roomRowChangeEvent((roomRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.roomRowDeleted != null)
			{
				this.roomRowDeleted(this, new roomRowChangeEvent((roomRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.roomRowDeleting != null)
			{
				this.roomRowDeleting(this, new roomRowChangeEvent((roomRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveroomRow(roomRow row)
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
			DataSetCheckIn dataSetCheckIn = new DataSetCheckIn();
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
			val5.FixedValue = dataSetCheckIn.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "roomDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSetCheckIn.GetSchemaSerializable();
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
	public class h_checkinDataTable : DataTable, IEnumerable
	{
		private DataColumn columnid;

		private DataColumn columnref_by;

		private DataColumn columnref_name;

		private DataColumn columnmobile_no;

		private DataColumn columncheck_date;

		private DataColumn columncheck_out_date;

		private DataColumn columnp_male;

		private DataColumn columnp_female;

		private DataColumn columnp_child;

		private DataColumn columnroom_charge;

		private DataColumn columntotal_room_charge;

		private DataColumn columnextra_charge;

		private DataColumn columntotal_charge;

		private DataColumn columntax_amt;

		private DataColumn columnafter_tax;

		private DataColumn columndis_amt;

		private DataColumn columntax_plan;

		private DataColumn columndis_plan;

		private DataColumn columngrand_total;

		private DataColumn columnpaid_amt;

		private DataColumn columnremaining;

		private DataColumn columnonlinebooked;

		private DataColumn columnpayment_method;

		private DataColumn columnbooking_date;

		private DataColumn columnroom_id;

		private DataColumn columntotal_days;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idColumn => columnid;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ref_byColumn => columnref_by;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ref_nameColumn => columnref_name;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn mobile_noColumn => columnmobile_no;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn check_dateColumn => columncheck_date;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn check_out_dateColumn => columncheck_out_date;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn p_maleColumn => columnp_male;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn p_femaleColumn => columnp_female;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn p_childColumn => columnp_child;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn room_chargeColumn => columnroom_charge;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn total_room_chargeColumn => columntotal_room_charge;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn extra_chargeColumn => columnextra_charge;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn total_chargeColumn => columntotal_charge;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tax_amtColumn => columntax_amt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn after_taxColumn => columnafter_tax;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn dis_amtColumn => columndis_amt;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn tax_planColumn => columntax_plan;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn dis_planColumn => columndis_plan;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn grand_totalColumn => columngrand_total;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn paid_amtColumn => columnpaid_amt;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn remainingColumn => columnremaining;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn onlinebookedColumn => columnonlinebooked;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn payment_methodColumn => columnpayment_method;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn booking_dateColumn => columnbooking_date;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn room_idColumn => columnroom_id;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn total_daysColumn => columntotal_days;

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_checkinRow this[int index] => (h_checkinRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkinRowChangeEventHandler h_checkinRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkinRowChangeEventHandler h_checkinRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkinRowChangeEventHandler h_checkinRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkinRowChangeEventHandler h_checkinRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkinDataTable()
		{
			base.TableName = "h_checkin";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_checkinDataTable(DataTable table)
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
		protected h_checkinDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Addh_checkinRow(h_checkinRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkinRow Addh_checkinRow(string ref_by, string ref_name, string mobile_no, string check_date, string check_out_date, string p_male, string p_female, string p_child, string room_charge, string total_room_charge, string extra_charge, string total_charge, string tax_amt, string after_tax, string dis_amt, string tax_plan, string dis_plan, string grand_total, string paid_amt, string remaining, string onlinebooked, string payment_method, string booking_date, string room_id, string total_days)
		{
			h_checkinRow h_checkinRow = (h_checkinRow)NewRow();
			object[] itemArray = new object[26]
			{
				null, ref_by, ref_name, mobile_no, check_date, check_out_date, p_male, p_female, p_child, room_charge,
				total_room_charge, extra_charge, total_charge, tax_amt, after_tax, dis_amt, tax_plan, dis_plan, grand_total, paid_amt,
				remaining, onlinebooked, payment_method, booking_date, room_id, total_days
			};
			h_checkinRow.ItemArray = itemArray;
			base.Rows.Add(h_checkinRow);
			return h_checkinRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual IEnumerator GetEnumerator()
		{
			return base.Rows.GetEnumerator();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			h_checkinDataTable h_checkinDataTable = (h_checkinDataTable)base.Clone();
			h_checkinDataTable.InitVars();
			return h_checkinDataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new h_checkinDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columnref_by = base.Columns["ref_by"];
			columnref_name = base.Columns["ref_name"];
			columnmobile_no = base.Columns["mobile_no"];
			columncheck_date = base.Columns["check_date"];
			columncheck_out_date = base.Columns["check_out_date"];
			columnp_male = base.Columns["p_male"];
			columnp_female = base.Columns["p_female"];
			columnp_child = base.Columns["p_child"];
			columnroom_charge = base.Columns["room_charge"];
			columntotal_room_charge = base.Columns["total_room_charge"];
			columnextra_charge = base.Columns["extra_charge"];
			columntotal_charge = base.Columns["total_charge"];
			columntax_amt = base.Columns["tax_amt"];
			columnafter_tax = base.Columns["after_tax"];
			columndis_amt = base.Columns["dis_amt"];
			columntax_plan = base.Columns["tax_plan"];
			columndis_plan = base.Columns["dis_plan"];
			columngrand_total = base.Columns["grand_total"];
			columnpaid_amt = base.Columns["paid_amt"];
			columnremaining = base.Columns["remaining"];
			columnonlinebooked = base.Columns["onlinebooked"];
			columnpayment_method = base.Columns["payment_method"];
			columnbooking_date = base.Columns["booking_date"];
			columnroom_id = base.Columns["room_id"];
			columntotal_days = base.Columns["total_days"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columnref_by = new DataColumn("ref_by", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnref_by);
			columnref_name = new DataColumn("ref_name", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnref_name);
			columnmobile_no = new DataColumn("mobile_no", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnmobile_no);
			columncheck_date = new DataColumn("check_date", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncheck_date);
			columncheck_out_date = new DataColumn("check_out_date", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncheck_out_date);
			columnp_male = new DataColumn("p_male", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnp_male);
			columnp_female = new DataColumn("p_female", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnp_female);
			columnp_child = new DataColumn("p_child", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnp_child);
			columnroom_charge = new DataColumn("room_charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnroom_charge);
			columntotal_room_charge = new DataColumn("total_room_charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotal_room_charge);
			columnextra_charge = new DataColumn("extra_charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnextra_charge);
			columntotal_charge = new DataColumn("total_charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotal_charge);
			columntax_amt = new DataColumn("tax_amt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntax_amt);
			columnafter_tax = new DataColumn("after_tax", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnafter_tax);
			columndis_amt = new DataColumn("dis_amt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndis_amt);
			columntax_plan = new DataColumn("tax_plan", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntax_plan);
			columndis_plan = new DataColumn("dis_plan", typeof(string), null, MappingType.Element);
			base.Columns.Add(columndis_plan);
			columngrand_total = new DataColumn("grand_total", typeof(string), null, MappingType.Element);
			base.Columns.Add(columngrand_total);
			columnpaid_amt = new DataColumn("paid_amt", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpaid_amt);
			columnremaining = new DataColumn("remaining", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnremaining);
			columnonlinebooked = new DataColumn("onlinebooked", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnonlinebooked);
			columnpayment_method = new DataColumn("payment_method", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnpayment_method);
			columnbooking_date = new DataColumn("booking_date", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnbooking_date);
			columnroom_id = new DataColumn("room_id", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnroom_id);
			columntotal_days = new DataColumn("total_days", typeof(string), null, MappingType.Element);
			base.Columns.Add(columntotal_days);
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnref_by.MaxLength = 50;
			columnref_name.MaxLength = 50;
			columnmobile_no.MaxLength = 50;
			columncheck_date.MaxLength = 50;
			columncheck_out_date.MaxLength = 50;
			columnp_male.MaxLength = 50;
			columnp_female.MaxLength = 50;
			columnp_child.MaxLength = 50;
			columnroom_charge.MaxLength = 50;
			columntotal_room_charge.MaxLength = 50;
			columnextra_charge.MaxLength = 50;
			columntotal_charge.MaxLength = 50;
			columntax_amt.MaxLength = 50;
			columnafter_tax.MaxLength = 50;
			columndis_amt.MaxLength = 50;
			columntax_plan.MaxLength = 50;
			columndis_plan.MaxLength = 50;
			columngrand_total.MaxLength = 50;
			columnpaid_amt.MaxLength = 50;
			columnremaining.MaxLength = 50;
			columnonlinebooked.MaxLength = 50;
			columnpayment_method.MaxLength = 50;
			columnbooking_date.MaxLength = 50;
			columnroom_id.MaxLength = 50;
			columntotal_days.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkinRow Newh_checkinRow()
		{
			return (h_checkinRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new h_checkinRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(h_checkinRow);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.h_checkinRowChanged != null)
			{
				this.h_checkinRowChanged(this, new h_checkinRowChangeEvent((h_checkinRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.h_checkinRowChanging != null)
			{
				this.h_checkinRowChanging(this, new h_checkinRowChangeEvent((h_checkinRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.h_checkinRowDeleted != null)
			{
				this.h_checkinRowDeleted(this, new h_checkinRowChangeEvent((h_checkinRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.h_checkinRowDeleting != null)
			{
				this.h_checkinRowDeleting(this, new h_checkinRowChangeEvent((h_checkinRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Removeh_checkinRow(h_checkinRow row)
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
			DataSetCheckIn dataSetCheckIn = new DataSetCheckIn();
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
			val5.FixedValue = dataSetCheckIn.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "h_checkinDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSetCheckIn.GetSchemaSerializable();
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
	public class h_checkin_planDataTable : DataTable, IEnumerable
	{
		private DataColumn columnid;

		private DataColumn columnroom_id;

		private DataColumn columnplan_charge;

		private DataColumn columncharge;

		private DataColumn columnqty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idColumn => columnid;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn room_idColumn => columnroom_id;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn plan_chargeColumn => columnplan_charge;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn chargeColumn => columncharge;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn qtyColumn => columnqty;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkin_planRow this[int index] => (h_checkin_planRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkin_planRowChangeEventHandler h_checkin_planRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkin_planRowChangeEventHandler h_checkin_planRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkin_planRowChangeEventHandler h_checkin_planRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event h_checkin_planRowChangeEventHandler h_checkin_planRowDeleted;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_checkin_planDataTable()
		{
			base.TableName = "h_checkin_plan";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_checkin_planDataTable(DataTable table)
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
		protected h_checkin_planDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Addh_checkin_planRow(h_checkin_planRow row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_checkin_planRow Addh_checkin_planRow(string room_id, string plan_charge, string charge, string qty)
		{
			h_checkin_planRow h_checkin_planRow = (h_checkin_planRow)NewRow();
			object[] itemArray = new object[5] { null, room_id, plan_charge, charge, qty };
			h_checkin_planRow.ItemArray = itemArray;
			base.Rows.Add(h_checkin_planRow);
			return h_checkin_planRow;
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
			h_checkin_planDataTable h_checkin_planDataTable = (h_checkin_planDataTable)base.Clone();
			h_checkin_planDataTable.InitVars();
			return h_checkin_planDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new h_checkin_planDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnid = base.Columns["id"];
			columnroom_id = base.Columns["room_id"];
			columnplan_charge = base.Columns["plan_charge"];
			columncharge = base.Columns["charge"];
			columnqty = base.Columns["qty"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnid);
			columnroom_id = new DataColumn("room_id", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnroom_id);
			columnplan_charge = new DataColumn("plan_charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnplan_charge);
			columncharge = new DataColumn("charge", typeof(string), null, MappingType.Element);
			base.Columns.Add(columncharge);
			columnqty = new DataColumn("qty", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnqty);
			columnid.AutoIncrement = true;
			columnid.AutoIncrementSeed = -1L;
			columnid.AutoIncrementStep = -1L;
			columnid.AllowDBNull = false;
			columnid.ReadOnly = true;
			columnroom_id.MaxLength = 50;
			columnplan_charge.MaxLength = 100;
			columncharge.MaxLength = 50;
			columnqty.MaxLength = 50;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkin_planRow Newh_checkin_planRow()
		{
			return (h_checkin_planRow)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new h_checkin_planRow(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(h_checkin_planRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.h_checkin_planRowChanged != null)
			{
				this.h_checkin_planRowChanged(this, new h_checkin_planRowChangeEvent((h_checkin_planRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.h_checkin_planRowChanging != null)
			{
				this.h_checkin_planRowChanging(this, new h_checkin_planRowChangeEvent((h_checkin_planRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.h_checkin_planRowDeleted != null)
			{
				this.h_checkin_planRowDeleted(this, new h_checkin_planRowChangeEvent((h_checkin_planRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.h_checkin_planRowDeleting != null)
			{
				this.h_checkin_planRowDeleting(this, new h_checkin_planRowChangeEvent((h_checkin_planRow)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Removeh_checkin_planRow(h_checkin_planRow row)
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
			DataSetCheckIn dataSetCheckIn = new DataSetCheckIn();
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
			val5.FixedValue = dataSetCheckIn.Namespace;
			val.Attributes.Add((XmlSchemaObject)(object)val5);
			XmlSchemaAttribute val6 = new XmlSchemaAttribute();
			val6.Name = "tableTypeName";
			val6.FixedValue = "h_checkin_planDataTable";
			val.Attributes.Add((XmlSchemaObject)(object)val6);
			val.Particle = (XmlSchemaParticle)(object)val2;
			XmlSchema schemaSerializable = dataSetCheckIn.GetSchemaSerializable();
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

	public class h_guest_entryRow : DataRow
	{
		private h_guest_entryDataTable tableh_guest_entry;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[tableh_guest_entry.idColumn];
			}
			set
			{
				base[tableh_guest_entry.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string guest_name
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.guest_nameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'guest_name' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.guest_nameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string gender
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.genderColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'gender' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.genderColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string company_name
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.company_nameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'company_name' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.company_nameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string address
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.addressColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'address' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.addressColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string city
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.cityColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'city' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.cityColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mobile_no
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.mobile_noColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mobile_no' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.mobile_noColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string emailid
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.emailidColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'emailid' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.emailidColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string documenttype
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.documenttypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'documenttype' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.documenttypeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string document_no
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.document_noColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'document_no' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.document_noColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string remark
		{
			get
			{
				try
				{
					return (string)base[tableh_guest_entry.remarkColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remark' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.remarkColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public byte[] photo
		{
			get
			{
				try
				{
					return (byte[])base[tableh_guest_entry.photoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'photo' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.photoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public byte[] document_photo
		{
			get
			{
				try
				{
					return (byte[])base[tableh_guest_entry.document_photoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'document_photo' in table 'h_guest_entry' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_guest_entry.document_photoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_guest_entryRow(DataRowBuilder rb)
			: base(rb)
		{
			tableh_guest_entry = (h_guest_entryDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isguest_nameNull()
		{
			return IsNull(tableh_guest_entry.guest_nameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setguest_nameNull()
		{
			base[tableh_guest_entry.guest_nameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsgenderNull()
		{
			return IsNull(tableh_guest_entry.genderColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetgenderNull()
		{
			base[tableh_guest_entry.genderColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Iscompany_nameNull()
		{
			return IsNull(tableh_guest_entry.company_nameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setcompany_nameNull()
		{
			base[tableh_guest_entry.company_nameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsaddressNull()
		{
			return IsNull(tableh_guest_entry.addressColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetaddressNull()
		{
			base[tableh_guest_entry.addressColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IscityNull()
		{
			return IsNull(tableh_guest_entry.cityColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetcityNull()
		{
			base[tableh_guest_entry.cityColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ismobile_noNull()
		{
			return IsNull(tableh_guest_entry.mobile_noColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setmobile_noNull()
		{
			base[tableh_guest_entry.mobile_noColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsemailidNull()
		{
			return IsNull(tableh_guest_entry.emailidColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetemailidNull()
		{
			base[tableh_guest_entry.emailidColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsdocumenttypeNull()
		{
			return IsNull(tableh_guest_entry.documenttypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetdocumenttypeNull()
		{
			base[tableh_guest_entry.documenttypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isdocument_noNull()
		{
			return IsNull(tableh_guest_entry.document_noColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdocument_noNull()
		{
			base[tableh_guest_entry.document_noColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsremarkNull()
		{
			return IsNull(tableh_guest_entry.remarkColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetremarkNull()
		{
			base[tableh_guest_entry.remarkColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsphotoNull()
		{
			return IsNull(tableh_guest_entry.photoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetphotoNull()
		{
			base[tableh_guest_entry.photoColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isdocument_photoNull()
		{
			return IsNull(tableh_guest_entry.document_photoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdocument_photoNull()
		{
			base[tableh_guest_entry.document_photoColumn] = Convert.DBNull;
		}
	}

	public class roomRow : DataRow
	{
		private roomDataTable tableroom;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[tableroom.idColumn];
			}
			set
			{
				base[tableroom.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string roomname
		{
			get
			{
				try
				{
					return (string)base[tableroom.roomnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'roomname' in table 'room' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableroom.roomnameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string roomtype
		{
			get
			{
				try
				{
					return (string)base[tableroom.roomtypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'roomtype' in table 'room' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableroom.roomtypeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string description
		{
			get
			{
				try
				{
					return (string)base[tableroom.descriptionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'description' in table 'room' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableroom.descriptionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string status
		{
			get
			{
				try
				{
					return (string)base[tableroom.statusColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'status' in table 'room' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableroom.statusColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string charges
		{
			get
			{
				try
				{
					return (string)base[tableroom.chargesColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'charges' in table 'room' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableroom.chargesColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal roomRow(DataRowBuilder rb)
			: base(rb)
		{
			tableroom = (roomDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsroomnameNull()
		{
			return IsNull(tableroom.roomnameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetroomnameNull()
		{
			base[tableroom.roomnameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsroomtypeNull()
		{
			return IsNull(tableroom.roomtypeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetroomtypeNull()
		{
			base[tableroom.roomtypeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsdescriptionNull()
		{
			return IsNull(tableroom.descriptionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetdescriptionNull()
		{
			base[tableroom.descriptionColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsstatusNull()
		{
			return IsNull(tableroom.statusColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetstatusNull()
		{
			base[tableroom.statusColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IschargesNull()
		{
			return IsNull(tableroom.chargesColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetchargesNull()
		{
			base[tableroom.chargesColumn] = Convert.DBNull;
		}
	}

	public class h_checkinRow : DataRow
	{
		private h_checkinDataTable tableh_checkin;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[tableh_checkin.idColumn];
			}
			set
			{
				base[tableh_checkin.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ref_by
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.ref_byColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ref_by' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.ref_byColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ref_name
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.ref_nameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ref_name' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.ref_nameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string mobile_no
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.mobile_noColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'mobile_no' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.mobile_noColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string check_date
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.check_dateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'check_date' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.check_dateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string check_out_date
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.check_out_dateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'check_out_date' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.check_out_dateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string p_male
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.p_maleColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'p_male' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.p_maleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string p_female
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.p_femaleColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'p_female' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.p_femaleColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string p_child
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.p_childColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'p_child' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.p_childColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string room_charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.room_chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'room_charge' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.room_chargeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string total_room_charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.total_room_chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total_room_charge' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.total_room_chargeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string extra_charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.extra_chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extra_charge' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.extra_chargeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string total_charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.total_chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total_charge' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.total_chargeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string tax_amt
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.tax_amtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tax_amt' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.tax_amtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string after_tax
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.after_taxColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'after_tax' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.after_taxColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string dis_amt
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.dis_amtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dis_amt' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.dis_amtColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string tax_plan
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.tax_planColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tax_plan' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.tax_planColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string dis_plan
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.dis_planColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dis_plan' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.dis_planColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string grand_total
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.grand_totalColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'grand_total' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.grand_totalColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string paid_amt
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.paid_amtColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'paid_amt' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.paid_amtColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string remaining
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.remainingColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'remaining' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.remainingColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string onlinebooked
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.onlinebookedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'onlinebooked' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.onlinebookedColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string payment_method
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.payment_methodColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'payment_method' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.payment_methodColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string booking_date
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.booking_dateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'booking_date' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.booking_dateColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string room_id
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.room_idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'room_id' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.room_idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string total_days
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin.total_daysColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'total_days' in table 'h_checkin' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin.total_daysColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_checkinRow(DataRowBuilder rb)
			: base(rb)
		{
			tableh_checkin = (h_checkinDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isref_byNull()
		{
			return IsNull(tableh_checkin.ref_byColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setref_byNull()
		{
			base[tableh_checkin.ref_byColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isref_nameNull()
		{
			return IsNull(tableh_checkin.ref_nameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setref_nameNull()
		{
			base[tableh_checkin.ref_nameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ismobile_noNull()
		{
			return IsNull(tableh_checkin.mobile_noColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setmobile_noNull()
		{
			base[tableh_checkin.mobile_noColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ischeck_dateNull()
		{
			return IsNull(tableh_checkin.check_dateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setcheck_dateNull()
		{
			base[tableh_checkin.check_dateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ischeck_out_dateNull()
		{
			return IsNull(tableh_checkin.check_out_dateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setcheck_out_dateNull()
		{
			base[tableh_checkin.check_out_dateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isp_maleNull()
		{
			return IsNull(tableh_checkin.p_maleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setp_maleNull()
		{
			base[tableh_checkin.p_maleColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isp_femaleNull()
		{
			return IsNull(tableh_checkin.p_femaleColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setp_femaleNull()
		{
			base[tableh_checkin.p_femaleColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isp_childNull()
		{
			return IsNull(tableh_checkin.p_childColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setp_childNull()
		{
			base[tableh_checkin.p_childColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isroom_chargeNull()
		{
			return IsNull(tableh_checkin.room_chargeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setroom_chargeNull()
		{
			base[tableh_checkin.room_chargeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Istotal_room_chargeNull()
		{
			return IsNull(tableh_checkin.total_room_chargeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Settotal_room_chargeNull()
		{
			base[tableh_checkin.total_room_chargeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isextra_chargeNull()
		{
			return IsNull(tableh_checkin.extra_chargeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setextra_chargeNull()
		{
			base[tableh_checkin.extra_chargeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Istotal_chargeNull()
		{
			return IsNull(tableh_checkin.total_chargeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settotal_chargeNull()
		{
			base[tableh_checkin.total_chargeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Istax_amtNull()
		{
			return IsNull(tableh_checkin.tax_amtColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Settax_amtNull()
		{
			base[tableh_checkin.tax_amtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isafter_taxNull()
		{
			return IsNull(tableh_checkin.after_taxColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setafter_taxNull()
		{
			base[tableh_checkin.after_taxColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isdis_amtNull()
		{
			return IsNull(tableh_checkin.dis_amtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdis_amtNull()
		{
			base[tableh_checkin.dis_amtColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Istax_planNull()
		{
			return IsNull(tableh_checkin.tax_planColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settax_planNull()
		{
			base[tableh_checkin.tax_planColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isdis_planNull()
		{
			return IsNull(tableh_checkin.dis_planColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setdis_planNull()
		{
			base[tableh_checkin.dis_planColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isgrand_totalNull()
		{
			return IsNull(tableh_checkin.grand_totalColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setgrand_totalNull()
		{
			base[tableh_checkin.grand_totalColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Ispaid_amtNull()
		{
			return IsNull(tableh_checkin.paid_amtColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Setpaid_amtNull()
		{
			base[tableh_checkin.paid_amtColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsremainingNull()
		{
			return IsNull(tableh_checkin.remainingColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetremainingNull()
		{
			base[tableh_checkin.remainingColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsonlinebookedNull()
		{
			return IsNull(tableh_checkin.onlinebookedColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetonlinebookedNull()
		{
			base[tableh_checkin.onlinebookedColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Ispayment_methodNull()
		{
			return IsNull(tableh_checkin.payment_methodColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setpayment_methodNull()
		{
			base[tableh_checkin.payment_methodColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isbooking_dateNull()
		{
			return IsNull(tableh_checkin.booking_dateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setbooking_dateNull()
		{
			base[tableh_checkin.booking_dateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Isroom_idNull()
		{
			return IsNull(tableh_checkin.room_idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setroom_idNull()
		{
			base[tableh_checkin.room_idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Istotal_daysNull()
		{
			return IsNull(tableh_checkin.total_daysColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Settotal_daysNull()
		{
			base[tableh_checkin.total_daysColumn] = Convert.DBNull;
		}
	}

	public class h_checkin_planRow : DataRow
	{
		private h_checkin_planDataTable tableh_checkin_plan;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[tableh_checkin_plan.idColumn];
			}
			set
			{
				base[tableh_checkin_plan.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string room_id
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin_plan.room_idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'room_id' in table 'h_checkin_plan' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin_plan.room_idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string plan_charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin_plan.plan_chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'plan_charge' in table 'h_checkin_plan' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin_plan.plan_chargeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string charge
		{
			get
			{
				try
				{
					return (string)base[tableh_checkin_plan.chargeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'charge' in table 'h_checkin_plan' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin_plan.chargeColumn] = value;
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
					return (string)base[tableh_checkin_plan.qtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'qty' in table 'h_checkin_plan' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableh_checkin_plan.qtyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal h_checkin_planRow(DataRowBuilder rb)
			: base(rb)
		{
			tableh_checkin_plan = (h_checkin_planDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isroom_idNull()
		{
			return IsNull(tableh_checkin_plan.room_idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setroom_idNull()
		{
			base[tableh_checkin_plan.room_idColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Isplan_chargeNull()
		{
			return IsNull(tableh_checkin_plan.plan_chargeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void Setplan_chargeNull()
		{
			base[tableh_checkin_plan.plan_chargeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IschargeNull()
		{
			return IsNull(tableh_checkin_plan.chargeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetchargeNull()
		{
			base[tableh_checkin_plan.chargeColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsqtyNull()
		{
			return IsNull(tableh_checkin_plan.qtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetqtyNull()
		{
			base[tableh_checkin_plan.qtyColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class h_guest_entryRowChangeEvent : EventArgs
	{
		private h_guest_entryRow eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_guest_entryRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_guest_entryRowChangeEvent(h_guest_entryRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class roomRowChangeEvent : EventArgs
	{
		private roomRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public roomRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public roomRowChangeEvent(roomRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class h_checkinRowChangeEvent : EventArgs
	{
		private h_checkinRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkinRow Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_checkinRowChangeEvent(h_checkinRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class h_checkin_planRowChangeEvent : EventArgs
	{
		private h_checkin_planRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public h_checkin_planRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public h_checkin_planRowChangeEvent(h_checkin_planRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private h_guest_entryDataTable tableh_guest_entry;

	private roomDataTable tableroom;

	private h_checkinDataTable tableh_checkin;

	private h_checkin_planDataTable tableh_checkin_plan;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public h_guest_entryDataTable h_guest_entry => tableh_guest_entry;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public roomDataTable room => tableroom;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public h_checkinDataTable h_checkin => tableh_checkin;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public h_checkin_planDataTable h_checkin_plan => tableh_checkin_plan;

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

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public DataSetCheckIn()
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
	protected DataSetCheckIn(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
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
			if (dataSet.Tables["h_guest_entry"] != null)
			{
				base.Tables.Add(new h_guest_entryDataTable(dataSet.Tables["h_guest_entry"]));
			}
			if (dataSet.Tables["room"] != null)
			{
				base.Tables.Add(new roomDataTable(dataSet.Tables["room"]));
			}
			if (dataSet.Tables["h_checkin"] != null)
			{
				base.Tables.Add(new h_checkinDataTable(dataSet.Tables["h_checkin"]));
			}
			if (dataSet.Tables["h_checkin_plan"] != null)
			{
				base.Tables.Add(new h_checkin_planDataTable(dataSet.Tables["h_checkin_plan"]));
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
		DataSetCheckIn dataSetCheckIn = (DataSetCheckIn)base.Clone();
		dataSetCheckIn.InitVars();
		dataSetCheckIn.SchemaSerializationMode = SchemaSerializationMode;
		return dataSetCheckIn;
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
			if (dataSet.Tables["h_guest_entry"] != null)
			{
				base.Tables.Add(new h_guest_entryDataTable(dataSet.Tables["h_guest_entry"]));
			}
			if (dataSet.Tables["room"] != null)
			{
				base.Tables.Add(new roomDataTable(dataSet.Tables["room"]));
			}
			if (dataSet.Tables["h_checkin"] != null)
			{
				base.Tables.Add(new h_checkinDataTable(dataSet.Tables["h_checkin"]));
			}
			if (dataSet.Tables["h_checkin_plan"] != null)
			{
				base.Tables.Add(new h_checkin_planDataTable(dataSet.Tables["h_checkin_plan"]));
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
		tableh_guest_entry = (h_guest_entryDataTable)base.Tables["h_guest_entry"];
		if (initTable && tableh_guest_entry != null)
		{
			tableh_guest_entry.InitVars();
		}
		tableroom = (roomDataTable)base.Tables["room"];
		if (initTable && tableroom != null)
		{
			tableroom.InitVars();
		}
		tableh_checkin = (h_checkinDataTable)base.Tables["h_checkin"];
		if (initTable && tableh_checkin != null)
		{
			tableh_checkin.InitVars();
		}
		tableh_checkin_plan = (h_checkin_planDataTable)base.Tables["h_checkin_plan"];
		if (initTable && tableh_checkin_plan != null)
		{
			tableh_checkin_plan.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "DataSetCheckIn";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSetCheckIn.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableh_guest_entry = new h_guest_entryDataTable();
		base.Tables.Add(tableh_guest_entry);
		tableroom = new roomDataTable();
		base.Tables.Add(tableroom);
		tableh_checkin = new h_checkinDataTable();
		base.Tables.Add(tableh_checkin);
		tableh_checkin_plan = new h_checkin_planDataTable();
		base.Tables.Add(tableh_checkin_plan);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeh_guest_entry()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeroom()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool ShouldSerializeh_checkin()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeh_checkin_plan()
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
		DataSetCheckIn dataSetCheckIn = new DataSetCheckIn();
		XmlSchemaComplexType val = new XmlSchemaComplexType();
		XmlSchemaSequence val2 = new XmlSchemaSequence();
		XmlSchemaAny val3 = new XmlSchemaAny();
		val3.Namespace = dataSetCheckIn.Namespace;
		((XmlSchemaGroupBase)val2).Items.Add((XmlSchemaObject)(object)val3);
		val.Particle = (XmlSchemaParticle)(object)val2;
		XmlSchema schemaSerializable = dataSetCheckIn.GetSchemaSerializable();
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
