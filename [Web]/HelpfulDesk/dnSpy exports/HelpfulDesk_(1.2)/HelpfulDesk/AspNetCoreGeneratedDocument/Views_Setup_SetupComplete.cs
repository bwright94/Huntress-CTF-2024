using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200000C RID: 12
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Setup/SetupComplete.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Setup_SetupComplete : RazorPage<object>
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002700 File Offset: 0x00000900
		[Nullable(0)]
		private TagHelperScopeManager __tagHelperScopeManager
		{
			[NullableContext(0)]
			get
			{
				if (this.__backed__tagHelperScopeManager == null)
				{
					this.__backed__tagHelperScopeManager = new TagHelperScopeManager(new Action<HtmlEncoder>(base.StartTagHelperWritingScope), new Func<TagHelperContent>(base.EndTagHelperWritingScope));
				}
				return this.__backed__tagHelperScopeManager;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002734 File Offset: 0x00000934
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Setup_SetupComplete.<ExecuteAsync>d__8 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Setup_SetupComplete.<ExecuteAsync>d__8>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000277F File Offset: 0x0000097F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002788 File Offset: 0x00000988
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002790 File Offset: 0x00000990
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002799 File Offset: 0x00000999
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000027A1 File Offset: 0x000009A1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000027AA File Offset: 0x000009AA
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000027B2 File Offset: 0x000009B2
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000027BB File Offset: 0x000009BB
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000027C3 File Offset: 0x000009C3
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

		// Token: 0x0400002A RID: 42
		[Nullable(0)]
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x0400002B RID: 43
		[Nullable(0)]
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x0400002C RID: 44
		[Nullable(0)]
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400002D RID: 45
		[Nullable(0)]
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400002E RID: 46
		[Nullable(0)]
		private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

		// Token: 0x0400002F RID: 47
		[Nullable(0)]
		private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
	}
}
