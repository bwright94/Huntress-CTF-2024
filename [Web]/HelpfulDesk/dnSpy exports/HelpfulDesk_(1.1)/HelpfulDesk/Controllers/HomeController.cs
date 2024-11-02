using System;
using System.Runtime.CompilerServices;
using HelpfulDesk.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	[Nullable(0)]
	public class HomeController : Controller
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000403C File Offset: 0x0000223C
		public HomeController(AuthenticationService authService)
		{
			this._authService = authService;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000404B File Offset: 0x0000224B
		public IActionResult Index()
		{
			return this.View();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004054 File Offset: 0x00002254
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			AuthenticationService.AuthenticationResult result = this._authService.ValidateUser(username, password);
			if (result.IsAuthenticated)
			{
				SessionExtensions.SetString(base.HttpContext.Session, "UserSession", username);
				SessionExtensions.SetString(base.HttpContext.Session, "IsAdmin", result.IsAdmin.ToString());
				return this.RedirectToAction("Index", "Dashboard");
			}
			if (HomeController.<>o__3.<>p__0 == null)
			{
				HomeController.<>o__3.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "LoginErrorMessage", typeof(HomeController), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			HomeController.<>o__3.<>p__0.Target(HomeController.<>o__3.<>p__0, base.ViewBag, "Invalid credentials.");
			return this.View("Index");
		}

		// Token: 0x0400009E RID: 158
		private readonly AuthenticationService _authService;
	}
}
