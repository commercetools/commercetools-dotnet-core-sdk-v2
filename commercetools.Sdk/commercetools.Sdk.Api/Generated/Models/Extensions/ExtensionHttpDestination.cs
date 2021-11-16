namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionHttpDestination : IExtensionHttpDestination
    {
        public string Type { get; set; }

        public string Url { get; set; }

        public IExtensionHttpDestinationAuthentication Authentication { get; set; }
        public ExtensionHttpDestination()
        {
            this.Type = "HTTP";
        }
    }
}
