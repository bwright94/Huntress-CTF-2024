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
	// Token: 0x02000011 RID: 17
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
	[RazorCompiledItemMetadata("Identifier", "/Views/_ViewImports.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views__ViewImports : RazorPage<object>
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002C28 File Offset: 0x00000E28
		[NullableContext(0)]
		public override Task ExecuteAsync()
		{
			Views__ViewImports.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views__ViewImports.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002C63 File Offset: 0x00000E63
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002C6B File Offset: 0x00000E6B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002C74 File Offset: 0x00000E74
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002C7C File Offset: 0x00000E7C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002C85 File Offset: 0x00000E85
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002C8D File Offset: 0x00000E8D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002C96 File Offset: 0x00000E96
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002C9E File Offset: 0x00000E9E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002CA7 File Offset: 0x00000EA7
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002CAF File Offset: 0x00000EAF
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
