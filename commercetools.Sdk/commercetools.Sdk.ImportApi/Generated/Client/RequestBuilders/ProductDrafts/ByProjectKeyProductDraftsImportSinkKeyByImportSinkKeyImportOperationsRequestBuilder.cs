using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductDrafts;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductDrafts
{

    public class ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsGet Get()
        {
            return new ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
        }


        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id)
        {
            return new ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
        }
    }
}
