

using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Data.SqlClient;
using System.Text.Json;

public class GlobalExceptionHandler : IMiddleware
{

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (ExistDataException e)
        {
            context.Response.StatusCode = 400;
            context.Response.ContentType = "application/json";
            var repuesta = new
            {
                Error = $" Error 400  {context.Request.Path.Value} + {context.Request.Method}"
            };

            await context.Response.WriteAsJsonAsync(repuesta);
        }

    }

}
