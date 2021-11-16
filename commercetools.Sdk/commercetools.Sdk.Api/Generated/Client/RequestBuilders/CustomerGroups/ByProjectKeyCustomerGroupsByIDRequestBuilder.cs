using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.CustomerGroups
{

    public class ByProjectKeyCustomerGroupsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyCustomerGroupsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyCustomerGroupsByIDGet Get() {
           return new ByProjectKeyCustomerGroupsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyCustomerGroupsByIDPost Post(commercetools.Api.Models.CustomerGroups.ICustomerGroupUpdate customerGroupUpdate) {
           return new ByProjectKeyCustomerGroupsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, customerGroupUpdate);
       }
       
       public ByProjectKeyCustomerGroupsByIDDelete Delete() {
           return new ByProjectKeyCustomerGroupsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
