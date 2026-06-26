using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsGet : ApiMethod<ByProjectKeyVariantsGet>, IApiMethod<ByProjectKeyVariantsGet, commercetools.Sdk.Api.Models.Variants.IVariantPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyVariantsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyVariantsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyVariantsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyVariantsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/variants";
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public ByProjectKeyVariantsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyVariantsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyVariantsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyVariantsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyVariantsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyVariantsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyVariantsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.Variants.IVariantPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariantPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariantPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariantPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
