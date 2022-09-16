using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyMissingDataPricesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataPricesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMissingDataPricesPost Post(commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesSearchRequest missingPricesSearchRequest)
        {
            return new ByProjectKeyMissingDataPricesPost(ApiHttpClient, SerializerService, ProjectKey, missingPricesSearchRequest);
        }

        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataPricesStatusRequestBuilder Status()
        {
            return new ByProjectKeyMissingDataPricesStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
