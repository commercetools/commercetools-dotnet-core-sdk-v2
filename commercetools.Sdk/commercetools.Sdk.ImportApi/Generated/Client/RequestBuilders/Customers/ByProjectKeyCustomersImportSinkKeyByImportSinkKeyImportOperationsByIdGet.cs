using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
   public partial class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string Id { get; }
       
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string importSinkKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.Id = id;
           this.RequestUrl = $"/{ProjectKey}/customers/importSinkKey={ImportSinkKey}/import-operations/{Id}";
       }
   
   
       

       public async Task<commercetools.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importoperations.IImportOperation>(requestMessage);
       }
   }
}
