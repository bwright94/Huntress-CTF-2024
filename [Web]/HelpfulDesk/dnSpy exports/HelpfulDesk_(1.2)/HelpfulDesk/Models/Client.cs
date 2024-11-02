using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HelpfulDesk.Models
{
	// Token: 0x02000016 RID: 22
	[NullableContext(1)]
	[Nullable(0)]
	public class Client
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003B05 File Offset: 0x00001D05
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003B0D File Offset: 0x00001D0D
		public string Id { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003B16 File Offset: 0x00001D16
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00003B1E File Offset: 0x00001D1E
		public string Name { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003B27 File Offset: 0x00001D27
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00003B2F File Offset: 0x00001D2F
		public List<FileItem> Filesystem { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003B38 File Offset: 0x00001D38
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00003B40 File Offset: 0x00001D40
		public bool Online { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00003B49 File Offset: 0x00001D49
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00003B51 File Offset: 0x00001D51
		public string CompanyName { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003B5A File Offset: 0x00001D5A
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00003B62 File Offset: 0x00001D62
		public DateTime LastCheckIn { get; set; }
	}
}
