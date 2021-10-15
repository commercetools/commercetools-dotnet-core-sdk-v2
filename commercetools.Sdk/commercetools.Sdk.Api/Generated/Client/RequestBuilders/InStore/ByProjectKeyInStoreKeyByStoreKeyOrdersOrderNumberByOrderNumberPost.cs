using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
    public partial class ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string OrderNumber { get; }

        private commercetools.Api.Models.Orders.IOrderUpdate OrderUpdate;

        public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string orderNumber, commercetools.Api.Models.Orders.IOrderUpdate orderUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.OrderNumber = orderNumber;
            this.OrderUpdate = orderUpdate;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/orders/order-number={OrderNumber}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.Orders.IOrder> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.IOrder>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(OrderUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
