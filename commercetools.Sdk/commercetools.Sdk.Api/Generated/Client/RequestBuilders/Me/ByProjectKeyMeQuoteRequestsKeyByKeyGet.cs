using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuoteRequestsKeyByKeyGet : ApiMethod<ByProjectKeyMeQuoteRequestsKeyByKeyGet>, IApiMethod<ByProjectKeyMeQuoteRequestsKeyByKeyGet, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeQuoteRequestsKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeQuoteRequestsKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeQuoteRequestsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyMeQuoteRequestsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/me/quote-requests/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeQuoteRequestsKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage);
        }

    }
}
