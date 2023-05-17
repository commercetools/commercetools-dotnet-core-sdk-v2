using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.AsAssociate
{

    public partial class ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost : ApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost>, IApiMethod<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string AssociateId { get; }

        private string BusinessUnitKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate QuoteRequestUpdate;

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string associateId, string businessUnitKey, string id, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestUpdate quoteRequestUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.AssociateId = associateId;
            this.BusinessUnitKey = businessUnitKey;
            this.ID = id;
            this.QuoteRequestUpdate = quoteRequestUpdate;
            this.RequestUrl = $"/{ProjectKey}/as-associate/{AssociateId}/in-business-unit/key={BusinessUnitKey}/quote-requests/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyAsAssociateByAssociateIdInBusinessUnitKeyByBusinessUnitKeyQuoteRequestsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequest>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(QuoteRequestUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}