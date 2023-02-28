using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts
{

    public partial class ByProjectKeyCartDiscountsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCartDiscountsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCartDiscountsGet Get()
        {
            return new ByProjectKeyCartDiscountsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCartDiscountsPost Post(commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountDraft cartDiscountDraft)
        {
            return new ByProjectKeyCartDiscountsPost(ApiHttpClient, SerializerService, ProjectKey, cartDiscountDraft);
        }


        public ByProjectKeyCartDiscountsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyCartDiscountsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyCartDiscountsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyCartDiscountsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
