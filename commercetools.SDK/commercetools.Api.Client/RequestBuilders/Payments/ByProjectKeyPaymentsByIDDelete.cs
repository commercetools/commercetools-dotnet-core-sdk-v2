using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Payments
{
   public partial class ByProjectKeyPaymentsByIDDelete : ApiMethod<ByProjectKeyPaymentsByIDDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyPaymentsByIDDelete(IClient apiHttpClient, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/payments/{ID}";
       }
   
       public List<string> GetDataErasure() {
           return this.GetQueryParam("dataErasure");
       }
       
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyPaymentsByIDDelete WithDataErasure(bool dataErasure){
           return this.AddQueryParam("dataErasure", dataErasure.ToString());
       }
       
       public ByProjectKeyPaymentsByIDDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyPaymentsByIDDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Payments.Payment> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Payments.Payment>(requestMessage);
       }
   }
}
