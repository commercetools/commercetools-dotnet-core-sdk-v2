using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{
    public partial class ByProjectKeyCustomObjectsByContainerGet : ApiMethod<ByProjectKeyCustomObjectsByContainerGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Container { get; }


        public ByProjectKeyCustomObjectsByContainerGet(IClient apiHttpClient, string projectKey, string container)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Container = container;
            this.RequestUrl = $"/{ProjectKey}/custom-objects/{Container}";
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomObjectsByContainerGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyCustomObjectsByContainerGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyCustomObjectsByContainerGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>(requestMessage);
        }

    }
}
