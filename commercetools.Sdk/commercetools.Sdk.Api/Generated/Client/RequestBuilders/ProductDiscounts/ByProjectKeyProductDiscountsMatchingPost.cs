using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts
{
    public partial class ByProjectKeyProductDiscountsMatchingPost : ApiMethod<ByProjectKeyProductDiscountsMatchingPost>, IApiMethod<ByProjectKeyProductDiscountsMatchingPost, commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductDiscountsMatchingPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscountMatchQuery ProductDiscountMatchQuery;

        public ByProjectKeyProductDiscountsMatchingPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscountMatchQuery productDiscountMatchQuery)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ProductDiscountMatchQuery = productDiscountMatchQuery;
            this.RequestUrl = $"/{ProjectKey}/product-discounts/matching";
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
                var body = this.SerializerService.Serialize(ProductDiscountMatchQuery);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
