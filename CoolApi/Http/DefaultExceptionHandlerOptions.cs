using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CoolApi.Http
{
    class DefaultExceptionHandlerOptions : ExceptionHandlerOptions
    {
        class InternalServerError
        {
            public string type { get => "https://tools.ietf.org/html/rfc7231#section-6.6.1"; }
            public string title { get => "Internal Server Error"; }
            public int status { get => 500; }
            public string traceId { get; }

            public InternalServerError(string TraceIdentifier)
            {
                traceId = TraceIdentifier;
            }
        }
        public DefaultExceptionHandlerOptions()
        {
            this.ExceptionHandler = (HttpContext context) =>
            {
                var error = new InternalServerError(context.TraceIdentifier);
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                return JsonSerializer.SerializeAsync(context.Response.BodyWriter.AsStream(), error);
            };
        }
    }
}