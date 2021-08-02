using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete(IClient apiHttpClient, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/orders/{ID}";
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
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete WithDataErasure(bool dataErasure){
           return this.AddQueryParam("dataErasure", dataErasure.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Orders.IOrder> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.IOrder>(requestMessage);
       }
   }
}
