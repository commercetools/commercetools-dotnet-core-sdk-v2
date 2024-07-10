using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string EmailToken { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string emailToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.EmailToken = emailToken;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet(ApiHttpClient, ProjectKey, StoreKey, EmailToken);
        }

    }
}
