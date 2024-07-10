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
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingCartGet : ApiMethod<ByProjectKeyShippingMethodsMatchingCartGet>, IApiMethod<ByProjectKeyShippingMethodsMatchingCartGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsMatchingCartGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsMatchingCartGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsMatchingCartGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingCartGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-cart";
        }

        public List<string> GetCartId()
        {
            return this.GetQueryParam("cartId");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyShippingMethodsMatchingCartGet WithCartId(string cartId)
        {
            return this.AddQueryParam("cartId", cartId);
        }

        public ByProjectKeyShippingMethodsMatchingCartGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
