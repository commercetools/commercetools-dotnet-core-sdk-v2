using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.PaymentMethods
{

    public partial class ByProjectKeyPaymentMethodsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPaymentMethodsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyPaymentMethodsGet Get()
        {
            return new ByProjectKeyPaymentMethodsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyPaymentMethodsHead Head()
        {
            return new ByProjectKeyPaymentMethodsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyPaymentMethodsPost Post(commercetools.Sdk.Api.Models.PaymentMethods.IPaymentMethodDraft paymentMethodDraft)
        {
            return new ByProjectKeyPaymentMethodsPost(ApiHttpClient, SerializerService, ProjectKey, paymentMethodDraft);
        }


        public ByProjectKeyPaymentMethodsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyPaymentMethodsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyPaymentMethodsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyPaymentMethodsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
