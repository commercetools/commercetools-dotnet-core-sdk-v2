using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.States;

namespace commercetools.Api.Client.RequestBuilders.States
{

    public class ByProjectKeyStatesRequestBuilder
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

        public ByProjectKeyStatesPost Post(commercetools.Api.Models.States.IStateDraft stateDraft)
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
