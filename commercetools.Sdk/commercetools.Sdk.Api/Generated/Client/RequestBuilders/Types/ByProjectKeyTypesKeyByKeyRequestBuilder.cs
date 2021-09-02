using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Types
{

    public class ByProjectKeyTypesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyTypesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyTypesKeyByKeyGet Get()
        {
            return new ByProjectKeyTypesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyTypesKeyByKeyPost Post(commercetools.Api.Models.Types.ITypeUpdate typeUpdate)
        {
            return new ByProjectKeyTypesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, typeUpdate);
        }

        public ByProjectKeyTypesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyTypesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
