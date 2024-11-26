using System.Net.Http;

namespace commercetools.Base.Client;

public class EmptyContent : StringContent
{
    public EmptyContent() : base(string.Empty)
    {
    }
}