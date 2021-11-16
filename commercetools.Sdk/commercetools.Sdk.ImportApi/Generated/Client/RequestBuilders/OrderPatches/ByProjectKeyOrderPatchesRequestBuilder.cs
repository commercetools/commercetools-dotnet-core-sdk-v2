using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.OrderPatches
{

    public class ByProjectKeyOrderPatchesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyOrderPatchesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyOrderPatchesImportContainersRequestBuilder ImportContainers() {
           return new ByProjectKeyOrderPatchesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       [Obsolete("usage of this endpoint has been deprecated.", false)]
       public ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyOrderPatchesImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
