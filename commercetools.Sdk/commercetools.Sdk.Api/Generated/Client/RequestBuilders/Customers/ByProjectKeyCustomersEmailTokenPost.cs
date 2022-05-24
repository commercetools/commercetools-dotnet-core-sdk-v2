using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{
    public partial class ByProjectKeyCustomersEmailTokenPost : ApiMethod<ByProjectKeyCustomersEmailTokenPost>, IApiMethod<ByProjectKeyCustomersEmailTokenPost, commercetools.Sdk.Api.Models.Customers.ICustomerToken>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersEmailTokenPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Customers.ICustomerCreateEmailToken CustomerCreateEmailToken;

        public ByProjectKeyCustomersEmailTokenPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Customers.ICustomerCreateEmailToken customerCreateEmailToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerCreateEmailToken = customerCreateEmailToken;
            this.RequestUrl = $"/{ProjectKey}/customers/email-token";
        }




        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomerToken> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomerToken>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerCreateEmailToken);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
