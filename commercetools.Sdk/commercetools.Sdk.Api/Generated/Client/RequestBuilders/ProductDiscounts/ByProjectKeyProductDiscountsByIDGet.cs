using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductDiscounts
{

    public partial class ByProjectKeyProductDiscountsByIDGet : ApiMethod<ByProjectKeyProductDiscountsByIDGet>, IApiMethod<ByProjectKeyProductDiscountsByIDGet, commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductDiscountsByIDGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductDiscountsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductDiscountsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyProductDiscountsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/product-discounts/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyProductDiscountsByIDGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductDiscounts.IProductDiscount>(requestMessage);
        }

    }
}
