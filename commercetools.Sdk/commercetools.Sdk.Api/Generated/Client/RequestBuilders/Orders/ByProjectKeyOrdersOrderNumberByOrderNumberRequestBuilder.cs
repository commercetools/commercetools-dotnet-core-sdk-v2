using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string OrderNumber { get; }

        public ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string orderNumber)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.OrderNumber = orderNumber;
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberGet Get()
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberGet(ApiHttpClient, ProjectKey, OrderNumber);
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberHead Head()
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberHead(ApiHttpClient, ProjectKey, OrderNumber);
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberPost Post(commercetools.Sdk.Api.Models.Orders.IOrderUpdate orderUpdate)
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberPost(ApiHttpClient, SerializerService, ProjectKey, OrderNumber, orderUpdate);
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberDelete Delete()
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberDelete(ApiHttpClient, ProjectKey, OrderNumber);
        }

    }
}
