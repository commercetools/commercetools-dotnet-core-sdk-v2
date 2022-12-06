using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsSuggestGet : ApiMethod<ByProjectKeyProductProjectionsSuggestGet>, IApiMethod<ByProjectKeyProductProjectionsSuggestGet, commercetools.Sdk.Api.Models.Products.ISuggestionResult>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyProductProjectionsSuggestGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductProjectionsSuggestGet>, commercetools.Sdk.Api.Client.IProjectionselectingTrait<ByProjectKeyProductProjectionsSuggestGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductProjectionsSuggestGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductProjectionsSuggestGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyProductProjectionsSuggestGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/product-projections/suggest";
        }

        public List<string> GetFuzzy()
        {
            return this.GetQueryParam("fuzzy");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public List<string> GetStaged()
        {
            return this.GetQueryParam("staged");
        }

        public ByProjectKeyProductProjectionsSuggestGet WithFuzzy(bool fuzzy)
        {
            return this.AddQueryParam("fuzzy", fuzzy.ToString());
        }

        public ByProjectKeyProductProjectionsSuggestGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyProductProjectionsSuggestGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductProjectionsSuggestGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductProjectionsSuggestGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyProductProjectionsSuggestGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyProductProjectionsSuggestGet WithSearchKeywords(string locale, string searchKeywords)
        {
            return this.AddQueryParam($"searchKeywords.{locale}", searchKeywords);
        }

        public async Task<commercetools.Sdk.Api.Models.Products.ISuggestionResult> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Products.ISuggestionResult>(requestMessage, cancellationToken);
        }

    }
}
