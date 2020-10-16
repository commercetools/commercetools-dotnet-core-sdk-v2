using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Domain;
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

        public async Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage)
        {
            var content = await ExecuteAsJsonAsync(requestMessage);
            return this.SerializerService.Deserialize<T>(content);   
        }
        
        public async Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage)
        {
            var result = await this.MiddlewareStack.SendAsync(requestMessage, CancellationToken.None).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (result.IsSuccessStatusCode)
            {
                return content;
            }

            // it will not reach this because either it will success and return the deserialized object or fail and handled by ErrorHandler which will throw it using the right exception type
            var exception = new ApiException(requestMessage, result);
            throw exception;
        }
    }
}
