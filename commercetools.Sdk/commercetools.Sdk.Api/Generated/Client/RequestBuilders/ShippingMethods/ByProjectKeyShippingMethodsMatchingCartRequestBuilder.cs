using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{

    public class ByProjectKeyShippingMethodsMatchingCartRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShippingMethodsMatchingCartRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShippingMethodsMatchingCartGet Get()
        {
            return new ByProjectKeyShippingMethodsMatchingCartGet(ApiHttpClient, ProjectKey);
        }

    }
}
