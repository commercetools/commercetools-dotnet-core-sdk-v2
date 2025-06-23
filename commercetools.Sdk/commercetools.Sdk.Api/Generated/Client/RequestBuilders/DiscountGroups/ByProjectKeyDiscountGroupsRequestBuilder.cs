using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountGroups
{

    public partial class ByProjectKeyDiscountGroupsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyDiscountGroupsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyDiscountGroupsGet Get()
        {
            return new ByProjectKeyDiscountGroupsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyDiscountGroupsHead Head()
        {
            return new ByProjectKeyDiscountGroupsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyDiscountGroupsPost Post(commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroupDraft discountGroupDraft)
        {
            return new ByProjectKeyDiscountGroupsPost(ApiHttpClient, SerializerService, ProjectKey, discountGroupDraft);
        }


        public ByProjectKeyDiscountGroupsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyDiscountGroupsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyDiscountGroupsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyDiscountGroupsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
