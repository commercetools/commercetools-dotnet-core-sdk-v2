using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Graphql
{

    public class ByProjectKeyGraphqlRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyGraphqlRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyGraphqlPost Post(commercetools.Api.Models.GraphQl.IGraphQLRequest graphQLRequest) {
           return new ByProjectKeyGraphqlPost(ApiHttpClient, SerializerService, ProjectKey, graphQLRequest);
       }
       
   }
}
