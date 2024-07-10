using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring
{

    public partial class ByProjectKeyProductTailoringRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductTailoringRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductTailoringGet Get()
        {
            return new ByProjectKeyProductTailoringGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyProductTailoringPost Post(commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoringDraft productTailoringDraft)
        {
            return new ByProjectKeyProductTailoringPost(ApiHttpClient, SerializerService, ProjectKey, productTailoringDraft);
        }


        public ByProjectKeyProductTailoringKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyProductTailoringKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyProductTailoringByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyProductTailoringByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
