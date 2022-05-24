using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{
    public partial class ByProjectKeyMePaymentsPost : ApiMethod<ByProjectKeyMePaymentsPost>, IApiMethod<ByProjectKeyMePaymentsPost, commercetools.Sdk.Api.Models.Me.IMyPayment>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMePaymentsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyMePaymentsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMePaymentsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Me.IMyPaymentDraft MyPaymentDraft;

        public ByProjectKeyMePaymentsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Me.IMyPaymentDraft myPaymentDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.MyPaymentDraft = myPaymentDraft;
            this.RequestUrl = $"/{ProjectKey}/me/payments";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMePaymentsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Me.IMyPayment> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Me.IMyPayment>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(MyPaymentDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
