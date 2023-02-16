using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyPut : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyPut>, IApiMethod<ByProjectKeyImportContainersByImportContainerKeyPut, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_import_containersTrait<ByProjectKeyImportContainersByImportContainerKeyPut>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Put;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerUpdateDraft ImportContainerUpdateDraft;

        public ByProjectKeyImportContainersByImportContainerKeyPut(IClient apiHttpClient, string projectKey, string importContainerKey, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerUpdateDraft importContainerUpdateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.ImportContainerUpdateDraft = importContainerUpdateDraft;
            this.RequestUrl = $"/{ProjectKey}/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
