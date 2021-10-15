using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Me;

namespace commercetools.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMeOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeOrdersGet Get()
        {
            return new ByProjectKeyMeOrdersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMeOrdersPost Post(commercetools.Api.Models.Me.IMyOrderFromCartDraft myOrderFromCartDraft)
        {
            return new ByProjectKeyMeOrdersPost(ApiHttpClient, SerializerService, ProjectKey, myOrderFromCartDraft);
        }


        public ByProjectKeyMeOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMeOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
