using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Types
{

    public partial class ByProjectKeyTypesImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyTypesImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyTypesImportContainersByImportContainerKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.ITypeImportRequest typeImportRequest)
        {
            return new ByProjectKeyTypesImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, typeImportRequest);
        }

    }
}
