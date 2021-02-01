using commercetools.Base.Client;

namespace commercetools.Sdk.ML.Client
{
    public class MLApiRoot
    {
        private IClient ApiHttpClient { get; }
        
        public MLApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
    }
}