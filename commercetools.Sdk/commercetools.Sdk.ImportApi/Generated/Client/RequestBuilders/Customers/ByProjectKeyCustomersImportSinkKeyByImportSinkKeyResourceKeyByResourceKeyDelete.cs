using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
   public partial class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete : ApiMethod<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string ResourceKey { get; }
       
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete(IClient apiHttpClient, string projectKey, string importSinkKey, string resourceKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ResourceKey = resourceKey;
           this.RequestUrl = $"/{ProjectKey}/customers/importSinkKey={ImportSinkKey}/resourceKey={ResourceKey}";
       }
   
   

       public async Task<commercetools.ImportApi.Models.Importoperations.ImportOperationStatus> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importoperations.ImportOperationStatus>(requestMessage);
       }
   }
}
