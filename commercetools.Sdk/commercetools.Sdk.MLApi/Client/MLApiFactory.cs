using commercetools.Base.Client;

namespace commercetools.Sdk.MLApi.Client
{
    public class MLApiFactory
    {
        public static MLApiRoot Create(
            IClient client)
        {
            return new MLApiRoot(client);
        }

        public static ProjectApiRoot Create(
            IClient client, string projectKey)
        {
            return new ProjectApiRoot(client, projectKey);
        }
    }
}