using commercetools.Api.Client.Domain;

namespace commercetools.Api.Client.Tokens
{
    public interface ITokenProvider
    {
        Token Token { get; }

        TokenFlow TokenFlow { get; }

        IClientConfiguration ClientConfiguration { get; set; }
    }
}
