using System;
namespace commercetools.Base.Client.DelegatingHandlers
{
    public interface IUserAgentProvider
    {
        string UserAgent { get; set; }
    }
}
