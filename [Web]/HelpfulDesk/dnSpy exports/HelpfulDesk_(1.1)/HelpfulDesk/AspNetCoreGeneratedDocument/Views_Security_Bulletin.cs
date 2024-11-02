using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HelpfulDesk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	[RazorCompiledItemMetadata("Identifier", "/Views/Security/Bulletin.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Security_Bulletin : RazorPage<IEnumerable<SecurityBulletin>>
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002660 File Offset: 0x00000860
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Security_Bulletin.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Security_Bulletin.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000026A3 File Offset: 0x000008A3
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000026AB File Offset: 0x000008AB
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000026BC File Offset: 0x000008BC
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000026C5 File Offset: 0x000008C5
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000026CD File Offset: 0x000008CD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000026D6 File Offset: 0x000008D6
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000026DE File Offset: 0x000008DE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000026E7 File Offset: 0x000008E7
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000026EF File Offset: 0x000008EF
		[RazorInject]
		public IHtmlHelper<IEnumerable<SecurityBulletin>> Html { get; private set; }
	}
}
