using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client.Tokens;

namespace commercetools.Api.CheckoutApp.Extensions
{
    /// <summary>
    /// Store user credentials in the Session as temp memory
    /// and generated Token in the cookie as long memory
    /// </summary>
    public class InSessionUserCredentialsStoreManager : InCookiesTokenStoreManager,
        IUserCredentialsStoreManager
    {

        public InSessionUserCredentialsStoreManager(
            InSessionStoreManager inSessionStoreManager, InCookiesStoreManager inCookiesStoreManager)
            : base(inCookiesStoreManager, inSessionStoreManager)
        {
        }

        public string Username
        {
            get => InSessionStoreManager.GetFromSession(Settings.UserNameKey);
            set => InSessionStoreManager.SetInSession(Settings.UserNameKey,value);
        }
        

        public string Password
        {
            get => InSessionStoreManager.GetFromSession(Settings.PasswordKey);
            set => InSessionStoreManager.SetInSession(Settings.PasswordKey,value);
        }

        public void StoreUserCredentialsAndClearToken(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.ClearToken();
        }

        public void ClearCredentialsAndToken()
        {
            InSessionStoreManager.ClearSession(Settings.UserNameKey);
            InSessionStoreManager.ClearSession(Settings.PasswordKey);
            InSessionStoreManager.ClearSession(Settings.TokenKey);
            InSessionStoreManager.ClearSession(Settings.AnonymousKey);
            this.ClearToken();
        }
    }
}