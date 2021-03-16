using commercetools.Api.Client.RequestBuilders.InStore;
using commercetools.Base.Client;
using commercetools.Api.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.Api.Client
{
    public class ApiFactory
    { 
       public static ApiRoot Create(
            IClient client)
        {
            return new ApiRoot(client);
        }

        public static ByProjectKeyRequestBuilder CreateForProject(
            IClient client, string projectKey)
        {
            return new ApiRoot(client).WithProjectKey(projectKey);
        }
        
        public static ByProjectKeyInStoreKeyByStoreKeyRequestBuilder CreateForStore(
            IClient client, string projectKey, string storeKey)
        {
            return new ApiRoot(client).WithProjectKey(projectKey).InStoreKeyWithStoreKeyValue(storeKey);
        }
    }
}
