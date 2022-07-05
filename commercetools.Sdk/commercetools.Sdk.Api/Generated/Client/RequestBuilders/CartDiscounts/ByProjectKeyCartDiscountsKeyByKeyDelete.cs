using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CartDiscounts
{

    public partial class ByProjectKeyCartDiscountsKeyByKeyDelete : ApiMethod<ByProjectKeyCartDiscountsKeyByKeyDelete>, IApiMethod<ByProjectKeyCartDiscountsKeyByKeyDelete, commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyCartDiscountsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyCartDiscountsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCartDiscountsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCartDiscountsKeyByKeyDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCartDiscountsKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyCartDiscountsKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/cart-discounts/key={Key}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCartDiscountsKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyCartDiscountsKeyByKeyDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscount>(requestMessage);
        }

    }
}
