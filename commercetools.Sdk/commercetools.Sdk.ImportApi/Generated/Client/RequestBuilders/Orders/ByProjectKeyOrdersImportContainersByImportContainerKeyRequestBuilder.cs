using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.Orders
{
   
   public class ByProjectKeyOrdersImportContainersByImportContainerKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportContainerKey { get; }
   
       public ByProjectKeyOrdersImportContainersByImportContainerKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportContainerKey = importContainerKey;
       }
   
       public ByProjectKeyOrdersImportContainersByImportContainerKeyPost Post(commercetools.ImportApi.Models.Importrequests.IOrderImportRequest orderImportRequest) {
           return new ByProjectKeyOrdersImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, orderImportRequest);
       }
       
   }
}
