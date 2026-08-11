using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet, commercetools.Sdk.Api.Models.Variants.IVariantProjection>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IPriceselectingTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IAttributefilteringTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }


        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet(IClient apiHttpClient, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/variant-projections/{ID}";
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

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceCustomerGroupAssignments(string priceCustomerGroupAssignments)
        {
            return this.AddQueryParam("priceCustomerGroupAssignments", priceCustomerGroupAssignments);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithPriceRecurrencePolicy(string priceRecurrencePolicy)
        {
            return this.AddQueryParam("priceRecurrencePolicy", priceRecurrencePolicy);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet WithExpand(string expand)
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
