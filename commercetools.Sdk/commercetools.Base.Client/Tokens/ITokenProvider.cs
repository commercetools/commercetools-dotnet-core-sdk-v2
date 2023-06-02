using System;
using System.Threading.Tasks;
using commercetools.Base.Client.Domain;

namespace commercetools.Base.Client.Tokens
{
    public interface ITokenProvider
    {
        [Obsolete("use GetToken method instead")]
        Token Token { get; }

        TokenFlow TokenFlow { get; }

        IClientConfiguration ClientConfiguration { get; set; }

        Task<Token> GetToken();
    }
}
