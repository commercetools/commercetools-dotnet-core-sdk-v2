using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersSearchPost : ApiMethod<ByProjectKeyCustomersSearchPost>, IApiMethod<ByProjectKeyCustomersSearchPost, commercetools.Sdk.Api.Models.CustomerSearches.ICustomerPagedSearchResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersSearchPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchRequest CustomerSearchRequest;

        public ByProjectKeyCustomersSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchRequest customerSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerSearchRequest = customerSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/customers/search";
        }




        public async Task<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerPagedSearchResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerPagedSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerPagedSearchResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerPagedSearchResponse>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(CustomerSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
