using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles
{

    public class ByProjectKeyAssociateRolesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyAssociateRolesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyAssociateRolesGet Get()
        {
            return new ByProjectKeyAssociateRolesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyAssociateRolesPost Post(commercetools.Sdk.Api.Models.AssociateRoles.IAssociateRoleDraft associateRoleDraft)
        {
            return new ByProjectKeyAssociateRolesPost(ApiHttpClient, SerializerService, ProjectKey, associateRoleDraft);
        }


        public ByProjectKeyAssociateRolesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyAssociateRolesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyAssociateRolesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyAssociateRolesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
