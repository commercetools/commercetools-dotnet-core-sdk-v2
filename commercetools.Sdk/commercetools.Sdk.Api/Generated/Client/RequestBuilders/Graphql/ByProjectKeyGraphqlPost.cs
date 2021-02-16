using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Graphql
{
   public partial class ByProjectKeyGraphqlPost : ApiMethod<ByProjectKeyGraphqlPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.GraphQl.IGraphQLRequest GraphQLRequest;
   
       public ByProjectKeyGraphqlPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.GraphQl.IGraphQLRequest graphQLRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.GraphQLRequest = graphQLRequest;
           this.RequestUrl = $"/{ProjectKey}/graphql";
       }
   
   

       public async Task<commercetools.Api.Models.GraphQl.GraphQLResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.GraphQl.GraphQLResponse>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(GraphQLRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
