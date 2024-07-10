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

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost, commercetools.Sdk.Api.Models.Quotes.IQuote>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate QuoteUpdate;

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id, commercetools.Sdk.Api.Models.Quotes.IQuoteUpdate quoteUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.QuoteUpdate = quoteUpdate;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/quotes/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuotesByIDPost WithExpand(string expand)
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
                var body = this.SerializerService.Serialize(QuoteUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
