using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurrencePolicies
{

    public partial class ByProjectKeyRecurrencePoliciesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRecurrencePoliciesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyRecurrencePoliciesGet Get()
        {
            return new ByProjectKeyRecurrencePoliciesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurrencePoliciesHead Head()
        {
            return new ByProjectKeyRecurrencePoliciesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurrencePoliciesPost Post(commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicyDraft recurrencePolicyDraft)
        {
            return new ByProjectKeyRecurrencePoliciesPost(ApiHttpClient, SerializerService, ProjectKey, recurrencePolicyDraft);
        }


        public ByProjectKeyRecurrencePoliciesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyRecurrencePoliciesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyRecurrencePoliciesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyRecurrencePoliciesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
