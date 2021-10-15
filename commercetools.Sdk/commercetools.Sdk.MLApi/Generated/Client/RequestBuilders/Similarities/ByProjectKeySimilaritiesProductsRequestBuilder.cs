using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.Similarities;

namespace commercetools.MLApi.Client.RequestBuilders.Similarities
{

    public class ByProjectKeySimilaritiesProductsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeySimilaritiesProductsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeySimilaritiesProductsPost Post(commercetools.MLApi.Models.SimilarProducts.ISimilarProductSearchRequest similarProductSearchRequest)
        {
            return new ByProjectKeySimilaritiesProductsPost(ApiHttpClient, SerializerService, ProjectKey, similarProductSearchRequest);
        }


        public ByProjectKeySimilaritiesProductsStatusRequestBuilder Status()
        {
            return new ByProjectKeySimilaritiesProductsStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
