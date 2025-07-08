using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208D8-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface _Worksheet
{
	void _VtblGap1_11();

	string Name
	{
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap2_32();

	Range Cells
	{
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap3_64();

	Range UsedRange
	{
		[DispId(412)]
		[LCIDConversion(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
