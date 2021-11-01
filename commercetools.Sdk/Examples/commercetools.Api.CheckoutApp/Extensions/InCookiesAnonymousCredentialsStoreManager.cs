using commercetools.Base.Client.Tokens;

namespace commercetools.Api.CheckoutApp.Extensions
{
    /// <summary>
    /// Store AnonymousId in the cookie and generated Token in cookie
    /// </summary>
    public class InCookiesAnonymousCredentialsStoreManager : InCookiesTokenStoreManager,
        IAnonymousCredentialsStoreManager
    {
        private readonly InCookiesStoreManager _inCookiesStoreManager;
        
        public InCookiesAnonymousCredentialsStoreManager(
            InCookiesStoreManager inCookiesStoreManager)
            : base(inCookiesStoreManager)
        {
            _inCookiesStoreManager = inCookiesStoreManager;
        }

        public string AnonymousId
        {
            get => _inCookiesStoreManager.GetFromCookie(InCookiesStoreManager.AnonymousKey);
            set => _inCookiesStoreManager.SetInCookie(InCookiesStoreManager.AnonymousKey,value);
        }
    }
}