using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersEmailTokenByEmailTokenGet : ApiMethod<ByProjectKeyCustomersEmailTokenByEmailTokenGet>, IApiMethod<ByProjectKeyCustomersEmailTokenByEmailTokenGet, commercetools.Sdk.Api.Models.Customers.ICustomer>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomersEmailTokenByEmailTokenGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersEmailTokenByEmailTokenGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomersEmailTokenByEmailTokenGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string EmailToken { get; }


        public ByProjectKeyCustomersEmailTokenByEmailTokenGet(IClient apiHttpClient, string projectKey, string emailToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.EmailToken = emailToken;
            this.RequestUrl = $"/{ProjectKey}/customers/email-token={EmailToken}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomersEmailTokenByEmailTokenGet WithExpand(string expand)
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
