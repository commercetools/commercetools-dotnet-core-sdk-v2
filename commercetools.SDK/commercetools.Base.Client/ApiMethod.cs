using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace commercetools.Base.Client
{
    public abstract class ApiMethod<T> where T:ApiMethod<T>
    {
        public abstract HttpMethod Method { get; }

        public string RequestUrl { get; set; }

        private List<KeyValuePair<string, string>> QueryParams { get; set; }

        private ApiHttpHeaders Headers { get; set; }

        public ApiMethod()
        {
            this.QueryParams = new List<KeyValuePair<string, string>>();
            this.Headers = new ApiHttpHeaders();
        }

        public T AddQueryParam(string key, string value)
        {
            this.QueryParams.Add(
                new KeyValuePair<string, string>(key, value));
            return (T)this;
        }

        public T WithQueryParam(List<KeyValuePair<string, string>> queryParams)
        {
            this.QueryParams = queryParams;
            return (T)this;
        }

        public List<string> GetQueryParam(string key)
        {
            return this.QueryParams.Where(
                p => p.Key.Equals(key))
                .Select(p => p.Value).ToList();
        }

        public T AddHeader(string key, string value)
        {
            this.Headers.AddHeader(key, value);
            return (T)this;
        }

        public T WithHeaders(ApiHttpHeaders headers)
        {
            this.Headers = headers;
            return (T)this;
        }

        public virtual HttpRequestMessage Build()
        {
            var requestPath = RequestUrl;
            QueryParams.ForEach(x => {
                requestPath = QueryHelpers.AddQueryString(requestPath, x.Key, x.Value);
            });

            var request = new HttpRequestMessage();
            request.Method = this.Method;
            request.RequestUri = new Uri(requestPath, UriKind.Relative);
            request.AddHeaders(Headers);
            return request;
        }
    }
}
