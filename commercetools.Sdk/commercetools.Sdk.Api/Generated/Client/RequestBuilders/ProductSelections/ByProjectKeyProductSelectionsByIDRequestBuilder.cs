using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyProductSelectionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyProductSelectionsByIDGet Get()
        {
            return new ByProjectKeyProductSelectionsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductSelectionsByIDHead Head()
        {
            return new ByProjectKeyProductSelectionsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductSelectionsByIDPost Post(commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionUpdate productSelectionUpdate)
        {
            return new ByProjectKeyProductSelectionsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productSelectionUpdate);
        }

        public ByProjectKeyProductSelectionsByIDDelete Delete()
        {
            return new ByProjectKeyProductSelectionsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }


        public ByProjectKeyProductSelectionsByIDProductsRequestBuilder Products()
        {
            return new ByProjectKeyProductSelectionsByIDProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
