using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsBulkPost : ApiMethod<ByProjectKeyVariantsBulkPost>, IApiMethod<ByProjectKeyVariantsBulkPost, commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdateResponse>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdate VariantBulkUpdate;

        public ByProjectKeyVariantsBulkPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdate variantBulkUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.VariantBulkUpdate = variantBulkUpdate;
            this.RequestUrl = $"/{ProjectKey}/variants/bulk";
        }

        public List<string> GetVersionControl()
        {
            return this.GetQueryParam("versionControl");
        }

        public ByProjectKeyVariantsBulkPost WithVersionControl(string versionControl)
        {
            return this.AddQueryParam("versionControl", versionControl);
        }


        public async Task<commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdateResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdateResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdateResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdateResponse>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(VariantBulkUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
