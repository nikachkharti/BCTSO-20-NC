using System.Net;
using Todo.Models;
using Todo.Service.Exceptions;

namespace Todo.API
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception exception)
        {
            ApiResponse apiRespone = new();

            switch (exception)
            {
                case
                    TodoNotFoundException todoNotFoundException:
                    apiRespone.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespone.IsSuccess = false;
                    apiRespone.Message = todoNotFoundException.Message;
                    apiRespone.Result = null;
                    break;
                case
                    UserNotFoundException userNotFoundException:
                    apiRespone.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespone.IsSuccess = false;
                    apiRespone.Message = userNotFoundException.Message;
                    apiRespone.Result = null;
                    break;
                case
                    ArgumentException argumentException:
                    apiRespone.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                    apiRespone.IsSuccess = false;
                    apiRespone.Message = argumentException.Message;
                    apiRespone.Result = null;
                    break;
                case
                    UnauthorizedAccessException unauthorizedAccessException:
                    apiRespone.StatusCode = Convert.ToInt32(HttpStatusCode.Forbidden);
                    apiRespone.IsSuccess = false;
                    apiRespone.Message = unauthorizedAccessException.Message;
                    apiRespone.Result = null;
                    break;
                case
                    Exception ex:
                    apiRespone.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                    apiRespone.IsSuccess = false;
                    apiRespone.Message = ex.Message;
                    apiRespone.Result = null;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = apiRespone.StatusCode;

            return context.Response.WriteAsJsonAsync(apiRespone);
        }
    }
}
