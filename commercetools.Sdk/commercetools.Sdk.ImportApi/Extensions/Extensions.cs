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
    }
}