using System;
namespace commercetools.Api.Client.DelegatingHandlers
{
    public interface IUserAgentProvider
    {
        string UserAgent { get; set; }
    }
}
