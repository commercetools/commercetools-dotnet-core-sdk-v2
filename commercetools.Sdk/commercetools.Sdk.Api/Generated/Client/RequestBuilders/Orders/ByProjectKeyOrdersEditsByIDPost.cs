using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsByIDPost : ApiMethod<ByProjectKeyOrdersEditsByIDPost>, IApiMethod<ByProjectKeyOrdersEditsByIDPost, commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyOrdersEditsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersEditsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersEditsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersEditsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.OrderEdits.IOrderEditUpdate OrderEditUpdate;

        public ByProjectKeyOrdersEditsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.OrderEdits.IOrderEditUpdate orderEditUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.OrderEditUpdate = orderEditUpdate;
            this.RequestUrl = $"/{ProjectKey}/orders/edits/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyOrdersEditsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(OrderEditUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
