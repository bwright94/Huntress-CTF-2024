using System;
using System.Runtime.CompilerServices;
using HelpfulDesk.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001A RID: 26
	[NullableContext(1)]
	[Nullable(0)]
	public class AccountController : Controller
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00003C86 File Offset: 0x00001E86
		public AccountController(AuthenticationService authService)
		{
			this._authService = authService;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003C95 File Offset: 0x00001E95
		public IActionResult Logout()
		{
			base.HttpContext.Session.Clear();
			return this.RedirectToAction("Index", "Home");
		}

		// Token: 0x0400009A RID: 154
		private readonly AuthenticationService _authService;
	}
}
