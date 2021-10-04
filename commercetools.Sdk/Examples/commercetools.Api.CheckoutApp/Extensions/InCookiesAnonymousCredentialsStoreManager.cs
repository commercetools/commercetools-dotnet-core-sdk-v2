using System;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Http;

namespace commercetools.Api.CheckoutApp.Extensions
{
    /// <summary>
    /// Store AnonymousId in the cookie and generated Token in Session
    /// </summary>
    public class InCookiesAnonymousCredentialsStoreManager : InCookiesTokenStoreManager,
        IAnonymousCredentialsStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _anonymousKey = "CTP_AnonymousId";

        public InCookiesAnonymousCredentialsStoreManager(
            string anonymousId,
            IHttpContextAccessor httpContextAccessor)
            : base(httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            this.AnonymousId = anonymousId;
        }

        public string AnonymousId
        {
            get => GetCredentialsFromCookie();
            set => SetCredentialsInCookie(value);
        }

        private void SetCredentialsInCookie(string anonymousId)
        {
            var request = _httpContextAccessor?.HttpContext?.Request;
            var response = _httpContextAccessor?.HttpContext?.Response;
            if (request != null && !request.Cookies.ContainsKey(_anonymousKey))
            {
                response?.Cookies.Append(_anonymousKey, anonymousId,
                    new CookieOptions()
                    {
                        Path = "/",
                        Secure = true,
                        HttpOnly = true,
                        Expires = DateTimeOffset.Now.AddDays(2)
                    });
            }
        }

        private string GetCredentialsFromCookie()
        {
            var request = _httpContextAccessor?.HttpContext?.Request;
            return request?.Cookies[_anonymousKey]; 
        }
    }
}