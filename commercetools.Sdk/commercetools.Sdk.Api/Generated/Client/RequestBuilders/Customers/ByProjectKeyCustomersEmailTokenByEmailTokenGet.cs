using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
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


        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomer> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Customers.ICustomer>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Customers.ICustomer>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
