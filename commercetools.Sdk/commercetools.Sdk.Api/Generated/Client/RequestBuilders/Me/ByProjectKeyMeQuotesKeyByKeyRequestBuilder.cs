using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMeQuotesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMeQuotesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMeQuotesKeyByKeyGet Get()
        {
            return new ByProjectKeyMeQuotesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMeQuotesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyQuoteUpdate myQuoteUpdate)
        {
            return new ByProjectKeyMeQuotesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myQuoteUpdate);
        }

    }
}
