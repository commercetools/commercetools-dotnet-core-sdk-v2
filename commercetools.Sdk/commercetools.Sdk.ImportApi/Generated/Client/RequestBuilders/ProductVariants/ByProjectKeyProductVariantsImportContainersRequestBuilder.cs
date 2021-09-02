using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductVariants;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariants
{

    public class ByProjectKeyProductVariantsImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductVariantsImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductVariantsImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyProductVariantsImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}