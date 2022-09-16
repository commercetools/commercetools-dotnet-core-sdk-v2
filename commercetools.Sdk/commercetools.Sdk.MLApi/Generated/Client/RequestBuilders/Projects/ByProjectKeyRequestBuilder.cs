using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch;
using commercetools.Sdk.MLApi.Client.RequestBuilders.Recommendations;
using commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData;
using commercetools.Sdk.MLApi.Client.RequestBuilders.Similarities;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Projects
{

    public class ByProjectKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyImageSearchRequestBuilder ImageSearch()
        {
            return new ByProjectKeyImageSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyRecommendationsRequestBuilder Recommendations()
        {
            return new ByProjectKeyRecommendationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataRequestBuilder MissingData()
        {
            return new ByProjectKeyMissingDataRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeySimilaritiesRequestBuilder Similarities()
        {
            return new ByProjectKeySimilaritiesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
