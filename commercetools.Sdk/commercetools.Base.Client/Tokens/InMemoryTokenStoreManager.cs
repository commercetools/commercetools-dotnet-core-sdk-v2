using commercetools.Base.Client.Domain;

namespace commercetools.Base.Client.Tokens
{
    public class InMemoryTokenStoreManager : ITokenStoreManager
    {
        public Token Token { get; set; }
    }
}