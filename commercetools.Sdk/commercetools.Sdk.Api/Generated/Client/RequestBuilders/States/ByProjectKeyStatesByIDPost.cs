using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.States
{
    public partial class ByProjectKeyStatesByIDPost : ApiMethod<ByProjectKeyStatesByIDPost>, IApiMethod<ByProjectKeyStatesByIDPost, commercetools.Sdk.Api.Models.States.IState>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyStatesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStatesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStatesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStatesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.States.IStateUpdate StateUpdate;

        public ByProjectKeyStatesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.States.IStateUpdate stateUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.StateUpdate = stateUpdate;
            this.RequestUrl = $"/{ProjectKey}/states/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStatesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.States.IState> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.States.IState>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(StateUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
