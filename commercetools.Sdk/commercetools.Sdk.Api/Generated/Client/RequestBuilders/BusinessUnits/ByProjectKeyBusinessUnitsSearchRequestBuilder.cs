using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyBusinessUnitsSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyBusinessUnitsSearchPost Post(commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchRequest businessUnitSearchRequest)
        {
            return new ByProjectKeyBusinessUnitsSearchPost(ApiHttpClient, SerializerService, ProjectKey, businessUnitSearchRequest);
        }

        public ByProjectKeyBusinessUnitsSearchHead Head()
        {
            return new ByProjectKeyBusinessUnitsSearchHead(ApiHttpClient, ProjectKey);
        }

    }
}
