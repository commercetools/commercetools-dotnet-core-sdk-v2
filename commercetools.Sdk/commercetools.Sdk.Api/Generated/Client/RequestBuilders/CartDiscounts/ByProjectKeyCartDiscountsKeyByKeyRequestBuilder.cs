using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts
{

    public partial class ByProjectKeyCartDiscountsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyCartDiscountsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyCartDiscountsKeyByKeyGet Get()
        {
            return new ByProjectKeyCartDiscountsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCartDiscountsKeyByKeyHead Head()
        {
            return new ByProjectKeyCartDiscountsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCartDiscountsKeyByKeyPost Post(commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate)
        {
            return new ByProjectKeyCartDiscountsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, cartDiscountUpdate);
        }

        public ByProjectKeyCartDiscountsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCartDiscountsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
