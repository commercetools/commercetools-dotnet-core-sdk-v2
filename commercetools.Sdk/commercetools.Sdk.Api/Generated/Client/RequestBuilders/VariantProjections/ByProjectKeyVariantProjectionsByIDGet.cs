using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsByIDGet : ApiMethod<ByProjectKeyVariantProjectionsByIDGet>, IApiMethod<ByProjectKeyVariantProjectionsByIDGet, commercetools.Sdk.Api.Models.Variants.IVariantProjection>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IAttributefilteringTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantProjectionsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyVariantProjectionsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/variant-projections/{ID}";
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

        public ByProjectKeyVariantProjectionsByIDGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments)
        {
            return this.AddQueryParam("priceCustomerGroupAssignments", priceCustomerGroupAssignments);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithPriceRecurrencePolicy(string priceRecurrencePolicy)
        {
            return this.AddQueryParam("priceRecurrencePolicy", priceRecurrencePolicy);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyVariantProjectionsByIDGet WithExpand(string expand)
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
