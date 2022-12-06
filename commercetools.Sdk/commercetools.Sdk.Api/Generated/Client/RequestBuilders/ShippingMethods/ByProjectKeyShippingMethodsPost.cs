using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsPost : ApiMethod<ByProjectKeyShippingMethodsPost>, IApiMethod<ByProjectKeyShippingMethodsPost, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyShippingMethodsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodDraft ShippingMethodDraft;

        public ByProjectKeyShippingMethodsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodDraft shippingMethodDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ShippingMethodDraft = shippingMethodDraft;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyShippingMethodsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethod>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ShippingMethodDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
