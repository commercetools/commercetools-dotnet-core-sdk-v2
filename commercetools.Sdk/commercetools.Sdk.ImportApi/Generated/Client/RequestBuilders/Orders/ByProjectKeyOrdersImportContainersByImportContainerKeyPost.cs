using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyOrdersImportContainersByImportContainerKeyPost>, IApiMethod<ByProjectKeyOrdersImportContainersByImportContainerKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_ordersTrait<ByProjectKeyOrdersImportContainersByImportContainerKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IOrderImportRequest OrderImportRequest;

        public ByProjectKeyOrdersImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.Sdk.ImportApi.Models.Importrequests.IOrderImportRequest orderImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.OrderImportRequest = orderImportRequest;
            this.RequestUrl = $"/{ProjectKey}/orders/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(OrderImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
