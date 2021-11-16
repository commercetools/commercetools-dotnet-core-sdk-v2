using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   
   public class ByProjectKeyCustomersByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyCustomersByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyCustomersByIDGet Get() {
           return new ByProjectKeyCustomersByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyCustomersByIDPost Post(commercetools.Api.Models.Customers.ICustomerUpdate customerUpdate) {
           return new ByProjectKeyCustomersByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, customerUpdate);
       }
       
       public ByProjectKeyCustomersByIDDelete Delete() {
           return new ByProjectKeyCustomersByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
