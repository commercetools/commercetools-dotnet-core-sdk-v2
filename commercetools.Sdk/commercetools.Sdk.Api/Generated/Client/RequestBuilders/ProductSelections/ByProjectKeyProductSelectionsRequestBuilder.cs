using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductSelectionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductSelectionsGet Get()
        {
            return new ByProjectKeyProductSelectionsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyProductSelectionsHead Head()
        {
            return new ByProjectKeyProductSelectionsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyProductSelectionsPost Post(commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionDraft productSelectionDraft)
        {
            return new ByProjectKeyProductSelectionsPost(ApiHttpClient, SerializerService, ProjectKey, productSelectionDraft);
        }


        public ByProjectKeyProductSelectionsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyProductSelectionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyProductSelectionsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyProductSelectionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
