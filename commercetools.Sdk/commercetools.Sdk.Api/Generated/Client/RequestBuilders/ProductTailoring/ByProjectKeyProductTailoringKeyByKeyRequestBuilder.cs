using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring
{

    public partial class ByProjectKeyProductTailoringKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductTailoringKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductTailoringKeyByKeyGet Get()
        {
            return new ByProjectKeyProductTailoringKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductTailoringKeyByKeyPost Post(commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate productTailoringUpdate)
        {
            return new ByProjectKeyProductTailoringKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productTailoringUpdate);
        }

        public ByProjectKeyProductTailoringKeyByKeyDelete Delete()
        {
            return new ByProjectKeyProductTailoringKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
