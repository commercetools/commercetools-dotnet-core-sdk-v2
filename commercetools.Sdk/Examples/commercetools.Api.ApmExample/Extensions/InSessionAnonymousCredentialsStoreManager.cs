using commercetools.Api.ApmExample.Services;
using commercetools.Base.Client.Tokens;

namespace commercetools.Api.ApmExample.Extensions
{
    /// <summary>
    /// Store AnonymousId in the session and generated Token in cookie
    /// </summary>
    public class InSessionAnonymousCredentialsStoreManager : InCookiesTokenStoreManager,
        IAnonymousCredentialsStoreManager
    {

        public InSessionAnonymousCredentialsStoreManager(
            InSessionStoreManager inSessionStoreManager, InCookiesStoreManager inCookiesStoreManager)
            : base(inCookiesStoreManager, inSessionStoreManager)
        {
        }

        public string AnonymousId
        {
            get => InSessionStoreManager.GetFromSession(Settings.AnonymousKey);
            set => InSessionStoreManager.SetInSession(Settings.AnonymousKey, value);
        }
    }
}