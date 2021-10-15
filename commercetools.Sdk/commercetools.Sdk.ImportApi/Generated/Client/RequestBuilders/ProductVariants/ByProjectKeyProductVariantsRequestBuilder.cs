using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariants;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariants
{

    public class ByProjectKeyProductVariantsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductVariantsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductVariantsImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyProductVariantsImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey)
        {
            return new ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
        }
    }
}
