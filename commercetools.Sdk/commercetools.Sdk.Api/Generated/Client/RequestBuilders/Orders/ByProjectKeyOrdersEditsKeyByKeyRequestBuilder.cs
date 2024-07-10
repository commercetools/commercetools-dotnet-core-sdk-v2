using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyOrdersEditsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyOrdersEditsKeyByKeyGet Get()
        {
            return new ByProjectKeyOrdersEditsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyOrdersEditsKeyByKeyHead Head()
        {
            return new ByProjectKeyOrdersEditsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyOrdersEditsKeyByKeyPost Post(commercetools.Sdk.Api.Models.OrderEdits.IOrderEditUpdate orderEditUpdate)
        {
            return new ByProjectKeyOrdersEditsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, orderEditUpdate);
        }

        public ByProjectKeyOrdersEditsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyOrdersEditsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
