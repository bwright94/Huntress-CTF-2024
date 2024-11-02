using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using HelpfulDesk.Models;
using HelpfulDesk.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	public class SetupController : Controller
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x000041AC File Offset: 0x000023AC
		public IActionResult SetupWizard()
		{
			if (File.Exists(this._credsFilePath))
			{
				string requestPath = base.HttpContext.Request.Path.Value.TrimEnd('/');
				if (requestPath.Equals("/Setup/SetupWizard", StringComparison.OrdinalIgnoreCase))
				{
					return this.View("Error", new ErrorViewModel
					{
						RequestId = "Server already set up.",
						ExceptionMessage = "Server already set up.",
						StatusCode = 403
					});
				}
			}
			return this.View();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000422C File Offset: 0x0000242C
		[HttpPost]
		public IActionResult SetupWizard(string username, string password)
		{
			string filePath = Path.Combine(Directory.GetCurrentDirectory(), "credentials.json");
			List<AuthenticationService.UserCredentials> credentials = new List<AuthenticationService.UserCredentials>
			{
				new AuthenticationService.UserCredentials
				{
					Username = username,
					Password = password,
					IsAdmin = true
				}
			};
			string json = JsonSerializer.Serialize<List<AuthenticationService.UserCredentials>>(credentials, null);
			File.WriteAllText(filePath, json);
			return this.RedirectToAction("SetupComplete");
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004289 File Offset: 0x00002489
		public IActionResult SetupComplete()
		{
			return this.View();
		}

		// Token: 0x0400009F RID: 159
		private readonly string _credsFilePath = "credentials.json";
	}
}
