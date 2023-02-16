using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InBusiness
{

    public partial class ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost : ApiMethod<ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost>, IApiMethod<ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost, commercetools.Sdk.Api.Models.Customers.ICustomerSignInResult>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string BusinessUnitKey { get; }

        private commercetools.Sdk.Api.Models.Me.IMyBusinessUnitAssociateDraft MyBusinessUnitAssociateDraft;

        public ByProjectKeyInBusinessUnitKeyByBusinessUnitKeyMeCustomersPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string businessUnitKey, commercetools.Sdk.Api.Models.Me.IMyBusinessUnitAssociateDraft myBusinessUnitAssociateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.BusinessUnitKey = businessUnitKey;
            this.MyBusinessUnitAssociateDraft = myBusinessUnitAssociateDraft;
            this.RequestUrl = $"/{ProjectKey}/in-business-unit/key={BusinessUnitKey}/me/customers";
        }




        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomerSignInResult> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomerSignInResult>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Customers.ICustomerSignInResult>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Customers.ICustomerSignInResult>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(MyBusinessUnitAssociateDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
