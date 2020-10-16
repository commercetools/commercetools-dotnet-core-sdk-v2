using commercetools.Base.Client.Domain;

namespace commercetools.Base.Client.Tokens
{
    public interface ITokenProvider
    {
        Token Token { get; }

        TokenFlow TokenFlow { get; }

        IClientConfiguration ClientConfiguration { get; set; }
    }
}
