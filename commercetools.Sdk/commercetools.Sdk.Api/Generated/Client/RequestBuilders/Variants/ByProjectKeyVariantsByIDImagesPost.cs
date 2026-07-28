using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsByIDImagesPost : ApiMethod<ByProjectKeyVariantsByIDImagesPost>, IApiMethod<ByProjectKeyVariantsByIDImagesPost, commercetools.Sdk.Api.Models.Variants.IVariant>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private Stream Stream;

        public ByProjectKeyVariantsByIDImagesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, Stream stream)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.Stream = stream;
            this.RequestUrl = $"/{ProjectKey}/variants/{ID}/images";
        }

        public List<string> GetFilename()
        {
            return this.GetQueryParam("filename");
        }

        public List<string> GetStaged()
        {
            return this.GetQueryParam("staged");
        }

        public ByProjectKeyVariantsByIDImagesPost WithFilename(string filename)
        {
            return this.AddQueryParam("filename", filename);
        }

        public ByProjectKeyVariantsByIDImagesPost WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.Variants.IVariant> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Variants.IVariant>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Variants.IVariant>(requestMessage, cancellationToken);

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
