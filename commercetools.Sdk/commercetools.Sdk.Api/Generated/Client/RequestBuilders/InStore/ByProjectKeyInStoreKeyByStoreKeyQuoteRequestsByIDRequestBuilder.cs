using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost Post(commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, quoteRequestUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
