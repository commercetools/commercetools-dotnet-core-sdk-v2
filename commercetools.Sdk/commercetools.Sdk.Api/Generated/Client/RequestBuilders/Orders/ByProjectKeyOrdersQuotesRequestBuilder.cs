using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyOrdersQuotesPost Post(commercetools.Sdk.Api.Models.Orders.IOrderFromQuoteDraft orderFromQuoteDraft)
        {
            return new ByProjectKeyOrdersQuotesPost(ApiHttpClient, SerializerService, ProjectKey, orderFromQuoteDraft);
        }

    }
}
