using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.PaymentMethods
{

    public partial class ByProjectKeyPaymentMethodsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyPaymentMethodsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyPaymentMethodsKeyByKeyGet Get()
        {
            return new ByProjectKeyPaymentMethodsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyPaymentMethodsKeyByKeyHead Head()
        {
            return new ByProjectKeyPaymentMethodsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyPaymentMethodsKeyByKeyPost Post(commercetools.Sdk.Api.Models.PaymentMethods.IPaymentMethodUpdate paymentMethodUpdate)
        {
            return new ByProjectKeyPaymentMethodsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, paymentMethodUpdate);
        }

        public ByProjectKeyPaymentMethodsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyPaymentMethodsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
