using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.CustomerGroups;

namespace commercetools.Api.Client.RequestBuilders.CustomerGroups
{
   
   public class ByProjectKeyCustomerGroupsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomerGroupsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomerGroupsGet Get() {
           return new ByProjectKeyCustomerGroupsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyCustomerGroupsPost Post(commercetools.Api.Models.CustomerGroups.ICustomerGroupDraft customerGroupDraft) {
           return new ByProjectKeyCustomerGroupsPost(ApiHttpClient, SerializerService, ProjectKey, customerGroupDraft);
       }
       
       
       public ByProjectKeyCustomerGroupsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyCustomerGroupsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       
       public ByProjectKeyCustomerGroupsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyCustomerGroupsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
