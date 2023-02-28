using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMePaymentsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyMePaymentsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyMePaymentsKeyByKeyGet Get()
        {
            return new ByProjectKeyMePaymentsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyMePaymentsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Me.IMyPaymentUpdate myPaymentUpdate)
        {
            return new ByProjectKeyMePaymentsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myPaymentUpdate);
        }

        public ByProjectKeyMePaymentsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyMePaymentsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
