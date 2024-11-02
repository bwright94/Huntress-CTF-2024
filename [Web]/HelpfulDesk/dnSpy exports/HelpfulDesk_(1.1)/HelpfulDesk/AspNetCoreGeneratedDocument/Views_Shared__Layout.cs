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
	// Token: 0x02000013 RID: 19
	[Dynamic(new bool[]
	{
		false,
		true
	})]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/_Layout.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared__Layout : RazorPage<object>
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002D60 File Offset: 0x00000F60
		private TagHelperScopeManager __tagHelperScopeManager
		{
			get
			{
				if (this.__backed__tagHelperScopeManager == null)
				{
					this.__backed__tagHelperScopeManager = new TagHelperScopeManager(new Action<HtmlEncoder>(base.StartTagHelperWritingScope), new Func<TagHelperContent>(base.EndTagHelperWritingScope));
				}
				return this.__backed__tagHelperScopeManager;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002D94 File Offset: 0x00000F94
		public override Task ExecuteAsync()
		{
			Views_Shared__Layout.<ExecuteAsync>d__33 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared__Layout.<ExecuteAsync>d__33>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002DD7 File Offset: 0x00000FD7
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002DDF File Offset: 0x00000FDF
		[Nullable(1)]
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { [NullableContext(1)] get; [NullableContext(1)] private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002DE8 File Offset: 0x00000FE8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Nullable(1)]
		[RazorInject]
		public IUrlHelper Url { [NullableContext(1)] get; [NullableContext(1)] private set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002DF9 File Offset: 0x00000FF9
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002E01 File Offset: 0x00001001
		[Nullable(1)]
		[RazorInject]
		public IViewComponentHelper Component { [NullableContext(1)] get; [NullableContext(1)] private set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002E0A File Offset: 0x0000100A
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002E12 File Offset: 0x00001012
		[Nullable(1)]
		[RazorInject]
		public IJsonHelper Json { [NullableContext(1)] get; [NullableContext(1)] private set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002E1B File Offset: 0x0000101B
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002E23 File Offset: 0x00001023
		[Dynamic(new bool[]
		{
			false,
			true
		})]
		[Nullable(1)]
		[RazorInject]
		public IHtmlHelper<dynamic> Html { [NullableContext(1)] [return: Dynamic(new bool[]
		{
			false,
			true
		})] get; [NullableContext(1)] [param: Dynamic(new bool[]
		{
			false,
			true
		})] private set; }

		// Token: 0x04000063 RID: 99
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", new HtmlString("stylesheet"), 0);

		// Token: 0x04000064 RID: 100
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("href", new HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), 0);

		// Token: 0x04000065 RID: 101
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("href", "~/css/site.css", 0);

		// Token: 0x04000066 RID: 102
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("href", "~/HelpfulDesk.styles.css", 0);

		// Token: 0x04000067 RID: 103
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("class", new HtmlString("navbar-brand"), 0);

		// Token: 0x04000068 RID: 104
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("asp-area", "", 0);

		// Token: 0x04000069 RID: 105
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("asp-controller", "Home", 0);

		// Token: 0x0400006A RID: 106
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("asp-action", "Index", 0);

		// Token: 0x0400006B RID: 107
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("class", new HtmlString("nav-link text-dark"), 0);

		// Token: 0x0400006C RID: 108
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("asp-controller", "Dashboard", 0);

		// Token: 0x0400006D RID: 109
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("asp-controller", "Account", 0);

		// Token: 0x0400006E RID: 110
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("asp-action", "Logout", 0);

		// Token: 0x0400006F RID: 111
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("method", "post", 0);

		// Token: 0x04000070 RID: 112
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("class", new HtmlString("form-inline"), 0);

		// Token: 0x04000071 RID: 113
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("asp-controller", "Security", 0);

		// Token: 0x04000072 RID: 114
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("asp-action", "Bulletin", 0);

		// Token: 0x04000073 RID: 115
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("src", new HtmlString("~/lib/jquery/dist/jquery.min.js"), 0);

		// Token: 0x04000074 RID: 116
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("src", new HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), 0);

		// Token: 0x04000075 RID: 117
		private static readonly TagHelperAttribute __tagHelperAttribute_18 = new TagHelperAttribute("src", "~/js/site.js", 0);

		// Token: 0x04000076 RID: 118
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000077 RID: 119
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000078 RID: 120
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000079 RID: 121
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400007A RID: 122
		private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

		// Token: 0x0400007B RID: 123
		private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;

		// Token: 0x0400007C RID: 124
		private LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;

		// Token: 0x0400007D RID: 125
		private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;

		// Token: 0x0400007E RID: 126
		private AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;

		// Token: 0x0400007F RID: 127
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000080 RID: 128
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000081 RID: 129
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
	}
}
