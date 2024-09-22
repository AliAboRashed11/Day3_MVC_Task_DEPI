namespace Day3.Middelware
{
	public class Midalware2
	{
		private readonly RequestDelegate _next;
		public Midalware2(RequestDelegate next)
		{
			_next = next;
		}
		public async Task Invoke(HttpContext httpContext)
		{
			await httpContext.Response.WriteAsync("first");
			await _next(httpContext);
			await httpContext.Response.WriteAsync("Hellow Custom Middleware \n");
		}
	}
	// Extension method used to add the middleware to the HTTP request pipeline.

	public static class ewareExtensions
	{
		public static IApplicationBuilder UseMyMiddleware2(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<Midalware2>();
		}
	}
}
