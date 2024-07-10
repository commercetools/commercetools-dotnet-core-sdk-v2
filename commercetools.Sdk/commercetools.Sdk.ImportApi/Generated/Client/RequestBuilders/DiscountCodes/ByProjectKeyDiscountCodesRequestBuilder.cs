using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyDiscountCodesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyDiscountCodesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyDiscountCodesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
