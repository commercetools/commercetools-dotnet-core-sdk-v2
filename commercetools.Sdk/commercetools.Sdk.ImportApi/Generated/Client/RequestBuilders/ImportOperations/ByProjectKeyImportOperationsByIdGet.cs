using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


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




        public async Task<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>(requestMessage);
        }

    }
}
