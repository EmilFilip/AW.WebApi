using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace AW.WebApi.Helpers
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Use this to authorize all api requests
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            IEnumerable<string> header;

            actionContext.Request.Headers.TryGetValues(Constants.customHeaderKey, out header);

            if (header == null || Base64Helper.Base64Decode(header.First()) != Constants.customHeaderValue)
            {
                throw new HttpResponseException(ApiHttpResponseException.Get(HttpStatusCode.Unauthorized, Constants.customHeaderExceptionMessage));
            }
        }
    }
}