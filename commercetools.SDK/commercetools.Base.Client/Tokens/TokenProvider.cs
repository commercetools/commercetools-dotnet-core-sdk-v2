using System;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client.Tokens
{
    public abstract class TokenProvider
    {
        private readonly ISerializerService serializerService;
        private readonly ITokenStoreManager tokenStoreManager;

        protected TokenProvider(IHttpClientFactory httpClientFactory, ITokenStoreManager tokenStoreManager, ITokenSerializerService serializerService)
        {
            this.HttpClientFactory = httpClientFactory;
            this.tokenStoreManager = tokenStoreManager;
            this.serializerService = serializerService;
        }

        public Token Token
        {
            get
            {
                var token = this.tokenStoreManager.Token;
                if (token == null)
                {
                    lock (this.tokenStoreManager)
                    {
                        token = this.tokenStoreManager.Token;
                        if (token != null)
                        {
                            return token;
                        }

                        token = this.GetToken(this.GetRequestMessage());
                        this.tokenStoreManager.Token = token;
                    }

                    return token;
                }

                if (!token.Expired)
                {
                    return token;
                }

                lock (this.tokenStoreManager)
                {
                    token = this.tokenStoreManager.Token;
                    if (!token.Expired)
                    {
                        return token;
                    }

                    var requestMessage = string.IsNullOrEmpty(token.RefreshToken)
                        ? this.GetRequestMessage()
                        : this.GetRefreshTokenRequestMessage();

                    token = this.GetToken(requestMessage);
                    this.tokenStoreManager.Token = token;
                    return token;
                }
            }
        }

        public IClientConfiguration ClientConfiguration { get; set; }

        protected IHttpClientFactory HttpClientFactory { get; }

        public abstract HttpRequestMessage GetRequestMessage();

        private HttpRequestMessage GetRefreshTokenRequestMessage()
        {
            var request = new HttpRequestMessage();
            var requestUri = this.ClientConfiguration.AuthorizationBaseAddress + "oauth/token?grant_type=refresh_token";
            requestUri += $"&refresh_token={this.tokenStoreManager.Token.RefreshToken}";
            request.RequestUri = new Uri(requestUri);
            var credentials = $"{this.ClientConfiguration.ClientId}:{this.ClientConfiguration.ClientSecret}";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials)));
            request.Method = HttpMethod.Post;
            return request;
        }

        private Token GetToken(HttpRequestMessage requestMessage)
        {
            return AsyncUtil.RunSync(() => this.GetTokenAsync(requestMessage));
        }

        private async Task<Token> GetTokenAsync(HttpRequestMessage requestMessage)
        {
            var client = this.HttpClientFactory.CreateClient(DefaultClientNames.Authorization);
            var result = await client.SendAsync(requestMessage).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (result.IsSuccessStatusCode)
            {
                return this.serializerService.Deserialize<Token>(content);
            }

            var generalClientException =
                new HttpApiClientException(result.ReasonPhrase, (int)result.StatusCode);
            throw generalClientException;
        }
    }
}
