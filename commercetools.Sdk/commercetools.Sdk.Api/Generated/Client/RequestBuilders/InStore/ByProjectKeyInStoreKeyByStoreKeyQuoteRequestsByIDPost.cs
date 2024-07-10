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

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate QuoteRequestUpdate;

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.QuoteRequestUpdate = quoteRequestUpdate;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/quote-requests/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(QuoteRequestUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
