using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Orders
{

    public class ByProjectKeyOrdersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyOrdersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyOrdersByIDGet Get()
        {
            return new ByProjectKeyOrdersByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyOrdersByIDPost Post(commercetools.Api.Models.Orders.IOrderUpdate orderUpdate)
        {
            return new ByProjectKeyOrdersByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, orderUpdate);
        }

        public ByProjectKeyOrdersByIDDelete Delete()
        {
            return new ByProjectKeyOrdersByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
