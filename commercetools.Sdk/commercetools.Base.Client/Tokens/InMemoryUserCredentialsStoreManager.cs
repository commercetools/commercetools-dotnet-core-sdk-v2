namespace commercetools.Base.Client.Tokens
{
    public class InMemoryUserCredentialsStoreManager : InMemoryTokenStoreManager, IUserCredentialsStoreManager
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}