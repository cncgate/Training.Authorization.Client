using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOwin.Middleware
{
    public static class DebugMiddlewareExtensions
    {
        public static void UseDebugMiddleware(this IAppBuilder app, DebugMiddlewareOptions options) {
            if (options == null) {
                options = new DebugMiddlewareOptions();
            }

            app.Use<DebugMiddleware>(options);
        }
    }
}