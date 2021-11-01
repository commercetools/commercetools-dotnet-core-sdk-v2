using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;
using Newtonsoft.Json;

namespace commercetools.Api.CheckoutApp.Extensions
{
    public class InCookiesTokenStoreManager : ITokenStoreManager
    {
        private readonly InCookiesStoreManager _inCookiesStoreManager;
        
        public InCookiesTokenStoreManager(InCookiesStoreManager inCookiesStoreManager)
        {
            _inCookiesStoreManager = inCookiesStoreManager;
        }
        public Token Token
        {
            get => GetTokenFromCookie();
            set => SetTokenInCookie(value);
        }

        private void SetTokenInCookie(Token token)
        {
            var tokenAsJson = JsonConvert.SerializeObject(token);
            _inCookiesStoreManager.SetInCookie(InCookiesStoreManager.TokenKey, tokenAsJson);
        }
        private Token GetTokenFromCookie()
        {
            var tokenAsJsonString = _inCookiesStoreManager.GetFromCookie(InCookiesStoreManager.TokenKey);
            if (!string.IsNullOrEmpty(tokenAsJsonString))
            {
                var token = JsonConvert.DeserializeObject<Token>(tokenAsJsonString);
                token.RefreshExpirationDate();
                return token;
            }
            return null;
        }
        public void ClearToken()
        {
            _inCookiesStoreManager.ClearCookie(InCookiesStoreManager.TokenKey);
        }
    }
}