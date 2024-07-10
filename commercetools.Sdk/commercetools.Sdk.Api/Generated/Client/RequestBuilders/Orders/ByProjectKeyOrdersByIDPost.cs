using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersByIDPost : ApiMethod<ByProjectKeyOrdersByIDPost>, IApiMethod<ByProjectKeyOrdersByIDPost, commercetools.Sdk.Api.Models.Orders.IOrder>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyOrdersByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Orders.IOrderUpdate OrderUpdate;

        public ByProjectKeyOrdersByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Orders.IOrderUpdate orderUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.OrderUpdate = orderUpdate;
            this.RequestUrl = $"/{ProjectKey}/orders/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyOrdersByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Orders.IOrder>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(OrderUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
