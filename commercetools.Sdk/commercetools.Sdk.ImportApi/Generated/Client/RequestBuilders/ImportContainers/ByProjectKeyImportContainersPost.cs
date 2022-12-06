using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersPost : ApiMethod<ByProjectKeyImportContainersPost>, IApiMethod<ByProjectKeyImportContainersPost, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_import_containersTrait<ByProjectKeyImportContainersPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerDraft ImportContainerDraft;

        public ByProjectKeyImportContainersPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerDraft importContainerDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerDraft = importContainerDraft;
            this.RequestUrl = $"/{ProjectKey}/import-containers";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ImportContainerDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
