using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{

    public class ByProjectKeyCustomObjectsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomObjectsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        [Obsolete]
        public ByProjectKeyCustomObjectsGet Get()
        {
            return new ByProjectKeyCustomObjectsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCustomObjectsPost Post(commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectDraft customObjectDraft)
        {
            return new ByProjectKeyCustomObjectsPost(ApiHttpClient, SerializerService, ProjectKey, customObjectDraft);
        }


        public ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder WithContainerAndKey(string container, string key)
        {
            return new ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, container, key);
        }

        public ByProjectKeyCustomObjectsByContainerRequestBuilder WithContainer(string container)
        {
            return new ByProjectKeyCustomObjectsByContainerRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, container);
        }
    }
}
