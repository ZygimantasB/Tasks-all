using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creating_and_Rendering_Sections.MiddleWare
{
    public class RequestQueryStringMiddleWare
    {
        private RequestDelegate next;

        public RequestQueryStringMiddleWare(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get
               && context.Request.Query["iscertifield"] == "true")
            {
                await context.Response.WriteAsync("Message from Costume Middleware \n");
            }
            await next();
        }
    }
}
