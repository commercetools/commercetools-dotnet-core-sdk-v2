using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }


        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDHead(IClient apiHttpClient, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/staged-quotes/{ID}";
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
