using commercetools.Api.Client.RequestBuilders.InStore;
using commercetools.Api.Client.RequestBuilders.Projects;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;

namespace commercetools.Sdk.Api.Extensions
{
    public static class Extensions
    {
        public static ApiRoot WithApi(this IClient client)
        {
            return ApiFactory.Create(client);
        }

        public static ProjectApiRoot WithProject(this IClient client, string projectKey)
        {
            return ApiFactory.Create(client, projectKey);
        }

        public static ByProjectKeyRequestBuilder WithApi(this IClient client, string projectKey)
        {
            return ApiFactory.CreateForProject(client, projectKey);
        }
        public static ByProjectKeyInStoreKeyByStoreKeyRequestBuilder WithApi(this IClient client, string projectKey, string storeKey)
        {
            return ApiFactory.CreateForStore(client, projectKey, storeKey);
        }
    }
}