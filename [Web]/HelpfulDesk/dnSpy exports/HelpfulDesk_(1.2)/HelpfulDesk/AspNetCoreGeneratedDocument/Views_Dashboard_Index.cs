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
	// Token: 0x02000008 RID: 8
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	[RazorCompiledItemMetadata("Identifier", "/Views/Dashboard/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Dashboard_Index : RazorPage<List<Client>>
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002360 File Offset: 0x00000560
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Dashboard_Index.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Dashboard_Index.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000023A3 File Offset: 0x000005A3
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000023AB File Offset: 0x000005AB
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000023BC File Offset: 0x000005BC
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000023C5 File Offset: 0x000005C5
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000023CD File Offset: 0x000005CD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000023D6 File Offset: 0x000005D6
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000023DE File Offset: 0x000005DE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000023E7 File Offset: 0x000005E7
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000023EF File Offset: 0x000005EF
		[RazorInject]
		public IHtmlHelper<List<Client>> Html { get; private set; }
	}
}
