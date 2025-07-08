using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208D5-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
[DefaultMember("_Default")]
public interface _Application
{
	void _VtblGap1_45();

	Workbooks Workbooks
	{
		[DispId(572)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap2_177();

	[DispId(302)]
	void Quit();

	void _VtblGap3_51();

	bool Visible
	{
		[LCIDConversion(0)]
		[DispId(558)]
		get;
		[DispId(558)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}
}
