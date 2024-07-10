using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsCustomerIdByCustomerIdHead : ApiMethod<ByProjectKeyCartsCustomerIdByCustomerIdHead>, IApiMethod<ByProjectKeyCartsCustomerIdByCustomerIdHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCartsCustomerIdByCustomerIdHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCartsCustomerIdByCustomerIdHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string CustomerId { get; }


        public ByProjectKeyCartsCustomerIdByCustomerIdHead(IClient apiHttpClient, string projectKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.CustomerId = customerId;
            this.RequestUrl = $"/{ProjectKey}/carts/customer-id={CustomerId}";
        }




        public async Task<string> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            return await ExecuteAsJsonAsync(cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<string>> SendAsync(CancellationToken cancellationToken = default)
        {

            return await SendAsJsonAsync(cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
