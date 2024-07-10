using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyCustomersImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyCustomersImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
