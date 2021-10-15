using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.Similarities;

namespace commercetools.MLApi.Client.RequestBuilders.Similarities
{

    public class ByProjectKeySimilaritiesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeySimilaritiesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeySimilaritiesProductsRequestBuilder Products()
        {
            return new ByProjectKeySimilaritiesProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
