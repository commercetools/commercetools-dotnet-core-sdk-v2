using commercetools.Base.Client;
using commercetools.Sdk.ML.Client;

namespace commercetools.Sdk.ML.Extensions
{
    public static class Extensions
    {
        public static MLApiRoot WithMLApi(this IClient client)
        {
            return MLApiFactory.Create(client);
        }
    }
}