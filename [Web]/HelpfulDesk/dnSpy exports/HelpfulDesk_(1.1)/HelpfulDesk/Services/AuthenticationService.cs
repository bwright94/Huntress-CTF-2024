using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace HelpfulDesk.Services
{
	// Token: 0x02000014 RID: 20
	[NullableContext(1)]
	[Nullable(0)]
	public class AuthenticationService
	{
		// Token: 0x060000BD RID: 189 RVA: 0x000031DC File Offset: 0x000013DC
		public AuthenticationService.AuthenticationResult ValidateUser(string username, string password)
		{
			string json = File.ReadAllText(this._filePath);
			List<AuthenticationService.UserCredentials> users = JsonConvert.DeserializeObject<List<AuthenticationService.UserCredentials>>(json);
			foreach (AuthenticationService.UserCredentials user in users)
			{
				if (user.Username == username && user.Password == password)
				{
					return new AuthenticationService.AuthenticationResult
					{
						IsAuthenticated = true,
						IsAdmin = user.IsAdmin
					};
				}
			}
			return new AuthenticationService.AuthenticationResult
			{
				IsAuthenticated = false,
				IsAdmin = false
			};
		}

		// Token: 0x04000087 RID: 135
		private readonly string _filePath = "credentials.json";

		// Token: 0x02000042 RID: 66
		[Nullable(0)]
		public class UserCredentials
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00007E8E File Offset: 0x0000608E
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00007E96 File Offset: 0x00006096
			public string Username { get; set; }

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00007E9F File Offset: 0x0000609F
			// (set) Token: 0x06000146 RID: 326 RVA: 0x00007EA7 File Offset: 0x000060A7
			public string Password { get; set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00007EB0 File Offset: 0x000060B0
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00007EB8 File Offset: 0x000060B8
			public bool IsAdmin { get; set; }
		}

		// Token: 0x02000043 RID: 67
		[NullableContext(0)]
		public class AuthenticationResult
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600014A RID: 330 RVA: 0x00007EC9 File Offset: 0x000060C9
			// (set) Token: 0x0600014B RID: 331 RVA: 0x00007ED1 File Offset: 0x000060D1
			public bool IsAuthenticated { get; set; }

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600014C RID: 332 RVA: 0x00007EDA File Offset: 0x000060DA
			// (set) Token: 0x0600014D RID: 333 RVA: 0x00007EE2 File Offset: 0x000060E2
			public bool IsAdmin { get; set; }
		}
	}
}
