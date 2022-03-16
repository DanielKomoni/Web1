using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;

namespace WebProject1
{
    public class UseLoggin
    {
        private readonly RequestDelegate _next;
        public UseLoggin(RequestDelegate next)
        {
            this._next = next;
        }
      
        public async Task Invoke(HttpContext context)
        {
            var tocen = context.Request.Query["tocen"];
            string path = context.Request.Path.Value.ToLower();
            if (path=="/")
            {
                if (tocen != "Daniel")
                {
                    context.Response.StatusCode = 403;


                }
                else
                {
                    await _next.Invoke(context);
                }
            }
            else
            {
                await _next.Invoke(context);
            }
            
        }
        
    }
}
