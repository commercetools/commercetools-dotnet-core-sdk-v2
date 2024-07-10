using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{

    public partial class ByProjectKeySubscriptionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeySubscriptionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeySubscriptionsByIDGet Get()
        {
            return new ByProjectKeySubscriptionsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeySubscriptionsByIDHead Head()
        {
            return new ByProjectKeySubscriptionsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeySubscriptionsByIDPost Post(commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionUpdate subscriptionUpdate)
        {
            return new ByProjectKeySubscriptionsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, subscriptionUpdate);
        }

        public ByProjectKeySubscriptionsByIDDelete Delete()
        {
            return new ByProjectKeySubscriptionsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }


        public ByProjectKeySubscriptionsByIDHealthRequestBuilder WithIdHealth()
        {
            return new ByProjectKeySubscriptionsByIDHealthRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
