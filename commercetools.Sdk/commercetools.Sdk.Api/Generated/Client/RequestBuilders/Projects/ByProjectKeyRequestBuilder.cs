using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate;
using commercetools.Sdk.Api.Client.RequestBuilders.AssociateRoles;
using commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits;
using commercetools.Sdk.Api.Client.RequestBuilders.Categories;
using commercetools.Sdk.Api.Client.RequestBuilders.Carts;
using commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts;
using commercetools.Sdk.Api.Client.RequestBuilders.Channels;
using commercetools.Sdk.Api.Client.RequestBuilders.Customers;
using commercetools.Sdk.Api.Client.RequestBuilders.CustomerGroups;
using commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects;
using commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes;
using commercetools.Sdk.Api.Client.RequestBuilders.Graphql;
using commercetools.Sdk.Api.Client.RequestBuilders.Inventory;
using commercetools.Sdk.Api.Client.RequestBuilders.Login;
using commercetools.Sdk.Api.Client.RequestBuilders.Messages;
using commercetools.Sdk.Api.Client.RequestBuilders.Orders;
using commercetools.Sdk.Api.Client.RequestBuilders.Payments;
using commercetools.Sdk.Api.Client.RequestBuilders.Products;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes;
using commercetools.Sdk.Api.Client.RequestBuilders.Quotes;
using commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests;
using commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes;
using commercetools.Sdk.Api.Client.RequestBuilders.Reviews;
using commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods;
using commercetools.Sdk.Api.Client.RequestBuilders.ShoppingLists;
using commercetools.Sdk.Api.Client.RequestBuilders.States;
using commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions;
using commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories;
using commercetools.Sdk.Api.Client.RequestBuilders.Types;
using commercetools.Sdk.Api.Client.RequestBuilders.Zones;
using commercetools.Sdk.Api.Client.RequestBuilders.Me;
using commercetools.Sdk.Api.Client.RequestBuilders.Extensions;
using commercetools.Sdk.Api.Client.RequestBuilders.ApiClients;
using commercetools.Sdk.Api.Client.RequestBuilders.Stores;
using commercetools.Sdk.Api.Client.RequestBuilders.InStore;
using commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices;
using commercetools.Sdk.Api.Client.RequestBuilders.InBusiness;
using commercetools.Sdk.Api.Client.RequestBuilders.AttributeGroups;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Projects
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

        public ByProjectKeyGet Get()
        {
            return new ByProjectKeyGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyHead Head()
        {
            return new ByProjectKeyHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyPost Post(commercetools.Sdk.Api.Models.Projects.IProjectUpdate projectUpdate)
        {
            return new ByProjectKeyPost(ApiHttpClient, SerializerService, ProjectKey, projectUpdate);
        }


        public ByProjectKeyAsAssociateRequestBuilder AsAssociate()
        {
            return new ByProjectKeyAsAssociateRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyAssociateRolesRequestBuilder AssociateRoles()
        {
            return new ByProjectKeyAssociateRolesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyBusinessUnitsRequestBuilder BusinessUnits()
        {
            return new ByProjectKeyBusinessUnitsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCategoriesRequestBuilder Categories()
        {
            return new ByProjectKeyCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCartsRequestBuilder Carts()
        {
            return new ByProjectKeyCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCartDiscountsRequestBuilder CartDiscounts()
        {
            return new ByProjectKeyCartDiscountsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyChannelsRequestBuilder Channels()
        {
            return new ByProjectKeyChannelsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomersRequestBuilder Customers()
        {
            return new ByProjectKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomerGroupsRequestBuilder CustomerGroups()
        {
            return new ByProjectKeyCustomerGroupsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyCustomObjectsRequestBuilder CustomObjects()
        {
            return new ByProjectKeyCustomObjectsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyDiscountCodesRequestBuilder DiscountCodes()
        {
            return new ByProjectKeyDiscountCodesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyGraphqlRequestBuilder Graphql()
        {
            return new ByProjectKeyGraphqlRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyInventoryRequestBuilder Inventory()
        {
            return new ByProjectKeyInventoryRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyLoginRequestBuilder Login()
        {
            return new ByProjectKeyLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMessagesRequestBuilder Messages()
        {
            return new ByProjectKeyMessagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyPaymentsRequestBuilder Payments()
        {
            return new ByProjectKeyPaymentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductsRequestBuilder Products()
        {
            return new ByProjectKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductDiscountsRequestBuilder ProductDiscounts()
        {
            return new ByProjectKeyProductDiscountsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductProjectionsRequestBuilder ProductProjections()
        {
            return new ByProjectKeyProductProjectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductSelectionsRequestBuilder ProductSelections()
        {
            return new ByProjectKeyProductSelectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductTailoringRequestBuilder ProductTailoring()
        {
            return new ByProjectKeyProductTailoringRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductTypesRequestBuilder ProductTypes()
        {
            return new ByProjectKeyProductTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyQuotesRequestBuilder Quotes()
        {
            return new ByProjectKeyQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyQuoteRequestsRequestBuilder QuoteRequests()
        {
            return new ByProjectKeyQuoteRequestsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyStagedQuotesRequestBuilder StagedQuotes()
        {
            return new ByProjectKeyStagedQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyReviewsRequestBuilder Reviews()
        {
            return new ByProjectKeyReviewsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyShippingMethodsRequestBuilder ShippingMethods()
        {
            return new ByProjectKeyShippingMethodsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyShoppingListsRequestBuilder ShoppingLists()
        {
            return new ByProjectKeyShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyStatesRequestBuilder States()
        {
            return new ByProjectKeyStatesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeySubscriptionsRequestBuilder Subscriptions()
        {
            return new ByProjectKeySubscriptionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyTaxCategoriesRequestBuilder TaxCategories()
        {
            return new ByProjectKeyTaxCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyTypesRequestBuilder Types()
        {
            return new ByProjectKeyTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyZonesRequestBuilder Zones()
        {
            return new ByProjectKeyZonesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeRequestBuilder Me()
        {
            return new ByProjectKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyExtensionsRequestBuilder Extensions()
        {
            return new ByProjectKeyExtensionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyApiClientsRequestBuilder ApiClients()
        {
            return new ByProjectKeyApiClientsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyStoresRequestBuilder Stores()
        {
            return new ByProjectKeyStoresRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder InStoreKeyWithStoreKeyValue(string storeKey)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, storeKey);
        }

        public ByProjectKeyStandalonePricesRequestBuilder StandalonePrices()
        {
            return new ByProjectKeyStandalonePricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder InBusinessUnitKeyWithBusinessUnitKeyValue(string businessUnitKey)
        {
            return new ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, businessUnitKey);
        }

        public ByProjectKeyAttributeGroupsRequestBuilder AttributeGroups()
        {
            return new ByProjectKeyAttributeGroupsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
