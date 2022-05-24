using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{
    public partial class ByProjectKeyProductTypesByIDPost : ApiMethod<ByProjectKeyProductTypesByIDPost>, IApiMethod<ByProjectKeyProductTypesByIDPost, commercetools.Sdk.Api.Models.ProductTypes.IProductType>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyProductTypesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductTypesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductTypesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTypesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.ProductTypes.IProductTypeUpdate ProductTypeUpdate;

        public ByProjectKeyProductTypesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.ProductTypes.IProductTypeUpdate productTypeUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ProductTypeUpdate = productTypeUpdate;
            this.RequestUrl = $"/{ProjectKey}/product-types/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductTypesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductTypes.IProductType> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductTypes.IProductType>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProductTypeUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
