using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet>, IApiMethod<ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet, commercetools.Sdk.ImportApi.Models.Importsummaries.IImportSummary>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_import_containersTrait<ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }


        public ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet(IClient apiHttpClient, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.RequestUrl = $"/{ProjectKey}/import-containers/{ImportContainerKey}/import-summaries";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importsummaries.IImportSummary> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importsummaries.IImportSummary>(requestMessage);
        }

    }
}
