using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Customers;

namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
   
   public class ByProjectKeyCustomersRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyCustomersImportContainersRequestBuilder ImportContainers() {
           return new ByProjectKeyCustomersImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       [Obsolete("usage of this endpoint has been deprecated.", false)]
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
