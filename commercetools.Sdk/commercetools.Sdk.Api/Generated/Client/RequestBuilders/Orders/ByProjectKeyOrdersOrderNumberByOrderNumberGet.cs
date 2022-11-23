using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersOrderNumberByOrderNumberGet : ApiMethod<ByProjectKeyOrdersOrderNumberByOrderNumberGet>, IApiMethod<ByProjectKeyOrdersOrderNumberByOrderNumberGet, commercetools.Sdk.Api.Models.Orders.IOrder>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersOrderNumberByOrderNumberGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersOrderNumberByOrderNumberGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersOrderNumberByOrderNumberGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string OrderNumber { get; }


        public ByProjectKeyOrdersOrderNumberByOrderNumberGet(IClient apiHttpClient, string projectKey, string orderNumber)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.OrderNumber = orderNumber;
            this.RequestUrl = $"/{ProjectKey}/orders/order-number={OrderNumber}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyOrdersOrderNumberByOrderNumberGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);
        }

    }
}
