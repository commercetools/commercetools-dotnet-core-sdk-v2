using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Me;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMePaymentsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMePaymentsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMePaymentsGet Get()
        {
            return new ByProjectKeyMePaymentsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMePaymentsHead Head()
        {
            return new ByProjectKeyMePaymentsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMePaymentsPost Post(commercetools.Sdk.Api.Models.Me.IMyPaymentDraft myPaymentDraft)
        {
            return new ByProjectKeyMePaymentsPost(ApiHttpClient, SerializerService, ProjectKey, myPaymentDraft);
        }


        public ByProjectKeyMePaymentsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMePaymentsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
