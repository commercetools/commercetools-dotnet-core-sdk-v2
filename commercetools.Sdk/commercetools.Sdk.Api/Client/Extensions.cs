using commercetools.Base.Client;

namespace commercetools.Api.Client
{
    public static class Extensions
    {
        public static ApiRoot ApiRoot(this IClient client)
        {
            return ApiFactory.Create(client);
        }
    }
}