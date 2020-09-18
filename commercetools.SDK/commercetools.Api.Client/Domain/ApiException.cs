using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using commercetools.Api.Models.Errors;

namespace commercetools.Api.Client.Domain
{
    /// <summary>
    /// Wrapper type of any api exception could happen while calling api service like (client exception, server exception, internet exception, ..etc)
    /// </summary>
    public class ApiException : Exception
    {
        private const string CorrelationHeaderKey = "X-Correlation-ID";

        #region Properites

        private string ParentExceptionMessage { get; set; }

        public HttpRequestMessage Request { get; set; }

        public HttpResponseMessage Response { get; set; }

        public ErrorResponse ErrorResponse { get; set; }

        public string ProjectKey { get; set; }

        public string CorrelationId
        {
            get
            {
                var correlationHeaderValue = Request?.Headers.GetValues(CorrelationHeaderKey).FirstOrDefault();
                return correlationHeaderValue;
            }
        }

        public override string Message => this.GetExceptionMessage();
        public string HttpSummary => GetHttpSummary();
        public string ResponseBody => GetResponseBody();

        #endregion

        #region Constructors

        public ApiException()
        {
        }

        public ApiException(HttpRequestMessage request, HttpResponseMessage response)
        {
            Request = request;
            Response = response;
        }

        public ApiException(string message) : base(message)
        {
            this.ParentExceptionMessage = message;
        }

        #endregion


        #region Functions

        /// <summary>
        /// Get Summary of the Http Request
        /// </summary>
        /// <returns>The Http Request Summary</returns>
        private string GetHttpSummary()
        {
            string httpSummary = "";
            try
            {
                StringBuilder builder = new StringBuilder();
                if (this.Request != null)
                {
                    builder.Append("Request Summary: ");
                    builder.Append(this.Request.Method.Method);
                    builder.Append(" ");
                    builder.Append(this.Request.RequestUri);
                    builder.Append(" failed ");
                    builder.Append(Response?.StatusCode.ToString() ?? "an unknown status code");
                    builder.Append(CorrelationId != null ? $" with {CorrelationHeaderKey} '{CorrelationId}'" : "");
                    builder.Append(" on ");
                    builder.Append(DateTime.UtcNow.ToString("s"));
                    builder.Append(Environment.NewLine);
                    httpSummary = builder.ToString();
                }
            }
            catch (Exception)
            {
                httpSummary = "";
            }

            return httpSummary;
        }

        /// <summary>
        /// Get Response Body
        /// </summary>
        /// <returns></returns>
        private string GetResponseBody()
        {
            string responseBody = "";
            try
            {
                StringBuilder builder = new StringBuilder();
                if (this.Response != null)
                {
                    string content = this.Response?.Content?.ReadAsStringAsync().Result;
                    builder.Append("Response: ");
                    builder.Append(content);
                    builder.Append(Environment.NewLine);
                    responseBody = builder.ToString();
                }
            }
            catch (Exception)
            {
                responseBody = "";
            }

            return responseBody;
        }


        /// <summary>
        /// Build Exception Message
        /// </summary>
        /// <returns></returns>
        private string GetExceptionMessage()
        {
            string exceptionMessage = "";
            StringBuilder builder = new StringBuilder();

            builder.Append(!string.IsNullOrEmpty(this.ParentExceptionMessage)
                    ? $"detailMessage: {ParentExceptionMessage}" + "\r\n"
                    : "")
                .Append(HttpSummary)
                .Append(ResponseBody)
                .Append(ProjectKey != null ? $"project: {ProjectKey}" : "");

            exceptionMessage = builder.ToString();
            return exceptionMessage;
        }

        #endregion
    }
}
