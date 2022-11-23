using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesByIDPost : ApiMethod<ByProjectKeyStandalonePricesByIDPost>, IApiMethod<ByProjectKeyStandalonePricesByIDPost, commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyStandalonePricesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStandalonePricesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStandalonePricesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStandalonePricesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate StandalonePriceUpdate;

        public ByProjectKeyStandalonePricesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate standalonePriceUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.StandalonePriceUpdate = standalonePriceUpdate;
            this.RequestUrl = $"/{ProjectKey}/standalone-prices/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStandalonePricesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePrice>(requestMessage, cancellationToken);
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
