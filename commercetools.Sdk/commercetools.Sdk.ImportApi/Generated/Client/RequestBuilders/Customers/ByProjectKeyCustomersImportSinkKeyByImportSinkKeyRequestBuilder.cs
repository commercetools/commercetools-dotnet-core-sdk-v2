using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Customers;

namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }

        public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
        }

        public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.ICustomerImportRequest customerImportRequest)
        {
            return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, customerImportRequest);
        }


        public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
        }
    }
}
