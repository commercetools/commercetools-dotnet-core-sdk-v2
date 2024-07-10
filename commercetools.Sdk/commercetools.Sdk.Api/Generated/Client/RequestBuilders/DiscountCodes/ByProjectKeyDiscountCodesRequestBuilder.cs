using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyDiscountCodesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyDiscountCodesGet Get()
        {
            return new ByProjectKeyDiscountCodesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyDiscountCodesHead Head()
        {
            return new ByProjectKeyDiscountCodesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyDiscountCodesPost Post(commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeDraft discountCodeDraft)
        {
            return new ByProjectKeyDiscountCodesPost(ApiHttpClient, SerializerService, ProjectKey, discountCodeDraft);
        }


        public ByProjectKeyDiscountCodesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyDiscountCodesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyDiscountCodesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyDiscountCodesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
