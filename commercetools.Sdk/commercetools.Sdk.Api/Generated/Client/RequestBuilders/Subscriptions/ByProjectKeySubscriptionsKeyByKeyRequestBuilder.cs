using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{

    public partial class ByProjectKeySubscriptionsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeySubscriptionsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeySubscriptionsKeyByKeyGet Get()
        {
            return new ByProjectKeySubscriptionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeySubscriptionsKeyByKeyHead Head()
        {
            return new ByProjectKeySubscriptionsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeySubscriptionsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionUpdate subscriptionUpdate)
        {
            return new ByProjectKeySubscriptionsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, subscriptionUpdate);
        }

        public ByProjectKeySubscriptionsKeyByKeyDelete Delete()
        {
            return new ByProjectKeySubscriptionsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
