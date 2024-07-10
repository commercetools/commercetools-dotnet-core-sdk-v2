using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Payments
{

    public partial class ByProjectKeyPaymentsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyPaymentsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyPaymentsByIDGet Get()
        {
            return new ByProjectKeyPaymentsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyPaymentsByIDHead Head()
        {
            return new ByProjectKeyPaymentsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyPaymentsByIDPost Post(commercetools.Sdk.Api.Models.Payments.IPaymentUpdate paymentUpdate)
        {
            return new ByProjectKeyPaymentsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, paymentUpdate);
        }

        public ByProjectKeyPaymentsByIDDelete Delete()
        {
            return new ByProjectKeyPaymentsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
