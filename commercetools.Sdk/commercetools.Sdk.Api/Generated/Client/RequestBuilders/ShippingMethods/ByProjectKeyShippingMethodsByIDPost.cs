using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsByIDPost : ApiMethod<ByProjectKeyShippingMethodsByIDPost>, IApiMethod<ByProjectKeyShippingMethodsByIDPost, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyShippingMethodsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodUpdate ShippingMethodUpdate;

        public ByProjectKeyShippingMethodsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodUpdate shippingMethodUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ShippingMethodUpdate = shippingMethodUpdate;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyShippingMethodsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ShippingMethodUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
