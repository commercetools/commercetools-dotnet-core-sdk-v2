using System;
using System.Net;

namespace commercetools.Base.Client
{
    public class ClientOptions
    {
        public DecompressionMethods DecompressionMethods { get; set; } =
            DecompressionMethods.Deflate | DecompressionMethods.GZip;

        public bool ReadResponseAsStream { get; set; } = true;

        public Version UseHttpVersion { get; set; } = null;
    }
}