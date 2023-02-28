using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch
{

    public partial class ByProjectKeyImageSearchConfigRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImageSearchConfigRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyImageSearchConfigGet Get()
        {
            return new ByProjectKeyImageSearchConfigGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyImageSearchConfigPost Post(commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest imageSearchConfigRequest)
        {
            return new ByProjectKeyImageSearchConfigPost(ApiHttpClient, SerializerService, ProjectKey, imageSearchConfigRequest);
        }

    }
}
