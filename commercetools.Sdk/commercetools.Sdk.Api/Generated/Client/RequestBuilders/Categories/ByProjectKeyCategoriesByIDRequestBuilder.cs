using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyCategoriesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyCategoriesByIDGet Get()
        {
            return new ByProjectKeyCategoriesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyCategoriesByIDHead Head()
        {
            return new ByProjectKeyCategoriesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyCategoriesByIDPost Post(commercetools.Sdk.Api.Models.Categories.ICategoryUpdate categoryUpdate)
        {
            return new ByProjectKeyCategoriesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, categoryUpdate);
        }

        public ByProjectKeyCategoriesByIDDelete Delete()
        {
            return new ByProjectKeyCategoriesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
