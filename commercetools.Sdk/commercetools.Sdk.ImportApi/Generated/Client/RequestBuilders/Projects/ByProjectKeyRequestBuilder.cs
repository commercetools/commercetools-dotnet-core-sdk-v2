using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportOperations;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Prices;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.StandalonePrices;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Products;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTypes;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariants;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariant;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Orders;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.OrderPatches;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Inventories;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return new ByProjectKeyCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyPricesRequestBuilder Prices()
        {
            return new ByProjectKeyPricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyStandalonePricesRequestBuilder StandalonePrices()
        {
            return new ByProjectKeyStandalonePricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductsRequestBuilder Products()
        {
            return new ByProjectKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductDraftsRequestBuilder ProductDrafts()
        {
            return new ByProjectKeyProductDraftsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductTypesRequestBuilder ProductTypes()
        {
            return new ByProjectKeyProductTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductVariantsRequestBuilder ProductVariants()
        {
            return new ByProjectKeyProductVariantsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductVariantPatchesRequestBuilder ProductVariantPatches()
        {
            return new ByProjectKeyProductVariantPatchesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrderPatchesRequestBuilder OrderPatches()
        {
            return new ByProjectKeyOrderPatchesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersRequestBuilder Customers()
        {
            return new ByProjectKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyInventoriesRequestBuilder Inventories()
        {
            return new ByProjectKeyInventoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
