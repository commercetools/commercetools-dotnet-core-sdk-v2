using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyDelete : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyDelete>, IApiMethod<ByProjectKeyImportContainersByImportContainerKeyDelete, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_import_containersTrait<ByProjectKeyImportContainersByImportContainerKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }


        public ByProjectKeyImportContainersByImportContainerKeyDelete(IClient apiHttpClient, string projectKey, string importContainerKey)
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
