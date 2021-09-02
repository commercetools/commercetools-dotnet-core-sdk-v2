using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Types;

namespace commercetools.Api.Client.RequestBuilders.Types
{

    public class ByProjectKeyTypesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyTypesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyTypesGet Get()
        {
            return new ByProjectKeyTypesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyTypesPost Post(commercetools.Api.Models.Types.ITypeDraft typeDraft)
        {
            return new ByProjectKeyTypesPost(ApiHttpClient, SerializerService, ProjectKey, typeDraft);
        }


        public ByProjectKeyTypesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyTypesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyTypesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyTypesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
