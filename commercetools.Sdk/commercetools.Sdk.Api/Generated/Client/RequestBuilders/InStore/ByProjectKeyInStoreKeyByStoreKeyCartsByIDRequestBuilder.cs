using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   
   public class ByProjectKeyInStoreKeyByStoreKeyCartsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsByIDGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsByIDPost Post(commercetools.Api.Models.Carts.ICartUpdate cartUpdate) {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, cartUpdate);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsByIDDelete Delete() {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
   }
}
