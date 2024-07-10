using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.Api.Client.RequestBuilders.Reviews;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Reviews
{

    public partial class ByProjectKeyReviewsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyReviewsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyReviewsGet Get()
        {
            return new ByProjectKeyReviewsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyReviewsHead Head()
        {
            return new ByProjectKeyReviewsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyReviewsPost Post(commercetools.Sdk.Api.Models.Reviews.IReviewDraft reviewDraft)
        {
            return new ByProjectKeyReviewsPost(ApiHttpClient, SerializerService, ProjectKey, reviewDraft);
        }


        public ByProjectKeyReviewsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyReviewsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyReviewsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyReviewsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
