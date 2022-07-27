using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{

    public partial class ByProjectKeyCustomObjectsPost : ApiMethod<ByProjectKeyCustomObjectsPost>, IApiMethod<ByProjectKeyCustomObjectsPost, commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomObjectsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyCustomObjectsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomObjectsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectDraft CustomObjectDraft;

        public ByProjectKeyCustomObjectsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectDraft customObjectDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomObjectDraft = customObjectDraft;
            this.RequestUrl = $"/{ProjectKey}/custom-objects";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomObjectsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObject>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomObjectDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
