using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariant
{
    public partial class ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost>, IApiMethod<ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost, commercetools.Sdk.ImportApi.Models.Importrequests.IImportResponse>, commercetools.Sdk.ImportApi.Client.ISecured_by_manage_productsTrait<ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private commercetools.Sdk.ImportApi.Models.Importrequests.IProductVariantPatchRequest ProductVariantPatchRequest;

        public ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.Sdk.ImportApi.Models.Importrequests.IProductVariantPatchRequest productVariantPatchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.ProductVariantPatchRequest = productVariantPatchRequest;
            this.RequestUrl = $"/{ProjectKey}/product-variant-patches/importSinkKey={ImportSinkKey}";
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
                var body = this.SerializerService.Serialize(ProductVariantPatchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
