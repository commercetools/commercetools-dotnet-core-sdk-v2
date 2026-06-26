using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead, string>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead>, commercetools.Sdk.Api.Client.IProjectionvalidatingTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string StoreKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead(IClient apiHttpClient, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/variant-projections";
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
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

        public List<string> GetFilterAttributes()
        {
            return this.GetQueryParam("filter[attributes]");
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsHead WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }


        public async Task<string> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            return await ExecuteAsJsonAsync(cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<string>> SendAsync(CancellationToken cancellationToken = default)
        {

            return await SendAsJsonAsync(cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
