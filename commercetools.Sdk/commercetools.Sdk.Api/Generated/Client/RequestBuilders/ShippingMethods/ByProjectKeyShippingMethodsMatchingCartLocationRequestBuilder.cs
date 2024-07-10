using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingCartLocationRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShippingMethodsMatchingCartLocationRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationGet Get()
        {
            return new ByProjectKeyShippingMethodsMatchingCartLocationGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationHead Head()
        {
            return new ByProjectKeyShippingMethodsMatchingCartLocationHead(ApiHttpClient, ProjectKey);
        }

    }
}
