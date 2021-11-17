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

        public static ProjectApiRoot Create(
            IClient client, string projectKey)
        {
            return new ProjectApiRoot(client, projectKey);
        }
    }
}