using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet, commercetools.Sdk.Api.Models.Carts.ICart>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }


        public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet(IClient apiHttpClient, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/carts/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Carts.ICart> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Carts.ICart>(requestMessage);
        }

    }
}
