using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsGet : ApiMethod<ByProjectKeyVariantProjectionsGet>, IApiMethod<ByProjectKeyVariantProjectionsGet, commercetools.Sdk.Api.Models.Variants.IVariantProjectionPagedQueryResponse>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IAttributefilteringTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantProjectionsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantProjectionsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyVariantProjectionsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/variant-projections";
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

        public List<string> GetPriceCustomerGroupAssignments()
        {
            return this.GetQueryParam("priceCustomerGroupAssignments");
        }

        public List<string> GetPriceChannel()
        {
            return this.GetQueryParam("priceChannel");
        }

        public List<string> GetPriceRecurrencePolicy()
        {
            return this.GetQueryParam("priceRecurrencePolicy");
        }

        public List<string> GetLocaleProjection()
        {
            return this.GetQueryParam("localeProjection");
        }

        public List<string> GetFilterAttributes()
        {
            return this.GetQueryParam("filter[attributes]");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
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

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyVariantProjectionsGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyVariantProjectionsGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyVariantProjectionsGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyVariantProjectionsGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyVariantProjectionsGet WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments)
        {
            return this.AddQueryParam("priceCustomerGroupAssignments", priceCustomerGroupAssignments);
        }

        public ByProjectKeyVariantProjectionsGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyVariantProjectionsGet WithPriceRecurrencePolicy(string priceRecurrencePolicy)
        {
            return this.AddQueryParam("priceRecurrencePolicy", priceRecurrencePolicy);
        }

        public ByProjectKeyVariantProjectionsGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyVariantProjectionsGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyVariantProjectionsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyVariantProjectionsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyVariantProjectionsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyVariantProjectionsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyVariantProjectionsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyVariantProjectionsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyVariantProjectionsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.Variants.IVariantProjectionPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariantProjectionPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariantProjectionPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariantProjectionPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
