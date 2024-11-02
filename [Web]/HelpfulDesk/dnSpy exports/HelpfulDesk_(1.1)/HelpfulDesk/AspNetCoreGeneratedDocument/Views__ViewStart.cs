using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000012 RID: 18
	[Dynamic(new bool[]
	{
		false,
		true
	})]
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[RazorCompiledItemMetadata("Identifier", "/Views/_ViewStart.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views__ViewStart : RazorPage<object>
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views__ViewStart.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views__ViewStart.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002D03 File Offset: 0x00000F03
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002D0B File Offset: 0x00000F0B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002D14 File Offset: 0x00000F14
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002D1C File Offset: 0x00000F1C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002D25 File Offset: 0x00000F25
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002D2D File Offset: 0x00000F2D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002D36 File Offset: 0x00000F36
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002D3E File Offset: 0x00000F3E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002D47 File Offset: 0x00000F47
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002D4F File Offset: 0x00000F4F
		[Dynamic(new bool[]
		{
			false,
			true
		})]
		[RazorInject]
		public IHtmlHelper<dynamic> Html { [return: Dynamic(new bool[]
		{
			false,
			true
		})] get; [param: Dynamic(new bool[]
		{
			false,
			true
		})] private set; }
	}
}
