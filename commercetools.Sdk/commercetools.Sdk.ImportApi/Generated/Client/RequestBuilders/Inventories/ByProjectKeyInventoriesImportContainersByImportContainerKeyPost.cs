using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Inventories
{

    public partial class ByProjectKeyInventoriesImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyInventoriesImportContainersByImportContainerKeyPost>, IApiMethod<ByProjectKeyInventoriesImportContainersByImportContainerKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_productsTrait<ByProjectKeyInventoriesImportContainersByImportContainerKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IInventoryImportRequest InventoryImportRequest;

        public ByProjectKeyInventoriesImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.Sdk.ImportApi.Models.Importrequests.IInventoryImportRequest inventoryImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.InventoryImportRequest = inventoryImportRequest;
            this.RequestUrl = $"/{ProjectKey}/inventories/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(InventoryImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
