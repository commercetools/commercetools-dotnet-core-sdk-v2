using System;
using System.Collections.Generic;
using commercetools.Api.Models.Errors;

namespace commercetools.Api.Client.Domain
{
    public class HttpApiClientException : Exception
    {
        public int StatusCode { get; set; }
        public List<ErrorObject> Errors { get; set; }

        public HttpApiClientException(string message) : base(message)
        {

        }

        public HttpApiClientException(string message, int statusCode, List<ErrorObject> errors = null, string body = null) : this(message)
        {
            StatusCode = statusCode;
            Errors = errors;
        }
        /// <summary>
        /// Create Exception from the json response
        /// </summary>
        /// <param name="response"></param>
        public HttpApiClientException(ErrorResponse response) : this(response.Message)
        {
            this.StatusCode = response.StatusCode;
            this.Errors = response.Errors;
        }

    }
}
