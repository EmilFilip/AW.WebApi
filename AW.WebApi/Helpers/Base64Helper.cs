using System;
using System.Web;

namespace AW.WebApi.Helpers
{
    /// <summary>
    /// Base64Helper extension method, Use this to decode the header
    /// </summary>
    public static class Base64Helper
    {
        public static string Base64Decode(this string base64EncodedData)
        {
            if (string.IsNullOrEmpty(base64EncodedData))
            {
                return string.Empty;
            }

            try
            {
                byte[] base64EncodedBytes = HttpServerUtility.UrlTokenDecode(base64EncodedData);
                return base64EncodedBytes == null ? string.Empty : System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (FormatException)
            {
                return string.Empty;
            }
        }
    }
}