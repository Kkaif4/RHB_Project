using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface _Workbook
{
	void _VtblGap1_7();

	object ActiveSheet
	{
		[DispId(307)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	void _VtblGap2_12();

	[LCIDConversion(3)]
	[DispId(277)]
	void Close([Optional][In][MarshalAs(UnmanagedType.Struct)] object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);

	void _VtblGap3_84();

	Sheets Sheets
	{
		[DispId(485)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap4_59();

	[DispId(1925)]
	[LCIDConversion(12)]
	void SaveAs([Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object FileFormat, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Password, [Optional][In][MarshalAs(UnmanagedType.Struct)] object WriteResPassword, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CreateBackup, [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ConflictResolution, [Optional][In][MarshalAs(UnmanagedType.Struct)] object AddToMru, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextCodepage, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TextVisualLayout, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Local);
}
