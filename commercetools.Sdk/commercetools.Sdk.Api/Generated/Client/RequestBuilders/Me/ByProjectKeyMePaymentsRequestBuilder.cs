using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMePaymentsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMePaymentsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMePaymentsGet Get()
        {
            return new ByProjectKeyMePaymentsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMePaymentsPost Post(commercetools.Sdk.Api.Models.Me.IMyPaymentDraft myPaymentDraft)
        {
            return new ByProjectKeyMePaymentsPost(ApiHttpClient, SerializerService, ProjectKey, myPaymentDraft);
        }


        public ByProjectKeyMePaymentsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMePaymentsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyMePaymentsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMePaymentsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
