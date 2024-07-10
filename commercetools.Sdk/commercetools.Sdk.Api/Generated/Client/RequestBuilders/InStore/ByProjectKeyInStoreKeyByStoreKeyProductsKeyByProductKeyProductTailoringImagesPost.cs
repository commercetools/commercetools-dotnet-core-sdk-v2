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
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost, commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductKey { get; }

        private Stream Stream;

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productKey, Stream stream)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductKey = productKey;
            this.Stream = stream;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/products/key={ProductKey}/product-tailoring/images";
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

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost WithFilename(string filename)
        {
            return this.AddQueryParam("filename", filename);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost WithVariant(long variant)
        {
            return this.AddQueryParam("variant", variant.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost WithSku(string sku)
        {
            return this.AddQueryParam("sku", sku);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

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
