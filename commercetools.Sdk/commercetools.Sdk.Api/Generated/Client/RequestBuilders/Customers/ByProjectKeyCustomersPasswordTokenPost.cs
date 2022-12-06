using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersPasswordTokenPost : ApiMethod<ByProjectKeyCustomersPasswordTokenPost>, IApiMethod<ByProjectKeyCustomersPasswordTokenPost, commercetools.Sdk.Api.Models.Customers.ICustomerToken>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersPasswordTokenPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Customers.ICustomerCreatePasswordResetToken CustomerCreatePasswordResetToken;

        public ByProjectKeyCustomersPasswordTokenPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Customers.ICustomerCreatePasswordResetToken customerCreatePasswordResetToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerCreatePasswordResetToken = customerCreatePasswordResetToken;
            this.RequestUrl = $"/{ProjectKey}/customers/password-token";
        }




        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomerToken> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomerToken>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerCreatePasswordResetToken);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
