using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace HelpfulDesk.Models
{
	// Token: 0x02000017 RID: 23
	[NullableContext(1)]
	[Nullable(0)]
	public class FileItem
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003B73 File Offset: 0x00001D73
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00003B7B File Offset: 0x00001D7B
		public string Name { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003B84 File Offset: 0x00001D84
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00003B8C File Offset: 0x00001D8C
		public bool IsDirectory { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003B95 File Offset: 0x00001D95
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00003B9D File Offset: 0x00001D9D
		public List<FileItem> Children { get; set; } = new List<FileItem>();
	}
}
