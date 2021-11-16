using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Orders
{

    public class ByProjectKeyOrdersEditsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyOrdersEditsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyOrdersEditsByIDGet Get() {
           return new ByProjectKeyOrdersEditsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyOrdersEditsByIDPost Post(commercetools.Api.Models.OrderEdits.IOrderEditUpdate orderEditUpdate) {
           return new ByProjectKeyOrdersEditsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, orderEditUpdate);
       }
       
       public ByProjectKeyOrdersEditsByIDDelete Delete() {
           return new ByProjectKeyOrdersEditsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
       
       public ByProjectKeyOrdersEditsByIDApplyRequestBuilder Apply() {
           return new ByProjectKeyOrdersEditsByIDApplyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
