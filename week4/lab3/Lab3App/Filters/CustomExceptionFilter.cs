using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Lab3App.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            File.WriteAllText("exception_log.txt", context.Exception.ToString());
            context.Result = new ObjectResult("An error occurred")
            {
                StatusCode = 500
            };
        }
    }
}
