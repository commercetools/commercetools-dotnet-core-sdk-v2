using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Orders;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyOrdersGet Get()
        {
            return new ByProjectKeyOrdersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyOrdersHead Head()
        {
            return new ByProjectKeyOrdersHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyOrdersPost Post(commercetools.Sdk.Api.Models.Orders.IOrderFromCartDraft orderFromCartDraft)
        {
            return new ByProjectKeyOrdersPost(ApiHttpClient, SerializerService, ProjectKey, orderFromCartDraft);
        }


        public ByProjectKeyOrdersImportRequestBuilder ImportOrder()
        {
            return new ByProjectKeyOrdersImportRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersQuotesRequestBuilder OrderQuote()
        {
            return new ByProjectKeyOrdersQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder WithOrderNumber(string orderNumber)
        {
            return new ByProjectKeyOrdersOrderNumberByOrderNumberRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, orderNumber);
        }

        public ByProjectKeyOrdersEditsRequestBuilder Edits()
        {
            return new ByProjectKeyOrdersEditsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyOrdersSearchRequestBuilder Search()
        {
            return new ByProjectKeyOrdersSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
