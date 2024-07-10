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

    public partial class ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost, commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate StagedQuoteUpdate;

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id, commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate stagedQuoteUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.StagedQuoteUpdate = stagedQuoteUpdate;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/staged-quotes/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyStagedQuotesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuote>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(StagedQuoteUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
