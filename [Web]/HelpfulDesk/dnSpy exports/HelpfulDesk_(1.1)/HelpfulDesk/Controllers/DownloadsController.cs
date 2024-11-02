using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	[Nullable(0)]
	[ApiController]
	[Route("api/v1/downloads")]
	public class DownloadsController : ControllerBase
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00003FE0 File Offset: 0x000021E0
		public DownloadsController(IWebHostEnvironment env)
		{
			this._env = env;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003FF0 File Offset: 0x000021F0
		[HttpGet("{fileName}")]
		public IActionResult DownloadFile(string fileName)
		{
			string fileDirectory = Path.Combine(this._env.WebRootPath, "downloads");
			string filePath = Path.Combine(fileDirectory, fileName);
			if (!File.Exists(filePath))
			{
				return this.NotFound();
			}
			return this.PhysicalFile(filePath, "application/octet-stream", Path.GetFileName(filePath));
		}

		// Token: 0x0400009D RID: 157
		private readonly IWebHostEnvironment _env;
	}
}
