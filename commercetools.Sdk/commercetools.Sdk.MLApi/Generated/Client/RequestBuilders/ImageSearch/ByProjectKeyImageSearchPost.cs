using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.ImageSearch
{
    public partial class ByProjectKeyImageSearchPost : ApiMethod<ByProjectKeyImageSearchPost>
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
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyImageSearchPost WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }


        public async Task<commercetools.MLApi.Models.ImageSearches.IImageSearchResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.ImageSearches.IImageSearchResponse>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (Stream != null && Stream.Length > 0)
            {
                request.Content = new StreamContent(Stream);
            }
            return request;
        }

    }
}
