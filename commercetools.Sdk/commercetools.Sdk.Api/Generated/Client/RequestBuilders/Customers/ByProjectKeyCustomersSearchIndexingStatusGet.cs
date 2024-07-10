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

    public partial class ByProjectKeyCustomersSearchIndexingStatusGet : ApiMethod<ByProjectKeyCustomersSearchIndexingStatusGet>, IApiMethod<ByProjectKeyCustomersSearchIndexingStatusGet, commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchIndexingStatusResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersSearchIndexingStatusGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomersSearchIndexingStatusGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyCustomersSearchIndexingStatusGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/customers/search/indexing-status";
        }




        public async Task<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchIndexingStatusResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchIndexingStatusResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchIndexingStatusResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.CustomerSearches.ICustomerSearchIndexingStatusResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
