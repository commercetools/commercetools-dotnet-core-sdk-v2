namespace commercetools.Base.Client.Tokens
{
    public class InMemoryUserCredentialsStoreManager : InMemoryTokenStoreManager, IUserCredentialsStoreManager
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public InMemoryUserCredentialsStoreManager(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}