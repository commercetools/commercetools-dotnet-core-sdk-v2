using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InBusiness
{

    public class ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string BusinessUnitKey { get; }

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string businessUnitKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitKey = businessUnitKey;
        }



        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeRequestBuilder Me()
        {
            return new ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, BusinessUnitKey);
        }
    }
}
