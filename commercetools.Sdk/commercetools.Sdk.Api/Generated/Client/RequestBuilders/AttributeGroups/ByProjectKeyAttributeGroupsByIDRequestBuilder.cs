using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups
{

    public partial class ByProjectKeyAttributeGroupsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyAttributeGroupsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyAttributeGroupsByIDGet Get()
        {
            return new ByProjectKeyAttributeGroupsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyAttributeGroupsByIDHead Head()
        {
            return new ByProjectKeyAttributeGroupsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyAttributeGroupsByIDPost Post(commercetools.Sdk.Api.Models.AttributeGroups.IAttributeGroupUpdate attributeGroupUpdate)
        {
            return new ByProjectKeyAttributeGroupsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, attributeGroupUpdate);
        }

        public ByProjectKeyAttributeGroupsByIDDelete Delete()
        {
            return new ByProjectKeyAttributeGroupsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
