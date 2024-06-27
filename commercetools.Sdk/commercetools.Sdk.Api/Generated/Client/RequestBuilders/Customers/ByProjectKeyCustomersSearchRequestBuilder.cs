using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersSearchPost Post(commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchRequest customerSearchRequest)
        {
            return new ByProjectKeyCustomersSearchPost(ApiHttpClient, SerializerService, ProjectKey, customerSearchRequest);
        }

        public ByProjectKeyCustomersSearchHead Head()
        {
            return new ByProjectKeyCustomersSearchHead(ApiHttpClient, ProjectKey);
        }

    }
}
