using commercetools.Base.Client;
using commercetools.ImportApi.Client.RequestBuilders.Categories;
using commercetools.ImportApi.Client.RequestBuilders.Customers;
using commercetools.ImportApi.Client.RequestBuilders.ImportContainers;
using commercetools.ImportApi.Client.RequestBuilders.ImportOperations;
using commercetools.ImportApi.Client.RequestBuilders.OrderPatches;
using commercetools.ImportApi.Client.RequestBuilders.Orders;
using commercetools.ImportApi.Client.RequestBuilders.Prices;
using commercetools.ImportApi.Client.RequestBuilders.ProductDrafts;
using commercetools.ImportApi.Client.RequestBuilders.Products;
using commercetools.ImportApi.Client.RequestBuilders.ProductTypes;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariant;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariants;
using commercetools.ImportApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.ImportApi.Client
{
    public class ProjectApiRoot
    {
        public string ClientName { get; }

        private string ProjectKey { get; }

        private IClient ApiHttpClient { get; }

        public ProjectApiRoot(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ClientName = apiHttpClient.Name;
        }

        private ByProjectKeyRequestBuilder With()
        {
            return new ImportApiRoot(ApiHttpClient).WithProjectKeyValue(ProjectKey);
        }

        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return With().Categories();
        }

        public ByProjectKeyImportContainersRequestBuilder ImportContainers()
        {
            return With().ImportContainers();
        }

        public ByProjectKeyImportOperationsRequestBuilder ImportOperations()
        {
            return With().ImportOperations();
        }

        public ByProjectKeyPricesRequestBuilder Prices()
        {
            return With().Prices();
        }

        public ByProjectKeyProductsRequestBuilder Products()
        {
            return With().Products();
        }

        public ByProjectKeyProductDraftsRequestBuilder ProductDrafts()
        {
            return With().ProductDrafts();
        }

        public ByProjectKeyProductTypesRequestBuilder ProductTypes()
        {
            return With().ProductTypes();
        }

        public ByProjectKeyProductVariantsRequestBuilder ProductVariants()
        {
            return With().ProductVariants();
        }

        public ByProjectKeyProductVariantPatchesRequestBuilder ProductVariantPatches()
        {
            return With().ProductVariantPatches();
        }

        public ByProjectKeyOrdersRequestBuilder Orders()
        {
            return With().Orders();
        }

        public ByProjectKeyOrderPatchesRequestBuilder OrderPatches()
        {
            return With().OrderPatches();
        }

        public ByProjectKeyCustomersRequestBuilder Customers()
        {
            return With().Customers();
        }
    }
}