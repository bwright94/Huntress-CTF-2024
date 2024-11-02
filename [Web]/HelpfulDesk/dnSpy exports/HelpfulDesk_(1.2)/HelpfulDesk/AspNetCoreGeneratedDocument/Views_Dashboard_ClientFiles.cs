using System;
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
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[RazorCompiledItemMetadata("Identifier", "/Views/Dashboard/ClientFiles.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Dashboard_ClientFiles : RazorPage<Client>
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000227C File Offset: 0x0000047C
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Dashboard_ClientFiles.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Dashboard_ClientFiles.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000022BF File Offset: 0x000004BF
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000022C7 File Offset: 0x000004C7
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000022D8 File Offset: 0x000004D8
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000022E1 File Offset: 0x000004E1
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000022E9 File Offset: 0x000004E9
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022F2 File Offset: 0x000004F2
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000022FA File Offset: 0x000004FA
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002303 File Offset: 0x00000503
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000230B File Offset: 0x0000050B
		[RazorInject]
		public IHtmlHelper<Client> Html { get; private set; }
	}
}
