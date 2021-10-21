using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Products
{

    public class ByProjectKeyProductsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductsKeyByKeyGet Get()
        {
            return new ByProjectKeyProductsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductsKeyByKeyHead Head()
        {
            return new ByProjectKeyProductsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductsKeyByKeyPost Post(commercetools.Api.Models.Products.IProductUpdate productUpdate)
        {
            return new ByProjectKeyProductsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productUpdate);
        }

        public ByProjectKeyProductsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyProductsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
