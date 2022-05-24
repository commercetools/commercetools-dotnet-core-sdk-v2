using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.DiscountCodes
{
    public partial class ByProjectKeyDiscountCodesByIDPost : ApiMethod<ByProjectKeyDiscountCodesByIDPost>, IApiMethod<ByProjectKeyDiscountCodesByIDPost, commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyDiscountCodesByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyDiscountCodesByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyDiscountCodesByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyDiscountCodesByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeUpdate DiscountCodeUpdate;

        public ByProjectKeyDiscountCodesByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCodeUpdate discountCodeUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.DiscountCodeUpdate = discountCodeUpdate;
            this.RequestUrl = $"/{ProjectKey}/discount-codes/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyDiscountCodesByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.DiscountCodes.IDiscountCode>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(DiscountCodeUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
