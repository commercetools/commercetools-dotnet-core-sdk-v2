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

    public partial class ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMePost Post(commercetools.Sdk.Api.Models.Me.IMyCustomerUpdate myCustomerUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMePost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myCustomerUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeDelete(ApiHttpClient, ProjectKey, StoreKey);
        }


        public ByProjectKeyInStoreKeyByStoreKeyMeCartsRequestBuilder Carts()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeActiveCartRequestBuilder ActiveCart()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeActiveCartRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder ShoppingLists()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmRequestBuilder EmailConfirm()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMePasswordRequestBuilder Password()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMePasswordRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeSignupRequestBuilder Signup()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeSignupRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeLoginRequestBuilder Login()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }
    }
}
