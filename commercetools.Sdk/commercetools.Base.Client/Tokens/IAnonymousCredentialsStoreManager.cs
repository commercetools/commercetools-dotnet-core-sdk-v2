namespace commercetools.Base.Client.Tokens
{
    public interface IAnonymousCredentialsStoreManager : ITokenStoreManager
    {
        string AnonymousId { get; }
    }
}