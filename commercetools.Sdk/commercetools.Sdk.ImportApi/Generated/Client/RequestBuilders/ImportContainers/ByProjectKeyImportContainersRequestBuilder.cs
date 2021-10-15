using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ImportContainers;

namespace commercetools.ImportApi.Client.RequestBuilders.ImportContainers
{

    public class ByProjectKeyImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyImportContainersPost Post(commercetools.ImportApi.Models.Importcontainers.IImportContainerDraft importContainerDraft)
        {
            return new ByProjectKeyImportContainersPost(ApiHttpClient, SerializerService, ProjectKey, importContainerDraft);
        }

        public ByProjectKeyImportContainersGet Get()
        {
            return new ByProjectKeyImportContainersGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}
