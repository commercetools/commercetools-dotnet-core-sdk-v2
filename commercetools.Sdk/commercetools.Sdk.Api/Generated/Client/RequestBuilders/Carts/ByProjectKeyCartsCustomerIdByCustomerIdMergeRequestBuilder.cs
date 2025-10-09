using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsCustomerIdByCustomerIdMergeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string CustomerId { get; }

        public ByProjectKeyCartsCustomerIdByCustomerIdMergeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerId = customerId;
        }

        public ByProjectKeyCartsCustomerIdByCustomerIdMergePost Post(commercetools.Sdk.Api.Models.Carts.IMergeCartDraft mergeCartDraft)
        {
            return new ByProjectKeyCartsCustomerIdByCustomerIdMergePost(ApiHttpClient, SerializerService, ProjectKey, CustomerId, mergeCartDraft);
        }

    }
}
