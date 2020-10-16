using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

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
   
       public ByProjectKeyGraphqlPost Post(commercetools.Api.Models.GraphQl.GraphQLRequest graphQLRequest) {
           return new ByProjectKeyGraphqlPost(ApiHttpClient, SerializerService, ProjectKey, graphQLRequest);
       }
       
   }
}
