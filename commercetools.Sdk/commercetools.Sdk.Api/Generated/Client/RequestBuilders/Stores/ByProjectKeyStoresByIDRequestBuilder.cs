using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Stores
{

    public partial class ByProjectKeyStoresByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyStoresByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyStoresByIDGet Get()
        {
            return new ByProjectKeyStoresByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStoresByIDHead Head()
        {
            return new ByProjectKeyStoresByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStoresByIDPost Post(commercetools.Sdk.Api.Models.Stores.IStoreUpdate storeUpdate)
        {
            return new ByProjectKeyStoresByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, storeUpdate);
        }

        public ByProjectKeyStoresByIDDelete Delete()
        {
            return new ByProjectKeyStoresByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
