using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;

namespace commercetools.Base.Client.Middlewares
{
    public class AuthorizationMiddleware : DelegatingMiddleware
    {
        private readonly ITokenProvider _tokenProvider;

        public AuthorizationMiddleware(ITokenProvider tokenProvider)
        {
            this._tokenProvider = tokenProvider;
        }

        protected internal override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Token token = await this._tokenProvider.GetToken().ConfigureAwait(false);
            request.Headers.Add("Authorization", $"Bearer {token.AccessToken}");
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
