using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Similarities
{

    public class ByProjectKeySimilaritiesProductsStatusRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeySimilaritiesProductsStatusRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeySimilaritiesProductsStatusByTaskIdRequestBuilder WithTaskId(string taskId)
        {
            return new ByProjectKeySimilaritiesProductsStatusByTaskIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, taskId);
        }
    }
}
