using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyDiscountCodesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyDiscountCodesKeyByKeyGet Get()
        {
            return new ByProjectKeyDiscountCodesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyDiscountCodesKeyByKeyHead Head()
        {
            return new ByProjectKeyDiscountCodesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyDiscountCodesKeyByKeyPost Post(commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeUpdate discountCodeUpdate)
        {
            return new ByProjectKeyDiscountCodesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, discountCodeUpdate);
        }

        public ByProjectKeyDiscountCodesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyDiscountCodesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
