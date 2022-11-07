using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups
{

    public class ByProjectKeyAttributeGroupsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAttributeGroupsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyAttributeGroupsGet Get()
        {
            return new ByProjectKeyAttributeGroupsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyAttributeGroupsPost Post(commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroupDraft attributeGroupDraft)
        {
            return new ByProjectKeyAttributeGroupsPost(ApiHttpClient, SerializerService, ProjectKey, attributeGroupDraft);
        }


        public ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyAttributeGroupsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyAttributeGroupsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAttributeGroupsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
