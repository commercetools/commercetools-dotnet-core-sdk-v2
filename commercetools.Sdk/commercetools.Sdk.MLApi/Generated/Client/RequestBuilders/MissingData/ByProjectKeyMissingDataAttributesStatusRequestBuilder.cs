using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyMissingDataAttributesStatusRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataAttributesStatusRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }


        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder WithTaskId(string taskId)
        {
            return new ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, taskId);
        }
    }
}
