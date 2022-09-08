using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyMissingDataPricesStatusByTaskIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string TaskId { get; }

        public ByProjectKeyMissingDataPricesStatusByTaskIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string taskId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.TaskId = taskId;
        }

        public ByProjectKeyMissingDataPricesStatusByTaskIdGet Get()
        {
            return new ByProjectKeyMissingDataPricesStatusByTaskIdGet(ApiHttpClient, ProjectKey, TaskId);
        }

    }
}
