using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories
{

    public partial class ByProjectKeyTaxCategoriesKeyByKeyGet : ApiMethod<ByProjectKeyTaxCategoriesKeyByKeyGet>, IApiMethod<ByProjectKeyTaxCategoriesKeyByKeyGet, commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyTaxCategoriesKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyTaxCategoriesKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyTaxCategoriesKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyTaxCategoriesKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/tax-categories/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTaxCategoriesKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>(requestMessage, cancellationToken);
        }

    }
}
