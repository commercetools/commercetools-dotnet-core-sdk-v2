using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Orders;

namespace commercetools.ImportApi.Client.RequestBuilders.Orders
{

    public class ByProjectKeyOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyOrdersImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyOrdersImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey)
        {
            return new ByProjectKeyOrdersImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
        }
    }
}
