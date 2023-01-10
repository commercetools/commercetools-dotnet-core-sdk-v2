using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestDraft))]
    public partial interface IMyQuoteRequestDraft
    {
        string CartId { get; set; }

        long CartVersion { get; set; }

        string Comment { get; set; }

    }
}
