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

    public partial class ByProjectKeyCustomerGroupsPost : ApiMethod<ByProjectKeyCustomerGroupsPost>, IApiMethod<ByProjectKeyCustomerGroupsPost, commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroup>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomerGroupsPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyCustomerGroupsPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomerGroupsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroupDraft CustomerGroupDraft;

        public ByProjectKeyCustomerGroupsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.CustomerGroups.ICustomerGroupDraft customerGroupDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerGroupDraft = customerGroupDraft;
            this.RequestUrl = $"/{ProjectKey}/customer-groups";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyCustomerGroupsPost WithExpand(string expand)
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
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(CustomerGroupDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
