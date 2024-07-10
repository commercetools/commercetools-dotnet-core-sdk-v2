using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportOperations
{

    public partial class ByProjectKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyImportOperationsByIdGet>, IApiMethod<ByProjectKeyImportOperationsByIdGet, commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_import_containersTrait<ByProjectKeyImportOperationsByIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Id { get; }


        public ByProjectKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.RequestUrl = $"/{ProjectKey}/import-operations/{Id}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
