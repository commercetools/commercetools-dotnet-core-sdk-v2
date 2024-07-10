using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersSearchIndexingStatusRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersSearchIndexingStatusRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersSearchIndexingStatusGet Get()
        {
            return new ByProjectKeyCustomersSearchIndexingStatusGet(ApiHttpClient, ProjectKey);
        }

    }
}
