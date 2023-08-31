using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories
{

    public partial class ByProjectKeyTaxCategoriesByIDDelete : ApiMethod<ByProjectKeyTaxCategoriesByIDDelete>, IApiMethod<ByProjectKeyTaxCategoriesByIDDelete, commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyTaxCategoriesByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyTaxCategoriesByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyTaxCategoriesByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyTaxCategoriesByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyTaxCategoriesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyTaxCategoriesByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/tax-categories/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTaxCategoriesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyTaxCategoriesByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.TaxCategories.ITaxCategory>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
