namespace TWishList.Web.Middlewares
{
    using Microsoft.AspNetCore.Builder;

    public static class SeedMiddlewareExtensions
    {
        public static IApplicationBuilder UseSeedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedMiddleware>();
        }
    }
}
