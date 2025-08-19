using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurrencePolicies
{

    public partial class ByProjectKeyRecurrencePoliciesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyRecurrencePoliciesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyRecurrencePoliciesKeyByKeyGet Get()
        {
            return new ByProjectKeyRecurrencePoliciesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurrencePoliciesKeyByKeyHead Head()
        {
            return new ByProjectKeyRecurrencePoliciesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurrencePoliciesKeyByKeyPost Post(commercetools.Sdk.Api.Models.RecurrencePolicies.IRecurrencePolicyUpdate recurrencePolicyUpdate)
        {
            return new ByProjectKeyRecurrencePoliciesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, recurrencePolicyUpdate);
        }

        public ByProjectKeyRecurrencePoliciesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyRecurrencePoliciesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
