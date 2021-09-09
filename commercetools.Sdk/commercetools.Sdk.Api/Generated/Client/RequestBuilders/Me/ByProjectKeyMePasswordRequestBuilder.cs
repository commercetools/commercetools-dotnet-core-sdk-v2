using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Me;

namespace commercetools.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMePasswordRequestBuilder
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

        public ByProjectKeyMePasswordPost Post(commercetools.Api.Models.Customers.IMyCustomerChangePassword myCustomerChangePassword)
        {
            return new ByProjectKeyMePasswordPost(ApiHttpClient, SerializerService, ProjectKey, myCustomerChangePassword);
        }


        public ByProjectKeyMePasswordResetRequestBuilder Reset()
        {
            return new ByProjectKeyMePasswordResetRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
