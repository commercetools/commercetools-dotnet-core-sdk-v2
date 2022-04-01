using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string PasswordToken { get; }


        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet(IClient apiHttpClient, string projectKey, string storeKey, string passwordToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.PasswordToken = passwordToken;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/password-token={PasswordToken}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage);
        }

    }
}
