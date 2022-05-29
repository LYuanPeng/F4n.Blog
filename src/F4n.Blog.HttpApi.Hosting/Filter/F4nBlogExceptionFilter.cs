using F4n.Blog.ToolKits.Helper;
using log4net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace F4n.Blog.HttpApi.Hosting.Filter
{
    public class F4nBlogExceptionFilter : IExceptionFilter
    {
        private readonly ILog _log;

        public F4nBlogExceptionFilter()
        {
            _log = LogManager.GetLogger(typeof(F4nBlogExceptionFilter));
        }

        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public void OnException(ExceptionContext context)
        {
            // 错误日志记录
            _log.Error($"{context.HttpContext.Request.Path}|{context.Exception.Message}", context.Exception);
        }
    }
}
