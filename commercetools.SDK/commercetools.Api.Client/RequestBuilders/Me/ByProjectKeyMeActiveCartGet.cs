using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeActiveCartGet : ApiMethod<ByProjectKeyMeActiveCartGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyMeActiveCartGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/me/active-cart";
       }
   
   

       public async Task<commercetools.Api.Models.Me.MyCart> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Me.MyCart>(requestMessage);
       }
   }
}
