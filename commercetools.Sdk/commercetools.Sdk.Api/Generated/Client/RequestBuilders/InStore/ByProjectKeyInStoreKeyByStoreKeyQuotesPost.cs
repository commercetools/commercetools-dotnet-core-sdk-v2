using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuotesPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuotesPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuotesPost, commercetools.Sdk.Api.Models.Quotes.IQuote>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyQuotesPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyInStoreKeyByStoreKeyQuotesPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyQuotesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private commercetools.Sdk.Api.Models.Quotes.IQuoteDraft QuoteDraft;

        public ByProjectKeyInStoreKeyByStoreKeyQuotesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Sdk.Api.Models.Quotes.IQuoteDraft quoteDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.QuoteDraft = quoteDraft;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/quotes";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Quotes.IQuote> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Quotes.IQuote>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Quotes.IQuote>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Quotes.IQuote>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(QuoteDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
