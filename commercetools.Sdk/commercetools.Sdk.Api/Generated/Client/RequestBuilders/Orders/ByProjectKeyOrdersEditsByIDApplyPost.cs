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
namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsByIDApplyPost : ApiMethod<ByProjectKeyOrdersEditsByIDApplyPost>, IApiMethod<ByProjectKeyOrdersEditsByIDApplyPost, commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersEditsByIDApplyPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.OrderEdits.IOrderEditApply OrderEditApply;

        public ByProjectKeyOrdersEditsByIDApplyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.OrderEdits.IOrderEditApply orderEditApply)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.OrderEditApply = orderEditApply;
            this.RequestUrl = $"/{ProjectKey}/orders/edits/{ID}/apply";
        }




        public async Task<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEdit>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(OrderEditApply);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
