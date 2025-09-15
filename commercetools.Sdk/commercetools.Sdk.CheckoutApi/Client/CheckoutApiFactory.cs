using commercetools.Base.Client;

namespace commercetools.Sdk.CheckoutApi.Client
{
    public class CheckoutApiFactory
    {
        public static CheckoutApiRoot Create(
            IClient client)
        {
            return new CheckoutApiRoot(client);
        }

        public static ProjectApiRoot Create(
            IClient client, string projectKey)
        {
            return new ProjectApiRoot(client, projectKey);
        }
    }
}