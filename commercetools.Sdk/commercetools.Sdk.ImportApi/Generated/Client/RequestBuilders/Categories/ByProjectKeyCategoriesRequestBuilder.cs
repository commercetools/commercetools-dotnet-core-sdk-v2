using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCategoriesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyCategoriesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyCategoriesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
