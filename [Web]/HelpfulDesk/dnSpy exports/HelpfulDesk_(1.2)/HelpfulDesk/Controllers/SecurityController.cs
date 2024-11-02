using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HelpfulDesk.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpfulDesk.Controllers
{
	// Token: 0x0200001E RID: 30
	public class SecurityController : Controller
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x0000412C File Offset: 0x0000232C
		[NullableContext(1)]
		public IActionResult Bulletin()
		{
			List<SecurityBulletin> bulletins = new List<SecurityBulletin>
			{
				new SecurityBulletin("1.1", DateTime.Now.AddMonths(-1), "Low", "Adds minor UI changes and improvements.", "/api/v1/downloads/helpfuldesk-1.1.zip"),
				new SecurityBulletin("1.0", DateTime.Now.AddMonths(-3), "Low", "This initial update addresses minor security concerns and some bug fixes.", "/api/v1/downloads/helpfuldesk-1.0.zip")
			};
			return this.View(bulletins);
		}
	}
}
