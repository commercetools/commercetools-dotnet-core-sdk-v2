using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.States
{
    public partial class ByProjectKeyStatesPost : ApiMethod<ByProjectKeyStatesPost>, IApiMethod<ByProjectKeyStatesPost, commercetools.Sdk.Api.Models.States.IState>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStatesPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyStatesPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStatesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.States.IStateDraft StateDraft;

        public ByProjectKeyStatesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.States.IStateDraft stateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StateDraft = stateDraft;
            this.RequestUrl = $"/{ProjectKey}/states";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyStatesPost WithExpand(string expand)
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
                var body = this.SerializerService.Serialize(StateDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
