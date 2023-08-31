using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch
{

    public partial class ByProjectKeyImageSearchPost : ApiMethod<ByProjectKeyImageSearchPost>, IApiMethod<ByProjectKeyImageSearchPost, commercetools.Sdk.MLApi.Models.ImageSearches.IImageSearchResponse>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private Stream Stream;

        public ByProjectKeyImageSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, Stream stream)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Stream = stream;
            this.RequestUrl = $"/{ProjectKey}/image-search";
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public ByProjectKeyImageSearchPost WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyImageSearchPost WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }


        public async Task<commercetools.Sdk.MLApi.Models.ImageSearches.IImageSearchResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.ImageSearches.IImageSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.MLApi.Models.ImageSearches.IImageSearchResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.MLApi.Models.ImageSearches.IImageSearchResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (Stream != null && Stream.Length > 0)
            {
                request.Content = new StreamContent(Stream);
                if (Headers.HasHeader(ApiHttpHeaders.CONTENT_TYPE))
                {
                    request.Content.Headers.ContentType =
                        new MediaTypeHeaderValue(Headers.GetFirst(ApiHttpHeaders.CONTENT_TYPE));
                }
            }
            return request;
        }

    }
}
