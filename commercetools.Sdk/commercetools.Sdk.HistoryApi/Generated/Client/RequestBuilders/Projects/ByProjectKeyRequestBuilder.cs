using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.HistoryApi.Client.RequestBuilders.ResourceType;

namespace commercetools.HistoryApi.Client.RequestBuilders.Projects
{

    public class ByProjectKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyGet Get()
        {
            return new ByProjectKeyGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyByResourceTypeRequestBuilder WithResourceTypeValue(string resourceType)
        {
            return new ByProjectKeyByResourceTypeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, resourceType);
        }
    }
}
