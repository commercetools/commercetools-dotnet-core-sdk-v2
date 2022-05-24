using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksByImportSinkKeyGet : ApiMethod<ByProjectKeyImportSinksByImportSinkKeyGet>, IApiMethod<ByProjectKeyImportSinksByImportSinkKeyGet, commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink>, commercetools.Sdk.ImportApi.Client.ISecured_by_view_import_sinksTrait<ByProjectKeyImportSinksByImportSinkKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }


        public ByProjectKeyImportSinksByImportSinkKeyGet(IClient apiHttpClient, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.RequestUrl = $"/{ProjectKey}/import-sinks/{ImportSinkKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink>(requestMessage);
        }

    }
}
