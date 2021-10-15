using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Stores
{

    public class ByProjectKeyStoresKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyStoresKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyStoresKeyByKeyGet Get()
        {
            return new ByProjectKeyStoresKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStoresKeyByKeyPost Post(commercetools.Api.Models.Stores.IStoreUpdate storeUpdate)
        {
            return new ByProjectKeyStoresKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, storeUpdate);
        }

        public ByProjectKeyStoresKeyByKeyDelete Delete()
        {
            return new ByProjectKeyStoresKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
