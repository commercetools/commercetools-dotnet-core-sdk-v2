using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class StreamCtpClient : IClient
    {
        public StreamCtpClient(
            Middleware middlewareStack,
            IStreamSerializerService serializerService) : this(middlewareStack, serializerService, DefaultClientNames.Api)
        {
            this.MiddlewareStack = middlewareStack;
            this._serializerService = serializerService;
        }

        public StreamCtpClient(
            Middleware middlewareStack,
            IStreamSerializerService serializerService,
            string name)
        {
            this.MiddlewareStack = middlewareStack;
            this._serializerService = serializerService;
            this.Name = name;
        }

        private readonly IStreamSerializerService _serializerService;

        public string Name { get; set; }
        public ISerializerService SerializerService => _serializerService;
        private Middleware MiddlewareStack { get; }

        public async Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var content = await SendAsync<T>(requestMessage, cancellationToken);
            return content.Body;
        }

        public async Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var result = await SendAsJsonAsync(requestMessage, cancellationToken);
            return result.Body;
        }

        public async Task<IApiResponse<T>> SendAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            using var result = await SendAsAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            await using var contentStream = await result.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var content = _serializerService.Deserialize<T>(contentStream);
            return new ApiResponse<T>(result.StatusCode, result.ReasonPhrase, result.Headers, content);
        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            using var result = await SendAsAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return new ApiResponse<string>(result.StatusCode, result.ReasonPhrase, result.Headers, content);
        }

        public async Task<HttpResponseMessage> SendAsAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            return await this.MiddlewareStack.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
        }
    }
}
