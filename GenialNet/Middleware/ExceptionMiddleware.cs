using System.Runtime.CompilerServices;
using GenialNet.Excessao;

namespace GenialNet.Middleware;

public class ExceptionMiddleware
{
    private RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ExcessaoNegocio ex)
        {
            context.Response.StatusCode = 400;
            context.Response.ContentType = "application/json";

            var responseJson = new
            {
                message = "Ocorreu uma exceção de negócio",
                error = ex.Message
            };

            await context.Response.WriteAsJsonAsync(responseJson);
        }
    }
}