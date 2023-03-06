using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCartsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCartsGet Get()
        {
            return new ByProjectKeyCartsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCartsPost Post(commercetools.Sdk.Api.Models.Carts.ICartDraft cartDraft)
        {
            return new ByProjectKeyCartsPost(ApiHttpClient, SerializerService, ProjectKey, cartDraft);
        }


        public ByProjectKeyCartsReplicateRequestBuilder Replicate()
        {
            return new ByProjectKeyCartsReplicateRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder WithCustomerId(string customerId)
        {
            return new ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, customerId);
        }

        public ByProjectKeyCartsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyCartsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyCartsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyCartsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
