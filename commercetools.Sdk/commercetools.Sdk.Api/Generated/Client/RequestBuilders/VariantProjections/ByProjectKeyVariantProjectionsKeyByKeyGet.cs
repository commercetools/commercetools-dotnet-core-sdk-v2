using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsKeyByKeyGet : ApiMethod<ByProjectKeyVariantProjectionsKeyByKeyGet>, IApiMethod<ByProjectKeyVariantProjectionsKeyByKeyGet, commercetools.Sdk.Api.Models.Variants.IVariantProjection>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IAttributefilteringTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantProjectionsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyVariantProjectionsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/variant-projections/key={Key}";
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

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments)
        {
            return this.AddQueryParam("priceCustomerGroupAssignments", priceCustomerGroupAssignments);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithPriceRecurrencePolicy(string priceRecurrencePolicy)
        {
            return this.AddQueryParam("priceRecurrencePolicy", priceRecurrencePolicy);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Variants.IVariantProjection> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariantProjection>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariantProjection>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariantProjection>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
