using commercetools.Api.Client.Domain;

namespace commercetools.Api.Client.Tokens
{
    public class InMemoryTokenStoreManager : ITokenStoreManager
    {
        public Token Token { get; set; }
    }
}