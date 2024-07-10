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

    public partial class ByProjectKeyMePasswordRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMePasswordRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMePasswordPost Post(commercetools.Sdk.Api.Models.Customers.IMyCustomerChangePassword myCustomerChangePassword)
        {
            return new ByProjectKeyMePasswordPost(ApiHttpClient, SerializerService, ProjectKey, myCustomerChangePassword);
        }


        public ByProjectKeyMePasswordResetRequestBuilder Reset()
        {
            return new ByProjectKeyMePasswordResetRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
