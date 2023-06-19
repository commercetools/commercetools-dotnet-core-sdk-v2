using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Types
{

    public partial class ByProjectKeyTypesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyTypesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyTypesGet Get()
        {
            return new ByProjectKeyTypesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyTypesPost Post(commercetools.Sdk.Api.Models.Types.ITypeDraft typeDraft)
        {
            return new ByProjectKeyTypesPost(ApiHttpClient, SerializerService, ProjectKey, typeDraft);
        }


        public ByProjectKeyTypesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyTypesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyTypesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyTypesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
