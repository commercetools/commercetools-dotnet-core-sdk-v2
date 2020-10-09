using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.CustomerGroups
{
   public partial class ByProjectKeyCustomerGroupsByIDGet : ApiMethod<ByProjectKeyCustomerGroupsByIDGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyCustomerGroupsByIDGet(IClient apiHttpClient, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/customer-groups/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomerGroupsByIDGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.CustomerGroups.CustomerGroup> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CustomerGroups.CustomerGroup>(requestMessage);
       }
   }
}
