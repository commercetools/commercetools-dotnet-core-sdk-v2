namespace commercetools.Base.Client.Tokens
{
    public class InMemoryAnonymousCredentialsStoreManager : InMemoryTokenStoreManager, IAnonymousCredentialsStoreManager
    {
        public string AnonymousId { get; set; }

        public InMemoryAnonymousCredentialsStoreManager(string anonymousId)
        {
            this.AnonymousId = anonymousId;
        }
    }
}