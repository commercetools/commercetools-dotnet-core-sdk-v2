using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksPost : ApiMethod<ByProjectKeyImportSinksPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkDraft ImportSinkDraft;

        public ByProjectKeyImportSinksPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkDraft = importSinkDraft;
            this.RequestUrl = $"/{ProjectKey}/import-sinks";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importsinks.IImportSink>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ImportSinkDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
