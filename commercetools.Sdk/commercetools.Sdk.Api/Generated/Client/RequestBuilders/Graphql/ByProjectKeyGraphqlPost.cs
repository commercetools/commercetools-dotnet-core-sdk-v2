using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Graphql
{

    public partial class ByProjectKeyGraphqlPost : ApiMethod<ByProjectKeyGraphqlPost>, IApiMethod<ByProjectKeyGraphqlPost, commercetools.Sdk.Api.Models.GraphQl.IGraphQLResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyGraphqlPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.GraphQl.IGraphQLRequest GraphQLRequest;

        public ByProjectKeyGraphqlPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.GraphQl.IGraphQLRequest graphQLRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.GraphQLRequest = graphQLRequest;
            this.RequestUrl = $"/{ProjectKey}/graphql";
        }




        public async Task<commercetools.Sdk.Api.Models.GraphQl.IGraphQLResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.GraphQl.IGraphQLResponse>(requestMessage, cancellationToken);
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
