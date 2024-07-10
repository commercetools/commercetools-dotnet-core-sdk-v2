using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring
{

    public partial class ByProjectKeyProductTailoringPost : ApiMethod<ByProjectKeyProductTailoringPost>, IApiMethod<ByProjectKeyProductTailoringPost, commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductTailoringPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyProductTailoringPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTailoringPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoringDraft ProductTailoringDraft;

        public ByProjectKeyProductTailoringPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoringDraft productTailoringDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ProductTailoringDraft = productTailoringDraft;
            this.RequestUrl = $"/{ProjectKey}/product-tailoring";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductTailoringPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(ProductTailoringDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
