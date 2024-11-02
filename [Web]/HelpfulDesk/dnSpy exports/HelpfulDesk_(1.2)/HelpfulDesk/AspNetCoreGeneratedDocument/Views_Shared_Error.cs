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
	// Token: 0x0200000E RID: 14
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/Error.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared_Error : RazorPage<object>
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000029D8 File Offset: 0x00000BD8
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Shared_Error.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared_Error.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002A1B File Offset: 0x00000C1B
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002A23 File Offset: 0x00000C23
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002A2C File Offset: 0x00000C2C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002A34 File Offset: 0x00000C34
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002A3D File Offset: 0x00000C3D
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002A45 File Offset: 0x00000C45
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002A4E File Offset: 0x00000C4E
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002A56 File Offset: 0x00000C56
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002A5F File Offset: 0x00000C5F
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002A67 File Offset: 0x00000C67
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
