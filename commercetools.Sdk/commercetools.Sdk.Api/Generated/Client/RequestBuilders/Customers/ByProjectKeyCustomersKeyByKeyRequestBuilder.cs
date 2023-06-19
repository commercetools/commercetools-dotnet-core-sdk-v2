using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyCustomersKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyCustomersKeyByKeyGet Get()
        {
            return new ByProjectKeyCustomersKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCustomersKeyByKeyPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerUpdate customerUpdate)
        {
            return new ByProjectKeyCustomersKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, customerUpdate);
        }

        public ByProjectKeyCustomersKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCustomersKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
