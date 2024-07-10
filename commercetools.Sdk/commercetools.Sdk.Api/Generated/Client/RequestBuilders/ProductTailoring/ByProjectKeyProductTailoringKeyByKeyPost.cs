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

    public partial class ByProjectKeyProductTailoringKeyByKeyPost : ApiMethod<ByProjectKeyProductTailoringKeyByKeyPost>, IApiMethod<ByProjectKeyProductTailoringKeyByKeyPost, commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyProductTailoringKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductTailoringKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductTailoringKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTailoringKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate ProductTailoringUpdate;

        public ByProjectKeyProductTailoringKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate productTailoringUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.ProductTailoringUpdate = productTailoringUpdate;
            this.RequestUrl = $"/{ProjectKey}/product-tailoring/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductTailoringKeyByKeyPost WithExpand(string expand)
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
                var body = this.SerializerService.Serialize(ProductTailoringUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
