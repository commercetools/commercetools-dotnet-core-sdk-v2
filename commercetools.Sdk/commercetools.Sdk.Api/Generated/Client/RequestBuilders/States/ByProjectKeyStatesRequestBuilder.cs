using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.States;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.States
{

    public partial class ByProjectKeyStatesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStatesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyStatesGet Get()
        {
            return new ByProjectKeyStatesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStatesHead Head()
        {
            return new ByProjectKeyStatesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStatesPost Post(commercetools.Sdk.Api.Models.States.IStateDraft stateDraft)
        {
            return new ByProjectKeyStatesPost(ApiHttpClient, SerializerService, ProjectKey, stateDraft);
        }


        public ByProjectKeyStatesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyStatesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyStatesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyStatesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
