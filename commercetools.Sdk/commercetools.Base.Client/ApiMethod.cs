#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace commercetools.Base.Client
{
    public abstract class ApiMethod<T> where T : ApiMethod<T>
    {
        public abstract HttpMethod Method { get; }

        public string RequestUrl { get; set; }

        private List<KeyValuePair<string, string>> QueryParams { get; set; }

        protected ApiHttpHeaders Headers { get; set; }

        public ApiMethod()
        {
            this.RequestUrl = "";
            this.QueryParams = new List<KeyValuePair<string, string>>();
            this.Headers = new ApiHttpHeaders();
        }

        public T AddQueryParam(string key, string value)
        {
            if (string.IsNullOrEmpty(value))
                return (T)this;
            this.QueryParams.Add(
                new KeyValuePair<string, string>(key, value));
            return (T)this;
        }

        public T WithQueryParam(List<KeyValuePair<string, string>> queryParams)
        {
            this.QueryParams = queryParams;
            return (T)this;
        }

        public ICollection<KeyValuePair<string, string>> GetQueryParams()
        {
            return this.QueryParams;
        }

        public List<string> GetQueryParam(string key)
        {
            return this.QueryParams.Where(
                    p => p.Key.Equals(key))
                .Select(p => p.Value).ToList();
        }

        public string? GetFirstQueryParam(string key)
        {
            return this.QueryParams.Where(
                    p => p.Key.Equals(key))
                .Select(p => p.Value).FirstOrDefault();
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
            var requestPath = new Uri(RequestUrl + ToQueryString(QueryParams), UriKind.Relative);
            var request = new HttpRequestMessage();
            request.Method = this.Method;
            request.RequestUri = requestPath;
            request.AddHeaders(Headers);
            return request;
        }
        
        private static string ToQueryString(IEnumerable<KeyValuePair<string, string>> queryParams)
        {
            var keyValuePairs = queryParams.ToList();
            if (keyValuePairs.Any()) 
                return "?" + string.Join("&",
                    keyValuePairs.Select(pair =>
                        $"{Uri.EscapeDataString(pair.Key)}={Uri.EscapeDataString(pair.Value)}"));
            return "";
        }
    }
}