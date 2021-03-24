using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace CoolApi.Http
{
    class HeroesHttpMessageHandler : DelegatingHandler
    {
        private const string AUTH_TOKEN = "7b7c78v89cv99vb09c665bc5n5vbnc6";

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", AUTH_TOKEN);
            var response = await base.SendAsync(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException();
            }
            return response;
        }
    }
}