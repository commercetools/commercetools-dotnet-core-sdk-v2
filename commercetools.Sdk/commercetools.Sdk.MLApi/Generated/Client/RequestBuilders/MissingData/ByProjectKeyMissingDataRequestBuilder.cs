using System;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public class ByProjectKeyMissingDataRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMissingDataRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }


        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataAttributesRequestBuilder Attributes()
        {
            return new ByProjectKeyMissingDataAttributesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataImagesRequestBuilder Images()
        {
            return new ByProjectKeyMissingDataImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
        [Obsolete("usage of this endpoint has been deprecated.", false)]
        public ByProjectKeyMissingDataPricesRequestBuilder Prices()
        {
            return new ByProjectKeyMissingDataPricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
