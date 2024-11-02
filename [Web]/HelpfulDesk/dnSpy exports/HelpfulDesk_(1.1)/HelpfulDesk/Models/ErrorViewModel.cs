using System;
using System.Runtime.CompilerServices;

namespace HelpfulDesk.Models
{
	// Token: 0x02000018 RID: 24
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorViewModel
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003BB9 File Offset: 0x00001DB9
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public string RequestId { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003BCA File Offset: 0x00001DCA
		public bool ShowRequestId
		{
			get
			{
				return !string.IsNullOrEmpty(this.RequestId);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003BDA File Offset: 0x00001DDA
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00003BE2 File Offset: 0x00001DE2
		public string ExceptionMessage { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003BEB File Offset: 0x00001DEB
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00003BF3 File Offset: 0x00001DF3
		public int StatusCode { get; set; }
	}
}
