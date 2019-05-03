using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

namespace DotNetCoreWebAPI
{
    public class CustomizedMiddleWare
    {
        private readonly RequestDelegate _next; 

        public CustomizedMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add("CustomizedMiddleWare","Yes");
            return _next(context);
        }
    }

    public static class CustomizedMiddleWareExtension
    {
        public static IApplicationBuilder UseCustomizedMiddleWear(this IApplicationBuilder builder)
        {
            builder.UseCors();
            builder.UseMvc();
            return builder.UseMiddleware<CustomizedMiddleWare>();
        }
    }
}
