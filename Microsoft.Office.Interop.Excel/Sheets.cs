using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("000208D7-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
public interface Sheets : IEnumerable
{
	void _VtblGap1_18();

	[IndexerName("_Default")]
	object this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}
}
