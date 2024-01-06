using AspExos.Middlewares;

namespace AspExos.Extensions;

public static class Redirect404MiddlewareExtension
{
	public static IApplicationBuilder UseRedirect404(this IApplicationBuilder builder)
	{
		return builder.UseMiddleware<Redirect404Middleware>();
	}
}
