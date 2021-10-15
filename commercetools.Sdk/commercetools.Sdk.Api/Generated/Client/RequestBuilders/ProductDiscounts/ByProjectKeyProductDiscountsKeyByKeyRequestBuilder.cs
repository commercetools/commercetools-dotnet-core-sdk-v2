using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductDiscounts
{

    public class ByProjectKeyProductDiscountsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductDiscountsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductDiscountsKeyByKeyGet Get()
        {
            return new ByProjectKeyProductDiscountsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyProductDiscountsKeyByKeyPost Post(commercetools.Api.Models.ProductDiscounts.IProductDiscountUpdate productDiscountUpdate)
        {
            return new ByProjectKeyProductDiscountsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productDiscountUpdate);
        }

        public ByProjectKeyProductDiscountsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyProductDiscountsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
