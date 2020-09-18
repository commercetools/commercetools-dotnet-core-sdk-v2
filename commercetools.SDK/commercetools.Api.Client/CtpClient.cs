using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Api.Client.DelegatingHandlers;
using commercetools.Api.Client.Domain;
using commercetools.Api.Serialization;

namespace commercetools.Api.Client
{
    public class CtpClient : IClient
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly ISerializerService serializerService;
        private readonly IUserAgentProvider userAgentProvider;
        private HttpClient httpClient;

        public CtpClient(
            IHttpClientFactory httpClientFactory,
            ISerializerService serializerService,
            IUserAgentProvider userAgentProvider)
        {
            this.httpClientFactory = httpClientFactory;
            this.serializerService = serializerService;
            this.userAgentProvider = userAgentProvider;
        }

        public string Name { get; set; } = DefaultClientNames.Api;

        private HttpClient HttpClient
        {
            get
            {
                if (this.httpClient == null)
                {
                    this.httpClient = this.httpClientFactory.CreateClient(this.Name);
                    this.httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(this.userAgentProvider.UserAgent);
                }

                return this.httpClient;
            }
        }

        public async Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage)
        {
            var content = await ExecuteAsJsonAsync(requestMessage);
            return this.serializerService.Deserialize<T>(content);   
        }
        
        public async Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage)
        {
            var result = await this.HttpClient.SendAsync(requestMessage).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (result.IsSuccessStatusCode)
            {
                return content;
            }

            // it will not reach this because either it will success and return the deserialized object or fail and handled by ErrorHandler which will throw it using the right exception type
            var exception = new ApiException(result.ReasonPhrase);
            throw exception;
        }
    }
}
