using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersOrderNumberByOrderNumberHead : ApiMethod<ByProjectKeyOrdersOrderNumberByOrderNumberHead>, IApiMethod<ByProjectKeyOrdersOrderNumberByOrderNumberHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersOrderNumberByOrderNumberHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersOrderNumberByOrderNumberHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string OrderNumber { get; }


        public ByProjectKeyOrdersOrderNumberByOrderNumberHead(IClient apiHttpClient, string projectKey, string orderNumber)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.OrderNumber = orderNumber;
            this.RequestUrl = $"/{ProjectKey}/orders/order-number={OrderNumber}";
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
