using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksByImportSinkKeyPut : ApiMethod<ByProjectKeyImportSinksByImportSinkKeyPut>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Put;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkUpdateDraft ImportSinkUpdateDraft;

        public ByProjectKeyImportSinksByImportSinkKeyPut(IClient apiHttpClient, string projectKey, string importSinkKey, commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkUpdateDraft importSinkUpdateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.ImportSinkUpdateDraft = importSinkUpdateDraft;
            this.RequestUrl = $"/{ProjectKey}/import-sinks/{ImportSinkKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink>(requestMessage);
        }

    }
}
