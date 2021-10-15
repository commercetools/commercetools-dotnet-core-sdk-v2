using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductProjections
{

    public class ByProjectKeyProductProjectionsSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductProjectionsSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductProjectionsSearchPost Post(List<KeyValuePair<string, string>> formParams = null)
        {
            return new ByProjectKeyProductProjectionsSearchPost(ApiHttpClient, SerializerService, ProjectKey, formParams);
        }

        public ByProjectKeyProductProjectionsSearchGet Get()
        {
            return new ByProjectKeyProductProjectionsSearchGet(ApiHttpClient, ProjectKey);
        }

    }
}
