using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories
{

    public class ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsGet Get()
        {
            return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
        }


        public ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id)
        {
            return new ByProjectKeyCategoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
        }
    }
}
