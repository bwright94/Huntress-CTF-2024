using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using HelpfulDesk.Models;
using HelpfulDesk.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001B RID: 27
	[NullableContext(1)]
	[Nullable(0)]
	public class DashboardController : Controller
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00003CB7 File Offset: 0x00001EB7
		public DashboardController(IWebHostEnvironment env, ClientService clientService)
		{
			this._env = env;
			this._clientService = clientService;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			string filePath = Path.Combine(Directory.GetCurrentDirectory(), "credentials.json");
			string json = File.ReadAllText(filePath);
			List<AuthenticationService.UserCredentials> credentialsList = JsonSerializer.Deserialize<List<AuthenticationService.UserCredentials>>(json, null);
			AuthenticationService.UserCredentials userCredentials = (credentialsList != null) ? credentialsList.FirstOrDefault((AuthenticationService.UserCredentials x) => x.Username == username && x.Password == password) : null;
			if (userCredentials != null)
			{
				SessionExtensions.SetString(base.HttpContext.Session, "UserSession", username);
				if (userCredentials.IsAdmin)
				{
					SessionExtensions.SetString(base.HttpContext.Session, "IsAdmin", "true");
				}
				return this.RedirectToAction("Index", "Dashboard");
			}
			if (DashboardController.<>o__3.<>p__0 == null)
			{
				DashboardController.<>o__3.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "ErrorMessage", typeof(DashboardController), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			DashboardController.<>o__3.<>p__0.Target(DashboardController.<>o__3.<>p__0, base.ViewBag, "Invalid credentials.");
			return this.View();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public IActionResult ClientFiles(string clientId)
		{
			Client client = this._clientService.GetClientById(clientId);
			if (client == null)
			{
				return this.NotFound();
			}
			return this.View(client);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003E10 File Offset: 0x00002010
		private string RenderFiles(List<FileItem> files, string indent = "")
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("<ul>");
			foreach (FileItem file in files)
			{
				if (file.IsDirectory)
				{
					sb.AppendFormat("<li><strong>{0}/</strong></li>", file.Name);
					sb.Append(this.RenderFiles(file.Children, indent + "&nbsp;&nbsp;&nbsp;&nbsp;"));
				}
				else
				{
					sb.AppendFormat("<li>{0}</li>", file.Name);
				}
			}
			sb.Append("</ul>");
			return sb.ToString();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003EC8 File Offset: 0x000020C8
		public IActionResult GetFileSystem(string clientId)
		{
			Client client = this._clientService.GetClientById(clientId);
			if (client == null)
			{
				return this.NotFound();
			}
			return this.Json(client.Filesystem);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003EF8 File Offset: 0x000020F8
		public IActionResult DownloadFile(string fileName)
		{
			string @string = SessionExtensions.GetString(base.HttpContext.Session, "IsAdmin");
			if (@string == null || !@string.Equals("true", StringComparison.OrdinalIgnoreCase))
			{
				return this.RedirectToAction("AccessDenied", "Error");
			}
			string restrictedPath = Path.Combine(this._env.WebRootPath, "restricted");
			string filePath = Path.Combine(restrictedPath, fileName);
			if (!File.Exists(filePath))
			{
				return this.NotFound();
			}
			string mimeType = "application/octet-stream";
			return this.PhysicalFile(filePath, mimeType, Path.GetFileName(filePath));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003F84 File Offset: 0x00002184
		public IActionResult Index()
		{
			string @string = SessionExtensions.GetString(base.HttpContext.Session, "IsAdmin");
			if (@string == null || !@string.Equals("True", StringComparison.OrdinalIgnoreCase))
			{
				return this.RedirectToAction("Index", "Home");
			}
			List<Client> clients = this._clientService.GetClients();
			return this.View(clients);
		}

		// Token: 0x0400009B RID: 155
		private readonly ClientService _clientService;

		// Token: 0x0400009C RID: 156
		private readonly IWebHostEnvironment _env;
	}
}
