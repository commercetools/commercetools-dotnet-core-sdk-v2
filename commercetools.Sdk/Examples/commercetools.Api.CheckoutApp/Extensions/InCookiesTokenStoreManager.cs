using System;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public class InCookiesTokenStoreManager : ITokenStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _tokenKey = "TokenKey";
        public InCookiesTokenStoreManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Token Token
        {
            get => GetTokenFromCookie();
            set => SetTokenInCookie(value);
        }

        private void SetTokenInCookie(Token token)
        {
            var response = _httpContextAccessor?.HttpContext?.Response;
            var tokenAsJson = JsonConvert.SerializeObject(token);
            response?.Cookies.Append(_tokenKey, tokenAsJson,
                new CookieOptions()
                {
                    Path = "/",
                    Secure = true,
                    HttpOnly = true,
                    Expires = DateTimeOffset.Now.AddDays(2)
                });
        }
        private Token GetTokenFromCookie()
        {
            var request = _httpContextAccessor?.HttpContext?.Request;
            if (request != null)
            {
                var cookiesContainsToken = request.Cookies.ContainsKey(_tokenKey);
                if (cookiesContainsToken)
                {
                    var tokenAsJsonString = request.Cookies[_tokenKey];
                    var token = JsonConvert.DeserializeObject<Token>(tokenAsJsonString);
                    token.RefreshExpirationDate();
                    return token;
                }
            }
            return null;

        }
    }
}