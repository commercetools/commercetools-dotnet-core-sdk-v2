using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeQuoteRequestsByIDPost : ApiMethod<ByProjectKeyMeQuoteRequestsByIDPost>, IApiMethod<ByProjectKeyMeQuoteRequestsByIDPost, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyMeQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeQuoteRequestsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Me.IMyQuoteRequestUpdate MyQuoteRequestUpdate;

        public ByProjectKeyMeQuoteRequestsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Me.IMyQuoteRequestUpdate myQuoteRequestUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.MyQuoteRequestUpdate = myQuoteRequestUpdate;
            this.RequestUrl = $"/{ProjectKey}/me/quote-requests/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyMeQuoteRequestsByIDPost WithExpand(string expand)
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
                var body = this.SerializerService.Serialize(MyQuoteRequestUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
