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

    public partial class ByProjectKeyShippingMethodsMatchingLocationHead : ApiMethod<ByProjectKeyShippingMethodsMatchingLocationHead>, IApiMethod<ByProjectKeyShippingMethodsMatchingLocationHead, string>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsMatchingLocationHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsMatchingLocationHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingLocationHead(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-location";
        }

        public List<string> GetCountry()
        {
            return this.GetQueryParam("country");
        }

        public List<string> GetState()
        {
            return this.GetQueryParam("state");
        }

        public List<string> GetCurrency()
        {
            return this.GetQueryParam("currency");
        }

        public ByProjectKeyShippingMethodsMatchingLocationHead WithCountry(string country)
        {
            return this.AddQueryParam("country", country);
        }

        public ByProjectKeyShippingMethodsMatchingLocationHead WithState(string state)
        {
            return this.AddQueryParam("state", state);
        }

        public ByProjectKeyShippingMethodsMatchingLocationHead WithCurrency(string currency)
        {
            return this.AddQueryParam("currency", currency);
        }


        public async Task<string> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            return await ExecuteAsJsonAsync(cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<string>> SendAsync(CancellationToken cancellationToken = default)
        {

            return await SendAsJsonAsync(cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
