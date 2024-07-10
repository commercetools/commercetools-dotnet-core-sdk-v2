using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyDiscountCodesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyDiscountCodesByIDGet Get()
        {
            return new ByProjectKeyDiscountCodesByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyDiscountCodesByIDHead Head()
        {
            return new ByProjectKeyDiscountCodesByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyDiscountCodesByIDPost Post(commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeUpdate discountCodeUpdate)
        {
            return new ByProjectKeyDiscountCodesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, discountCodeUpdate);
        }

        public ByProjectKeyDiscountCodesByIDDelete Delete()
        {
            return new ByProjectKeyDiscountCodesByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
