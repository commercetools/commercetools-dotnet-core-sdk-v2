using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client
{
    public class CtpClient : IClient
    {
        public CtpClient(
            Middleware middlewareStack,
            ISerializerService serializerService) : this(middlewareStack, serializerService, DefaultClientNames.Api)
        {
            this.MiddlewareStack = middlewareStack;
            this.SerializerService = serializerService;
        }

        public CtpClient(
            Middleware middlewareStack,
            ISerializerService serializerService,
            string name)
        {
            this.MiddlewareStack = middlewareStack;
            this.SerializerService = serializerService;
            this.Name = name;
        }


        public string Name { get; set; }
        public ISerializerService SerializerService { get; }
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
            var result = await SendAsJsonAsync(requestMessage, cancellationToken);
            var body = this.SerializerService.Deserialize<T>(result.Body);
            return new ApiResponse<T>(result.StatusCode, result.ReasonPhrase, result.HttpHeaders, body);
        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var result = await SendAsAsync(requestMessage, cancellationToken);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return new ApiResponse<string>(result.StatusCode, result.ReasonPhrase, result.Headers, content);
        }
        
        public async Task<HttpResponseMessage> SendAsAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            return await this.MiddlewareStack.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
        }
    }
}
