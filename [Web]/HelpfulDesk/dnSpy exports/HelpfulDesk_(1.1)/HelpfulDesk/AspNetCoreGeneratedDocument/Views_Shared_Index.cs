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
	// Token: 0x0200000F RID: 15
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared_Index : RazorPage<object>
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00002A78 File Offset: 0x00000C78
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Shared_Index.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared_Index.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002AB3 File Offset: 0x00000CB3
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002ABB File Offset: 0x00000CBB
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002AC4 File Offset: 0x00000CC4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002ACC File Offset: 0x00000CCC
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002AD5 File Offset: 0x00000CD5
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002ADD File Offset: 0x00000CDD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002AE6 File Offset: 0x00000CE6
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002AEE File Offset: 0x00000CEE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002AF7 File Offset: 0x00000CF7
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002AFF File Offset: 0x00000CFF
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
