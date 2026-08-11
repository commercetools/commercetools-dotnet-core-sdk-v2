using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsByIDVariantAttributesGet : ApiMethod<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, IApiMethod<ByProjectKeyProductProjectionsByIDVariantAttributesGet, commercetools.Sdk.Api.Models.VariantAttributes.IVariantAttributes>, commercetools.Sdk.Api.Client.IProjectionselectingTrait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, commercetools.Sdk.Api.Client.ILocaleprojectingTrait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, commercetools.Sdk.Api.Client.IVariantattributefilteringTrait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, commercetools.Sdk.Api.Client.ISupplychannelfilteringTrait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductProjectionsByIDVariantAttributesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyProductProjectionsByIDVariantAttributesGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/product-projections/{ID}/variant-attributes";
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

        public ByProjectKeyProductProjectionsByIDVariantAttributesGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyProductProjectionsByIDVariantAttributesGet WithLocaleProjection(string localeProjection)
        {
            return this.AddQueryParam("localeProjection", localeProjection);
        }

        public ByProjectKeyProductProjectionsByIDVariantAttributesGet WithFilterAttributes(string filterAttributes)
        {
            return this.AddQueryParam("filter[attributes]", filterAttributes);
        }

        public ByProjectKeyProductProjectionsByIDVariantAttributesGet WithFilterSupplyChannels(string filterSupplyChannels)
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
