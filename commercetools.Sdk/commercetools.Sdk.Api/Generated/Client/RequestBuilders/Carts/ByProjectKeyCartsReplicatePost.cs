using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Carts
{
   public partial class ByProjectKeyCartsReplicatePost : ApiMethod<ByProjectKeyCartsReplicatePost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Carts.IReplicaCartDraft ReplicaCartDraft;
   
       public ByProjectKeyCartsReplicatePost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Carts.IReplicaCartDraft replicaCartDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ReplicaCartDraft = replicaCartDraft;
           this.RequestUrl = $"/{ProjectKey}/carts/replicate";
       }
   
   
       

       public async Task<commercetools.Api.Models.Carts.ICart> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Carts.ICart>(requestMessage);
       }
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ReplicaCartDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }

   }
}
