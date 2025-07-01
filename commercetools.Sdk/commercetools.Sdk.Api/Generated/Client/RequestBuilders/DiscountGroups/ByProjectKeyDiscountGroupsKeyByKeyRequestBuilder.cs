using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountGroups
{

    public partial class ByProjectKeyDiscountGroupsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyDiscountGroupsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyDiscountGroupsKeyByKeyGet Get()
        {
            return new ByProjectKeyDiscountGroupsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyDiscountGroupsKeyByKeyHead Head()
        {
            return new ByProjectKeyDiscountGroupsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyDiscountGroupsKeyByKeyPost Post(commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroupUpdate discountGroupUpdate)
        {
            return new ByProjectKeyDiscountGroupsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, discountGroupUpdate);
        }

        public ByProjectKeyDiscountGroupsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyDiscountGroupsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
