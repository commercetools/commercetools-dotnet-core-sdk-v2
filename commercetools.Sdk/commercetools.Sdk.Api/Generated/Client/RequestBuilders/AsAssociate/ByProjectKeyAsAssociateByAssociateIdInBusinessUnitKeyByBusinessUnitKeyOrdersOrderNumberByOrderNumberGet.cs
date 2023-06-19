using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet : ApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet>, IApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet, commercetools.Sdk.Api.Models.Orders.IOrder>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string OrderNumber { get; }


        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet(IClient apiHttpClient, string projectKey, string associateId, string businessUnitKey, string orderNumber)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.OrderNumber = orderNumber;
            this.RequestUrl = $"/{ProjectKey}/as-associate/{AssociateId}/in-business-unit/key={BusinessUnitKey}/orders/order-number={OrderNumber}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyOrdersOrderNumberByOrderNumberGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Orders.IOrder>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
