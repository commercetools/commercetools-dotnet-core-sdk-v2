using commercetools.Api.Client.Domain;

namespace commercetools.Api.Client.Tokens
{
    public interface ITokenStoreManager
    {
        Token Token { get; set; }
    }
}