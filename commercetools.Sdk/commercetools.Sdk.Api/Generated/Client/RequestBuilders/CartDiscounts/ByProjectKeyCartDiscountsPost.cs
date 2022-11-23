using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts
{

    public partial class ByProjectKeyCartDiscountsPost : ApiMethod<ByProjectKeyCartDiscountsPost>, IApiMethod<ByProjectKeyCartDiscountsPost, commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCartDiscountsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyCartDiscountsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCartDiscountsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountDraft CartDiscountDraft;

        public ByProjectKeyCartDiscountsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountDraft cartDiscountDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CartDiscountDraft = cartDiscountDraft;
            this.RequestUrl = $"/{ProjectKey}/cart-discounts";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCartDiscountsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CartDiscountDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
