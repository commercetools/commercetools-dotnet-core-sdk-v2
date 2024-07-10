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
namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomerGroups
{

    public partial class ByProjectKeyCustomerGroupsKeyByKeyGet : ApiMethod<ByProjectKeyCustomerGroupsKeyByKeyGet>, IApiMethod<ByProjectKeyCustomerGroupsKeyByKeyGet, commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomerGroupsKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomerGroupsKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomerGroupsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyCustomerGroupsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/customer-groups/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomerGroupsKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
