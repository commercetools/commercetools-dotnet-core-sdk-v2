using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersQuotesPost : ApiMethod<ByProjectKeyOrdersQuotesPost>, IApiMethod<ByProjectKeyOrdersQuotesPost, commercetools.Sdk.Api.Models.Orders.IOrder>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersQuotesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Orders.IOrderFromQuoteDraft OrderFromQuoteDraft;

        public ByProjectKeyOrdersQuotesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Orders.IOrderFromQuoteDraft orderFromQuoteDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.OrderFromQuoteDraft = orderFromQuoteDraft;
            this.RequestUrl = $"/{ProjectKey}/orders/quotes";
        }




        public async Task<commercetools.Sdk.Api.Models.Orders.IOrder> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrder>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(OrderFromQuoteDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
