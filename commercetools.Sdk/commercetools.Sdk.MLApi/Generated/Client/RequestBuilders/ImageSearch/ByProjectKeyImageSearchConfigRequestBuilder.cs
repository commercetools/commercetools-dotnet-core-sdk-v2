using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.MLApi.Client.RequestBuilders.ImageSearch
{

    public class ByProjectKeyImageSearchConfigRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImageSearchConfigRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyImageSearchConfigGet Get()
        {
            return new ByProjectKeyImageSearchConfigGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyImageSearchConfigPost Post(commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest imageSearchConfigRequest)
        {
            return new ByProjectKeyImageSearchConfigPost(ApiHttpClient, SerializerService, ProjectKey, imageSearchConfigRequest);
        }

    }
}
