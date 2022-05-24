using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers
{
    public partial class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet>, IApiMethod<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet, commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_customersTrait<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private string Id { get; }


        public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string importSinkKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.Id = id;
            this.RequestUrl = $"/{ProjectKey}/customers/importSinkKey={ImportSinkKey}/import-operations/{Id}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>(requestMessage);
        }

    }
}
