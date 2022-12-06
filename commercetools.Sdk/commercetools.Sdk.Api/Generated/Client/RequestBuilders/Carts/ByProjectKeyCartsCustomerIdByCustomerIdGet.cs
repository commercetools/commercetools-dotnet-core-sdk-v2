using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsCustomerIdByCustomerIdGet : ApiMethod<ByProjectKeyCartsCustomerIdByCustomerIdGet>, IApiMethod<ByProjectKeyCartsCustomerIdByCustomerIdGet, commercetools.Sdk.Api.Models.Carts.ICart>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCartsCustomerIdByCustomerIdGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCartsCustomerIdByCustomerIdGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCartsCustomerIdByCustomerIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string CustomerId { get; }


        public ByProjectKeyCartsCustomerIdByCustomerIdGet(IClient apiHttpClient, string projectKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.CustomerId = customerId;
            this.RequestUrl = $"/{ProjectKey}/carts/customer-id={CustomerId}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCartsCustomerIdByCustomerIdGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Carts.ICart> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Carts.ICart>(requestMessage, cancellationToken);
        }

    }
}
