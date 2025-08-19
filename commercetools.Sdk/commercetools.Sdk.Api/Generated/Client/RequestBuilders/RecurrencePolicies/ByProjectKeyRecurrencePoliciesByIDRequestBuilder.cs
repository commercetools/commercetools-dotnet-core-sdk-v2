using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurrencePolicies
{

    public partial class ByProjectKeyRecurrencePoliciesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyRecurrencePoliciesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyRecurrencePoliciesByIDGet Get()
        {
            return new ByProjectKeyRecurrencePoliciesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyRecurrencePoliciesByIDHead Head()
        {
            return new ByProjectKeyRecurrencePoliciesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyRecurrencePoliciesByIDPost Post(commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicyUpdate recurrencePolicyUpdate)
        {
            return new ByProjectKeyRecurrencePoliciesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, recurrencePolicyUpdate);
        }

        public ByProjectKeyRecurrencePoliciesByIDDelete Delete()
        {
            return new ByProjectKeyRecurrencePoliciesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
