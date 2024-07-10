using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.States
{

    public partial class ByProjectKeyStatesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyStatesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyStatesByIDGet Get()
        {
            return new ByProjectKeyStatesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStatesByIDHead Head()
        {
            return new ByProjectKeyStatesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyStatesByIDPost Post(commercetools.Sdk.Api.Models.States.IStateUpdate stateUpdate)
        {
            return new ByProjectKeyStatesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, stateUpdate);
        }

        public ByProjectKeyStatesByIDDelete Delete()
        {
            return new ByProjectKeyStatesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
