using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestDraft : IMyQuoteRequestDraft
    {
        public ICartResourceIdentifier Cart { get; set; }

        public long Version { get; set; }

        public string Comment { get; set; }
    }
}
