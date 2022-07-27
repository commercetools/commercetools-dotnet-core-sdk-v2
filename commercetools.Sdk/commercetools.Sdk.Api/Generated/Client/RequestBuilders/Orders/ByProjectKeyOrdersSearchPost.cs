using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersSearchPost : ApiMethod<ByProjectKeyOrdersSearchPost>, IApiMethod<ByProjectKeyOrdersSearchPost, commercetools.Sdk.Api.Models.Orders.IOrderPagedSearchResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersSearchPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Orders.IOrderSearchRequest OrderSearchRequest;

        public ByProjectKeyOrdersSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Orders.IOrderSearchRequest orderSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.OrderSearchRequest = orderSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/orders/search";
        }




        public async Task<commercetools.Sdk.Api.Models.Orders.IOrderPagedSearchResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Orders.IOrderPagedSearchResponse>(requestMessage);
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
