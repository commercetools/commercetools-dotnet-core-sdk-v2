using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesHead : ApiMethod<ByProjectKeyProductTypesHead>, IApiMethod<ByProjectKeyProductTypesHead, JsonElement>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTypesHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductTypesHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }


        public ByProjectKeyProductTypesHead(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/product-types";
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyProductTypesHead WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }


        public async Task<JsonElement> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage, cancellationToken);
        }

    }
}
