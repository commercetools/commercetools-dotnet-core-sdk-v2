using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories
{

    public class ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        private string Id { get; }

        public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.Id = id;
        }

        public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdGet Get()
        {
            return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdGet(ApiHttpClient, ProjectKey, ImportSinkKey, Id);
        }

    }
}
