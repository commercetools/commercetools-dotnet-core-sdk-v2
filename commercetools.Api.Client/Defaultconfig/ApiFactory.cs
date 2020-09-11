using commercetools.Api.Client.RequestBuilders;

namespace commercetools.Api.Client.Defaultconfig
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
    }
}
