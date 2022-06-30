using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{
    public partial class ByProjectKeyMeQuoteRequestsPost : ApiMethod<ByProjectKeyMeQuoteRequestsPost>, IApiMethod<ByProjectKeyMeQuoteRequestsPost, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeQuoteRequestsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyMeQuoteRequestsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeQuoteRequestsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Me.IMyQuoteRequestDraft MyQuoteRequestDraft;

        public ByProjectKeyMeQuoteRequestsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Me.IMyQuoteRequestDraft myQuoteRequestDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.MyQuoteRequestDraft = myQuoteRequestDraft;
            this.RequestUrl = $"/{ProjectKey}/me/quote-requests";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeQuoteRequestsPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(MyQuoteRequestDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
