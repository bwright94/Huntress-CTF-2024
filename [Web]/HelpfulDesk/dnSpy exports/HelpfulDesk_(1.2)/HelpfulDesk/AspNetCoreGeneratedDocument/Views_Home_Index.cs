using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000009 RID: 9
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Home/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Home_Index : RazorPage<object>
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002400 File Offset: 0x00000600
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

		// Token: 0x06000026 RID: 38 RVA: 0x00002434 File Offset: 0x00000634
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Home_Index.<ExecuteAsync>d__15 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Home_Index.<ExecuteAsync>d__15>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002477 File Offset: 0x00000677
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000247F File Offset: 0x0000067F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002488 File Offset: 0x00000688
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002490 File Offset: 0x00000690
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002499 File Offset: 0x00000699
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000024A1 File Offset: 0x000006A1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000024AA File Offset: 0x000006AA
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000024B2 File Offset: 0x000006B2
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000024BB File Offset: 0x000006BB
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000024C3 File Offset: 0x000006C3
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

		// Token: 0x0400000E RID: 14
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("method", "post", 0);

		// Token: 0x0400000F RID: 15
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("asp-controller", "Home", 0);

		// Token: 0x04000010 RID: 16
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("asp-action", "Login", 0);

		// Token: 0x04000011 RID: 17
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("src", new HtmlString("~/images/computer.png"), 0);

		// Token: 0x04000012 RID: 18
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("class", new HtmlString("img-fluid"), 0);

		// Token: 0x04000013 RID: 19
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("alt", new HtmlString("Responsive image"), 0);

		// Token: 0x04000014 RID: 20
		[Nullable(0)]
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000015 RID: 21
		[Nullable(0)]
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000016 RID: 22
		[Nullable(0)]
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000017 RID: 23
		[Nullable(0)]
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000018 RID: 24
		[Nullable(0)]
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000019 RID: 25
		[Nullable(0)]
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x0400001A RID: 26
		[Nullable(0)]
		private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
	}
}
