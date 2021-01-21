using commercetools.Base.Client;

namespace commercetools.Sdk.ImportApi.Client
{
    public class ImportApiRoot
    {
        private IClient ApiHttpClient { get; }
        
        public ImportApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
    }
}