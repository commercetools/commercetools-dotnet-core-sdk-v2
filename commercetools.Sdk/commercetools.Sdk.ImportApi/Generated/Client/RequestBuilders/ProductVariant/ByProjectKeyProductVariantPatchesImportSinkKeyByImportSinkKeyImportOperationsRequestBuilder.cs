using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariant;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariant
{
   
   public class ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsGet Get() {
           return new ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
       
       public ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id) {
           return new ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
       }
   }
}
