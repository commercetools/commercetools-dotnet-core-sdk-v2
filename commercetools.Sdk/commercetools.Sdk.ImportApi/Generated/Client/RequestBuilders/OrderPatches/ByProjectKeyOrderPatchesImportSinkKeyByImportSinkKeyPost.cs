using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.OrderPatches
{
    public partial class ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyPost>, IApiMethod<ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_ordersTrait<ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IOrderPatchImportRequest OrderPatchImportRequest;

        public ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.Sdk.ImportApi.Models.Importrequests.IOrderPatchImportRequest orderPatchImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.OrderPatchImportRequest = orderPatchImportRequest;
            this.RequestUrl = $"/{ProjectKey}/order-patches/importSinkKey={ImportSinkKey}";
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
                var body = this.SerializerService.Serialize(OrderPatchImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
