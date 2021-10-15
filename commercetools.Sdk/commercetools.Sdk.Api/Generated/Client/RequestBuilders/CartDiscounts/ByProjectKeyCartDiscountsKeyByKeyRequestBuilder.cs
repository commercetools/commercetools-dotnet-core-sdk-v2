using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.CartDiscounts
{

    public class ByProjectKeyCartDiscountsKeyByKeyRequestBuilder
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

        public ByProjectKeyCartDiscountsKeyByKeyPost Post(commercetools.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate)
        {
            return new ByProjectKeyCartDiscountsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, cartDiscountUpdate);
        }

        public ByProjectKeyCartDiscountsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCartDiscountsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
