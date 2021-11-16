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


namespace commercetools.Api.Client.RequestBuilders.Projects
{
   public partial class ByProjectKeyPost : ApiMethod<ByProjectKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Projects.IProjectUpdate ProjectUpdate;
   
       public ByProjectKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Projects.IProjectUpdate projectUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ProjectUpdate = projectUpdate;
           this.RequestUrl = $"/{ProjectKey}";
       }
   
   
       

       public async Task<commercetools.Api.Models.Projects.IProject> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Projects.IProject>(requestMessage);
       }
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ProjectUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }

   }
}
