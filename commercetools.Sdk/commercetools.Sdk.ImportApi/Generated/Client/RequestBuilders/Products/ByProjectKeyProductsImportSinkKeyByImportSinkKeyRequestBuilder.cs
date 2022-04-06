using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IProductImportRequest productImportRequest)
        {
            return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, productImportRequest);
        }


        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
        }
    }
}
