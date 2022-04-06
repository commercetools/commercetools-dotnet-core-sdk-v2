using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{
    public partial class ByProjectKeyImportContainersGet : ApiMethod<ByProjectKeyImportContainersGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyImportContainersGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/import-containers";
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public ByProjectKeyImportContainersGet WithLimit(double limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyImportContainersGet WithOffset(double offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyImportContainersGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }


        public async Task<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerPagedResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerPagedResponse>(requestMessage);
        }

    }
}
