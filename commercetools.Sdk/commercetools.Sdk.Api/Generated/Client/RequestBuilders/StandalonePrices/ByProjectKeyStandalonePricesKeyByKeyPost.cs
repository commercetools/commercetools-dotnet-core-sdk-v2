using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{
    public partial class ByProjectKeyStandalonePricesKeyByKeyPost : ApiMethod<ByProjectKeyStandalonePricesKeyByKeyPost>, IApiMethod<ByProjectKeyStandalonePricesKeyByKeyPost, commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyStandalonePricesKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStandalonePricesKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStandalonePricesKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStandalonePricesKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate StandalonePriceUpdate;

        public ByProjectKeyStandalonePricesKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate standalonePriceUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.StandalonePriceUpdate = standalonePriceUpdate;
            this.RequestUrl = $"/{ProjectKey}/standalone-prices/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStandalonePricesKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(StandalonePriceUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
