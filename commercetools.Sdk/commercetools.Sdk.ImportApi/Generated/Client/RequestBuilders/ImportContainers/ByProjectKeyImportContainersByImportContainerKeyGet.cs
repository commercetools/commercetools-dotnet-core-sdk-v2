using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyGet : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyGet>, IApiMethod<ByProjectKeyImportContainersByImportContainerKeyGet, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_import_containersTrait<ByProjectKeyImportContainersByImportContainerKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }


        public ByProjectKeyImportContainersByImportContainerKeyGet(IClient apiHttpClient, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.RequestUrl = $"/{ProjectKey}/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage, cancellationToken);
        }

    }
}
