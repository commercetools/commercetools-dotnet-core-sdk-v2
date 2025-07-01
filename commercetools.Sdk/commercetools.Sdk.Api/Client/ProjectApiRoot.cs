using commercetools.Sdk.Api.Client.RequestBuilders.ApiClients;
using commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts;
using commercetools.Sdk.Api.Client.RequestBuilders.Carts;
using commercetools.Sdk.Api.Client.RequestBuilders.Categories;
using commercetools.Sdk.Api.Client.RequestBuilders.Channels;
using commercetools.Sdk.Api.Client.RequestBuilders.CustomerGroups;
using commercetools.Sdk.Api.Client.RequestBuilders.Customers;
using commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects;
using commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes;
using commercetools.Sdk.Api.Client.RequestBuilders.Extensions;
using commercetools.Sdk.Api.Client.RequestBuilders.Graphql;
using commercetools.Sdk.Api.Client.RequestBuilders.InStore;
using commercetools.Sdk.Api.Client.RequestBuilders.Inventory;
using commercetools.Sdk.Api.Client.RequestBuilders.Login;
using commercetools.Sdk.Api.Client.RequestBuilders.Me;
using commercetools.Sdk.Api.Client.RequestBuilders.Messages;
using commercetools.Sdk.Api.Client.RequestBuilders.Orders;
using commercetools.Sdk.Api.Client.RequestBuilders.Payments;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections;
using commercetools.Sdk.Api.Client.RequestBuilders.Products;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes;
using commercetools.Sdk.Api.Client.RequestBuilders.Projects;
using commercetools.Sdk.Api.Client.RequestBuilders.Reviews;
using commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods;
using commercetools.Sdk.Api.Client.RequestBuilders.ShoppingLists;
using commercetools.Sdk.Api.Client.RequestBuilders.States;
using commercetools.Sdk.Api.Client.RequestBuilders.Stores;
using commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions;
using commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories;
using commercetools.Sdk.Api.Client.RequestBuilders.Types;
using commercetools.Sdk.Api.Client.RequestBuilders.Zones;
using commercetools.Sdk.Api.Models.Projects;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups;
using commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits;
using commercetools.Sdk.Api.Client.RequestBuilders.InBusiness;
using commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections;
using commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests;
using commercetools.Sdk.Api.Client.RequestBuilders.Quotes;
using commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes;
using commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate;
using commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles;
using commercetools.Sdk.Api.Client.RequestBuilders.DiscountGroups;
using commercetools.Sdk.Api.Client.RequestBuilders.PaymentMethods;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring;

namespace commercetools.Sdk.Api.Client
{
    public class ProjectApiRoot : IProjectApiRoot
    {
        public string ClientName { get; }
        public string ProjectKey { get; }
        public IClient ApiHttpClient { get; }

        public ProjectApiRoot(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ClientName = apiHttpClient.Name;
        }

        public ByProjectKeyRequestBuilder With()
        {
            return new ApiRoot(ApiHttpClient).WithProjectKey(ProjectKey);
        }

        public ByProjectKeyGet Get()
        {
            return With().Get();
        }

        public ByProjectKeyPost Post(ProjectUpdate projectUpdate)
        {
            return With().Post(projectUpdate);
        }

        public ByProjectKeyHead Head()
        {
            return With().Head();
        }

        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return With().Categories();
        }

        public ByProjectKeyCartsRequestBuilder Carts()
        {
            return With().Carts();
        }

        public ByProjectKeyCartDiscountsRequestBuilder CartDiscounts()
        {
            return With().CartDiscounts();
        }

        public ByProjectKeyChannelsRequestBuilder Channels()
        {
            return With().Channels();
        }

        public ByProjectKeyCustomersRequestBuilder Customers()
        {
            return With().Customers();
        }

        public ByProjectKeyCustomerGroupsRequestBuilder CustomerGroups()
        {
            return With().CustomerGroups();
        }

        public ByProjectKeyCustomObjectsRequestBuilder CustomObjects()
        {
            return With().CustomObjects();
        }

        public ByProjectKeyDiscountCodesRequestBuilder DiscountCodes()
        {
            return With().DiscountCodes();
        }

        public ByProjectKeyGraphqlRequestBuilder Graphql()
        {
            return With().Graphql();
        }

        public ByProjectKeyInventoryRequestBuilder Inventory()
        {
            return With().Inventory();
        }

        public ByProjectKeyLoginRequestBuilder Login()
        {
            return With().Login();
        }

        public ByProjectKeyMessagesRequestBuilder Messages()
        {
            return With().Messages();
        }

        public ByProjectKeyOrdersRequestBuilder Orders()
        {
            return With().Orders();
        }

        public ByProjectKeyPaymentsRequestBuilder Payments()
        {
            return With().Payments();
        }

        public ByProjectKeyProductsRequestBuilder Products()
        {
            return With().Products();
        }

        public ByProjectKeyProductDiscountsRequestBuilder ProductDiscounts()
        {
            return With().ProductDiscounts();
        }

        public ByProjectKeyProductProjectionsRequestBuilder ProductProjections()
        {
            return With().ProductProjections();
        }

        public ByProjectKeyProductSelectionsRequestBuilder ProductSelections()
        {
            return With().ProductSelections();
        }


        public ByProjectKeyProductTypesRequestBuilder ProductTypes()
        {
            return With().ProductTypes();
        }

        public ByProjectKeyQuotesRequestBuilder Quotes()
        {
            return With().Quotes();
        }

        public ByProjectKeyQuoteRequestsRequestBuilder QuoteRequests()
        {
            return With().QuoteRequests();
        }

        public ByProjectKeyReviewsRequestBuilder Reviews()
        {
            return With().Reviews();
        }

        public ByProjectKeyShippingMethodsRequestBuilder ShippingMethods()
        {
            return With().ShippingMethods();
        }

        public ByProjectKeyShoppingListsRequestBuilder ShoppingLists()
        {
            return With().ShoppingLists();
        }

        public ByProjectKeyStagedQuotesRequestBuilder StagedQuotesRequests()
        {
            return With().StagedQuotes();
        }

        public ByProjectKeyStatesRequestBuilder States()
        {
            return With().States();
        }

        public ByProjectKeySubscriptionsRequestBuilder Subscriptions()
        {
            return With().Subscriptions();
        }

        public ByProjectKeyTaxCategoriesRequestBuilder TaxCategories()
        {
            return With().TaxCategories();
        }

        public ByProjectKeyTypesRequestBuilder Types()
        {
            return With().Types();
        }

        public ByProjectKeyZonesRequestBuilder Zones()
        {
            return With().Zones();
        }

        public ByProjectKeyMeRequestBuilder Me()
        {
            return With().Me();
        }

        public ByProjectKeyExtensionsRequestBuilder Extensions()
        {
            return With().Extensions();
        }

        public ByProjectKeyApiClientsRequestBuilder ApiClients()
        {
            return With().ApiClients();
        }

        public ByProjectKeyStoresRequestBuilder Stores()
        {
            return With().Stores();
        }

        public ByProjectKeyBusinessUnitsRequestBuilder BusinessUnits()
        {
            return With().BusinessUnits();
        }

        public ByProjectKeyStagedQuotesRequestBuilder StagedQuotes()
        {
            return With().StagedQuotes();
        }

        public ByProjectKeyAttributeGroupsRequestBuilder AttributeGroups()
        {
            return With().AttributeGroups();
        }

        public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder InStore(string storeKey)
        {
            return With().InStoreKeyWithStoreKeyValue(storeKey);
        }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder InBusinessUnit(string businessUnitKey)
        {
            return With().InBusinessUnitKeyWithBusinessUnitKeyValue(businessUnitKey);
        }

        public ByProjectKeyStandalonePricesRequestBuilder StandalonePrices()
        {
            return With().StandalonePrices();
        }

        public ByProjectKeyAsAssociateRequestBuilder AsAssociate()
        {
            return With().AsAssociate();
        }

        public ByProjectKeyAssociateRolesRequestBuilder AssociateRoles()
        {
            return With().AssociateRoles();
        }

        public ByProjectKeyProductTailoringRequestBuilder ProductTailoring()
        {
            return With().ProductTailoring();
        }

        public ByProjectKeyDiscountGroupsRequestBuilder DiscountGroups()
        {
            return With().DiscountGroups();
        }

        public ByProjectKeyPaymentMethodsRequestBuilder PaymentMethods()
        {
            return With().PaymentMethods();
        }
    }
}