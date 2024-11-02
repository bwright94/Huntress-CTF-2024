using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200000D RID: 13
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Setup/SetupWizard.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Setup_SetupWizard : RazorPage<object>
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002867 File Offset: 0x00000A67
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

		// Token: 0x0600005C RID: 92 RVA: 0x0000289C File Offset: 0x00000A9C
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Setup_SetupWizard.<ExecuteAsync>d__11 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Setup_SetupWizard.<ExecuteAsync>d__11>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000028DF File Offset: 0x00000ADF
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000028E7 File Offset: 0x00000AE7
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000028F0 File Offset: 0x00000AF0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000028F8 File Offset: 0x00000AF8
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002901 File Offset: 0x00000B01
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002909 File Offset: 0x00000B09
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002912 File Offset: 0x00000B12
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000291A File Offset: 0x00000B1A
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002923 File Offset: 0x00000B23
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000292B File Offset: 0x00000B2B
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

		// Token: 0x04000035 RID: 53
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("asp-action", "SetupWizard", 0);

		// Token: 0x04000036 RID: 54
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("asp-controller", "Setup", 0);

		// Token: 0x04000037 RID: 55
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("method", "post", 0);

		// Token: 0x04000038 RID: 56
		[Nullable(0)]
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000039 RID: 57
		[Nullable(0)]
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x0400003A RID: 58
		[Nullable(0)]
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400003B RID: 59
		[Nullable(0)]
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400003C RID: 60
		[Nullable(0)]
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x0400003D RID: 61
		[Nullable(0)]
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
	}
}
