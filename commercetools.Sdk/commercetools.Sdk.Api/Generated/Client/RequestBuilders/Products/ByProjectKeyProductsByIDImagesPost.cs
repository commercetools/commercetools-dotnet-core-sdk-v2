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
namespace commercetools.Sdk.Api.Client.RequestBuilders.Products
{

    public partial class ByProjectKeyProductsByIDImagesPost : ApiMethod<ByProjectKeyProductsByIDImagesPost>, IApiMethod<ByProjectKeyProductsByIDImagesPost, commercetools.Sdk.Api.Models.Products.IProduct>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private Stream Stream;

        public ByProjectKeyProductsByIDImagesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, Stream stream)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.Stream = stream;
            this.RequestUrl = $"/{ProjectKey}/products/{ID}/images";
        }

        public List<string> GetFilename()
        {
            return this.GetQueryParam("filename");
        }

        public List<string> GetVariant()
        {
            return this.GetQueryParam("variant");
        }

        public List<string> GetSku()
        {
            return this.GetQueryParam("sku");
        }

        public List<string> GetStaged()
        {
            return this.GetQueryParam("staged");
        }

        public ByProjectKeyProductsByIDImagesPost WithFilename(string filename)
        {
            return this.AddQueryParam("filename", filename);
        }

        public ByProjectKeyProductsByIDImagesPost WithVariant(long variant)
        {
            return this.AddQueryParam("variant", variant.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyProductsByIDImagesPost WithSku(string sku)
        {
            return this.AddQueryParam("sku", sku);
        }

        public ByProjectKeyProductsByIDImagesPost WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.Products.IProduct> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Products.IProduct>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Products.IProduct>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Products.IProduct>(requestMessage, cancellationToken);

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
