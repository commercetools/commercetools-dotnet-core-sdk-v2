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
            var content = await ExecuteAsJsonAsync(requestMessage, cancellationToken);
            return this.SerializerService.Deserialize<T>(content);
        }

        public async Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            var result = await this.MiddlewareStack.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return content;
        }
    }
}
