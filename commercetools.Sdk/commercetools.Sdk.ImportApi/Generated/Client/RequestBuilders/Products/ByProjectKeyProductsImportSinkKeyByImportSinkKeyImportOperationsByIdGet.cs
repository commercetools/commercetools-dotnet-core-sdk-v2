using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Products
{
    public partial class ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsByIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private string Id { get; }


        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string importSinkKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.Id = id;
            this.RequestUrl = $"/{ProjectKey}/products/importSinkKey={ImportSinkKey}/import-operations/{Id}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importoperations.IImportOperation>(requestMessage);
        }

    }
}
