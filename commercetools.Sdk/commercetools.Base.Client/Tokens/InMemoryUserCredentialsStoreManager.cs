namespace commercetools.Base.Client.Tokens
{
    public class InMemoryUserCredentialsStoreManager : InMemoryTokenStoreManager, IUserCredentialsStoreManager
    {
        public string Username { get; set; }

        public string Password { get; set; }
        public void StoreUserCredentialsAndClearToken(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.ClearToken(); 
        }

        public void ClearCredentialsAndToken()
        {
            Username = null;
            Password = null;
            this.ClearToken();
        }

        public InMemoryUserCredentialsStoreManager(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}