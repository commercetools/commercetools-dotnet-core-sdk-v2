using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.MissingData;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{

    public class ByProjectKeyMissingDataPricesStatusRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataPricesStatusRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyMissingDataPricesStatusByTaskIdRequestBuilder WithTaskId(string taskId)
        {
            return new ByProjectKeyMissingDataPricesStatusByTaskIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, taskId);
        }
    }
}
