using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeGet Get()
        {
            return new ByProjectKeyMeGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMePost Post(commercetools.Sdk.Api.Models.Me.IMyCustomerUpdate myCustomerUpdate)
        {
            return new ByProjectKeyMePost(ApiHttpClient, SerializerService, ProjectKey, myCustomerUpdate);
        }

        public ByProjectKeyMeDelete Delete()
        {
            return new ByProjectKeyMeDelete(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyMeEmailConfirmRequestBuilder EmailConfirm()
        {
            return new ByProjectKeyMeEmailConfirmRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMePasswordRequestBuilder Password()
        {
            return new ByProjectKeyMePasswordRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeSignupRequestBuilder Signup()
        {
            return new ByProjectKeyMeSignupRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeLoginRequestBuilder Login()
        {
            return new ByProjectKeyMeLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeActiveCartRequestBuilder ActiveCart()
        {
            return new ByProjectKeyMeActiveCartRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeBusinessUnitsRequestBuilder BusinessUnits()
        {
            return new ByProjectKeyMeBusinessUnitsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeCartsRequestBuilder Carts()
        {
            return new ByProjectKeyMeCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyMeOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMePaymentsRequestBuilder Payments()
        {
            return new ByProjectKeyMePaymentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeQuoteRequestsRequestBuilder QuoteRequests()
        {
            return new ByProjectKeyMeQuoteRequestsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeQuotesRequestBuilder Quotes()
        {
            return new ByProjectKeyMeQuotesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMeShoppingListsRequestBuilder ShoppingLists()
        {
            return new ByProjectKeyMeShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
