using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductDiscounts
{

    public class ByProjectKeyProductDiscountsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductDiscountsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductDiscountsGet Get()
        {
            return new ByProjectKeyProductDiscountsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyProductDiscountsPost Post(commercetools.Api.Models.ProductDiscounts.IProductDiscountDraft productDiscountDraft)
        {
            return new ByProjectKeyProductDiscountsPost(ApiHttpClient, SerializerService, ProjectKey, productDiscountDraft);
        }


        public ByProjectKeyProductDiscountsMatchingRequestBuilder Matching()
        {
            return new ByProjectKeyProductDiscountsMatchingRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductDiscountsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyProductDiscountsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyProductDiscountsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyProductDiscountsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
