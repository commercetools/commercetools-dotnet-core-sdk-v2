using System;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;
using Microsoft.AspNetCore.Http;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public class InSessionTokenStoreManager : ITokenStoreManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _tokenKey = "TokenKey";
        public InSessionTokenStoreManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Token Token
        {
            get => GetTokenFromSession();
            set => SetTokenInSession(value);
        }

        private void SetTokenInSession(Token token)
        {
            var session = _httpContextAccessor?.HttpContext?.Session;
            session?.SetObjectAsJson(_tokenKey, token);
        }
        private Token GetTokenFromSession()
        {
            var session = _httpContextAccessor?.HttpContext?.Session;
            if (session != null)
            {
                var sessionContainsToken = session.GetString("token_AccessToken") != null;
                if (sessionContainsToken)
                {
                    var token = session.GetObjectFromJson<Token>(_tokenKey);
                    return token;
                }
            }
            return null;

        }
    }
}