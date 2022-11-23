using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{

    public partial class ByProjectKeyDiscountCodesPost : ApiMethod<ByProjectKeyDiscountCodesPost>, IApiMethod<ByProjectKeyDiscountCodesPost, commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyDiscountCodesPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyDiscountCodesPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyDiscountCodesPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeDraft DiscountCodeDraft;

        public ByProjectKeyDiscountCodesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeDraft discountCodeDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.DiscountCodeDraft = discountCodeDraft;
            this.RequestUrl = $"/{ProjectKey}/discount-codes";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyDiscountCodesPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(DiscountCodeDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
