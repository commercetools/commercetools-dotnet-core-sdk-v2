using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups
{

    public partial class ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyAttributeGroupsKeyByKeyGet Get()
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyAttributeGroupsKeyByKeyHead Head()
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyAttributeGroupsKeyByKeyPost Post(commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroupUpdate attributeGroupUpdate)
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, attributeGroupUpdate);
        }

        public ByProjectKeyAttributeGroupsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
