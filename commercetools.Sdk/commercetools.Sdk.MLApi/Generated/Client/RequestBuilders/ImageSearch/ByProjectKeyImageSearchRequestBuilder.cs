using System.IO;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch
{

    public partial class ByProjectKeyImageSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImageSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyImageSearchPost Post(Stream stream)
        {
            return new ByProjectKeyImageSearchPost(ApiHttpClient, SerializerService, ProjectKey, stream);
        }


        public ByProjectKeyImageSearchConfigRequestBuilder Config()
        {
            return new ByProjectKeyImageSearchConfigRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
