using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Inventories;

namespace commercetools.ImportApi.Client.RequestBuilders.Inventories
{
   
   public class ByProjectKeyInventoriesImportContainersRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyInventoriesImportContainersRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyInventoriesImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey) {
           return new ByProjectKeyInventoriesImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
       }
   }
}
