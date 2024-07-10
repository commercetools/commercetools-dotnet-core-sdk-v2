using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InBusiness
{

    public partial class ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string BusinessUnitKey { get; }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string businessUnitKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitKey = businessUnitKey;
        }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost Post(commercetools.Sdk.Api.Models.Me.IMyBusinessUnitAssociateDraft myBusinessUnitAssociateDraft)
        {
            return new ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost(ApiHttpClient, SerializerService, ProjectKey, BusinessUnitKey, myBusinessUnitAssociateDraft);
        }

    }
}
