using commercetools.Base.Client;

namespace commercetools.Sdk.HistoryApi.Client
{
    public class HistoryApiFactory
    {
        public static HistoryApiRoot Create(
            IClient client)
        {
            return new HistoryApiRoot(client);
        }

        public static ProjectApiRoot Create(
            IClient client, string projectKey)
        {
            return new ProjectApiRoot(client, projectKey);
        }
    }
}