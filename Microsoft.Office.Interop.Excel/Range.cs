using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("00020846-0000-0000-C000-000000000046")]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[CompilerGenerated]
public interface Range
{
	Range Cells
	{
		[PreserveSig]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	Range Columns
	{
		[PreserveSig]
		[DispId(241)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	int Count
	{
		[PreserveSig]
		[DispId(118)]
		get;
	}

	[IndexerName("_Default")]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[PreserveSig]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	Range Rows
	{
		[PreserveSig]
		[DispId(258)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
