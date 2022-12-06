using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Extensions
{

    public partial class ByProjectKeyExtensionsPost : ApiMethod<ByProjectKeyExtensionsPost>, IApiMethod<ByProjectKeyExtensionsPost, commercetools.Sdk.Api.Models.Extensions.IExtension>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyExtensionsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyExtensionsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyExtensionsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Extensions.IExtensionDraft ExtensionDraft;

        public ByProjectKeyExtensionsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Extensions.IExtensionDraft extensionDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ExtensionDraft = extensionDraft;
            this.RequestUrl = $"/{ProjectKey}/extensions";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyExtensionsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Extensions.IExtension> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Extensions.IExtension>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ExtensionDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
