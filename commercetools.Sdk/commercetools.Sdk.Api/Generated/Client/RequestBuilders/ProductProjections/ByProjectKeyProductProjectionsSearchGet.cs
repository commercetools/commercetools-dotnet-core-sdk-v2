using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsSearchGet : ApiMethod<ByProjectKeyProductProjectionsSearchGet>, IApiMethod<ByProjectKeyProductProjectionsSearchGet, commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IProjectionselectingTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IStoreprojectingTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductProjectionsSearchGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductProjectionsSearchGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyProductProjectionsSearchGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/product-projections/search";
        }

        public List<string> GetFuzzy()
        {
            return this.GetQueryParam("fuzzy");
        }

        public List<string> GetFuzzyLevel()
        {
            return this.GetQueryParam("fuzzyLevel");
        }

        public List<string> GetMarkMatchingVariants()
        {
            return this.GetQueryParam("markMatchingVariants");
        }

        public List<string> GetFilter()
        {
            return this.GetQueryParam("filter");
        }

        public List<string> GetFilterFacets()
        {
            return this.GetQueryParam("filter.facets");
        }

        public List<string> GetFilterQuery()
        {
            return this.GetQueryParam("filter.query");
        }

        public List<string> GetFacet()
        {
            return this.GetQueryParam("facet");
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

        public List<string> GetPriceCurrency()
        {
            return this.GetQueryParam("priceCurrency");
        }

        public List<string> GetPriceCountry()
        {
            return this.GetQueryParam("priceCountry");
        }

        public List<string> GetPriceCustomerGroup()
        {
            return this.GetQueryParam("priceCustomerGroup");
        }

        public List<string> GetPriceChannel()
        {
            return this.GetQueryParam("priceChannel");
        }

        public List<string> GetLocaleProjection()
        {
            return this.GetQueryParam("localeProjection");
        }

        public List<string> GetStoreProjection()
        {
            return this.GetQueryParam("storeProjection");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductProjectionsSearchGet WithFuzzy(bool fuzzy)
        {
            return this.AddQueryParam("fuzzy", fuzzy.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithFuzzyLevel(decimal fuzzyLevel)
        {
            return this.AddQueryParam("fuzzyLevel", fuzzyLevel.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithMarkMatchingVariants(bool markMatchingVariants)
        {
            return this.AddQueryParam("markMatchingVariants", markMatchingVariants.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithFilter(string filter)
        {
            return this.AddQueryParam("filter", filter);
        }

        public ByProjectKeyProductProjectionsSearchGet WithFilterFacets(string filterFacets)
        {
            return this.AddQueryParam("filter.facets", filterFacets);
        }

        public ByProjectKeyProductProjectionsSearchGet WithFilterQuery(string filterQuery)
        {
            return this.AddQueryParam("filter.query", filterQuery);
        }

        public ByProjectKeyProductProjectionsSearchGet WithFacet(string facet)
        {
            return this.AddQueryParam("facet", facet);
        }

        public ByProjectKeyProductProjectionsSearchGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyProductProjectionsSearchGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyProductProjectionsSearchGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyProductProjectionsSearchGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyProductProjectionsSearchGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyProductProjectionsSearchGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyProductProjectionsSearchGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyProductProjectionsSearchGet WithStoreProjection(string storeProjection)
        {
            return this.AddQueryParam("storeProjection", storeProjection);
        }

        public ByProjectKeyProductProjectionsSearchGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyProductProjectionsSearchGet WithText(string locale, string text)
        {
            return this.AddQueryParam($"text.{locale}", text);
        }

        public async Task<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
