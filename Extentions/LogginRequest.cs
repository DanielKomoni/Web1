using Microsoft.AspNetCore.Builder;

namespace WebProject1
{
    public static class LogginRequest
    {
        public static IApplicationBuilder LogginUser(this IApplicationBuilder builder) 
        {
            return builder.UseMiddleware<UseLoggin>();
        }

    }
}
