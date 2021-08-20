using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ImportSinks;
using commercetools.ImportApi.Client.RequestBuilders.ImportSummaries;
using commercetools.ImportApi.Client.RequestBuilders.Categories;
using commercetools.ImportApi.Client.RequestBuilders.Prices;
using commercetools.ImportApi.Client.RequestBuilders.Products;
using commercetools.ImportApi.Client.RequestBuilders.ProductDrafts;
using commercetools.ImportApi.Client.RequestBuilders.ProductTypes;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariants;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariant;
using commercetools.ImportApi.Client.RequestBuilders.Orders;
using commercetools.ImportApi.Client.RequestBuilders.OrderPatches;
using commercetools.ImportApi.Client.RequestBuilders.Customers;
using commercetools.ImportApi.Client.RequestBuilders.Inventories;

namespace commercetools.ImportApi.Client.RequestBuilders.Projects
{
   
   public class ByProjectKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyImportSinksRequestBuilder ImportSinks() {
           return new ByProjectKeyImportSinksRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyImportSummariesRequestBuilder ImportSummaries() {
           return new ByProjectKeyImportSummariesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyCategoriesRequestBuilder Categories() {
           return new ByProjectKeyCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyPricesRequestBuilder Prices() {
           return new ByProjectKeyPricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyProductsRequestBuilder Products() {
           return new ByProjectKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyProductDraftsRequestBuilder ProductDrafts() {
           return new ByProjectKeyProductDraftsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyProductTypesRequestBuilder ProductTypes() {
           return new ByProjectKeyProductTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyProductVariantsRequestBuilder ProductVariants() {
           return new ByProjectKeyProductVariantsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyProductVariantPatchesRequestBuilder ProductVariantPatches() {
           return new ByProjectKeyProductVariantPatchesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyOrdersRequestBuilder Orders() {
           return new ByProjectKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyOrderPatchesRequestBuilder OrderPatches() {
           return new ByProjectKeyOrderPatchesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyCustomersRequestBuilder Customers() {
           return new ByProjectKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyInventoriesRequestBuilder Inventories() {
           return new ByProjectKeyInventoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
   }
}
