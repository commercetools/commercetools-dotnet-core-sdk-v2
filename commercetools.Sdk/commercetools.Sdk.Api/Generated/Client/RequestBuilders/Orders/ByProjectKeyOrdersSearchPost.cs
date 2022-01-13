using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Orders
{
    public partial class ByProjectKeyOrdersSearchPost : ApiMethod<ByProjectKeyOrdersSearchPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Api.Models.Orders.IOrderSearchRequest OrderSearchRequest;

        public ByProjectKeyOrdersSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Orders.IOrderSearchRequest orderSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.OrderSearchRequest = orderSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/orders/search";
        }




        public async Task<commercetools.Api.Models.Orders.IOrderPagedSearchResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.IOrderPagedSearchResponse>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(OrderSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
