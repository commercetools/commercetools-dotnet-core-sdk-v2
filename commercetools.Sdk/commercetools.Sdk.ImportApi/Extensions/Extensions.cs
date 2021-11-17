using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Client;

namespace commercetools.Sdk.ImportApi.Extensions
{
    public static class Extensions
    {
        public static ImportApiRoot WithImportApi(this IClient client)
        {
            return ImportApiFactory.Create(client);
        }

        public static ProjectApiRoot WithImportApi(this IClient client, string projectKey)
        {
            return ImportApiFactory.Create(client, projectKey);
        }
    }
}