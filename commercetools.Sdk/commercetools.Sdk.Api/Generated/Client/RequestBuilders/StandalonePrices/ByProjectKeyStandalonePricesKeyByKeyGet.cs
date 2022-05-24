using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{
    public partial class ByProjectKeyStandalonePricesKeyByKeyGet : ApiMethod<ByProjectKeyStandalonePricesKeyByKeyGet>, IApiMethod<ByProjectKeyStandalonePricesKeyByKeyGet, commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStandalonePricesKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStandalonePricesKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStandalonePricesKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyStandalonePricesKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/standalone-prices/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStandalonePricesKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>(requestMessage);
        }

    }
}
