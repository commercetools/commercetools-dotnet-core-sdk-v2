using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.ShoppingLists;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShoppingLists
{

    public partial class ByProjectKeyShoppingListsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShoppingListsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShoppingListsGet Get()
        {
            return new ByProjectKeyShoppingListsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyShoppingListsHead Head()
        {
            return new ByProjectKeyShoppingListsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyShoppingListsPost Post(commercetools.Sdk.Api.Models.ShoppingLists.IShoppingListDraft shoppingListDraft)
        {
            return new ByProjectKeyShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, shoppingListDraft);
        }


        public ByProjectKeyShoppingListsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyShoppingListsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
