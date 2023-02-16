using System.Net;

namespace commercetools.Base.Client
{
    public class ClientOptions
    {
        public DecompressionMethods DecompressionMethods { get; set; } =
            DecompressionMethods.Deflate | DecompressionMethods.GZip;
    }
}