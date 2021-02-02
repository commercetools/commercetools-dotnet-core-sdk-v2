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
    }
}