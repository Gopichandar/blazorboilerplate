using BlazorBoilerplate.Middlewares;

namespace BlazorBoilerplate.Extensions;

public static class RequestContextLoggingExtension
{
    public static IApplicationBuilder UseRequestContextLogging(
    this IApplicationBuilder app)
    {
        app.UseMiddleware<RequestContextLoggingMiddleware>();

        return app;
    }
}
