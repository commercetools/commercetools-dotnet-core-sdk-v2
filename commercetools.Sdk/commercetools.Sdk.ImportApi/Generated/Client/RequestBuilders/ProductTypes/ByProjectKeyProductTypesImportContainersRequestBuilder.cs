using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductTypes;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductTypes
{

    public class ByProjectKeyProductTypesImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductTypesImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductTypesImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyProductTypesImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}
