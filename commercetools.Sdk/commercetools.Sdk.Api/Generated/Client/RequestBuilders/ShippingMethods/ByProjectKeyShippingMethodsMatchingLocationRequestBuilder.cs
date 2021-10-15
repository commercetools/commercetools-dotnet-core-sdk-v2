using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{

    public class ByProjectKeyShippingMethodsMatchingLocationRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShippingMethodsMatchingLocationRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet Get()
        {
            return new ByProjectKeyShippingMethodsMatchingLocationGet(ApiHttpClient, ProjectKey);
        }

    }
}
