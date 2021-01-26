using commercetools.Base.Client;

namespace commercetools.Sdk.ImportApi.Client
{
    public class ImportApiFactory
    {
        public static ImportApiRoot Create(
            IClient client)
        {
            return new ImportApiRoot(client);
        }
    }
}