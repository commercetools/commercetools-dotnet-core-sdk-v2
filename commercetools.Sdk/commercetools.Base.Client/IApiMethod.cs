using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace commercetools.Base.Client
{
    public interface IApiMethod<T, TResult> where T : IApiMethod<T, TResult>
    {
        HttpMethod Method { get; }
        string RequestUrl { get; set; }
        T AddQueryParam(string key, string value);
        T WithQueryParam(List<KeyValuePair<string, string>> queryParams);
        List<string> GetQueryParam(string key);
        T AddHeader(string key, string value);
        T WithHeaders(ApiHttpHeaders headers);
        HttpRequestMessage Build();
        public Task<TResult> ExecuteAsync();
    }
}