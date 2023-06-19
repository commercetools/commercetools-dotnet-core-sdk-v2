using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomerGroups
{

    public partial class ByProjectKeyCustomerGroupsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyCustomerGroupsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyCustomerGroupsKeyByKeyGet Get()
        {
            return new ByProjectKeyCustomerGroupsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCustomerGroupsKeyByKeyPost Post(commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroupUpdate customerGroupUpdate)
        {
            return new ByProjectKeyCustomerGroupsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, customerGroupUpdate);
        }

        public ByProjectKeyCustomerGroupsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCustomerGroupsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
