using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.CustomerGroups
{
   public partial class ByProjectKeyCustomerGroupsKeyByKeyGet : ApiMethod<ByProjectKeyCustomerGroupsKeyByKeyGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
   
       public ByProjectKeyCustomerGroupsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.RequestUrl = $"/{ProjectKey}/customer-groups/key={Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomerGroupsKeyByKeyGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.CustomerGroups.CustomerGroup> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CustomerGroups.CustomerGroup>(requestMessage);
       }
   }
}
