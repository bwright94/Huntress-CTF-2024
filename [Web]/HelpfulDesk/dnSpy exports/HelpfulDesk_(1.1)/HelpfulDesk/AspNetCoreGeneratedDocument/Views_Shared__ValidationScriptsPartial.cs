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
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000010 RID: 16
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
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/_ValidationScriptsPartial.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared__ValidationScriptsPartial : RazorPage<object>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002B10 File Offset: 0x00000D10
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

		// Token: 0x06000083 RID: 131 RVA: 0x00002B44 File Offset: 0x00000D44
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views_Shared__ValidationScriptsPartial.<ExecuteAsync>d__9 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared__ValidationScriptsPartial.<ExecuteAsync>d__9>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002B87 File Offset: 0x00000D87
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002B8F File Offset: 0x00000D8F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002BA0 File Offset: 0x00000DA0
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002BA9 File Offset: 0x00000DA9
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002BB1 File Offset: 0x00000DB1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002BBA File Offset: 0x00000DBA
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002BC2 File Offset: 0x00000DC2
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002BCB File Offset: 0x00000DCB
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002BD3 File Offset: 0x00000DD3
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

		// Token: 0x0400004D RID: 77
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", new HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), 0);

		// Token: 0x0400004E RID: 78
		[Nullable(0)]
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("src", new HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), 0);

		// Token: 0x0400004F RID: 79
		[Nullable(0)]
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000050 RID: 80
		[Nullable(0)]
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000051 RID: 81
		[Nullable(0)]
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000052 RID: 82
		[Nullable(0)]
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000053 RID: 83
		[Nullable(0)]
		private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
	}
}
