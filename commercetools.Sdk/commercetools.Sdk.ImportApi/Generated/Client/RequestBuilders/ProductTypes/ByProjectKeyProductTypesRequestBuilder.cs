using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTypes
{

    public class ByProjectKeyProductTypesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductTypesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductTypesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyProductTypesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey)
        {
            return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
        }
    }
}
