using System.Net.Http;

namespace commercetools.Base.Client
{
    public static class HttpResponseMessageExtensions
    {
        /// <summary>
        /// Extract the response body
        /// </summary>
        /// <param name="response">the http response message</param>
        /// <returns>extracted body</returns>
        public static string ExtractResponseBody(this HttpResponseMessage response)
        {
            string body = response?.Content?.ReadAsStringAsync().Result;
            body ??= string.Empty;
            return body;
        }

        /// <summary>
        /// Return true if service not available (hack since backend returns in same error conditions response code 500 but with the message Service unavailable)
        /// </summary>
        /// <param name="response">http response</param>
        /// <returns>true if service is not available, else return false</returns>
        public static bool IsServiceNotAvailable(this HttpResponseMessage response)
        {
            int statusCode = (int)response.StatusCode;
            bool isContentContainsServiceUnavailable =
                response.ExtractResponseBody().Contains("<h2>Service Unavailable</h2>");

            return statusCode == 503 || isContentContainsServiceUnavailable;
        }
    }
}