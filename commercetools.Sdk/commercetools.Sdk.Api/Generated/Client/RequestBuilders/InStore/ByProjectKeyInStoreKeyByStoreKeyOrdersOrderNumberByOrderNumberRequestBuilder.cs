using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   
   public class ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string OrderNumber { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string orderNumber) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.OrderNumber = orderNumber;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet(ApiHttpClient, ProjectKey, StoreKey, OrderNumber);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost Post(commercetools.Api.Models.Orders.IOrderUpdate orderUpdate) {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, OrderNumber, orderUpdate);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberDelete Delete() {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberDelete(ApiHttpClient, ProjectKey, StoreKey, OrderNumber);
       }
       
   }
}
