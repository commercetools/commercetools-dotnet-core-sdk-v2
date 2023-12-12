using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeCartsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeCartsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeCartsGet Get()
        {
            return new ByProjectKeyMeCartsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeCartsHead Head()
        {
            return new ByProjectKeyMeCartsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeCartsPost Post(commercetools.Sdk.Api.Models.Me.IMyCartDraft myCartDraft)
        {
            return new ByProjectKeyMeCartsPost(ApiHttpClient, SerializerService, ProjectKey, myCartDraft);
        }


        public ByProjectKeyMeCartsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMeCartsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyMeCartsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeCartsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeCartsReplicateRequestBuilder Replicate()
        {
            return new ByProjectKeyMeCartsReplicateRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
