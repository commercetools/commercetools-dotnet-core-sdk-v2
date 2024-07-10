namespace commercetools.Sdk.Api.Models.Common
{

    public partial class Attribution : IAttribution
    {
        public string ClientId { get; set; }

        public IAttributionSource Source { get; set; }
    }
}
