using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStandalonePricesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyStandalonePricesGet Get()
        {
            return new ByProjectKeyStandalonePricesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStandalonePricesHead Head()
        {
            return new ByProjectKeyStandalonePricesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStandalonePricesPost Post(commercetools.Sdk.Api.Models.StandalonePrices.IStandalonePriceDraft standalonePriceDraft)
        {
            return new ByProjectKeyStandalonePricesPost(ApiHttpClient, SerializerService, ProjectKey, standalonePriceDraft);
        }


        public ByProjectKeyStandalonePricesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyStandalonePricesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyStandalonePricesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyStandalonePricesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
