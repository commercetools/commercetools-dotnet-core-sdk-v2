using commercetools.Base.Client;
using commercetools.Sdk.CheckoutApi.Client;
namespace commercetools.Sdk.CheckoutApi.Extensions
{
    public static class Extensions
    {
        public static CheckoutApiRoot WithCheckoutApi(this IClient client)
        {
            return CheckoutApiFactory.Create(client);
        }

        public static ProjectApiRoot WithCheckoutApi(this IClient client, string projectKey)
        {
            return CheckoutApiFactory.Create(client, projectKey);
        }
    }
}