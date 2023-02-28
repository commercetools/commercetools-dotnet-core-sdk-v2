using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Reviews
{

    public partial class ByProjectKeyReviewsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyReviewsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyReviewsByIDGet Get()
        {
            return new ByProjectKeyReviewsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyReviewsByIDPost Post(commercetools.Sdk.Api.Models.Reviews.IReviewUpdate reviewUpdate)
        {
            return new ByProjectKeyReviewsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, reviewUpdate);
        }

        public ByProjectKeyReviewsByIDDelete Delete()
        {
            return new ByProjectKeyReviewsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
