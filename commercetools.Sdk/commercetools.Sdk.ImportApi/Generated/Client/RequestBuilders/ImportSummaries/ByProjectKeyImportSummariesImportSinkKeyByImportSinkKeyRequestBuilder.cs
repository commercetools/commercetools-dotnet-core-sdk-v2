using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportSummaries
{

    public class ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyGet Get()
        {
            return new ByProjectKeyImportSummariesImportSinkKeyByImportSinkKeyGet(ApiHttpClient, ProjectKey, ImportSinkKey);
        }

    }
}
