using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers
{
    public partial class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.ICustomerImportRequest CustomerImportRequest;

        public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.Sdk.ImportApi.Models.Importrequests.ICustomerImportRequest customerImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.CustomerImportRequest = customerImportRequest;
            this.RequestUrl = $"/{ProjectKey}/customers/importSinkKey={ImportSinkKey}";
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
                var body = this.SerializerService.Serialize(CustomerImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
