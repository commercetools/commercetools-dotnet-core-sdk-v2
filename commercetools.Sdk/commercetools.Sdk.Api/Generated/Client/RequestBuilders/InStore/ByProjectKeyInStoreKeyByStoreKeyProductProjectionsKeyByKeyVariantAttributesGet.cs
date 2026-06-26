using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet, commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes>, commercetools.Sdk.Api.Client.IProjectionselectingvariantTrait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, commercetools.Sdk.Api.Client.IVariantattributefilteringTrait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, commercetools.Sdk.Api.Client.ISupplychannelfilteringTrait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }


        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet(IClient apiHttpClient, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/product-projections/key={Key}/variant-attributes";
        }

        public List<string> GetStaged()
        {
            return this.GetQueryParam("staged");
        }

        public List<string> GetLocaleProjection()
        {
            return this.GetQueryParam("localeProjection");
        }

        public List<string> GetFilterAttributes()
        {
            return this.GetQueryParam("filter[attributes]");
        }

        public List<string> GetFilterSupplyChannels()
        {
            return this.GetQueryParam("filter[supplyChannels]");
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsKeyByKeyVariantAttributesGet WithFilterSupplyChannels(string filterSupplyChannels)
        {
            return this.AddQueryParam("filter[supplyChannels]", filterSupplyChannels);
        }


        public async Task<commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
