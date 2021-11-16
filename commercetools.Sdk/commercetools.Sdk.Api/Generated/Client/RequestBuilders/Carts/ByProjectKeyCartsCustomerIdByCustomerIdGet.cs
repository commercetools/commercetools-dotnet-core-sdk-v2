using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.Carts
{
    public partial class ByProjectKeyCartsCustomerIdByCustomerIdGet : ApiMethod<ByProjectKeyCartsCustomerIdByCustomerIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string CustomerId { get; }
       
   
       public ByProjectKeyCartsCustomerIdByCustomerIdGet(IClient apiHttpClient, string projectKey, string customerId) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.CustomerId = customerId;
           this.RequestUrl = $"/{ProjectKey}/carts/customer-id={CustomerId}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCartsCustomerIdByCustomerIdGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.Carts.ICart> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Carts.ICart>(requestMessage);
       }

   }
}
