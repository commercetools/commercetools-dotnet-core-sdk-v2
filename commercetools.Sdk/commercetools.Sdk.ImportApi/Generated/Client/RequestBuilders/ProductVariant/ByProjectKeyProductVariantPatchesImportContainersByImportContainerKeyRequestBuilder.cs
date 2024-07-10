using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariant
{

    public partial class ByProjectKeyProductVariantPatchesImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyProductVariantPatchesImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyProductVariantPatchesImportContainersByImportContainerKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IProductVariantPatchRequest productVariantPatchRequest)
        {
            return new ByProjectKeyProductVariantPatchesImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, productVariantPatchRequest);
        }

    }
}
