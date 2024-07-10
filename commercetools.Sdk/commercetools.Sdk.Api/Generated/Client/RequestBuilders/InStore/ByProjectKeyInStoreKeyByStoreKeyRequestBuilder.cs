using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.InStore;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }



        public ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder Carts()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder Me()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder Customers()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder Login()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder ShippingMethods()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder ShoppingLists()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsRequestBuilder ProductProjections()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductProjectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsRequestBuilder ProductSelectionAssignments()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsRequestBuilder CartDiscounts()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductTailoringRequestBuilder ProductTailoring()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductTailoringRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsRequestBuilder Products()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsRequestBuilder QuoteRequests()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesRequestBuilder StagedQuotes()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyStagedQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesRequestBuilder Quotes()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }
    }
}
