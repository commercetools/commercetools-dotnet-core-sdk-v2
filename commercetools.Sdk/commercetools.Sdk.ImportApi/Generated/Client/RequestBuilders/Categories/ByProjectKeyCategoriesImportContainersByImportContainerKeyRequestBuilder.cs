using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.Categories
{
   
   public class ByProjectKeyCategoriesImportContainersByImportContainerKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportContainerKey { get; }
   
       public ByProjectKeyCategoriesImportContainersByImportContainerKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportContainerKey = importContainerKey;
       }
   
       public ByProjectKeyCategoriesImportContainersByImportContainerKeyPost Post(commercetools.ImportApi.Models.Importrequests.ICategoryImportRequest categoryImportRequest) {
           return new ByProjectKeyCategoriesImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, categoryImportRequest);
       }
       
   }
}
