using commercetools.Api.Client.RequestBuilders.ApiClients;
using commercetools.Api.Client.RequestBuilders.CartDiscounts;
using commercetools.Api.Client.RequestBuilders.Carts;
using commercetools.Api.Client.RequestBuilders.Categories;
using commercetools.Api.Client.RequestBuilders.Channels;
using commercetools.Api.Client.RequestBuilders.CustomerGroups;
using commercetools.Api.Client.RequestBuilders.Customers;
using commercetools.Api.Client.RequestBuilders.CustomObjects;
using commercetools.Api.Client.RequestBuilders.DiscountCodes;
using commercetools.Api.Client.RequestBuilders.Extensions;
using commercetools.Api.Client.RequestBuilders.Graphql;
using commercetools.Api.Client.RequestBuilders.InStore;
using commercetools.Api.Client.RequestBuilders.Inventory;
using commercetools.Api.Client.RequestBuilders.Login;
using commercetools.Api.Client.RequestBuilders.Me;
using commercetools.Api.Client.RequestBuilders.Messages;
using commercetools.Api.Client.RequestBuilders.Orders;
using commercetools.Api.Client.RequestBuilders.Payments;
using commercetools.Api.Client.RequestBuilders.ProductDiscounts;
using commercetools.Api.Client.RequestBuilders.ProductProjections;
using commercetools.Api.Client.RequestBuilders.Products;
using commercetools.Api.Client.RequestBuilders.ProductTypes;
using commercetools.Api.Client.RequestBuilders.Projects;
using commercetools.Api.Client.RequestBuilders.Reviews;
using commercetools.Api.Client.RequestBuilders.ShippingMethods;
using commercetools.Api.Client.RequestBuilders.ShoppingLists;
using commercetools.Api.Client.RequestBuilders.States;
using commercetools.Api.Client.RequestBuilders.Stores;
using commercetools.Api.Client.RequestBuilders.Subscriptions;
using commercetools.Api.Client.RequestBuilders.TaxCategories;
using commercetools.Api.Client.RequestBuilders.Types;
using commercetools.Api.Client.RequestBuilders.Zones;
using commercetools.Api.Models.Projects;
using commercetools.Base.Client;

namespace commercetools.Sdk.Api.Client
{
    public class ProjectApiRoot
    {
            public string ProjectKey { get;  }
            private IClient ApiHttpClient { get; }

            public ProjectApiRoot(IClient apiHttpClient, string projectKey)
            {
                this.ApiHttpClient = apiHttpClient;
                this.ProjectKey = projectKey;
            }
            
            private ByProjectKeyRequestBuilder With()
            {
                return new ApiRoot(ApiHttpClient).WithProjectKey(ProjectKey);
            }
            
            public ByProjectKeyGet Get() {
                return With().Get();
            }

            public ByProjectKeyPost Post(ProjectUpdate projectUpdate) {
                return With().Post(projectUpdate);
            }
            
            public ByProjectKeyCategoriesRequestBuilder Categories() {
                return With().Categories();
            }

            public ByProjectKeyCartsRequestBuilder Carts() {
                return With().Carts();
            }

            public ByProjectKeyCartDiscountsRequestBuilder CartDiscounts() {
                return With().CartDiscounts();
            }

            public ByProjectKeyChannelsRequestBuilder Channels() {
                return With().Channels();
            }

            public ByProjectKeyCustomersRequestBuilder Customers() {
                return With().Customers();
            }

            public ByProjectKeyCustomerGroupsRequestBuilder CustomerGroups() {
                return With().CustomerGroups();
            }

            public ByProjectKeyCustomObjectsRequestBuilder CustomObjects() {
                return With().CustomObjects();
            }

            public ByProjectKeyDiscountCodesRequestBuilder DiscountCodes() {
                return With().DiscountCodes();
            }

            public ByProjectKeyGraphqlRequestBuilder Graphql() {
                return With().Graphql();
            }

            public ByProjectKeyInventoryRequestBuilder Inventory() {
                return With().Inventory();
            }

            public ByProjectKeyLoginRequestBuilder Login() {
                return With().Login();
            }

            public ByProjectKeyMessagesRequestBuilder Messages() {
                return With().Messages();
            }

            public ByProjectKeyOrdersRequestBuilder Orders() {
                return With().Orders();
            }

            public ByProjectKeyPaymentsRequestBuilder Payments() {
                return With().Payments();
            }

            public ByProjectKeyProductsRequestBuilder Products() {
                return With().Products();
            }

            public ByProjectKeyProductDiscountsRequestBuilder ProductDiscounts() {
                return With().ProductDiscounts();
            }

            public ByProjectKeyProductProjectionsRequestBuilder ProductProjections() {
                return With().ProductProjections();
            }

            public ByProjectKeyProductTypesRequestBuilder ProductTypes() {
                return With().ProductTypes();
            }

            public ByProjectKeyReviewsRequestBuilder Reviews() {
                return With().Reviews();
            }

            public ByProjectKeyShippingMethodsRequestBuilder ShippingMethods() {
                return With().ShippingMethods();
            }

            public ByProjectKeyShoppingListsRequestBuilder ShoppingLists() {
                return With().ShoppingLists();
            }

            public ByProjectKeyStatesRequestBuilder States() {
                return With().States();
            }

            public ByProjectKeySubscriptionsRequestBuilder Subscriptions() {
                return With().Subscriptions();
            }

            public ByProjectKeyTaxCategoriesRequestBuilder TaxCategories() {
                return With().TaxCategories();
            }

            public ByProjectKeyTypesRequestBuilder Types() {
                return With().Types();
            }

            public ByProjectKeyZonesRequestBuilder Zones() {
                return With().Zones();
            }

            public ByProjectKeyMeRequestBuilder Me() {
                return With().Me();
            }

            public ByProjectKeyExtensionsRequestBuilder Extensions() {
                return With().Extensions();
            }

            public ByProjectKeyApiClientsRequestBuilder ApiClients() {
                return With().ApiClients();
            }

            public ByProjectKeyStoresRequestBuilder Stores() {
                return With().Stores();
            }

            public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder InStore(string storeKey) {
                return With().InStoreKeyWithStoreKeyValue(storeKey);
            }
    }
}