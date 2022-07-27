namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class HttpDestination : IHttpDestination
    {
        public string Type { get; set; }

        public string Url { get; set; }

        public IHttpDestinationAuthentication Authentication { get; set; }
        public HttpDestination()
        {
            this.Type = "HTTP";
        }
    }
}
