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
	// Token: 0x0200000A RID: 10
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Home/Privacy.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Home_Privacy : RazorPage<object>
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000025C0 File Offset: 0x000007C0
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Home_Privacy.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Home_Privacy.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002603 File Offset: 0x00000803
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000260B File Offset: 0x0000080B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002614 File Offset: 0x00000814
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000261C File Offset: 0x0000081C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002625 File Offset: 0x00000825
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000262D File Offset: 0x0000082D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002636 File Offset: 0x00000836
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000263E File Offset: 0x0000083E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002647 File Offset: 0x00000847
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000264F File Offset: 0x0000084F
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
