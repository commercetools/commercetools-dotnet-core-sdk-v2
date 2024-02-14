using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesKeyByKeyHead : ApiMethod<ByProjectKeyDiscountCodesKeyByKeyHead>, IApiMethod<ByProjectKeyDiscountCodesKeyByKeyHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyDiscountCodesKeyByKeyHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyDiscountCodesKeyByKeyHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyDiscountCodesKeyByKeyHead(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/discount-codes/key={Key}";
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
