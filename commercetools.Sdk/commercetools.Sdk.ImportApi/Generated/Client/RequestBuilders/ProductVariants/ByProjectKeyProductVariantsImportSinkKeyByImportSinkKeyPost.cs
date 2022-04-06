using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariants
{
    public partial class ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IProductVariantImportRequest ProductVariantImportRequest;

        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.Sdk.ImportApi.Models.Importrequests.IProductVariantImportRequest productVariantImportRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.ProductVariantImportRequest = productVariantImportRequest;
            this.RequestUrl = $"/{ProjectKey}/product-variants/importSinkKey={ImportSinkKey}";
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
                var body = this.SerializerService.Serialize(ProductVariantImportRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
