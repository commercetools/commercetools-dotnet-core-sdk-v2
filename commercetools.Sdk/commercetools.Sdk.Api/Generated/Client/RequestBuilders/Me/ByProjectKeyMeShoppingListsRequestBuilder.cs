using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Me;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeShoppingListsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeShoppingListsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeShoppingListsGet Get()
        {
            return new ByProjectKeyMeShoppingListsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeShoppingListsHead Head()
        {
            return new ByProjectKeyMeShoppingListsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeShoppingListsPost Post(commercetools.Sdk.Api.Models.Me.IMyShoppingListDraft myShoppingListDraft)
        {
            return new ByProjectKeyMeShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, myShoppingListDraft);
        }


        public ByProjectKeyMeShoppingListsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
