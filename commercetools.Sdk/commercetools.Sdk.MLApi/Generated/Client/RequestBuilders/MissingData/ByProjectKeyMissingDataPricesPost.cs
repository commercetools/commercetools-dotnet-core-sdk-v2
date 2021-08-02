using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
   public partial class ByProjectKeyMissingDataPricesPost : ApiMethod<ByProjectKeyMissingDataPricesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.MLApi.Models.MissingData.IMissingPricesSearchRequest MissingPricesSearchRequest;
   
       public ByProjectKeyMissingDataPricesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.MLApi.Models.MissingData.IMissingPricesSearchRequest missingPricesSearchRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.MissingPricesSearchRequest = missingPricesSearchRequest;
           this.RequestUrl = $"/{ProjectKey}/missing-data/prices";
       }
   
   

       public async Task<commercetools.MLApi.Models.Common.ITaskToken> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.Common.ITaskToken>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(MissingPricesSearchRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
