using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsByIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Id { get; }

        public ByProjectKeyApplicationsByIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
        }

        public ByProjectKeyApplicationsByIdGet Get()
        {
            return new ByProjectKeyApplicationsByIdGet(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyApplicationsByIdHead Head()
        {
            return new ByProjectKeyApplicationsByIdHead(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyApplicationsByIdPost Post(commercetools.Sdk.CheckoutApi.Models.Applications.IApplicationUpdateActions applicationUpdateActions)
        {
            return new ByProjectKeyApplicationsByIdPost(ApiHttpClient, SerializerService, ProjectKey, Id, applicationUpdateActions);
        }

        public ByProjectKeyApplicationsByIdDelete Delete(commercetools.Sdk.CheckoutApi.Models.Applications.IApplication application)
        {
            return new ByProjectKeyApplicationsByIdDelete(ApiHttpClient, ProjectKey, Id, application);
        }

    }
}
