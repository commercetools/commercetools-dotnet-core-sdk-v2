using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType
{

    public partial class ByProjectKeyByResourceTypeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ResourceType { get; }

        public ByProjectKeyByResourceTypeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string resourceType)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ResourceType = resourceType;
        }

        public ByProjectKeyByResourceTypeGet Get()
        {
            return new ByProjectKeyByResourceTypeGet(ApiHttpClient, ProjectKey, ResourceType);
        }


        public ByProjectKeyByResourceTypeByIDRequestBuilder WithIDValue(string ID)
        {
            return new ByProjectKeyByResourceTypeByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ResourceType, ID);
        }
    }
}
