using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Types
{

    public partial class ByProjectKeyTypesByIDPost : ApiMethod<ByProjectKeyTypesByIDPost>, IApiMethod<ByProjectKeyTypesByIDPost, commercetools.Sdk.Api.Models.Types.IType>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyTypesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyTypesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyTypesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyTypesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Types.ITypeUpdate TypeUpdate;

        public ByProjectKeyTypesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Types.ITypeUpdate typeUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.TypeUpdate = typeUpdate;
            this.RequestUrl = $"/{ProjectKey}/types/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTypesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Types.IType> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Types.IType>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(TypeUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
