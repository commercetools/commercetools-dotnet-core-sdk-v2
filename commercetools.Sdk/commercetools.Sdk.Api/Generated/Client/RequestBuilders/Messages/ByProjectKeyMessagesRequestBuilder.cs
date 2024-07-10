using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Messages;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Messages
{

    public partial class ByProjectKeyMessagesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMessagesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMessagesGet Get()
        {
            return new ByProjectKeyMessagesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMessagesHead Head()
        {
            return new ByProjectKeyMessagesHead(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyMessagesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMessagesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
