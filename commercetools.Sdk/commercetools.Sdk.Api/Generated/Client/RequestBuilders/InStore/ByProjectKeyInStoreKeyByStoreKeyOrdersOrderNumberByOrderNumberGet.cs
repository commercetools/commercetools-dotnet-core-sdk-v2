using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string OrderNumber { get; }


        public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet(IClient apiHttpClient, string projectKey, string storeKey, string orderNumber)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.OrderNumber = orderNumber;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/orders/order-number={OrderNumber}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage);
        }

    }
}
