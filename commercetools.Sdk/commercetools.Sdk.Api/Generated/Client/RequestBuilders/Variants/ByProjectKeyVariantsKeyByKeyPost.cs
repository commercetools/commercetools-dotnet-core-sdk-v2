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

    public partial class ByProjectKeyVariantsKeyByKeyPost : ApiMethod<ByProjectKeyVariantsKeyByKeyPost>, IApiMethod<ByProjectKeyVariantsKeyByKeyPost, commercetools.Sdk.Api.Models.Variants.IVariant>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyVariantsKeyByKeyPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyVariantsKeyByKeyPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyVariantsKeyByKeyPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyVariantsKeyByKeyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Key { get; }

        private commercetools.Sdk.Api.Models.Variants.IVariantUpdate VariantUpdate;

        public ByProjectKeyVariantsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Sdk.Api.Models.Variants.IVariantUpdate variantUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.VariantUpdate = variantUpdate;
            this.RequestUrl = $"/{ProjectKey}/variants/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyVariantsKeyByKeyPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Variants.IVariant> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariant>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(VariantUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
