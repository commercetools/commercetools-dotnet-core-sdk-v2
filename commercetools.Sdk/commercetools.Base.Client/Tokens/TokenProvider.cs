using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;
using commercetools.Base.Serialization;

namespace commercetools.Base.Client.Tokens
{
    public abstract class TokenProvider
    {
        private readonly ISerializerService _serializerService;
        private readonly ITokenStoreManager _tokenStoreManager;
        
        private Task<Token> _tokenTask;

        private static readonly TimeSpan WaitTimeout = TimeSpan.FromSeconds(10);
        
        private readonly object _lockObject = new object();

        protected TokenProvider(HttpClient httpClient, ITokenStoreManager tokenStoreManager, ITokenSerializerService serializerService, string tokenEndpointBaseAddress)
        {
            this.HttpClient = httpClient;
            this._tokenStoreManager = tokenStoreManager;
            this._serializerService = serializerService;
            this.TokenEndpointBaseAddress = tokenEndpointBaseAddress;
        }

        public Token Token
        {
            get
            {
                var token = _tokenStoreManager.Token;
                if (token == null)
                {
                    lock (_lockObject)
                    {
                        if (_tokenTask == null || _tokenTask.IsCompleted)
                        {
                            _tokenTask = this.SetToken();
                        }
                    }
                    if (!_tokenTask.IsCompleted && !_tokenTask.Wait(WaitTimeout))
                    {
                        throw new TimeoutException("OAuth token not retrieved in time");
                    }
                }
                token = _tokenStoreManager.Token;
                if (!token.Expired)
                {
                    return token;
                }
                lock (_lockObject)
                {
                    if (_tokenTask == null || _tokenTask.IsCompleted)
                    {
                        _tokenTask = this.RefreshToken(token);
                    }
                }
                if (!_tokenTask.IsCompleted && !_tokenTask.Wait(WaitTimeout))
                {
                    throw new TimeoutException("OAuth token not retrieved in time");
                }
                return _tokenStoreManager.Token;
            }
        }

        public IClientConfiguration ClientConfiguration { get; set; }

        protected HttpClient HttpClient { get; }

        protected string TokenEndpointBaseAddress { get; }

        public virtual HttpRequestMessage GetRequestMessage()
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                RequestUri = new Uri(this.TokenEndpointBaseAddress),
                Content = new StringContent(BuildTokenRequestBody(), Encoding.UTF8, "application/x-www-form-urlencoded")
            };
            string credentials = $"{this.ClientConfiguration.ClientId}:{this.ClientConfiguration.ClientSecret}";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials)));
            request.Method = HttpMethod.Post;
            return request;
        }

        private HttpRequestMessage GetRefreshTokenRequestMessage()
        {
            var request = new HttpRequestMessage();
            var requestUri = this.ClientConfiguration.AuthorizationBaseAddress + "oauth/token?grant_type=refresh_token";
            requestUri += $"&refresh_token={this._tokenStoreManager.Token.RefreshToken}";
            request.RequestUri = new Uri(requestUri);
            var credentials = $"{this.ClientConfiguration.ClientId}:{this.ClientConfiguration.ClientSecret}";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials)));
            request.Method = HttpMethod.Post;
            return request;
        }

        private async Task<Token> SetToken()
        {
            var token = await GetTokenAsync(this.GetRequestMessage());
            _tokenStoreManager.Token = token;
            return token;
        }
        
        private async Task<Token> RefreshToken(Token token)
        {
            var requestMessage = string.IsNullOrEmpty(token.RefreshToken)
                ? GetRequestMessage()
                : GetRefreshTokenRequestMessage();

            token = await GetTokenAsync(requestMessage);
            _tokenStoreManager.Token = token;
            return token;
        }
        
        private async Task<Token> GetTokenAsync(HttpRequestMessage requestMessage)
        {
            var client = this.HttpClient;
            var result = await client.SendAsync(requestMessage).ConfigureAwait(false);
            var content = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (result.IsSuccessStatusCode)
            {
                return this._serializerService.Deserialize<Token>(content);
            }

            var generalClientException =
                new HttpApiClientException(result.ReasonPhrase, (int)result.StatusCode);
            throw generalClientException;
        }
        protected virtual string BuildTokenRequestBody()
        {
            var body = "grant_type=client_credentials";
            var scope = this.ClientConfiguration.Scope;
            if (!string.IsNullOrEmpty(scope))
            {
                body += $"&scope={scope}";
            }

            return body;
        }
    }
}
