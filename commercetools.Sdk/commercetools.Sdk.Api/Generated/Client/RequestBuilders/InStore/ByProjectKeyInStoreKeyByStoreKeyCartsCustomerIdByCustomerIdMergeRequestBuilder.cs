using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdMergeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string CustomerId { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdMergeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.CustomerId = customerId;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdMergePost Post(commercetools.Sdk.Api.Models.Carts.IMergeCartDraft mergeCartDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdMergePost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, CustomerId, mergeCartDraft);
        }

    }
}
