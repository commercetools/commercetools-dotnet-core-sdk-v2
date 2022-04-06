using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IProductDraftImportRequest productDraftImportRequest)
        {
            return new ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, productDraftImportRequest);
        }


        public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
        }
    }
}
