using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.ImportOperations
{

    public class ByProjectKeyImportOperationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImportOperationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyImportOperationsByIdRequestBuilder WithIdValue(string id)
        {
            return new ByProjectKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }
    }
}
