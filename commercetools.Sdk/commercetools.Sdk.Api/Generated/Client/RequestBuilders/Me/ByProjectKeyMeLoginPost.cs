using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
    public partial class ByProjectKeyMeLoginPost : ApiMethod<ByProjectKeyMeLoginPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Api.Models.Customers.ICustomerSignin CustomerSignin;

        public ByProjectKeyMeLoginPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Customers.ICustomerSignin customerSignin)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerSignin = customerSignin;
            this.RequestUrl = $"/{ProjectKey}/me/login";
        }




        public async Task<commercetools.Api.Models.Customers.ICustomerSignInResult> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.ICustomerSignInResult>(requestMessage);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerSignin);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }
    }
}
