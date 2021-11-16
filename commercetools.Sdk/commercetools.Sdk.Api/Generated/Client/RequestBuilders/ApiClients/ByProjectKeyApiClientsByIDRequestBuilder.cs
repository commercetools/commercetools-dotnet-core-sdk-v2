using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ApiClients
{

    public class ByProjectKeyApiClientsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyApiClientsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyApiClientsByIDGet Get()
        {
            return new ByProjectKeyApiClientsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyApiClientsByIDDelete Delete()
        {
            return new ByProjectKeyApiClientsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
