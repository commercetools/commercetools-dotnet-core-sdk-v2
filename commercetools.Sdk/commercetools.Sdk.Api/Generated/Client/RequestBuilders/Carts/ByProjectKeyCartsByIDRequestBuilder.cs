using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyCartsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyCartsByIDGet Get()
        {
            return new ByProjectKeyCartsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyCartsByIDPost Post(commercetools.Sdk.Api.Models.Carts.ICartUpdate cartUpdate)
        {
            return new ByProjectKeyCartsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, cartUpdate);
        }

        public ByProjectKeyCartsByIDDelete Delete()
        {
            return new ByProjectKeyCartsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
