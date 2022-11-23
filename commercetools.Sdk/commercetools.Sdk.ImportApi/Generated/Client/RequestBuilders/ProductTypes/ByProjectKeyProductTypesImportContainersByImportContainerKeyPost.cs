using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyProductTypesImportContainersByImportContainerKeyPost>, IApiMethod<ByProjectKeyProductTypesImportContainersByImportContainerKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_productsTrait<ByProjectKeyProductTypesImportContainersByImportContainerKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IProductTypeImportRequest ProductTypeImportRequest;

        public ByProjectKeyProductTypesImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.Sdk.ImportApi.Models.Importrequests.IProductTypeImportRequest productTypeImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.ProductTypeImportRequest = productTypeImportRequest;
            this.RequestUrl = $"/{ProjectKey}/product-types/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProductTypeImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
