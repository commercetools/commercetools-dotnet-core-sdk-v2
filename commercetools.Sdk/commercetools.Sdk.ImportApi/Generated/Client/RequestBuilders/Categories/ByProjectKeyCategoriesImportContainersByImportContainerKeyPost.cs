using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyCategoriesImportContainersByImportContainerKeyPost>, IApiMethod<ByProjectKeyCategoriesImportContainersByImportContainerKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_productsTrait<ByProjectKeyCategoriesImportContainersByImportContainerKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.ICategoryImportRequest CategoryImportRequest;

        public ByProjectKeyCategoriesImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.Sdk.ImportApi.Models.Importrequests.ICategoryImportRequest categoryImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.CategoryImportRequest = categoryImportRequest;
            this.RequestUrl = $"/{ProjectKey}/categories/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CategoryImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
