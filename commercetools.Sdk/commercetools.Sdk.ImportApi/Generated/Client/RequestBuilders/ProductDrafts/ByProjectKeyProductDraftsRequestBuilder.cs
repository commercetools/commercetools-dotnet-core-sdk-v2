using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts
{

    public partial class ByProjectKeyProductDraftsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductDraftsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductDraftsImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyProductDraftsImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
