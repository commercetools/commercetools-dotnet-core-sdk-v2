using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet, commercetools.Sdk.Api.Models.Variants.IVariantProjection>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IAttributefilteringTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }


        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet(IClient apiHttpClient, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/variant-projections/key={Key}";
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

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments)
        {
            return this.AddQueryParam("priceCustomerGroupAssignments", priceCustomerGroupAssignments);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithPriceRecurrencePolicy(string priceRecurrencePolicy)
        {
            return this.AddQueryParam("priceRecurrencePolicy", priceRecurrencePolicy);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet WithExpand(string expand)
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
