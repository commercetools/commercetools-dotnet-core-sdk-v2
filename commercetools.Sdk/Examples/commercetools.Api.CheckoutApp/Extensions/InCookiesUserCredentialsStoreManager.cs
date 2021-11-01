using commercetools.Base.Client.Tokens;

namespace commercetools.Api.CheckoutApp.Extensions
{
    /// <summary>
    /// Store user credentials in the cookie and generated Token in cookie
    /// </summary>
    public class InCookiesUserCredentialsStoreManager : InCookiesTokenStoreManager,
        IUserCredentialsStoreManager
    {
        private readonly InCookiesStoreManager _inCookiesStoreManager;

        public InCookiesUserCredentialsStoreManager(
            InCookiesStoreManager inCookiesStoreManager)
            : base(inCookiesStoreManager)
        {
            _inCookiesStoreManager = inCookiesStoreManager;
        }

        public string Username
        {
            get => _inCookiesStoreManager.GetFromCookie(InCookiesStoreManager.UserNameKey);
            set => _inCookiesStoreManager.SetInCookie(InCookiesStoreManager.UserNameKey,value);
        }
        

        public string Password
        {
            get => _inCookiesStoreManager.GetFromCookie(InCookiesStoreManager.PasswordKey);
            set => _inCookiesStoreManager.SetInCookie(InCookiesStoreManager.PasswordKey,value);
        }

        public void StoreUserCredentialsAndClearToken(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.ClearToken();
        }
    }
}