using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyShippingMethodsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyShippingMethodsKeyByKeyGet Get()
        {
            return new ByProjectKeyShippingMethodsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyShippingMethodsKeyByKeyHead Head()
        {
            return new ByProjectKeyShippingMethodsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyShippingMethodsKeyByKeyPost Post(commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodUpdate shippingMethodUpdate)
        {
            return new ByProjectKeyShippingMethodsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, shippingMethodUpdate);
        }

        public ByProjectKeyShippingMethodsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyShippingMethodsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
