using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportSummaries
{
    public partial class ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyGet : ApiMethod<ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
   
       public ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyGet(IClient apiHttpClient, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.RequestUrl = $"/{ProjectKey}/import-summaries/importSinkKey={ImportSinkKey}";
       }
   
   
       

       public async Task<commercetools.ImportApi.Models.Importsummaries.IImportSummary> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsummaries.IImportSummary>(requestMessage);
       }

   }
}
