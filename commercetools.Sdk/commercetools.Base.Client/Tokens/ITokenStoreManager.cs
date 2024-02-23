using commercetools.Base.Client.Domain;

namespace commercetools.Base.Client.Tokens
{
    public interface ITokenStoreManager
    {
        Token Token { get; set; }

        void ClearToken();
    }
}