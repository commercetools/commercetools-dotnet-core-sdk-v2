using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes
{

    public partial class ByProjectKeyStagedQuotesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyStagedQuotesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyStagedQuotesKeyByKeyGet Get()
        {
            return new ByProjectKeyStagedQuotesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStagedQuotesKeyByKeyPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteUpdate stagedQuoteUpdate)
        {
            return new ByProjectKeyStagedQuotesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, stagedQuoteUpdate);
        }

        public ByProjectKeyStagedQuotesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyStagedQuotesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
