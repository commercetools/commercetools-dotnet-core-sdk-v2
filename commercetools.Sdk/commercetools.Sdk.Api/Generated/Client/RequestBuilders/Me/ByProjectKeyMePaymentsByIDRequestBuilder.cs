using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMePaymentsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMePaymentsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMePaymentsByIDGet Get()
        {
            return new ByProjectKeyMePaymentsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMePaymentsByIDPost Post(commercetools.Sdk.Api.Models.Me.IMyPaymentUpdate myPaymentUpdate)
        {
            return new ByProjectKeyMePaymentsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myPaymentUpdate);
        }

        public ByProjectKeyMePaymentsByIDDelete Delete()
        {
            return new ByProjectKeyMePaymentsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
