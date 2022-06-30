using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestDraft))]
    public partial interface IMyQuoteRequestDraft
    {
        ICartResourceIdentifier Cart { get; set; }

        long Version { get; set; }

        string Comment { get; set; }
    }
}
