using System.Net;
using System.Net.Http;

namespace AW.WebApi.Helpers
{
    /// <summary>
    /// Use this to build a HttpResponseMessage
    /// </summary>
    public static class ApiHttpResponseException
    {
        public static HttpResponseMessage Get(HttpStatusCode statusCode, string reasonPhrase)
        {
            return new HttpResponseMessage(statusCode) { ReasonPhrase = reasonPhrase };
        }
    }
}