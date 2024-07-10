using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.ApiClients;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ApiClients
{

    public partial class ByProjectKeyApiClientsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyApiClientsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyApiClientsGet Get()
        {
            return new ByProjectKeyApiClientsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyApiClientsHead Head()
        {
            return new ByProjectKeyApiClientsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyApiClientsPost Post(commercetools.Sdk.Api.Models.ApiClients.IApiClientDraft apiClientDraft)
        {
            return new ByProjectKeyApiClientsPost(ApiHttpClient, SerializerService, ProjectKey, apiClientDraft);
        }


        public ByProjectKeyApiClientsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyApiClientsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
