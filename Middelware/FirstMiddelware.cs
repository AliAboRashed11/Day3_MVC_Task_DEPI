using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Http;

namespace Day3.Middelware
{
	public class FirstMiddelware
	{

		
		
			private readonly RequestDelegate _next;
			public FirstMiddelware(RequestDelegate next)
			{
				_next = next;
			}
			public async Task Invoke(HttpContext httpContext)
			{
				await httpContext.Response.WriteAsync("First Midel Ware");
				await _next(httpContext);
			await httpContext.Response.WriteAsync("list Midel Ware");

		}
	}
	// Extension method used to add the middleware to the HTTP request pipeline.
	public static class MyMiddlewareExtensions
	{
		public static IApplicationBuilder UseMyMiddleware1(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<FirstMiddelware>();
		}
	}
	}


