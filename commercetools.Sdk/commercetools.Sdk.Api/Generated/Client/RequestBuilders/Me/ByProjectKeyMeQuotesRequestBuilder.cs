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

    public partial class ByProjectKeyMeQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeQuotesGet Get()
        {
            return new ByProjectKeyMeQuotesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeQuotesHead Head()
        {
            return new ByProjectKeyMeQuotesHead(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyMeQuotesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeQuotesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyMeQuotesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMeQuotesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
