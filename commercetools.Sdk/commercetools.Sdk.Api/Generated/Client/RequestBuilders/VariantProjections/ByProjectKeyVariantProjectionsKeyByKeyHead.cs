using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsKeyByKeyHead : ApiMethod<ByProjectKeyVariantProjectionsKeyByKeyHead>, IApiMethod<ByProjectKeyVariantProjectionsKeyByKeyHead, string>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyVariantProjectionsKeyByKeyHead>, commercetools.Sdk.Api.Client.IProjectionvalidatingTrait<ByProjectKeyVariantProjectionsKeyByKeyHead>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantProjectionsKeyByKeyHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantProjectionsKeyByKeyHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyVariantProjectionsKeyByKeyHead(IClient apiHttpClient, string projectKey, string key)
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

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithPriceCurrency(string priceCurrency)
        {
            return this.AddQueryParam("priceCurrency", priceCurrency);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithPriceCountry(string priceCountry)
        {
            return this.AddQueryParam("priceCountry", priceCountry);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithPriceCustomerGroup(string priceCustomerGroup)
        {
            return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithPriceChannel(string priceChannel)
        {
            return this.AddQueryParam("priceChannel", priceChannel);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead WithFilterAttributes(string filterAttributes)
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
