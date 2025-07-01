using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.PaymentMethods
{

    public partial class ByProjectKeyPaymentMethodsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyPaymentMethodsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyPaymentMethodsByIDGet Get()
        {
            return new ByProjectKeyPaymentMethodsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyPaymentMethodsByIDHead Head()
        {
            return new ByProjectKeyPaymentMethodsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyPaymentMethodsByIDPost Post(commercetools.Sdk.Api.Models.PaymentMethods.IPaymentMethodUpdate paymentMethodUpdate)
        {
            return new ByProjectKeyPaymentMethodsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, paymentMethodUpdate);
        }

        public ByProjectKeyPaymentMethodsByIDDelete Delete()
        {
            return new ByProjectKeyPaymentMethodsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
