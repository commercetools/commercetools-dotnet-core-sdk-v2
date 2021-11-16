using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   
   public class ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.Key = key;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost Post(commercetools.Api.Models.ShoppingLists.IShoppingListUpdate shoppingListUpdate) {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, shoppingListUpdate);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyDelete Delete() {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
       }
       
   }
}
