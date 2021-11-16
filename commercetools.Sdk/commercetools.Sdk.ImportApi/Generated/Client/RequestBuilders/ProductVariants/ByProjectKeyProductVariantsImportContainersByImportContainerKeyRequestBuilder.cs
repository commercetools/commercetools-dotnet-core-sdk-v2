using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariants
{
   
   public class ByProjectKeyProductVariantsImportContainersByImportContainerKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportContainerKey { get; }
   
       public ByProjectKeyProductVariantsImportContainersByImportContainerKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportContainerKey = importContainerKey;
       }
   
       public ByProjectKeyProductVariantsImportContainersByImportContainerKeyPost Post(commercetools.ImportApi.Models.Importrequests.IProductVariantImportRequest productVariantImportRequest) {
           return new ByProjectKeyProductVariantsImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, productVariantImportRequest);
       }
       
   }
}
