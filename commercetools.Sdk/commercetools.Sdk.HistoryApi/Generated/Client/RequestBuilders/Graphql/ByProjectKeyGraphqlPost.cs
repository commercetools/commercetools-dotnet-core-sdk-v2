using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.Graphql
{

    public partial class ByProjectKeyGraphqlPost : ApiMethod<ByProjectKeyGraphqlPost>, IApiMethod<ByProjectKeyGraphqlPost, commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLResponse>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLRequest GraphQLRequest;

        public ByProjectKeyGraphqlPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLRequest graphQLRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.GraphQLRequest = graphQLRequest;
            this.RequestUrl = $"/{ProjectKey}/graphql";
        }




        public async Task<commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.HistoryApi.Models.GraphQl.IGraphQLResponse>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(GraphQLRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
