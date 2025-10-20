using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyApplicationsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyApplicationsKeyByKeyGet Get()
        {
            return new ByProjectKeyApplicationsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyApplicationsKeyByKeyPost Post(commercetools.Sdk.CheckoutApi.Models.Applications.IApplicationUpdateActions applicationUpdateActions)
        {
            return new ByProjectKeyApplicationsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, applicationUpdateActions);
        }

        public ByProjectKeyApplicationsKeyByKeyHead Head()
        {
            return new ByProjectKeyApplicationsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyApplicationsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyApplicationsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
