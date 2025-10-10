using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyApplicationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyApplicationsGet Get()
        {
            return new ByProjectKeyApplicationsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyApplicationsPost Post(commercetools.Sdk.CheckoutApi.Models.Applications.IApplicationDraft applicationDraft)
        {
            return new ByProjectKeyApplicationsPost(ApiHttpClient, SerializerService, ProjectKey, applicationDraft);
        }


        public ByProjectKeyApplicationsByIdRequestBuilder WithId(string id)
        {
            return new ByProjectKeyApplicationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }

        public ByProjectKeyApplicationsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyApplicationsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
