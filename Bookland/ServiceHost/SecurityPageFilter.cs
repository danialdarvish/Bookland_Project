using System.Linq;
using System.Reflection;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ServiceHost
{
    public class SecurityPageFilter : IPageFilter
    {
        private readonly IAuthHelper _authHelper;

        public SecurityPageFilter(IAuthHelper authHelper)
        {
            _authHelper = authHelper;
        }


        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var handlerPermissions = (NeedsPermissionAttribute) context.HandlerMethod.MethodInfo
                .GetCustomAttribute(typeof(NeedsPermissionAttribute));

            if (handlerPermissions == null)
                return;

            if (_authHelper.GetPermissions().All(x=> x != handlerPermissions.Permission))
                context.HttpContext.Response.Redirect("/404NotFound");

        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }
    }
}
