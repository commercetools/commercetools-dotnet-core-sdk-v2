using commercetools.Base.Client;

namespace commercetools.Sdk.ML.Client
{
    public class MLApiFactory
    {
        public static MLApiRoot Create(
            IClient client)
        {
            return new MLApiRoot(client);
        }
    }
}