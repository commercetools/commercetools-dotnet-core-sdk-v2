using commercetools.Api.ApmExample.Services;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;
using Newtonsoft.Json;

namespace commercetools.Api.ApmExample.Extensions
{
    public class InCookiesTokenStoreManager : ITokenStoreManager
    {
        protected readonly InCookiesStoreManager InCookiesStoreManager;
        protected readonly InSessionStoreManager InSessionStoreManager;

        public InCookiesTokenStoreManager(InCookiesStoreManager inCookiesStoreManager,
            InSessionStoreManager inSessionStoreManager)
        {
            InCookiesStoreManager = inCookiesStoreManager;
            InSessionStoreManager = inSessionStoreManager;
        }

        public Token Token
        {
            get => GetToken();
            set => SetToken(value);
        }

        /// <summary>
        /// Set Token in both cookie for the longUse and save it on session on for temp use
        /// saving token in session for temp use till response back to the user with the new cookie
        /// </summary>
        /// <param name="token"></param>
        private void SetToken(Token token)
        {
            var tokenAsJson = JsonConvert.SerializeObject(token);
            InCookiesStoreManager.SetInCookie(Settings.TokenKey, tokenAsJson);
            InSessionStoreManager.SetInSession(Settings.TokenKey, tokenAsJson);
        }

        /// <summary>
        /// Always get token from the cookie,
        /// in cases of multiple requests before saving the cookie in the response, use session as temp source for the token
        /// </summary>
        /// <returns></returns>
        private Token GetToken()
        {
            var tokenAsJsonString = GetTokenAsJson();
            if (!string.IsNullOrEmpty(tokenAsJsonString))
            {
                var token = JsonConvert.DeserializeObject<Token>(tokenAsJsonString);
                token.RefreshExpirationDate();
                return token;
            }

            return null;
        }

        /// <summary>
        /// Clear Token from the session if it's already stored in the cookie so it's not needed anymore
        /// </summary>
        private void ClearTokenFromSessionIfExists()
        {
            if (InSessionStoreManager.IsKeyExists(Settings.TokenKey))
            {
                InSessionStoreManager.ClearSession(Settings.TokenKey);
            }
        }

        private string GetTokenAsJson()
        {
            var tokenAsJsonString = InCookiesStoreManager.GetFromCookie(Settings.TokenKey);
            if (string.IsNullOrEmpty(tokenAsJsonString))
            {
                //get from session
                tokenAsJsonString = InSessionStoreManager.GetFromSession(Settings.TokenKey);
            }
            else
            {
                ClearTokenFromSessionIfExists();
            }

            return tokenAsJsonString;
        }

        public void ClearToken()
        {
            InCookiesStoreManager.ClearCookie(Settings.TokenKey);
        }
    }
}