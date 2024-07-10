using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Products;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Products
{

    public partial class ByProjectKeyProductsImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductsImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductsImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyProductsImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}
