using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyStandalonePricesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyStandalonePricesKeyByKeyGet Get()
        {
            return new ByProjectKeyStandalonePricesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStandalonePricesKeyByKeyPost Post(commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceUpdate standalonePriceUpdate)
        {
            return new ByProjectKeyStandalonePricesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, standalonePriceUpdate);
        }

        public ByProjectKeyStandalonePricesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyStandalonePricesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
