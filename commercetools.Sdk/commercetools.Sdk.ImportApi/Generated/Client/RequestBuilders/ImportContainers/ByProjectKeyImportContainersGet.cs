using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersGet : ApiMethod<ByProjectKeyImportContainersGet>, IApiMethod<ByProjectKeyImportContainersGet, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerPagedResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_import_containersTrait<ByProjectKeyImportContainersGet>
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

        public ByProjectKeyImportContainersGet WithLimit(decimal limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyImportContainersGet WithOffset(decimal offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyImportContainersGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }


        public async Task<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerPagedResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerPagedResponse>(requestMessage, cancellationToken);
        }

    }
}
