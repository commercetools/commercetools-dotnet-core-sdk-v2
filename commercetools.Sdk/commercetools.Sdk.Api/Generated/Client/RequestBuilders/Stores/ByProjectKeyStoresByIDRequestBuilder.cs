using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Stores
{

    public class ByProjectKeyStoresByIDRequestBuilder
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

        public ByProjectKeyStoresByIDPost Post(commercetools.Api.Models.Stores.IStoreUpdate storeUpdate)
        {
            return new ByProjectKeyStoresByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, storeUpdate);
        }

        public ByProjectKeyStoresByIDDelete Delete()
        {
            return new ByProjectKeyStoresByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
