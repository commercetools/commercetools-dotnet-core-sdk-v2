using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Client;
namespace commercetools.Sdk.HistoryApi.Extensions
{
    public static class Extensions
    {
        public static HistoryApiRoot WithHistoryApi(this IClient client)
        {
            return HistoryApiFactory.Create(client);
        }

        public static ProjectApiRoot WithHistoryApi(this IClient client, string projectKey)
        {
            return HistoryApiFactory.Create(client, projectKey);
        }
    }
}