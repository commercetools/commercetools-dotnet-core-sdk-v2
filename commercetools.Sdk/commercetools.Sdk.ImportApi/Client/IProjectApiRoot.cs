using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportOperations;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Inventories;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.OrderPatches;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Orders;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Prices;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Products;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTypes;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariant;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariants;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Projects;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.StandalonePrices;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Types;

namespace commercetools.Sdk.ImportApi.Client;

public interface IProjectApiRoot
{
    string ClientName { get; }
    string ProjectKey { get; }
    IClient ApiHttpClient { get; }
    ByProjectKeyRequestBuilder With();
    ByProjectKeyCategoriesRequestBuilder Categories();
    ByProjectKeyImportContainersRequestBuilder ImportContainers();
    ByProjectKeyImportOperationsRequestBuilder ImportOperations();
    ByProjectKeyPricesRequestBuilder Prices();
    ByProjectKeyProductsRequestBuilder Products();
    ByProjectKeyProductDraftsRequestBuilder ProductDrafts();
    ByProjectKeyProductTypesRequestBuilder ProductTypes();
    ByProjectKeyProductVariantsRequestBuilder ProductVariants();
    ByProjectKeyProductVariantPatchesRequestBuilder ProductVariantPatches();
    ByProjectKeyOrdersRequestBuilder Orders();
    ByProjectKeyOrderPatchesRequestBuilder OrderPatches();
    ByProjectKeyCustomersRequestBuilder Customers();
    ByProjectKeyStandalonePricesRequestBuilder StandalonePrices();
    ByProjectKeyInventoriesRequestBuilder Inventories();
    ByProjectKeyTypesRequestBuilder Types();
}