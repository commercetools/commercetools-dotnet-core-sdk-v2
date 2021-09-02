using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Prices;

namespace commercetools.ImportApi.Client.RequestBuilders.Prices
{

    public class ByProjectKeyPricesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPricesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyPricesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyPricesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyPricesImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey)
        {
            return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
        }
    }
}
