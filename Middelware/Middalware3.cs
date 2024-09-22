namespace Day3.Middelware3
{
	public class Middalware3
	{

		private readonly RequestDelegate _next;
		public Middalware3(RequestDelegate next)
		{
			_next = next;
		}
		public async Task Invoke(HttpContext httpContext)
		{
			await httpContext.Response.WriteAsync("First");
			await _next(httpContext);
			await httpContext.Response.WriteAsync("last");

		}
	}
	// Extension method used to add the middleware to the HTTP request pipeline.
	
	public static class MyMiddlewareExtensions
	{
		public static IApplicationBuilder UseMyMiddleware3(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<Middalware3>();
		
		}

	}
}
