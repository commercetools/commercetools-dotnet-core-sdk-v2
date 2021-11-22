using commercetools.Base.Client;
using commercetools.Sdk.MLApi.Client;

namespace commercetools.Sdk.MLApi.Extensions
{
    public static class Extensions
    {
        public static MLApiRoot WithMLApi(this IClient client)
        {
            return MLApiFactory.Create(client);
        }

        public static ProjectApiRoot WithMLApi(this IClient client, string projectKey)
        {
            return MLApiFactory.Create(client, projectKey);
        }
    }
}