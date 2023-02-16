using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsSearchPost : ApiMethod<ByProjectKeyProductProjectionsSearchPost>, IApiMethod<ByProjectKeyProductProjectionsSearchPost, commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductProjectionsSearchPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private List<KeyValuePair<string, string>> _formParams;

        public ByProjectKeyProductProjectionsSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, List<KeyValuePair<string, string>> formParams = null)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this._formParams = formParams ?? new List<KeyValuePair<string, string>>();
            this.RequestUrl = $"/{ProjectKey}/product-projections/search";
        }




        public async Task<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Products.IProductProjectionPagedSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();

            request.Content = new FormUrlEncodedContent(_formParams);
            return request;
        }

        public ByProjectKeyProductProjectionsSearchPost AddFormParam<TValue>(string key, TValue value)
        {
            this._formParams.Add(new KeyValuePair<string, string>(key, value.ToString()));
            return this;
        }

        public ByProjectKeyProductProjectionsSearchPost WithFormParam<TValue>(string key, TValue value)
        {
            return WithoutFormParam(key).AddFormParam(key, value);
        }

        /**
         * removes the specified form parameter
         * @param key form parameter name
         * @return T
         */
        public ByProjectKeyProductProjectionsSearchPost WithoutFormParam(string key)
        {
            this._formParams = this._formParams.FindAll(pair => !pair.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase));
            return this;
        }

        /**
         * set the form parameters
         * @param formParams list of form parameters
         * @return T
         */
        public ByProjectKeyProductProjectionsSearchPost WithFormParams(List<KeyValuePair<string, string>> formParams)
        {
            this._formParams = formParams;
            return this;
        }

        public List<KeyValuePair<string, string>> GetFormParams()
        {
            return this._formParams.ToList();
        }

        public List<string> GetFormParam(string key)
        {
            return this._formParams.FindAll(pair => pair.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)).Select(pair => pair.Value).ToList();
        }

        public List<string> GetFormParamUriStrings()
        {
            return this._formParams.Select(ToUriString).ToList();
        }

        public string GetFormParamUriString()
        {
            return string.Join('&', this._formParams.Select(ToUriString));
        }

        private static string ToUriString(KeyValuePair<string, string> entry)
        {
            return entry.Key + "=" + WebUtility.UrlEncode(entry.Value);
        }

#nullable enable
        public string? GetFirstFormParam(string key)
        {
            return this._formParams
                .FirstOrDefault(pair => pair.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)).Value;
        }
#nullable disable
    }
}
