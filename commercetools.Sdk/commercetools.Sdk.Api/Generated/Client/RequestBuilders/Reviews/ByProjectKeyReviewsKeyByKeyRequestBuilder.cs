using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Reviews
{

    public class ByProjectKeyReviewsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyReviewsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyReviewsKeyByKeyGet Get()
        {
            return new ByProjectKeyReviewsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyReviewsKeyByKeyPost Post(commercetools.Api.Models.Reviews.IReviewUpdate reviewUpdate)
        {
            return new ByProjectKeyReviewsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, reviewUpdate);
        }

        public ByProjectKeyReviewsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyReviewsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
