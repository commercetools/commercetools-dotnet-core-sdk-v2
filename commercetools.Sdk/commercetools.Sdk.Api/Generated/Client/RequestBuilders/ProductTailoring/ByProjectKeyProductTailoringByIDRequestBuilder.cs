using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTailoring
{

    public partial class ByProjectKeyProductTailoringByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyProductTailoringByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyProductTailoringByIDGet Get()
        {
            return new ByProjectKeyProductTailoringByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductTailoringByIDPost Post(commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate productTailoringUpdate)
        {
            return new ByProjectKeyProductTailoringByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productTailoringUpdate);
        }

        public ByProjectKeyProductTailoringByIDDelete Delete()
        {
            return new ByProjectKeyProductTailoringByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
