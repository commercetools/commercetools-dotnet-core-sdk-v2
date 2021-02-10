namespace commercetools.Base.Client.Tokens
{
    public interface IUserCredentialsStoreManager : ITokenStoreManager
    {
        string Username { get; }

        string Password { get; }
    }
}