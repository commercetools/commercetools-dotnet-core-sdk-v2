using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Products;

namespace commercetools.ImportApi.Client.RequestBuilders.Products
{

    public class ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsGet Get()
        {
            return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
        }


        public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id)
        {
            return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
        }
    }
}
