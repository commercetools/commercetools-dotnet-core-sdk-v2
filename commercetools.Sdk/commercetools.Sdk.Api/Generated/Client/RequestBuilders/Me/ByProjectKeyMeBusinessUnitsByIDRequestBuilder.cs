using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeBusinessUnitsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMeBusinessUnitsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMeBusinessUnitsByIDGet Get()
        {
            return new ByProjectKeyMeBusinessUnitsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeBusinessUnitsByIDPost Post(commercetools.Sdk.Api.Models.Me.IMyBusinessUnitUpdate myBusinessUnitUpdate)
        {
            return new ByProjectKeyMeBusinessUnitsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myBusinessUnitUpdate);
        }

        public ByProjectKeyMeBusinessUnitsByIDDelete Delete()
        {
            return new ByProjectKeyMeBusinessUnitsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
