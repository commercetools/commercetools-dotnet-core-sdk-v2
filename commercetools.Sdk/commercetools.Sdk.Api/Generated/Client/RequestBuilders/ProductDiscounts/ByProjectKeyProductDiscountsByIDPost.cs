using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts
{
    public partial class ByProjectKeyProductDiscountsByIDPost : ApiMethod<ByProjectKeyProductDiscountsByIDPost>, IApiMethod<ByProjectKeyProductDiscountsByIDPost, commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyProductDiscountsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductDiscountsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductDiscountsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductDiscountsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscountUpdate ProductDiscountUpdate;

        public ByProjectKeyProductDiscountsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscountUpdate productDiscountUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.ProductDiscountUpdate = productDiscountUpdate;
            this.RequestUrl = $"/{ProjectKey}/product-discounts/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductDiscountsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ProductDiscountUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
