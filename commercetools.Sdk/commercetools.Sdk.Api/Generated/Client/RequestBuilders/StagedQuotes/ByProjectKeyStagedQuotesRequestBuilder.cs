using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes
{

    public class ByProjectKeyStagedQuotesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStagedQuotesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyStagedQuotesGet Get()
        {
            return new ByProjectKeyStagedQuotesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStagedQuotesPost Post(commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuoteDraft stagedQuoteDraft)
        {
            return new ByProjectKeyStagedQuotesPost(ApiHttpClient, SerializerService, ProjectKey, stagedQuoteDraft);
        }


        public ByProjectKeyStagedQuotesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyStagedQuotesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyStagedQuotesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyStagedQuotesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
