using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;

namespace commercetools.Base.Client.DelegatingHandlers
{
    public class AuthorizationHandler : DelegatingHandler
    {
        private readonly ITokenProvider tokenProvider;

        public AuthorizationHandler(ITokenProvider tokenProvider)
        {
            this.tokenProvider = tokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Token token = this.tokenProvider.Token;
            request.Headers.Add("Authorization", $"Bearer {token.AccessToken}");
            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
