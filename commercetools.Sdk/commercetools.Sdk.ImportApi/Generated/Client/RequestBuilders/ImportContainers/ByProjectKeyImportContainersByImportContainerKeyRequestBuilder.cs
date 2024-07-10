using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyImportContainersByImportContainerKeyPut Put(commercetools.Sdk.ImportApi.Models.Importcontainers.IImportContainerUpdateDraft importContainerUpdateDraft)
        {
            return new ByProjectKeyImportContainersByImportContainerKeyPut(ApiHttpClient, ProjectKey, ImportContainerKey, importContainerUpdateDraft);
        }

        public ByProjectKeyImportContainersByImportContainerKeyGet Get()
        {
            return new ByProjectKeyImportContainersByImportContainerKeyGet(ApiHttpClient, ProjectKey, ImportContainerKey);
        }

        public ByProjectKeyImportContainersByImportContainerKeyDelete Delete()
        {
            return new ByProjectKeyImportContainersByImportContainerKeyDelete(ApiHttpClient, ProjectKey, ImportContainerKey);
        }


        public ByProjectKeyImportContainersByImportContainerKeyImportSummariesRequestBuilder ImportSummaries()
        {
            return new ByProjectKeyImportContainersByImportContainerKeyImportSummariesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey);
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportOperationsRequestBuilder ImportOperations()
        {
            return new ByProjectKeyImportContainersByImportContainerKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey);
        }
    }
}
