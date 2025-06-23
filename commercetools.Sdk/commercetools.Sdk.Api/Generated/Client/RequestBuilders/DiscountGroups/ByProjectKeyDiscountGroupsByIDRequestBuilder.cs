using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountGroups
{

    public partial class ByProjectKeyDiscountGroupsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyDiscountGroupsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyDiscountGroupsByIDGet Get()
        {
            return new ByProjectKeyDiscountGroupsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyDiscountGroupsByIDHead Head()
        {
            return new ByProjectKeyDiscountGroupsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyDiscountGroupsByIDPost Post(commercetools.Sdk.Api.Models.DiscountGroups.IDiscountGroupUpdate discountGroupUpdate)
        {
            return new ByProjectKeyDiscountGroupsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, discountGroupUpdate);
        }

        public ByProjectKeyDiscountGroupsByIDDelete Delete()
        {
            return new ByProjectKeyDiscountGroupsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
