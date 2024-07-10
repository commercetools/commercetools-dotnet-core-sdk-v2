using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string CustomerId { get; }


        public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdHead(IClient apiHttpClient, string projectKey, string storeKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.CustomerId = customerId;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/carts/customer-id={CustomerId}";
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
