using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Similarities
{

    public partial class ByProjectKeySimilaritiesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeySimilaritiesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeySimilaritiesProductsRequestBuilder Products()
        {
            return new ByProjectKeySimilaritiesProductsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
