using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTypes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IProductTypeImportRequest productTypeImportRequest)
        {
            return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, productTypeImportRequest);
        }


        public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
        }
    }
}
