using AspExos.Middlewares;

namespace AspExos.Extensions;

public static class MiddlewareExtension
{
    public static IApplicationBuilder AddMiddlewares(this IApplicationBuilder builder)
    {

        return builder.UseMiddleware<Redirect404Middleware>();
    }
}
