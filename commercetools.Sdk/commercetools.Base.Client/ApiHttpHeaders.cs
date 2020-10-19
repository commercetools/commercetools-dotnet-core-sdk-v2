using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Base.Client
{
    public class ApiHttpHeaders
    {
        public const string ACCEPT_ENCODING = "Accept-Encoding";
        public const string AUTHORIZATION = "Authorization";
        public const string USER_AGENT = "User-Agent";
        public const string CONTENT_ENCODING = "Content-Encoding";
        public const string CONTENT_TYPE = "Content-Type";
        public const string CONTENT_LENGTH = "Content-Length";
        public const string X_CORRELATION_ID = "X-Correlation-ID";

        public List<KeyValuePair<string, string>> Headers { get;}

        public ApiHttpHeaders()
        {
            Headers = new List<KeyValuePair<string, string>>();
        }

        public void AddHeader (string key, string value)
        {
            this.Headers.Add(
                new KeyValuePair<string, string>(key, value));
        }

        public List<string> GetHeaderValue(string key)
        {
            return Headers.Where(h => h.Key.Equals(key))
                .Select(h => h.Value).ToList();
        }

        public string GetFirst(string key)
        {
            return Headers.Where(h => h.Key.Equals(key))
                .Select(h => h.Value).FirstOrDefault();
        }
        public List<KeyValuePair<string, string>> GetHeaders(string key)
        {
            return Headers.Where(h => h.Key.Equals(key)).ToList();
        }
    }
}
