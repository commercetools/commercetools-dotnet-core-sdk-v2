using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyStandalonePricesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyStandalonePricesByIDGet Get()
        {
            return new ByProjectKeyStandalonePricesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStandalonePricesByIDPost Post(commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate standalonePriceUpdate)
        {
            return new ByProjectKeyStandalonePricesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, standalonePriceUpdate);
        }

        public ByProjectKeyStandalonePricesByIDDelete Delete()
        {
            return new ByProjectKeyStandalonePricesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
