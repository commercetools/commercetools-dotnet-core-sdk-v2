using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.Categories
{
    public partial class ByProjectKeyCategoriesImportContainersByImportContainerKeyPost : ApiMethod<ByProjectKeyCategoriesImportContainersByImportContainerKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ImportContainerKey { get; }
       
       private commercetools.ImportApi.Models.Importrequests.ICategoryImportRequest CategoryImportRequest;
   
       public ByProjectKeyCategoriesImportContainersByImportContainerKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey, commercetools.ImportApi.Models.Importrequests.ICategoryImportRequest categoryImportRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportContainerKey = importContainerKey;
           this.CategoryImportRequest = categoryImportRequest;
           this.RequestUrl = $"/{ProjectKey}/categories/import-containers/{ImportContainerKey}";
       }
   
   
       

       public async Task<commercetools.ImportApi.Models.Importrequests.IImportResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importrequests.IImportResponse>(requestMessage);
       }
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CategoryImportRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }

   }
}
