using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariant
{
   public partial class ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost : ApiMethod<ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private commercetools.ImportApi.Models.Importrequests.IProductVariantPatchRequest ProductVariantPatchRequest;
   
       public ByProjectKeyProductVariantPatchesImportSinkKeyByImportSinkKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, commercetools.ImportApi.Models.Importrequests.IProductVariantPatchRequest productVariantPatchRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ProductVariantPatchRequest = productVariantPatchRequest;
           this.RequestUrl = $"/{ProjectKey}/product-variant-patches/importSinkKey={ImportSinkKey}";
       }
   
   

       public async Task<commercetools.ImportApi.Models.Importrequests.ImportResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importrequests.ImportResponse>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ProductVariantPatchRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
