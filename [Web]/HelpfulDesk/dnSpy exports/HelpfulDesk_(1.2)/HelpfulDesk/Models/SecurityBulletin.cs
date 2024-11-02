using System;
using System.Runtime.CompilerServices;

namespace HelpfulDesk.Models
{
	// Token: 0x02000019 RID: 25
	[NullableContext(1)]
	[Nullable(0)]
	public class SecurityBulletin
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003C04 File Offset: 0x00001E04
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00003C0C File Offset: 0x00001E0C
		public string Version { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003C15 File Offset: 0x00001E15
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00003C1D File Offset: 0x00001E1D
		public DateTime ReleaseDate { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003C26 File Offset: 0x00001E26
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00003C2E File Offset: 0x00001E2E
		public string Severity { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003C37 File Offset: 0x00001E37
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00003C3F File Offset: 0x00001E3F
		public string Description { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00003C50 File Offset: 0x00001E50
		public string DownloadLink { get; set; }

		// Token: 0x060000E8 RID: 232 RVA: 0x00003C59 File Offset: 0x00001E59
		public SecurityBulletin(string version, DateTime releaseDate, string severity, string description, string downloadLink)
		{
			this.Version = version;
			this.ReleaseDate = releaseDate;
			this.Severity = severity;
			this.Description = description;
			this.DownloadLink = downloadLink;
		}
	}
}
