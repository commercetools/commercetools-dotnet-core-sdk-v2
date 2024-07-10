using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyShippingMethodsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyShippingMethodsByIDGet Get()
        {
            return new ByProjectKeyShippingMethodsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyShippingMethodsByIDHead Head()
        {
            return new ByProjectKeyShippingMethodsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyShippingMethodsByIDPost Post(commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodUpdate shippingMethodUpdate)
        {
            return new ByProjectKeyShippingMethodsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, shippingMethodUpdate);
        }

        public ByProjectKeyShippingMethodsByIDDelete Delete()
        {
            return new ByProjectKeyShippingMethodsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
