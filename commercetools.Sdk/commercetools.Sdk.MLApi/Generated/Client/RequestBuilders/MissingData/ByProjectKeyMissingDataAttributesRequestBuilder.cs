using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.MissingData;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{

    public class ByProjectKeyMissingDataAttributesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataAttributesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMissingDataAttributesPost Post(commercetools.MLApi.Models.MissingData.IMissingAttributesSearchRequest missingAttributesSearchRequest)
        {
            return new ByProjectKeyMissingDataAttributesPost(ApiHttpClient, SerializerService, ProjectKey, missingAttributesSearchRequest);
        }


        public ByProjectKeyMissingDataAttributesStatusRequestBuilder Status()
        {
            return new ByProjectKeyMissingDataAttributesStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
