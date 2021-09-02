using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private commercetools.Api.Models.Customers.ICustomerCreatePasswordResetToken CustomerCreatePasswordResetToken;

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Api.Models.Customers.ICustomerCreatePasswordResetToken customerCreatePasswordResetToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.CustomerCreatePasswordResetToken = customerCreatePasswordResetToken;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/password-token";
        }




        public async Task<commercetools.Api.Models.Customers.ICustomerToken> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.ICustomerToken>(requestMessage);
        }

        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerCreatePasswordResetToken);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }
    }
}
