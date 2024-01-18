using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Products
{

    public partial class ByProjectKeyProductsSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductsSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductsSearchPost Post(commercetools.Sdk.Api.Models.ProductSearches.IProductSearchRequest productSearchRequest)
        {
            return new ByProjectKeyProductsSearchPost(ApiHttpClient, SerializerService, ProjectKey, productSearchRequest);
        }

        public ByProjectKeyProductsSearchHead Head()
        {
            return new ByProjectKeyProductsSearchHead(ApiHttpClient, ProjectKey);
        }

    }
}
