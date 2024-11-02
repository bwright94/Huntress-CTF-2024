using System;
using System.IO;
using System.Runtime.CompilerServices;
using HelpfulDesk.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Token: 0x02000006 RID: 6
[CompilerGenerated]
internal class Program
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002140 File Offset: 0x00000340
	private static void <Main>$(string[] args)
	{
		WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
		MvcServiceCollectionExtensions.AddControllersWithViews(builder.Services);
		MemoryCacheServiceCollectionExtensions.AddDistributedMemoryCache(builder.Services);
		SessionServiceCollectionExtensions.AddSession(builder.Services, delegate(SessionOptions options)
		{
			options.IdleTimeout = TimeSpan.FromMinutes(30.0);
			options.Cookie.HttpOnly = true;
			options.Cookie.IsEssential = true;
		});
		ServiceCollectionServiceExtensions.AddScoped<ClientService>(builder.Services);
		HttpServiceCollectionExtensions.AddHttpContextAccessor(builder.Services);
		ServiceCollectionServiceExtensions.AddScoped<AuthenticationService>(builder.Services);
		WebApplication app = builder.Build();
		if (!HostEnvironmentEnvExtensions.IsDevelopment(app.Environment))
		{
			ExceptionHandlerExtensions.UseExceptionHandler(app, "/Home/Error");
			HstsBuilderExtensions.UseHsts(app);
		}
		HttpsPolicyBuilderExtensions.UseHttpsRedirection(app);
		StaticFileExtensions.UseStaticFiles(app, new StaticFileOptions
		{
			OnPrepareResponse = delegate(StaticFileResponseContext ctx)
			{
				if (ctx.File.PhysicalPath.Contains(Path.Combine(app.Environment.WebRootPath, "restricted"), StringComparison.OrdinalIgnoreCase))
				{
					ctx.Context.Response.StatusCode = 404;
					ctx.Context.Response.ContentLength = new long?(0L);
					ctx.Context.Response.Body = Stream.Null;
					ctx.Context.Response.Body.Flush();
				}
			}
		});
		EndpointRoutingApplicationBuilderExtensions.UseRouting(app);
		SessionMiddlewareExtensions.UseSession(app);
		AuthorizationAppBuilderExtensions.UseAuthorization(app);
		ControllerEndpointRouteBuilderExtensions.MapControllerRoute(app, "default", "{controller=Home}/{action=Index}/{id?}", null, null, null);
		app.Run(null);
	}
}
