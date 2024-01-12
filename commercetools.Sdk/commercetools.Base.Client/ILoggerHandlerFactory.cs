using System.Net.Http;

namespace commercetools.Base.Client
{
    public interface ILoggerHandlerFactory
    {
        public DelegatingHandler Create();
    }
}