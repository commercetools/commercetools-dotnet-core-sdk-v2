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
   public partial class ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete(IClient apiHttpClient, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/carts/{ID}";
       }
   
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Carts.Cart> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Carts.Cart>(requestMessage);
       }
   }
}
