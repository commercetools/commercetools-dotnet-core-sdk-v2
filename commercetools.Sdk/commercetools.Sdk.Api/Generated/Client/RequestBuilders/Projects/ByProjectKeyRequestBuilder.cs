using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Categories;
using commercetools.Api.Client.RequestBuilders.Carts;
using commercetools.Api.Client.RequestBuilders.CartDiscounts;
using commercetools.Api.Client.RequestBuilders.Channels;
using commercetools.Api.Client.RequestBuilders.Customers;
using commercetools.Api.Client.RequestBuilders.CustomerGroups;
using commercetools.Api.Client.RequestBuilders.CustomObjects;
using commercetools.Api.Client.RequestBuilders.DiscountCodes;
using commercetools.Api.Client.RequestBuilders.Graphql;
using commercetools.Api.Client.RequestBuilders.Inventory;
using commercetools.Api.Client.RequestBuilders.Login;
using commercetools.Api.Client.RequestBuilders.Messages;
using commercetools.Api.Client.RequestBuilders.Orders;
using commercetools.Api.Client.RequestBuilders.Payments;
using commercetools.Api.Client.RequestBuilders.Products;
using commercetools.Api.Client.RequestBuilders.ProductDiscounts;
using commercetools.Api.Client.RequestBuilders.ProductProjections;
using commercetools.Api.Client.RequestBuilders.ProductTypes;
using commercetools.Api.Client.RequestBuilders.Reviews;
using commercetools.Api.Client.RequestBuilders.ShippingMethods;
using commercetools.Api.Client.RequestBuilders.ShoppingLists;
using commercetools.Api.Client.RequestBuilders.States;
using commercetools.Api.Client.RequestBuilders.Subscriptions;
using commercetools.Api.Client.RequestBuilders.TaxCategories;
using commercetools.Api.Client.RequestBuilders.Types;
using commercetools.Api.Client.RequestBuilders.Zones;
using commercetools.Api.Client.RequestBuilders.Me;
using commercetools.Api.Client.RequestBuilders.Extensions;
using commercetools.Api.Client.RequestBuilders.ApiClients;
using commercetools.Api.Client.RequestBuilders.Stores;
using commercetools.Api.Client.RequestBuilders.InStore;

namespace commercetools.Api.Client.RequestBuilders.Projects
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
   
       public ByProjectKeyGet Get() {
           return new ByProjectKeyGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyPost Post(commercetools.Api.Models.Projects.IProjectUpdate projectUpdate) {
           return new ByProjectKeyPost(ApiHttpClient, SerializerService, ProjectKey, projectUpdate);
       }
       
       public ByProjectKeyCategoriesRequestBuilder Categories() {
           return new ByProjectKeyCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCartsRequestBuilder Carts() {
           return new ByProjectKeyCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCartDiscountsRequestBuilder CartDiscounts() {
           return new ByProjectKeyCartDiscountsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyChannelsRequestBuilder Channels() {
           return new ByProjectKeyChannelsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCustomersRequestBuilder Customers() {
           return new ByProjectKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCustomerGroupsRequestBuilder CustomerGroups() {
           return new ByProjectKeyCustomerGroupsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCustomObjectsRequestBuilder CustomObjects() {
           return new ByProjectKeyCustomObjectsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyDiscountCodesRequestBuilder DiscountCodes() {
           return new ByProjectKeyDiscountCodesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyGraphqlRequestBuilder Graphql() {
           return new ByProjectKeyGraphqlRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyInventoryRequestBuilder Inventory() {
           return new ByProjectKeyInventoryRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyLoginRequestBuilder Login() {
           return new ByProjectKeyLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyMessagesRequestBuilder Messages() {
           return new ByProjectKeyMessagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyOrdersRequestBuilder Orders() {
           return new ByProjectKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyPaymentsRequestBuilder Payments() {
           return new ByProjectKeyPaymentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyProductsRequestBuilder Products() {
           return new ByProjectKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyProductDiscountsRequestBuilder ProductDiscounts() {
           return new ByProjectKeyProductDiscountsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyProductProjectionsRequestBuilder ProductProjections() {
           return new ByProjectKeyProductProjectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyProductTypesRequestBuilder ProductTypes() {
           return new ByProjectKeyProductTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyReviewsRequestBuilder Reviews() {
           return new ByProjectKeyReviewsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyShippingMethodsRequestBuilder ShippingMethods() {
           return new ByProjectKeyShippingMethodsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyShoppingListsRequestBuilder ShoppingLists() {
           return new ByProjectKeyShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyStatesRequestBuilder States() {
           return new ByProjectKeyStatesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeySubscriptionsRequestBuilder Subscriptions() {
           return new ByProjectKeySubscriptionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyTaxCategoriesRequestBuilder TaxCategories() {
           return new ByProjectKeyTaxCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyTypesRequestBuilder Types() {
           return new ByProjectKeyTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyZonesRequestBuilder Zones() {
           return new ByProjectKeyZonesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyMeRequestBuilder Me() {
           return new ByProjectKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyExtensionsRequestBuilder Extensions() {
           return new ByProjectKeyExtensionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyApiClientsRequestBuilder ApiClients() {
           return new ByProjectKeyApiClientsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyStoresRequestBuilder Stores() {
           return new ByProjectKeyStoresRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder InStoreKeyWithStoreKeyValue(string storeKey) {
           return new ByProjectKeyInStoreKeyByStoreKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, storeKey);
       }
   }
}
