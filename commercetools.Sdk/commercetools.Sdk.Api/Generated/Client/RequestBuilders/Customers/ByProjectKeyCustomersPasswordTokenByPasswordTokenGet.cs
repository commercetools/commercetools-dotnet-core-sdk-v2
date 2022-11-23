using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersPasswordTokenByPasswordTokenGet : ApiMethod<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet>, IApiMethod<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string PasswordToken { get; }


        public ByProjectKeyCustomersPasswordTokenByPasswordTokenGet(IClient apiHttpClient, string projectKey, string passwordToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.PasswordToken = passwordToken;
            this.RequestUrl = $"/{ProjectKey}/customers/password-token={PasswordToken}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomersPasswordTokenByPasswordTokenGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage, cancellationToken);
        }

    }
}
