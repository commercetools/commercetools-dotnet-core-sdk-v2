using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Payments
{

    public class ByProjectKeyPaymentsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyPaymentsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyPaymentsKeyByKeyGet Get()
        {
            return new ByProjectKeyPaymentsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyPaymentsKeyByKeyPost Post(commercetools.Api.Models.Payments.IPaymentUpdate paymentUpdate)
        {
            return new ByProjectKeyPaymentsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, paymentUpdate);
        }

        public ByProjectKeyPaymentsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyPaymentsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
